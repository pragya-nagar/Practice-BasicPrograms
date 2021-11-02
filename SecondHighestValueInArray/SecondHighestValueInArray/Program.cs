using System;

namespace SecondHighestValueInArray
{
    class Program
    {
        //internal static void SecondLargest(int[] arr)
        //{
        //    Array.Sort(arr);
        //    Array.Reverse(arr);
        //    Console.WriteLine("Second Highest element is" + " " + arr[1]);
        //}
        internal static void SecondLargest(int[] arr)
        {
            int largest = int.MinValue;
            int secondLargest = int.MinValue;
            foreach(var item in arr)
            {
                if(item>largest)
                {
                    secondLargest = largest;
                    largest = item;
                }
                else if(item>secondLargest)
                {
                    secondLargest = item;
                }
            }
            Console.WriteLine(secondLargest);
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            SecondLargest(arr);
        }


        //using linq
        //int secondHighest = (from number in test
        //                     orderby number descending
        //                     select number).Distinct().Skip(1).First()
    }
}
