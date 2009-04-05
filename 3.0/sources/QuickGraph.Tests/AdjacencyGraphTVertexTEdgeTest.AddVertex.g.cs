// <copyright file="AdjacencyGraphTVertexTEdgeTest.AddVertex.g.cs" company="MSIT">Copyright © MSIT 2007</copyright>
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
        [Ignore]
        [PexDescription("the test state was: path bounds exceeded")]
        public void AddVertex01()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = new AdjacencyGraph<int, Edge<int>>(false, 1073741824, 2);
            b = this.AddVertex<int, Edge<int>>(adjacencyGraph, 3);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVertex02()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = new AdjacencyGraph<int, Edge<int>>(false, 0, 2);
            b = this.AddVertex<int, Edge<int>>(adjacencyGraph, 3);
            Assert.AreEqual<bool>(true, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVertex03()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = new AdjacencyGraph<int, Edge<int>>(false, int.MinValue, 2);
            b = this.AddVertex<int, Edge<int>>(adjacencyGraph, 3);
            Assert.AreEqual<bool>(true, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVertex04()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.AddVertex<int, Edge<int>>(adjacencyGraph, 2);
            Assert.AreEqual<bool>(true, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVertex05()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.AddVertex<int, Edge<int>>(adjacencyGraph, 2);
            Assert.AreEqual<bool>(true, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVertex06()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(1057368192, -2147483624);
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(24, default(int));
            keyValuePairs[1] = s1;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.AddVertex<int, Edge<int>>(adjacencyGraph, 2);
            Assert.AreEqual<bool>(true, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVertex09()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(default(int), 61493);
            keyValuePairs[0] = s0;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.AddVertex<int, Edge<int>>(adjacencyGraph, 5);
            Assert.AreEqual<bool>(true, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVertex10()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(49344, 25169093);
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(49344, 1812135938);
            keyValuePairs[1] = s1;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.AddVertex<int, Edge<int>>(adjacencyGraph, 5);
            Assert.AreEqual<bool>(true, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVertex07()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.AddVertex<int, Edge<int>>(adjacencyGraph, 0);
            Assert.AreEqual<bool>(true, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVertex08()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.AddVertex<int, Edge<int>>(adjacencyGraph, 0);
            Assert.AreEqual<bool>(false, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVertex11()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(44681361, 1073741824);
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(3, 3);
            keyValuePairs[1] = s1;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.AddVertex<int, Edge<int>>(adjacencyGraph, 0);
            Assert.AreEqual<bool>(true, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVertex12()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.AddVertex<int, Edge<int>>(adjacencyGraph, 0);
            Assert.AreEqual<bool>(true, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVertex13()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.AddVertex<int, Edge<int>>(adjacencyGraph, 0);
            Assert.AreEqual<bool>(false, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVertex14()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(44681361, 1073741824);
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(3, 3);
            keyValuePairs[1] = s1;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.AddVertex<int, Edge<int>>(adjacencyGraph, 0);
            Assert.AreEqual<bool>(true, b);
        }
    }
}
