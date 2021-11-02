using System;

namespace InsertionSort
{
    //insertion sort me hum index +1 previous index ki value ko check krte hai agar choti hoti hai to replace kr dete h
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 10, 4, 8, 6, 7 };
            int i = 1;

            while (i < arr.Length)
            {
                int j = i;
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    double temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    j--;
                }

                i++;
            }

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
