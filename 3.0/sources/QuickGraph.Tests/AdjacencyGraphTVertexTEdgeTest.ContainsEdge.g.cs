// <copyright file="AdjacencyGraphTVertexTEdgeTest.ContainsEdge.g.cs" company="MSIT">Copyright © MSIT 2007</copyright>
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
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

namespace QuickGraph
{
    public partial class AdjacencyGraphTVertexTEdgeTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void ContainsEdge02()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.ContainsEdge<int, Edge<int>>(adjacencyGraph, 2, 3);
            Assert.AreEqual<bool>(false, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void ContainsEdge03()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.ContainsEdge<int, Edge<int>>(adjacencyGraph, 2, 3);
            Assert.AreEqual<bool>(false, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void ContainsEdge04()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(24577, 48);
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(25167362, default(int));
            keyValuePairs[1] = s1;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.ContainsEdge<int, Edge<int>>(adjacencyGraph, 5, 6);
            Assert.AreEqual<bool>(false, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void ContainsEdge07()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(default(int), 8192);
            keyValuePairs[0] = s0;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.ContainsEdge<int, Edge<int>>(adjacencyGraph, 5, 6);
            Assert.AreEqual<bool>(false, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void ContainsEdge08()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(141917952, 100663298);
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(931823871, 226888801);
            keyValuePairs[1] = s1;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.ContainsEdge<int, Edge<int>>(adjacencyGraph, 5, 6);
            Assert.AreEqual<bool>(false, b);
        }
    }
}
