using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SortingComparison
{
    public class NumberProvider
    {
        public List<string> ShuffledFilePaths = new List<string>()
            {
                "one_thousand.txt",
                "ten_thousand.txt",
                //"fifty_thousand.txt",
                //"one_hundred_thousand.txt",
                //"five_hundret_thousand.txt",
                //"one_million.txt",
                //"three_millions.txt",
            };

        public List<string> SortedFilePaths = new List<string>()
            {
                "sorted_one_thousand.txt",
                "sorted_ten_thousand.txt",
                //"sorted_fifty_thousand.txt",
                //"sorted_one_hundred_thousand.txt",
                //"sorted_five_hundret_thousand.txt",
                //"sorted_one_million.txt",
                //"sorted_three_millions.txt",
            };

        public List<List<int>> ListsOfUnorderedNumbers { get; private set; } = new List<List<int>>();
        public List<int[]> ArraysOfUnorderedNumbers { get; private set; } = new List<int[]>();
        public List<LinkedList<int>> LinkedListsOfUnorderedNumbers { get; private set; } = new List<LinkedList<int>>();
        
        public List<List<int>> ListsOfOrderedNumbers { get; private set; } = new List<List<int>>();
        public List<int[]> ArraysOfOrderedNumbers { get; private set; } = new List<int[]>();
        public List<LinkedList<int>> LinkedListsOfOrderedNumbers { get; private set; } = new List<LinkedList<int>>();

        public NumberProvider()
        {
            foreach (var path in ShuffledFilePaths)
            {
                Console.WriteLine(path);
                List<int> numbersList = GetListOfNumbers(path);
                int[] numbersArray = numbersList.ToArray();
                LinkedList<int> numbersLinkedList = new LinkedList<int>(numbersArray);

                ListsOfUnorderedNumbers.Add(numbersList);
                ArraysOfUnorderedNumbers.Add(numbersArray);
                LinkedListsOfUnorderedNumbers.Add(numbersLinkedList);
            }
            foreach (var path in SortedFilePaths)
            {
                Console.WriteLine(path);
                List<int> numbersList = GetListOfNumbers(path);
                int[] numbersArray = numbersList.ToArray();
                LinkedList<int> numbersLinkedList = new LinkedList<int>(numbersArray);

                ListsOfOrderedNumbers.Add(numbersList);
                ArraysOfOrderedNumbers.Add(numbersArray);
                LinkedListsOfOrderedNumbers.Add(numbersLinkedList);
            }
        }

        private List<int> GetListOfNumbers(string fileName)
        {
            string path = Path.Combine(Environment.CurrentDirectory, $@"..\..\..\Resources\", fileName);

            const Int32 BufferSize = 128;
            List<int> allNumbers = new List<int>();

            using (var fileStream = File.OpenRead(path))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    allNumbers.Add(Convert.ToInt32(line));
                }
            }
            Console.WriteLine($"File {fileName} loaded");
            return allNumbers;
        }
    }
}
