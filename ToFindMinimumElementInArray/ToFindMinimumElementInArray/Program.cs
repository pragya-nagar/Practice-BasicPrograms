using System;

namespace ToFindMinimumElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,2,5,0,8,6};
            PrintMinElement(arr);
        }

        public static void PrintMinElement(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if(min>arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("small element is :" + min);
        }
    }
}
