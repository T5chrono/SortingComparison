﻿using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace SortingComparison
{
    class BubbleSort : ISorter
    {
        public NumberProvider NumberProvider { get; set; }
        public string SortAlgorithmName { get; set; } = "Bubble Sort";

        public BubbleSort()
        {
            NumberProvider = new NumberProvider();
        }
        
        public BigInteger Sort(int[] numbers)
        {
            BigInteger totalNumberOfComparisons = 0;

            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                    totalNumberOfComparisons++;
                }
            }

            return totalNumberOfComparisons;
        }  

        public BigInteger Sort(List<int> numbers)
        {
            BigInteger totalNumberOfComparisons = 0;

            int n = numbers.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                    totalNumberOfComparisons++;
                }
            }

            return totalNumberOfComparisons;
        }
    }
}
