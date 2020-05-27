using System;
using System.Collections.Generic;

namespace SortingComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberProvider originalNumberProvider = LoadNumbersFromFile();

            List<ISorter> SortingAlgorithms = new List<ISorter>()
            {
                new BubbleSort(originalNumberProvider),
                new InsertionSort(originalNumberProvider),
                new QuickSort(originalNumberProvider),
                new MergeSort(originalNumberProvider),
                new SelectionSort(originalNumberProvider),
            };

            SortingController SortingController = new SortingController(SortingAlgorithms);

           //Console.WriteLine("Test");
           //SortingAlgorithms[4].Sort(originalNumberProvider.ArraysOfUnorderedNumbers[1]);
           //Console.WriteLine("End test");
            
            SortingController.ComputeSortAlgorithmsStatistics();
        }
        private static NumberProvider LoadNumbersFromFile()
        {
            Console.WriteLine("Hello in Sorting Comparison");
            NumberProvider NumberProvider = new NumberProvider();
            Console.WriteLine("Completed Loading Files");
            Console.WriteLine(Environment.NewLine);
            return NumberProvider;
        }
    }
}
