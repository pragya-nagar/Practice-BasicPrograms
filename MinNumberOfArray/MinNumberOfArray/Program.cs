using System;

namespace MinNumberOfArray
{
    class Program
    {
        public void MinimumNumber(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {

                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(min);

        }
        static void Main(string[] args)
        {
            int[] arr1 = { 25, 10, 20, 15, 40, 50 };
            Program program = new Program();
             program.MinimumNumber(arr1);
            Console.ReadKey();
          
        }
    }
}
