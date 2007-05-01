using System;
using System.Collections.Generic;
using QuickGraph.Unit;

namespace QuickGraph.Algorithms
{
    [TypeFixture(typeof(IVertexListGraph<string,Edge<string>>))]
    [TypeFactory(typeof(AdjacencyGraphFactory))]
    [TypeFactory(typeof(BidirectionalGraphFactory))]
    public sealed class WeaklyConnectedComponentsAlgorithmTest
    {
        [Test]
        public void Compute(IVertexListGraph<string,Edge<string>> g)
        {
            GraphConsoleSerializer.DisplayGraph(g);

            WeaklyConnectedComponentsAlgorithm<string,Edge<string>> dfs = 
                new WeaklyConnectedComponentsAlgorithm<string,Edge<string>>(g);
            dfs.Compute();

            Console.WriteLine("Weak components: {0}", dfs.ComponentCount);
            Assert.AreEqual(g.VertexCount, dfs.Components.Count);
            foreach (KeyValuePair<string, int> kv in dfs.Components)
            {
                Console.WriteLine("\t{0}: {1}", kv.Key, kv.Value);
            }

            foreach(KeyValuePair<string,int> kv in dfs.Components)
            {
                Assert.IsLowerEqual(0, kv.Value);
                Assert.IsLower(kv.Value, dfs.ComponentCount);
            }

            foreach(string vertex in g.Vertices)
                foreach (Edge<string> edge in g.OutEdges(vertex))
                {
                    Assert.AreEqual(dfs.Components[edge.Source], dfs.Components[edge.Target]);
                }
        }
    }
}