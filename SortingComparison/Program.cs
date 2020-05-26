using System.Collections.Generic;

namespace SortingComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISorter> SortingAlgorithms = new List<ISorter>()
            {
                new InsertionSort(),
            };

            SortingController SortingController = new SortingController(SortingAlgorithms);
            
            SortingController.ComputeSortAlgorithmsStatistics();
        }

    }
}
