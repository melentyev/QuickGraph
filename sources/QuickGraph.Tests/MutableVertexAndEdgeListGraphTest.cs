﻿using System;
using QuickGraph.Unit;

namespace QuickGraph
{
    [TypeFixture(typeof(IMutableVertexAndEdgeListGraph<string,Edge<string>>))]
    [TypeFactory(typeof(AdjacencyGraphFactory))]
    [TypeFactory(typeof(BidirectionalGraphFactory))]
    public class MutableVertexAndEdgeListGraphTest
    {
        [Test]
        public void AddVertex(IMutableVertexAndEdgeListGraph<string, Edge<string>> g)
        {
            int vertexCount = g.VertexCount;
            g.AddVertex("xxx");
            Assert.AreEqual(vertexCount + 1, g.VertexCount);
            Assert.IsTrue(g.ContainsVertex("xxx"));
            VerifyCounts(g);
        }

        [Test]
        public void AddAndRemoveVertex(IMutableVertexAndEdgeListGraph<string, Edge<string>> g)
        {
            int vertexCount = g.VertexCount;
            g.AddVertex("xxx");
            Assert.AreEqual(vertexCount + 1, g.VertexCount);
            Assert.IsTrue(g.ContainsVertex("xxx"));
            g.RemoveVertex("xxx");
            Assert.AreEqual(vertexCount, g.VertexCount);
            Assert.IsFalse(g.ContainsVertex("xxx"));
            VerifyCounts(g);
        }

        [Test]
        public void AddVertexAddEdgesAndRemoveTargetVertex(IMutableVertexAndEdgeListGraph<string, Edge<string>> g)
        {
            int vertexCount = g.VertexCount;
            int edgeCount = g.EdgeCount;

            g.AddVertex("v1");
            g.AddVertex("v2");
            Assert.AreEqual(vertexCount + 2, g.VertexCount);
            Assert.IsTrue(g.ContainsVertex("v1"));
            Assert.IsTrue(g.ContainsVertex("v2"));

            g.AddEdge(new Edge<string>("v1", "v2"));
            Assert.AreEqual(edgeCount + 1, g.EdgeCount);

            g.RemoveVertex("v2");
            Assert.AreEqual(vertexCount + 1, g.VertexCount);
            Assert.AreEqual(edgeCount, g.EdgeCount);
            Assert.IsTrue(g.ContainsVertex("v1"));
            Assert.IsFalse(g.ContainsVertex("v2"));
            VerifyCounts(g);
        }

        [Test]
        public void AddVertexAddEdgesAndRemoveSourceVertex(IMutableVertexAndEdgeListGraph<string, Edge<string>> g)
        {
            int vertexCount = g.VertexCount;
            int edgeCount = g.EdgeCount;

            g.AddVertex("v1");
            g.AddVertex("v2");
            Assert.AreEqual(vertexCount + 2, g.VertexCount);
            Assert.IsTrue(g.ContainsVertex("v1"));
            Assert.IsTrue(g.ContainsVertex("v2"));

            g.AddEdge(new Edge<string>("v1", "v2"));
            Assert.AreEqual(edgeCount + 1, g.EdgeCount);

            g.RemoveVertex("v1");
            Assert.AreEqual(vertexCount + 1, g.VertexCount);
            Assert.AreEqual(edgeCount, g.EdgeCount);
            Assert.IsTrue(g.ContainsVertex("v2"));
            Assert.IsFalse(g.ContainsVertex("v1"));
            VerifyCounts(g);
        }

        private void VerifyCounts(IMutableVertexAndEdgeListGraph<string, Edge<string>> g)
        {
            int i = 0;
            foreach (string v in g.Vertices)
                i++;
            Assert.AreEqual(g.VertexCount, i);

            i = 0;
            foreach (string v in g.Vertices)
                foreach (Edge<string> e in g.OutEdges(v))
                    i++;
            Assert.AreEqual(g.EdgeCount, i);

            i = 0;
            foreach (Edge<string> e in g.Edges)
                i++;
            Assert.AreEqual(g.EdgeCount, i);
        }
    }
}