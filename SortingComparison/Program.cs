﻿using System;
using System.Collections.Generic;

namespace SortingComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISorter> SortingAlgorithms = new List<ISorter>()
            {
                new BubbleSort(),
                new InsertionSort(),
            };

            SortingController SortingController = new SortingController(SortingAlgorithms);
            
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
