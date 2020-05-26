using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SortingComparison
{
    class SortingController
    {
        private readonly List<ISorter> algorithms;

        public SortingController(List<ISorter> algorithms)
        {
            this.algorithms = algorithms;
        }

        public void ComputeSortAlgorithmsStatistics()
        {
            foreach (var algorithm in algorithms)
            {
                for (int i = 0; i < algorithm.NumberProvider.ArraysOfUnorderedNumbers.Count; i++)
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
            var totalNumberOfComparisons = Sorter.Sort(Sorter.NumberProvider.ArraysOfUnorderedNumbers[fileNumber]);
            benchmarkTime.Stop();
            TimeSpan ts = benchmarkTime.Elapsed;
            string elapsedTime = $"{ts.TotalMilliseconds} miliseconds";
            //Results printout
            Console.WriteLine($"{Sorter.SortAlgorithmName} on {Sorter.NumberProvider.ShuffledFilePaths[fileNumber]}");
            Console.WriteLine(elapsedTime);
            Console.WriteLine($"{totalNumberOfComparisons} comparisons");
        }
    }
}
