using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SortingComparison
{
    class MergeSort : ISorter
    {
        public NumberProvider NumberProvider { get; set; }
        public string SortAlgorithmName { get; set; } = "Merge Sort";

        public MergeSort()
        {
            NumberProvider = new NumberProvider();
        }
        public MergeSort(NumberProvider originalNumberProvider)
        {
            this.NumberProvider = new NumberProvider(originalNumberProvider);
        }

        public BigInteger Sort(int[] numbers, int left = 0, int right = 0)
        {
            BigInteger totalNumberOfComparisons = 0;

            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                Sort(numbers, left, mid);
                Sort(numbers, (mid + 1), right);
                MainMerge(numbers, left, (mid + 1), right);
            }
            return totalNumberOfComparisons;
        }

        public BigInteger Sort(List<int> numbers, int left = 0, int right = 0)
        {
            BigInteger totalNumberOfComparisons = 0;

            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                Sort(numbers, left, mid);
                Sort(numbers, (mid + 1), right);
                MainMerge(numbers, left, (mid + 1), right);
            }
            return totalNumberOfComparisons;
        }

        static public void MainMerge(IList<int> numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (left <= eol)
                temp[pos++] = numbers[left++];
            while (mid <= right)
                temp[pos++] = numbers[mid++];
            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
    }
}
