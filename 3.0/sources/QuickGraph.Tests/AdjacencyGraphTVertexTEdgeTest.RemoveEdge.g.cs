// <copyright file="AdjacencyGraphTVertexTEdgeTest.RemoveEdge.g.cs" company="MSIT">Copyright © MSIT 2007</copyright>
// <auto-generated>
// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
// </auto-generated>
using System;
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Microsoft.Pex.Framework.Exceptions;

namespace QuickGraph
{
    public partial class AdjacencyGraphTVertexTEdgeTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void RemoveEdge01()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                bool b;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
                adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
                b = this.RemoveEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void RemoveEdge02()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                bool b;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
                adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
                b = this.RemoveEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [PexRaisedException(typeof(KeyNotFoundException))]
        public void RemoveEdge03()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            Edge<int> edge;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            edge = EdgeFactory.Create(3, 4);
            b = this.RemoveEdge<int, Edge<int>>(adjacencyGraph, edge);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void RemoveEdge04()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(1741164543, 417792);
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(805306369, default(int));
            keyValuePairs[1] = s1;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.RemoveEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
            Assert.AreEqual<bool>(true, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void RemoveEdge05()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[3];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(1409286144, default(int))
              ;
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(-1845493760, 301989888);
            keyValuePairs[1] = s1;
            KeyValuePair<int, int> s2 = new KeyValuePair<int, int>(-1845493760, 1574592);
            keyValuePairs[2] = s2;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.RemoveEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
            Assert.AreEqual<bool>(true, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void RemoveEdge06()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                bool b;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
                adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
                b = this.RemoveEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void RemoveEdge07()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                bool b;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
                adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
                b = this.RemoveEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void RemoveEdge08()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            Edge<int> edge;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            edge = EdgeFactory.Create(3, 4);
            b = this.RemoveEdge<int, Edge<int>>(adjacencyGraph, edge);
            Assert.AreEqual<bool>(false, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void RemoveEdge09()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(25165824, 1572888);
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(786432, 1);
            keyValuePairs[1] = s1;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.RemoveEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
            Assert.AreEqual<bool>(true, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void RemoveEdge10()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(50, default(int));
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(50, 1);
            keyValuePairs[1] = s1;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.RemoveEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
            Assert.AreEqual<bool>(true, b);
        }
    }
}
