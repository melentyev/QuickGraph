// <copyright file="AdjacencyGraphTVertexTEdgeTest.AddEdgeRange.g.cs" company="MSIT">Copyright © MSIT 2007</copyright>
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
using Microsoft.Pex.Framework.Exceptions;
using System.Diagnostics.Contracts;

namespace QuickGraph
{
    public partial class AdjacencyGraphTVertexTEdgeTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddEdgeRange01()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                int i;
                adjacencyGraph = new AdjacencyGraph<int, Edge<int>>(false, 2, 3);
                i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, (Edge<int>[])null);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdgeRange02()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            int i;
            adjacencyGraph = new AdjacencyGraph<int, Edge<int>>(false, 1, 2);
            Edge<int>[] edges = new Edge<int>[0];
            i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, edges);
            Assert.AreEqual<int>(0, i);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [Ignore]
        [PexDescription("the test state was: path bounds exceeded")]
        public void AddEdgeRange03()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            int i;
            adjacencyGraph = new AdjacencyGraph<int, Edge<int>>(false, 1073741824, 3);
            i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, (Edge<int>[])null);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddEdgeRange04()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                int i;
                adjacencyGraph = new AdjacencyGraph<int, Edge<int>>(false, 1, 2);
                Edge<int>[] edges = new Edge<int>[1];
                i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, edges);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdgeRange05()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            int i;
            adjacencyGraph = new AdjacencyGraph<int, Edge<int>>(false, int.MinValue, 2);
            Edge<int>[] edges = new Edge<int>[0];
            i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, edges);
            Assert.AreEqual<int>(0, i);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddEdgeRange06()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                Edge<int> edge;
                int i;
                adjacencyGraph = new AdjacencyGraph<int, Edge<int>>(false, 1, 3);
                edge = new Edge<int>(5, 6);
                Edge<int>[] edges = new Edge<int>[1];
                edges[0] = edge;
                i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, edges);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddEdgeRange07()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                Edge<int> edge;
                int i;
                adjacencyGraph = new AdjacencyGraph<int, Edge<int>>(false, int.MinValue, 3);
                edge = new Edge<int>(4, 5);
                Edge<int>[] edges = new Edge<int>[1];
                edges[0] = edge;
                i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, edges);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdgeRange08()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            int i;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            Edge<int>[] edges = new Edge<int>[0];
            i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, edges);
            Assert.AreEqual<int>(0, i);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdgeRange09()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            int i;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            Edge<int>[] edges = new Edge<int>[0];
            i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, edges);
            Assert.AreEqual<int>(0, i);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddEdgeRange10()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                int i;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
                KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(6291504, 1207959554);
                keyValuePairs[0] = s0;
                adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
                i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, (Edge<int>[])null);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddEdgeRange11()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                int i;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[4];
                adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
                Edge<int>[] edges = new Edge<int>[1];
                i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, edges);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddEdgeRange12()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                Edge<int> edge;
                int i;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[6];
                adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
                edge = EdgeFactory.Create(5, 7);
                Edge<int>[] edges = new Edge<int>[2];
                edges[0] = edge;
                edges[1] = edge;
                i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, edges);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdgeRange13()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            int i;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(1610615810, 252051533);
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(12610572, 101056513);
            keyValuePairs[1] = s1;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            Edge<int>[] edges = new Edge<int>[0];
            i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, edges);
            Assert.AreEqual<int>(0, i);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddEdgeRange16()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                int i;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
                KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(6291504, 1207959554);
                keyValuePairs[0] = s0;
                adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
                i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, (Edge<int>[])null);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddEdgeRange17()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                int i;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[4];
                adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
                Edge<int>[] edges = new Edge<int>[1];
                i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, edges);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddEdgeRange18()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                Edge<int> edge;
                int i;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[6];
                adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
                edge = EdgeFactory.Create(5, 7);
                Edge<int>[] edges = new Edge<int>[2];
                edges[0] = edge;
                edges[1] = edge;
                i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, edges);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddEdgeRange19()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                int i;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
                KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(default(int), 2);
                keyValuePairs[0] = s0;
                adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
                Edge<int>[] edges = new Edge<int>[4];
                i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, edges);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(TraceAssertionException))]
        public void AddEdgeRange20()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            using (PexTraceListenerContext.Create())
            {
                AdjacencyGraph<int, Edge<int>> adjacencyGraph;
                int i;
                KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
                KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(12583296, 1816657920);
                keyValuePairs[0] = s0;
                KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(7680, 1);
                keyValuePairs[1] = s1;
                adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
                Edge<int>[] edges = new Edge<int>[2];
                i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, edges);
            }
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(ContractException))]
        public void AddEdgeRange14()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            int i;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, (Edge<int>[])null);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(ContractException))]
        public void AddEdgeRange21()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            int i;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, (Edge<int>[])null);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(ContractException))]
        public void AddEdgeRange22()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            int i;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            Edge<int>[] edges = new Edge<int>[1];
            i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, edges);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(ContractException))]
        public void AddEdgeRange23()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            Edge<int> edge;
            int i;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            edge = EdgeFactory.Create(0, 0);
            Edge<int>[] edges = new Edge<int>[1];
            edges[0] = edge;
            i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, edges);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(ContractException))]
        public void AddEdgeRange24()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            int i;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(37933133, 618999);
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(557842444, default(int));
            keyValuePairs[1] = s1;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, (Edge<int>[])null);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(ContractException))]
        public void AddEdgeRange25()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            Edge<int> edge;
            int i;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(12, 12);
            keyValuePairs[0] = s0;
            adjacencyGraph = AdjacencyGraphFactory.Create(true, keyValuePairs);
            edge = EdgeFactory.Create(0, 0);
            Edge<int>[] edges = new Edge<int>[1];
            edges[0] = edge;
            i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, edges);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdgeRange26()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            int i;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[3];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(369098880, 283166762);
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(115043328, 283166762);
            keyValuePairs[1] = s1;
            KeyValuePair<int, int> s2
               = new KeyValuePair<int, int>(-1864316886, default(int));
            keyValuePairs[2] = s2;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            Edge<int>[] edges = new Edge<int>[1];
            edges[0] = (Edge<int>)null;
            i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, edges);
            Assert.AreEqual<int>(0, i);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(ContractException))]
        public void AddEdgeRange27()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            int i;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, (Edge<int>[])null);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(ContractException))]
        public void AddEdgeRange29()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            int i;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, (Edge<int>[])null);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(ContractException))]
        public void AddEdgeRange30()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            int i;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            Edge<int>[] edges = new Edge<int>[1];
            i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, edges);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(ContractException))]
        public void AddEdgeRange31()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            Edge<int> edge;
            int i;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            edge = EdgeFactory.Create(0, 0);
            Edge<int>[] edges = new Edge<int>[1];
            edges[0] = edge;
            i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, edges);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(ContractException))]
        public void AddEdgeRange32()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            int i;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(37933133, 618999);
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(557842444, default(int));
            keyValuePairs[1] = s1;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, (Edge<int>[])null);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        [ExpectedException(typeof(ContractException))]
        public void AddEdgeRange33()
        {
            if (!PexContract.HasRuntimeContracts(typeof(AdjacencyGraph<,>)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            int i;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[3];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(1646274564, 1470341636);
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(609227148, 1470341636);
            keyValuePairs[1] = s1;
            KeyValuePair<int, int> s2 = new KeyValuePair<int, int>(-677142012, 10);
            keyValuePairs[2] = s2;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            Edge<int>[] edges = new Edge<int>[2];
            edges[0] = (Edge<int>)null;
            i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, edges);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdgeRange34()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            int i;
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[3];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(1, 1884758142);
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(574413078, 574413078);
            keyValuePairs[1] = s1;
            KeyValuePair<int, int> s2
               = new KeyValuePair<int, int>(-2147483647, default(int));
            keyValuePairs[2] = s2;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
            Edge<int>[] edges = new Edge<int>[1];
            edges[0] = (Edge<int>)null;
            i = this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, edges);
            Assert.AreEqual<int>(0, i);
        }
    }
}
