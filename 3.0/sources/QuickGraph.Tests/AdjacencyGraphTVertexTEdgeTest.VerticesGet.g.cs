// <copyright file="AdjacencyGraphTVertexTEdgeTest.VerticesGet.g.cs" company="MSIT">Copyright © MSIT 2007</copyright>
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
        public void VerticesGet01()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            this.VerticesGet<int, Edge<int>>(adjacencyGraph);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void VerticesGet02()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            this.VerticesGet<int, Edge<int>>(adjacencyGraph);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void VerticesGet03()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[3];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(default(int), 1611005955)
              ;
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(384, 384);
            keyValuePairs[1] = s1;
            KeyValuePair<int, int> s2 = new KeyValuePair<int, int>(12288, default(int));
            keyValuePairs[2] = s2;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            this.VerticesGet<int, Edge<int>>(adjacencyGraph);
        }
    }
}
