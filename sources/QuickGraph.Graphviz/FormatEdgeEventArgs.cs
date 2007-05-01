﻿using System;
using NGraphviz.Helpers;

namespace QuickGraph.Graphviz
{
    public sealed class FormatEdgeEventArgs<V,E> : EdgeEventArgs<V,E>
        where E : IEdge<V>
    {
        private GraphvizEdge edgeFormatter;

        public FormatEdgeEventArgs(GraphvizEdge edgeFormatter, E e)
			: base(e)
        {
            if (edgeFormatter == null)
                throw new ArgumentNullException("edgeFormatter");
            this.edgeFormatter = edgeFormatter;
        }

        /// <summary>
        /// Edge formatter
        /// </summary>
        public GraphvizEdge EdgeFormatter
        {
            get
            {
                return edgeFormatter;
            }
        }
    }

    public delegate void FormatEdgeEventHandler<Vertex, Edge>(
        object sender, 
        FormatEdgeEventArgs<Vertex,Edge> e)
        where Edge : IEdge<Vertex>;
}