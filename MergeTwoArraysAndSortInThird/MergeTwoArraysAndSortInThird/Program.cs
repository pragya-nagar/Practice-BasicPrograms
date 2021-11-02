using System;

namespace MergeTwoArraysAndSortInThird
{
    class Program
    {
        static void Main(string[] args)
        {
            //First thing that we are going to do is copy two arrays into a third one 
            int[] arr_A = { 1, 12, 92, 4, -5, 6 };
            int[] arr_B = { 121, 2, 32, 4 };

            int[] result = new int[arr_A.Length + arr_B.Length];

            for (int idxA = 0, idxB = 0; idxA + idxB < result.Length;)
            {
                if(idxA < arr_A.Length)
                {
                    result[idxA] = arr_A[idxA];
                    idxA++;
                }
                if(idxB<arr_B.Length)
                {
                    result[arr_A.Length + idxB] = arr_B[idxB];
                    idxB++;
                }
            }
            Array.Sort(result);
            for(int i=0;i<result.Length;i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
