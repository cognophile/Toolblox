using System;
using System.Linq;
using System.Collections.Generic;

namespace Cognophile.Toolblox.Blocks.Base.Collections
{
    public static class CollectionsBaseBlock
    {
        /// <summary>
        /// Determines whether the subject called upon is empty
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns>Boolean value representing the state of the collection</returns>
        public static bool IsEmpty<T>(IEnumerable<T> collection)
        {
            return !collection.Any();
        }

        /// <summary>
        /// Retrieves the element of the collection with the lowest value for the given property
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="P"></typeparam>
        /// <param name="collection"></param>
        /// <param name="func"></param>
        /// <returns>An element of type TSource with the lowest value</returns>
        public static T GetByPropertyMin<T, P>(IEnumerable<T> collection, Func<T, P> func) where P : IComparable
        {
            return collection.Aggregate((a, b) => func(a).CompareTo(func(b)) < 0 ? a : b);
        }

        /// <summary>
        /// Retrieves the element of the collection with the highest value for the given property
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="P"></typeparam>
        /// <param name="collection"></param>
        /// <param name="func"></param>
        /// <returns>An element of type TSource with the highest value</returns>
        public static T GetByPropertyMax<T, P>(IEnumerable<T> collection, Func<T, P> func) where P : IComparable
        {
            return collection.Aggregate((a, b) => func(a).CompareTo(func(b)) > 0 ? a : b);
        }

        /// <summary>
        /// Partitions the source by the given predicate
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="func"></param>
        /// <returns>Enumeration containing enumerations representing the predicate-divised partitions</returns>
        public static IEnumerable<IEnumerable<T>> PartitionBy<T>(IEnumerable<T> collection, Func<T, bool> func)
        {
            yield return collection.Where(func);
            yield return collection.Where(x => !func(x));
        }
    }
}
