using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 7, 8, 9, 1, 5 };
            int[] sortedArray = quickSort(nums, 0, nums.Length - 1);

            foreach (var num in sortedArray)
            {
                Console.Write(num);
            } 
            Console.ReadLine();
        }

        static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than or equal to pivot 
                if (arr[j] <= pivot)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        /// <summary>
        /// The main function that implements QuickSort()
        /// </summary>
        /// <param name="arr">Array to be sorted</param>
        /// <param name="low">Starting index</param>
        /// <param name="high">Ending index</param>
        /// <returns>Array of type int</returns>
        static int[] quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
            return arr;
        }
    }
}

