using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SortingComparison
{
    class QuickSort : ISorter
    {
        public NumberProvider NumberProvider { get; set; }
        public string SortAlgorithmName { get; set; } = "Quick Sort";

        public QuickSort()
        {
            NumberProvider = new NumberProvider();
        }
        public QuickSort(NumberProvider originalNumberProvider)
        {
            this.NumberProvider = new NumberProvider(originalNumberProvider);
        }

        public BigInteger Sort(int[] numbers, int start, int end)
        {
            BigInteger totalNumberOfComparisons = 0;

            int i;
            if (start < end)
            {
                i = Partition(numbers, start, end);

                Sort(numbers, start, i - 1);
                Sort(numbers, i + 1, end);
            }
            return totalNumberOfComparisons;
        }

        public BigInteger Sort(List<int> numbers, int start, int end)
        {
            BigInteger totalNumberOfComparisons = 0;

            int i;
            if (start < end)
            {
                i = Partition(numbers, start, end);

                Sort(numbers, start, i - 1);
                Sort(numbers, i + 1, end);
            }
            return totalNumberOfComparisons;
        }


        private int Partition(IList<int> numbers, int start, int end)
        {
            int temp;
            int p = numbers[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (numbers[j] <= p)
                {
                    i++;
                    temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }

            temp = numbers[i + 1];
            numbers[i + 1] = numbers[end];
            numbers[end] = temp;
            return i + 1;
        }
    }
}
