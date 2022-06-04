using System;
using System.Collections.Generic;
using Cognophile.Toolblox.Blocks.Base;
using Cognophile.Toolblox.Blocks.Base.Collections;

namespace Cognophile.Toolblox.Blocks.Statics.Collections
{
    public sealed class CollectionsBlock : IBlock
    {
        /// <summary>
        /// Determines whether the subject called upon is empty
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns>Boolean value representing the state of the collection</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsEmpty<T>(IEnumerable<T> collection) => CollectionsBaseBlock.IsEmpty(collection);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Retrieves the element of the collection with the lowest value for the given property
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="P"></typeparam>
        /// <param name="collection"></param>
        /// <param name="func"></param>
        /// <returns>An element of type TSource with the lowest value</returns>
#pragma warning disable CA1822 // Mark members as static
        public T GetByPropertyMin<T, P>(IEnumerable<T> collection, Func<T, P> func) where P : IComparable => CollectionsBaseBlock.GetByPropertyMin<T, P>(collection, func);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Retrieves the element of the collection with the highest value for the given property
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="P"></typeparam>
        /// <param name="collection"></param>
        /// <param name="func"></param>
        /// <returns>An element of type TSource with the highest value</returns>
#pragma warning disable CA1822 // Mark members as static
        public T GetByPropertyMax<T, P>(IEnumerable<T> collection, Func<T, P> func) where P : IComparable => CollectionsBaseBlock.GetByPropertyMax<T, P>(collection, func);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Partitions the source by the given predicate
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="func"></param>
        /// <returns>Enumeration containing enumerations representing the predicate-divised partitions</returns>
#pragma warning disable CA1822 // Mark members as static
        public IEnumerable<IEnumerable<T>> PartitionBy<T>(IEnumerable<T> collection, Func<T, bool> func) => CollectionsBaseBlock.PartitionBy<T>(collection, func);
#pragma warning restore CA1822 // Mark members as static
    }
}
