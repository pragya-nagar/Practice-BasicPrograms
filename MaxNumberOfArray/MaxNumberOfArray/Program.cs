using System;

namespace MaxNumberOfArray
{
    class Program
    {
        public void PrintMaxNumber(int[] arr)
        {
            var max = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if(max<arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 25, 10, 20, 15, 40, 50 };
            Program program = new Program();
            program.PrintMaxNumber(arr1);
        }
    }
}
