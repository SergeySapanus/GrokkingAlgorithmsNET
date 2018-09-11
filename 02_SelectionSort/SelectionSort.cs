using System;
using System.Collections.Generic;

namespace _02_SelectionSort
{
    public class SelectionSort
    {
        public static T[] OrderByAscending<T>(IList<T> array) where T : IComparable<T>
        {
            return OrderBy(OrderType.Ascending, array);
        }

        public static T[] OrderByDescending<T>(IList<T> array) where T : IComparable<T>
        {
            return OrderBy(OrderType.Descending, array);
        }

        private static T[] OrderBy<T>(OrderType orderType, IList<T> array) where T : IComparable<T>
        {
            var sortedArray = new T[array.Count];

            for (var i = 0; i < sortedArray.Length; i++)
            {
                var foundIndex = SearchIndex(orderType, array);
                sortedArray[i] = array[foundIndex];
                array.RemoveAt(foundIndex);
            }

            return sortedArray;
        }

        private static int SearchIndex<T>(OrderType orderType, IList<T> array) where T : IComparable<T>
        {
            var item = array[0];
            var resultIndex = 0;

            for (var i = 1; i < array.Count; i++)
            {
                if (Compare(orderType, array[i], item))
                {
                    item = array[i];
                    resultIndex = i;
                }
            }

            return resultIndex;
        }

        private static bool Compare<T>(OrderType orderType, T next, T current) where T : IComparable<T>
        {
            switch (orderType)
            {
                case OrderType.Ascending:
                    return next.CompareTo(current) < 0;
                case OrderType.Descending:
                    return next.CompareTo(current) > 0;
                default:
                    throw new ArgumentOutOfRangeException(nameof(orderType), orderType, nameof(Compare));
            }
        }
    }

    enum OrderType
    {
        Ascending,
        Descending
    }
}
