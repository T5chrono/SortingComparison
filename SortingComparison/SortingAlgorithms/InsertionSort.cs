using System.Collections.Generic;
using System.Numerics;

namespace SortingComparison
{
    class InsertionSort : ISorter
    {
        public NumberProvider NumberProvider { get; set; }
        public string SortAlgorithmName { get; set; } = "Insertion Sort";

        public InsertionSort()
        {
            NumberProvider = new NumberProvider();
        }
        public InsertionSort(NumberProvider originalNumberProvider)
        {
            this.NumberProvider = new NumberProvider(originalNumberProvider);
        }

        public BigInteger Sort(int[] numbers)
        {
            BigInteger totalNumberOfComparisons = 0;

            int n = numbers.Length;
            for (int i = 1; i < n; ++i)
            {
                totalNumberOfComparisons++;
                int key = numbers[i];
                int j = i - 1;
                while (j >= 0 && numbers[j] > key)
                {
                    totalNumberOfComparisons++;
                    numbers[j + 1] = numbers[j];
                    j = j - 1;
                }
                numbers[j + 1] = key;
            }
            return totalNumberOfComparisons;
        }

        public BigInteger Sort(List<int> numbers)
        {
            BigInteger totalNumberOfComparisons = 0;

            int n = numbers.Count;
            for (int i = 1; i < n; ++i)
            {
                totalNumberOfComparisons++;
                int key = numbers[i];
                int j = i - 1;
                while (j >= 0 && numbers[j] > key)
                {
                    totalNumberOfComparisons++;
                    numbers[j + 1] = numbers[j];
                    j = j - 1;
                }
                numbers[j + 1] = key;
            }
            return totalNumberOfComparisons;
        }
    }
}
