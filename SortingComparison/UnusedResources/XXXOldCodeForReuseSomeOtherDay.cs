//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SortingComparison
//{
//    class XXXOldCodeForReuseSomeOtherDay
//    {
//        using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.IO;
//using System.IO.Enumeration;
//using System.Reflection.Metadata.Ecma335;
//using System.Text;

//namespace SortingComparison
//    {
//        class Program
//        {
//            static void Main(string[] args)
//            {
//                List<string> Filepaths = new List<string>();
//                List<string> FileNames = new List<string>();
//                try
//                {
//                    Filepaths = GetAllPaths(args);
//                    FileNames = GetAllFileNames(args);
//                }
//                catch (IndexOutOfRangeException)
//                {
//                    Console.WriteLine("You should provide at least one valid file name as line argument");
//                }
//                Console.WriteLine(Filepaths[0]);

//                for (int i = 0; i < Filepaths.Count; i++)
//                {
//                    DoInsertionSort(Filepaths[i], FileNames[i]);
//                }


//                static List<string> GetAllPaths(string[] args)
//                {
//                    List<string> paths = new List<string>();
//                    for (int i = 0; i < args.Length; i++)
//                    {
//                        paths.Add($@"C:\Users\Tomasz.Giela\Dropbox\Codecool - JS\SortingComparison\Resources\{args[i]}.txt");
//                    }
//                    return paths;
//                }

//                static List<string> GetAllFileNames(string[] args)
//                {
//                    List<string> fileNames = new List<string>();
//                    for (int i = 0; i < args.Length; i++)
//                    {
//                        fileNames.Add(args[i]);
//                    }
//                    return fileNames;
//                }
//            }

//            private static void DoInsertionSort(string filePath, string fileName)
//            {
//                string fileNameX = fileName;

//                List<int> AllNumbers = GetListOfNumbers(filePath);
//                int[] AllNumbersArray = AllNumbers.ToArray();

//                Stopwatch benchmarkTime = new Stopwatch();
//                benchmarkTime.Start();
//                InsertionSort(AllNumbersArray);
//                benchmarkTime.Stop();
//                TimeSpan ts = benchmarkTime.Elapsed;
//                string elapsedTime = $"{ts.TotalMilliseconds} miliseconds";
//                Console.WriteLine(elapsedTime);

//                WriteResultToAFile(fileName, AllNumbersArray);

//                static List<int> GetListOfNumbers(string fileName)
//                {
//                    const Int32 BufferSize = 128;
//                    List<int> allNumbers = new List<int>();

//                    using (var fileStream = File.OpenRead(fileName))
//                    using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
//                    {
//                        String line;
//                        while ((line = streamReader.ReadLine()) != null)
//                        {
//                            allNumbers.Add(Convert.ToInt32(line));
//                        }
//                    }

//                    return allNumbers;
//                }

//                static void InsertionSort(int[] arrayInts)
//                {
//                    int n = arrayInts.Length;
//                    for (int i = 1; i < n; ++i)
//                    {
//                        int key = arrayInts[i];
//                        int j = i - 1;
//                        while (j >= 0 && arrayInts[j] > key)
//                        {
//                            arrayInts[j + 1] = arrayInts[j];
//                            j = j - 1;
//                        }

//                        arrayInts[j + 1] = key;
//                    }
//                }

//                static void WriteResultToAFile(string fileNameX, int[] allNumbersArray)
//                {
//                    using (StreamWriter file = new StreamWriter($@"C:\Users\Tomasz.Giela\Dropbox\Codecool - JS\SortingComparison\Resources\sorted_{fileNameX}.txt"))
//                    {
//                        foreach (var number in allNumbersArray)
//                        {
//                            file.WriteLine(number);
//                        }
//                    }
//                }
//            }
//        }
//    }

//}
//}
