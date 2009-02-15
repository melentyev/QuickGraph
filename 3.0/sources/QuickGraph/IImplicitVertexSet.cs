﻿using System;
using System.Diagnostics.Contracts;
using QuickGraph.Contracts;

namespace QuickGraph
{
    /// <summary>
    /// An implicit set of vertices
    /// </summary>
    /// <typeparam name="TVertex"></typeparam>
#if CONTRACTS_FULL
    [ContractClass(typeof(IImplicitVertexSetContract<>))]
#endif
    public interface IImplicitVertexSet<TVertex>
    {
        /// <summary>
        /// Determines whether the specified vertex contains vertex.
        /// </summary>
        /// <param name="vertex">The vertex.</param>
        /// <returns>
        /// 	<c>true</c> if the specified vertex contains vertex; otherwise, <c>false</c>.
        /// </returns>
        [Pure]
        bool ContainsVertex(TVertex vertex);
    }
}
