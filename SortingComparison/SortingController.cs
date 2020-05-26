using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SortingComparison
{
    class SortingController
    {
        private readonly NumberProvider numberProvider;
        private readonly List<ISorter> algorithms;

        public SortingController(List<ISorter> algorithms)
        {
            this.numberProvider = LoadNumbersFromFile();
            this.algorithms = algorithms;
        }

        public void ComputeSortAlgorithmsStatistics()
        {
            foreach (var algorithm in algorithms)
            {
                for (int i = 0; i < numberProvider.ArraysOfUnorderedNumbers.Count; i++)
                {
                    Sort(algorithm, i);
                }
            }
        }

        private void Sort(ISorter Sorter, int fileNumber)
        {
            //Timed sorting
            Stopwatch benchmarkTime = new Stopwatch();
            benchmarkTime.Start();
            var totalNumberOfComparisons = Sorter.Sort(numberProvider.ArraysOfUnorderedNumbers[fileNumber]);
            benchmarkTime.Stop();
            TimeSpan ts = benchmarkTime.Elapsed;
            string elapsedTime = $"{ts.TotalMilliseconds} miliseconds";
            //Results printout
            Console.WriteLine($"{Sorter.SortAlgorithmName} on {numberProvider.ShuffledFilePaths[fileNumber]}");
            Console.WriteLine(elapsedTime);
            Console.WriteLine($"{totalNumberOfComparisons} comparisons");
        }

        private NumberProvider LoadNumbersFromFile()
        {
            Console.WriteLine("Hello in Sorting Comparison");
            NumberProvider NumberProvider = new NumberProvider();
            Console.WriteLine("Completed Loading Files");
            Console.WriteLine(Environment.NewLine);
            return NumberProvider;
        }
    }
}
