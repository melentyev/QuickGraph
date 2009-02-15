﻿using System;
using System.Collections.Generic;
using QuickGraph.Collections;
using QuickGraph.Algorithms.Observers;
using QuickGraph.Predicates;
using QuickGraph.Algorithms.Search;
using QuickGraph.Algorithms.Services;
using System.Diagnostics.Contracts;

namespace QuickGraph.Algorithms.MaximumFlow
{
    /// <summary>
    /// Edmond and Karp maximum flow algorithm
    /// for directed graph with positive capacities and
    /// flows.
    /// </summary>
    /// <typeparam name="Vertex"></typeparam>
    /// <typeparam name="Edge"></typeparam>
    [Serializable]
    public sealed class EdmondsKarpMaximumFlowAlgorithm<TVertex, TEdge>
        : MaximumFlowAlgorithm<TVertex,TEdge>
        where TEdge : IEdge<TVertex>
    {
        public EdmondsKarpMaximumFlowAlgorithm(
            IVertexListGraph<TVertex, TEdge> g,
            Func<TEdge, double> capacities,
            Dictionary<TEdge, TEdge> reversedEdges
            )
            : this(null, g, capacities, reversedEdges)
        { }

		public EdmondsKarpMaximumFlowAlgorithm(
            IAlgorithmComponent host,
			IVertexListGraph<TVertex,TEdge> g,
			Func<TEdge,double> capacities,
			Dictionary<TEdge,TEdge> reversedEdges
			)
			: base(host, g,capacities,reversedEdges)
		{}
	
		private IVertexListGraph<TVertex,TEdge> ResidualGraph
		{
			get
			{
				return new FilteredVertexListGraph<
                        TVertex,
                        TEdge,
                        IVertexListGraph<TVertex,TEdge>
                        >(
        					VisitedGraph,
                            v => true,
				        	new ResidualEdgePredicate<TVertex,TEdge>(ResidualCapacities).Test
    					);
			}
		}
	
		private void Augment(
			TVertex source,
			TVertex sink
			)
		{
            Contract.Requires(source != null);
            Contract.Requires(sink != null);

			TEdge e;
			TVertex u;

			// find minimum residual capacity along the augmenting path
			double delta = double.MaxValue;
            u = sink;
            do
			{
                e = Predecessors[u];
                delta = Math.Min(delta, ResidualCapacities[e]);
                u = e.Source;
			} while (!u.Equals(source));

			// push delta units of flow along the augmenting path
            u = sink;
            do 
			{
                e = Predecessors[u];
                ResidualCapacities[e] -= delta;
                ResidualCapacities[ ReversedEdges[e] ] += delta;
				u = e.Source;
			} while (!u.Equals(source));
		}
    
		/// <summary>
		/// Computes the maximum flow between <paramref name="src"/> and
		/// <paramref name="sink"/>
		/// </summary>
		/// <param name="src"></param>
		/// <param name="sink"></param>
		/// <returns></returns>
		protected override void InternalCompute()
		{
			if (this.Source==null)
				throw new InvalidOperationException("Source is not specified");
			if (this.Sink==null)
                throw new InvalidOperationException("Sink is not specified");

            var g = this.VisitedGraph;
            foreach(var u in g.Vertices)
				foreach(var e in g.OutEdges(u))
					this.ResidualCapacities[e] = this.Capacities(e);   			
    
			this.VertexColors[Sink] = GraphColor.Gray;
			while (this.VertexColors[Sink] != GraphColor.White)
			{
                var vis = new VertexPredecessorRecorderObserver<TVertex,TEdge>(
                    this.Predecessors
					);
				var Q = new QuickGraph.Collections.Queue<TVertex>();
				var bfs = new BreadthFirstSearchAlgorithm<TVertex,TEdge>(
					this.ResidualGraph,
					Q,
					this.VertexColors
					);
                using (ObserverScope.Create(bfs, vis))
                    bfs.Compute(this.Source);

                if (this.VertexColors[this.Sink] != GraphColor.White)
					this.Augment(this.Source, this.Sink);
			} // while

            this.MaxFlow = 0;
            foreach(var e in g.OutEdges(Source))
				this.MaxFlow += (this.Capacities(e) - this.ResidualCapacities[e]);
		} 
	}

}