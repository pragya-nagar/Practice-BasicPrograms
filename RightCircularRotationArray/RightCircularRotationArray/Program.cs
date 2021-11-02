using System;

namespace RightCircularRotationArray
{
    class Program
    {
        internal static void RotateArrayRight(int[] arr)
        {
            int size = arr.Length;
            int temp;
            for (int j = 0; j < arr.Length - 1; j++)
            {
                temp = arr[0];
                arr[0] = arr[j + 1];
                arr[j + 1] = temp;

            }
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            RotateArrayRight(arr);
        }
    }
}
