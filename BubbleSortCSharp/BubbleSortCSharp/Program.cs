using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortCSharp
{
    class Program
    {
        static int[] nums = { 4, 2, 7, 3, 1 };

        static void Main(string[] args)
        {
            foreach (var n in nums)
            {
                Console.Write(n);
            }
            Console.WriteLine();

            int[] sortedList = bubbleSort(nums);
            foreach (var n in sortedList)
            {
                Console.Write(n);
            }
            Console.ReadLine();
        }

        static int[] bubbleSort(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < list.Length - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return list;
        }
    }
}
