using System.Collections.Generic;
using System.Numerics;

namespace SortingComparison
{
    internal interface ISorter
    {
        BigInteger Sort(int[] numbers);
        BigInteger Sort(List<int> numbers);
    }
}
