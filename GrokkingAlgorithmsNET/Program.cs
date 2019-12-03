using System;
using System.Collections.Generic;
using System.Linq;
using _01_BinarySearch;
using _02_SelectionSort;
using _03_01_RecursionCountdown;
using _03_02_RecursionGreet;
using _03_03_RecursionFactorial;
using _04_01_QuicksortDivideAndConquer;
using AutoFixture;

namespace GrokkingAlgorithmsNET
{
    class Program
    {
        private static readonly Random _random = new Random();
        private static readonly Fixture _fixture = new Fixture();

        static void Main(string[] args)
        {
            //BinarySearchExample01();
            //BinarySearchExample02();
            //BinarySearchExample03();
            //BinarySearchExample04();

            //SelectionSortExample01();
            //SelectionSortExample02();
            //SelectionSortExample03();
            //SelectionSortExample04();

            //RecursionCountdownExample01();
            //RecursionGreetExample01();
            //RecursionFactorialExample01();

            //QuicksortDivideAndConquerExample01();
            QuicksortDivideAndConquerExample02();
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

        static void BinarySearchExample04()
        {
            var array = new[]
            {
                Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid()
            }.OrderBy(a => a).Select(a => a.ToString()).ToArray();

            int? indexExpected = null;

            Console.WriteLine($@"Expected index: {(indexExpected.HasValue ? indexExpected.Value.ToString() : "null")}");

            var index = BinarySearch.IndexOf(array, "serge");
            var indexString = index.HasValue ? index.Value.ToString() : "null";

            Console.WriteLine($"Actual index: {indexString}");
        }

        #endregion BinarySearch

        #region SelectionSort

        static void SelectionSortExample01()
        {
            var items = new List<int>();

            for (var i = 0; i < 20; i++)
                items.Add(_random.Next(1, 1000));

            Console.WriteLine($"Original: {string.Join(", ", items)}");

            var result = SelectionSort.OrderByAscending(items);

            Console.WriteLine($"OrderByAscending: {string.Join(", ", result)}");
            Console.WriteLine();
        }

        static void SelectionSortExample02()
        {
            var items = new List<int>();

            for (var i = 0; i < 20; i++)
                items.Add(_random.Next(1, 1000));

            Console.WriteLine($"Original: {string.Join(", ", items)}");

            var result = SelectionSort.OrderByDescending(items);

            Console.WriteLine($"OrderByDescending: {string.Join(", ", result)}");
            Console.WriteLine();
        }

        static void SelectionSortExample03()
        {
            var items = new List<Guid>();

            for (var i = 0; i < 20; i++)
                items.Add(Guid.NewGuid());

            Console.WriteLine($"Original:\r\n{string.Join("\r\n", items)}");
            Console.WriteLine();

            var result = SelectionSort.OrderByAscending(items);

            Console.WriteLine($"OrderByAscending:\r\n{string.Join("\r\n", result)}");
            Console.WriteLine();
        }

        static void SelectionSortExample04()
        {
            var items = new List<Guid>();

            for (var i = 0; i < 20; i++)
                items.Add(Guid.NewGuid());

            Console.WriteLine($"Original:\r\n{string.Join("\r\n", items)}");
            Console.WriteLine();

            var result = SelectionSort.OrderByDescending(items);

            Console.WriteLine($"OrderByDescending:\r\n{string.Join("\r\n", result)}");
            Console.WriteLine();
        }

        #endregion SelectionSort

        #region Recursion

        static void RecursionCountdownExample01()
        {
            RecursionCountdown.Countdown(50);
        }

        static void RecursionGreetExample01()
        {
            RecursionGreet.Greet("Sergey");
        }

        static void RecursionFactorialExample01()
        {
            const int num = 5;

            Console.WriteLine($"num = {num}");
            Console.WriteLine($"Factorial(num) = {RecursionFactorial.Factorial(num)}");
        }

        #endregion Recursion

        #region Quicksort

        static void QuicksortDivideAndConquerExample01()
        {
            var size = (1680, 640);
            var result = QuicksortDivideAndConquer.GetBiggestEvenlySize(size);

            Console.WriteLine($"{nameof(QuicksortDivideAndConquer.GetBiggestEvenlySize)} = {result}");
            Console.WriteLine($"Plot of land count = {size.Item1 / result * (size.Item2 / result)}");
        }

        static void QuicksortDivideAndConquerExample02()
        {
            IEnumerable<int> GetArray()
            {
                for (var i = 0; i < 100; i++)
                {
                    yield return _fixture.Create<int>(); ;
                }
            }

            var array = GetArray().ToArray();
            var result = QuicksortDivideAndConquer.GetTotal(array);

            Console.WriteLine($"{nameof(GetArray)} = {array.AsString()}");
            Console.WriteLine($"{nameof(QuicksortDivideAndConquer.GetTotal)} = {result}");
        }

        #endregion Quicksort
    }
}
