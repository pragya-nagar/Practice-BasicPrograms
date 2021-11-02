using System;

namespace BasicArrayProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int[] st = {13, 45, 67};
            arr[0] = 10;
            arr[2] = 20;
            arr[4] = 30;

            //Traversing array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
    }
    }
}
