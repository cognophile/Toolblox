using System;
using System.Collections.Generic;
using Cognophile.Toolblox.Blocks.Base.Collections;

namespace Cognophile.Toolblox.Blocks.Extensions.Collections
{
    public static class CollectionsExtensionBlock
    {
        /// <summary>
        /// Determines whether the subject called upon is empty
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns>Boolean value representing the state of the collection</returns>
        public static bool IsEmpty<T>(this IEnumerable<T> collection)
        {
            return CollectionsBaseBlock.IsEmpty(collection);
        }

        /// <summary>
        /// Retrieves the element of the collection with the lowest value for the given property
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="P"></typeparam>
        /// <param name="collection"></param>
        /// <param name="func"></param>
        /// <returns>An element of type TSource with the lowest value</returns>
        public static T GetByPropertyMin<T, P>(this IEnumerable<T> collection, Func<T, P> func) where P : IComparable
        {
            return CollectionsBaseBlock.GetByPropertyMin<T, P>(collection, func);
        }


        /// <summary>
        /// Retrieves the element of the collection with the highest value for the given property
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="P"></typeparam>
        /// <param name="collection"></param>
        /// <param name="func"></param>
        /// <returns>An element of type TSource with the highest value</returns>
        public static T GetByPropertyMax<T, P>(this IEnumerable<T> collection, Func<T, P> func) where P : IComparable
        {
            return CollectionsBaseBlock.GetByPropertyMax<T, P>(collection, func);
        }

        /// <summary>
        /// Partitions the source by the given predicate
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="func"></param>
        /// <returns>Enumeration containing enumerations representing the predicate-divised partitions</returns>
        public static IEnumerable<IEnumerable<T>> PartitionBy<T>(this IEnumerable<T> collection, Func<T, bool> func)
        {
            return CollectionsBaseBlock.PartitionBy<T>(collection, func);
        }
    }
}
