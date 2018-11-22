using System;
using System.Collections.Generic;
using System.Text;

namespace SortingTest
{
    public class Sorter
    {
        /// <summary>
        /// Generates *count* copies of a random array of size *numsPerTest*
        /// </summary>
        /// <param name="random"></param>
        /// <param name="count"></param>
        /// <param name="numsPerTest"></param>
        /// <returns></returns>
        public static int[][] GenerateArrays(Random random, int count, int numsPerTest)
        {
            int[][] arrays = new int[count][];

            arrays[0] = new int[numsPerTest];
            for(int j = 0; j < numsPerTest; j++)
            {
                arrays[0][j] = random.Next(Program.minmax.min, Program.minmax.max);
            }
            for(int i = 1; i < count; i++)
            {
                arrays[i] = new int[numsPerTest];
                for (int j = 0; j < numsPerTest; j++)
                {
                    arrays[i][j] = arrays[0][j];
                }
            }

            return arrays;
        }

        #region QuickSort
        public static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);

                if (pivot > 1)
                {
                    QuickSort(array, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(array, pivot + 1, right);
                }
            }

        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }
        #endregion QuickSort
        
        #region MergeSort

        public static int[] MergeSort(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];
            
            if (array.Length <= 1)
                return array;
            
            int midPoint = array.Length / 2;
            
            left = new int[midPoint];
            
            if (array.Length % 2 == 0) right = new int[midPoint];
            else right = new int[midPoint + 1];
            
            for (int i = 0; i < midPoint; i++) left[i] = array[i];
            
            int x = 0;
            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }
            
            left = MergeSort(left);
            right = MergeSort(right);
            result = merge(left, right);

            return result;
        }
        
        private static int[] merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];

            int indexLeft = 0, indexRight = 0, indexResult = 0;
            
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }

            }
            return result;
        }

        #endregion MergeSort

        #region BubbleSort
        public static void BubbleSort(int[] array)
        {
            int length = array.Length;

            int temp = array[0];

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];

                        array[i] = array[j];

                        array[j] = temp;
                    }
                }
            }
        }
        #endregion BubbleSort

        #region InsertionSort
        public static void InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        #endregion InsertionSort

        #region HeapSort

        public static void HeapSort(int[] array)
        {
            int heapSize = BuildHeap(array);
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Swap(array, 0, i);
                heapSize--;
                Heapify(array, 0, heapSize);
            }
        }

        private static int BuildHeap(int[] arr)
        {
            int heapSize = arr.Length - 1;
            for (int i = heapSize / 2; i >= 0; i--)
            {
                Heapify(arr, i, heapSize);
            }
            return heapSize;
        }
        private static void Heapify(int[] arr, int index, int heapSize)
        {
            int left = 2 * index;
            int right = 2 * index + 1;
            int largest = index;

            if (left <= heapSize && arr[left] > arr[index])
            {
                largest = left;
            }

            if (right <= heapSize && arr[right] > arr[largest])
            {
                largest = right;
            }

            if (largest != index)
            {
                Swap(arr, index, largest);
                Heapify(arr, largest, heapSize);
            }
        }

        #endregion HeapSort

        #region SelectionSort
        public static void SelectionSort(int[] array)
        {
            int smallest;
            for (int i = 0; i < array.Length - 1; i++)
            {
                smallest = i;

                for (int index = i + 1; index < array.Length; index++)
                {
                    if (array[index] < array[smallest])
                    {
                        smallest = index;
                    }
                }
                Swap(array, i, smallest);
            }
        }
        #endregion SelectionSort

        private static void Swap(int[] arr, int x, int y)
        {
            int temp = arr[x];
            arr[x]   = arr[y];
            arr[y]   = temp;
        }
    }
}
