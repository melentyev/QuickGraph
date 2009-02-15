// <copyright file="AdjacencyGraphTVertexTEdgeTest.RemoveVertex.g.cs" company="MSIT">Copyright © MSIT 2007</copyright>
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
        public void RemoveVertex01()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.RemoveVertex<int, Edge<int>>(adjacencyGraph, 2);
            Assert.AreEqual<bool>(false, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void RemoveVertex02()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.RemoveVertex<int, Edge<int>>(adjacencyGraph, 2);
            Assert.AreEqual<bool>(false, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void RemoveVertex06()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(13, default(int));
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(576, 226888801);
            keyValuePairs[1] = s1;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.RemoveVertex<int, Edge<int>>(adjacencyGraph, 5);
            Assert.AreEqual<bool>(false, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void RemoveVertex07()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(5, default(int));
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(int.MinValue, 226888801);
            keyValuePairs[1] = s1;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.RemoveVertex<int, Edge<int>>(adjacencyGraph, 5);
            Assert.AreEqual<bool>(true, b);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void RemoveVertex08()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[3];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(5, default(int));
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(int.MinValue, 226888801);
            keyValuePairs[1] = s1;
            KeyValuePair<int, int> s2 = new KeyValuePair<int, int>(1079205900, 226888801);
            keyValuePairs[2] = s2;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            b = this.RemoveVertex<int, Edge<int>>(adjacencyGraph, 5);
            Assert.AreEqual<bool>(true, b);
        }
    }
}
