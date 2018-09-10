using System;
using System.Linq;
using _01_BinarySearch;

namespace GrokkingAlgorithmsNET
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchExample01();
            BinarySearchExample02();
            BinarySearchExample03();


        }

        #region BinarySearch

        static void BinarySearchExample01()
        {
            var array = new[] { 10, 11, 20, 24, 34, 39, 40, 44, 58, 90, 99 };
            var item = 20;

            Console.WriteLine($"Expected index: {array.ToList().IndexOf(item)}");

            var index = BinarySearch.IndexOf(array, item);
            var indexString = index.HasValue ? index.Value.ToString() : "null";

            Console.WriteLine($"Actual index: {indexString}");
        }

        static void BinarySearchExample02()
        {
            var array = new string[11];

            for (var i = 0; i < array.Length; i++)
                array[i] = Guid.NewGuid().ToString();

            array = array.OrderBy(a => a).ToArray();

            var indexExpected = 10;

            Console.WriteLine($"Expected index: {indexExpected}");

            var index = BinarySearch.IndexOf(array, array[indexExpected]);
            var indexString = index.HasValue ? index.Value.ToString() : "null";

            Console.WriteLine($"Actual index: {indexString}");
        }

        static void BinarySearchExample03()
        {
            var array = new[]
            {
                Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid()
            }.OrderBy(a => a).ToArray();

            var indexExpected = 0;

            Console.WriteLine($"Expected index: {indexExpected}");

            var index = BinarySearch.IndexOf(array, array[indexExpected]);
            var indexString = index.HasValue ? index.Value.ToString() : "null";

            Console.WriteLine($"Actual index: {indexString}");
        }

        #endregion BinarySearch
    }
}
