using System;

namespace PassingArrayToFunctions
{
    class Program
    {
        /// <summary>
        /// Don't get confused array  can have duplicate elements the only disadvantage is that it has fixed size
        /// </summary>
        /// <param name="arr"></param>
        static void PrintArray(int[] arr)
        {
            Console.WriteLine("Printing array elements:");
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] arr1 = {23,45,67,98,34 };
            int[] arr2 = { 56, 89, 56, 78 };
            PrintArray(arr1);
            PrintArray(arr2);
        }
    }
}
