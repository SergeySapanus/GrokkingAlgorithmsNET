using System;
using System.Collections.Generic;

namespace _01_BinarySearch
{
    public class BinarySearch
    {
        public static int? IndexOf<T>(IReadOnlyList<T> sortedArray, T searchItem) where T : IComparable<T>
        {
            var low = 0;
            var high = sortedArray.Count - 1;

            while (low <= high)
            {
                var mid = (low + high) / 2;
                var guess = sortedArray[mid];

                var compareTo = guess.CompareTo(searchItem);

                if (compareTo == 0)
                    return mid;

                if (compareTo > 0)
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return null;
        }
    }
}
