using System;
using System.IO;

namespace SortingTest
{
    class Program
    {
        const int testCount = 1000;
        const int numsPerTest = 1000;
        public static (int min, int max) minmax = (0, 1000);
        static Random random = new Random();

        static void Main(string[] args)
        {
            //Quick, Merge, Bubble, Insertion, Heap, Selection
            long[,] elapsedTimes = new long[6, testCount];
            for(int i = 0; i < testCount; i++)
            {
                int[][] arrays = Sorter.GenerateArrays(random, 6, numsPerTest);


                var watch = System.Diagnostics.Stopwatch.StartNew();

                watch.Start();
                //Quick
                Sorter.QuickSort(arrays[0]);
                watch.Stop(); elapsedTimes[0, i] = watch.ElapsedTicks;

                watch.Restart();
                //Merge
                arrays[1] = Sorter.MergeSort(arrays[1]);
                watch.Stop(); elapsedTimes[1, i] = watch.ElapsedTicks;

                watch.Restart();
                //Bubble
                Sorter.BubbleSort(arrays[2]);
                watch.Stop(); elapsedTimes[2, i] = watch.ElapsedTicks;

                watch.Restart();
                //Insertion
                Sorter.InsertionSort(arrays[3]);
                watch.Stop(); elapsedTimes[3, i] = watch.ElapsedTicks;

                watch.Restart();
                //Heap
                Sorter.HeapSort(arrays[4]);
                watch.Stop(); elapsedTimes[4, i] = watch.ElapsedTicks;

                watch.Restart();
                //Selection
                Sorter.SelectionSort(arrays[5]);
                watch.Stop(); elapsedTimes[5, i] = watch.ElapsedTicks;
            }

            //Done with test
            //Recording data in csv file:

            File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "output.csv"));
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(Path.Combine(Directory.GetCurrentDirectory(), "output.csv"), true))
            {
                for (int j = 0; j < elapsedTimes.GetLength(1); j++)
                {
                    for (int i = 0; i < elapsedTimes.GetLength(0); i++)
                    {
                        file.Write(elapsedTimes[i, j] + ", ");
                    }
                    file.WriteLine();
                }
            }
        }
    }
}
