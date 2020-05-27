using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SortingComparison
{
    class SelectionSort : ISorter
    {
        public NumberProvider NumberProvider { get; set; }
        public string SortAlgorithmName { get; set; } = "Selection Sort";

        public SelectionSort()
        {
            NumberProvider = new NumberProvider();
        }
        public SelectionSort(NumberProvider originalNumberProvider)
        {
            this.NumberProvider = new NumberProvider(originalNumberProvider);
        }

        public BigInteger Sort(int[] numbers, int start = 0, int end = 0)
        {
            BigInteger totalNumberOfComparisons = 0;

            int n = numbers.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (numbers[j] < numbers[min_idx])
                        min_idx = j;

                int temp = numbers[min_idx];
                numbers[min_idx] = numbers[i];
                numbers[i] = temp;
            }
            return totalNumberOfComparisons;
        }

        public BigInteger Sort(List<int> numbers, int start = 0, int end = 0)
        {
            BigInteger totalNumberOfComparisons = 0;

            int n = numbers.Count;

            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (numbers[j] < numbers[min_idx])
                        min_idx = j;

                int temp = numbers[min_idx];
                numbers[min_idx] = numbers[i];
                numbers[i] = temp;
            }
            return totalNumberOfComparisons;
        }
    }
}
