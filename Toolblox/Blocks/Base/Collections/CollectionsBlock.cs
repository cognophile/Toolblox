using System;
using System.Linq;
using System.Collections.Generic;

namespace Toolblox.Blocks.Base.Collections
{
    public static class CollectionsBlock
    {
        public static bool IsEmpty<T>(IEnumerable<T> collection)
        {
            return collection.Count().Equals(0);
        }

        public static T GetByPropertyMin<T, P>(IEnumerable<T> collection, Func<T, P> func) where P : IComparable
        {
            return collection.Aggregate((a, b) => func(a).CompareTo(func(b)) < 0 ? a : b);
        }

        public static T GetByPropertyMax<T, P>(IEnumerable<T> collection, Func<T, P> func) where P : IComparable
        {
            return collection.Aggregate((a, b) => func(a).CompareTo(func(b)) > 0 ? a : b);
        }
    }
}
