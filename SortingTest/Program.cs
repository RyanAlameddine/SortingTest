using System;

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
            long[] elapsedTimes = new long[6];
            for(int i = 0; i < testCount; i++)
            {
                double[][] arrays = Sorter.GenerateArrays(random, 6, numsPerTest);


                var watch = System.Diagnostics.Stopwatch.StartNew();
                //Quick
                watch.Stop(); elapsedTimes[0] += watch.ElapsedMilliseconds;

                watch.Restart();
                //Merge
                watch.Stop(); elapsedTimes[1] += watch.ElapsedMilliseconds;

                watch.Restart();
                //Bubble
                watch.Stop(); elapsedTimes[2] += watch.ElapsedMilliseconds;

                watch.Restart();
                //Insertion
                watch.Stop(); elapsedTimes[3] += watch.ElapsedMilliseconds;

                watch.Restart();
                //Heap
                watch.Stop(); elapsedTimes[4] += watch.ElapsedMilliseconds;

                watch.Restart();
                //Selection
                watch.Stop(); elapsedTimes[5] += watch.ElapsedMilliseconds;
            }
        }
    }
}
