using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortCSharp
{
    class Program
    {
        static int[] nums = { 2, 8, 3, 5, 1, 3 };

        static void Main(string[] args)
        {
            int[] sortedList = InsertionSort(nums);

            foreach (var n in sortedList)
            {
                Console.Write(n);
            }
            Console.ReadLine();
        }

        static int[] InsertionSort(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                int currentValue = list[i];
                while (i > 0 && list[i - 1] > currentValue)
                {
                    list[i] = list[i - 1];
                    i--;
                }
                list[i] = currentValue;
            }
            return list;
        }
    }
}
