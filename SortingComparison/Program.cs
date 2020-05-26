using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Enumeration;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SortingComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello in Sorting Comparison");
            NumberProvider NumberProvider = new NumberProvider();
            Console.WriteLine("Completed Loading Files");

            var InsertionSort = new InsertionSort(NumberProvider);

            Stopwatch benchmarkTime = new Stopwatch();
            benchmarkTime.Start();
            var totalNumberOfComparisons = InsertionSort.Sort(NumberProvider.ArraysOfUnorderedNumbers[2]);
            benchmarkTime.Stop();
            TimeSpan ts = benchmarkTime.Elapsed;
            string elapsedTime = $"{ts.TotalMilliseconds} miliseconds";
            Console.WriteLine(elapsedTime);
            Console.WriteLine(totalNumberOfComparisons.ToString());
        }
    }
}
