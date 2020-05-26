using System.Collections.Generic;
using System.Numerics;

namespace SortingComparison
{
    internal interface ISorter
    {
        NumberProvider NumberProvider { get; set; }
        public string SortAlgorithmName { get; set; }
        BigInteger Sort(int[] numbers);
        BigInteger Sort(List<int> numbers);
    }
}
