using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Sum_of_Integer_Array
{
    internal class Program
    {
        // Recursive method to calculate sum of array elements
        static int SumArray(int[] arr, int index)
        {
            // Base case: if index reaches array length, stop recursion
            if (index == arr.Length)
                return 0;

            // Recursive case: current element + sum of remaining elements
            return arr[index] + SumArray(arr, index + 1);
        }

        static void Main(string[] args)
        {
            int[] array = { 5, 10, 15, 20, 25 };

            int sum = SumArray(array, 0);

            Console.WriteLine("Array elements: " + string.Join(", ", array));
            Console.WriteLine("Sum of array elements (recursive): " + sum);
        }
    }
}

