using System;

namespace SelectionSort
{
    class Program
    {
        //0 index se last index tak sbse chota no. dhundte hai jo 0 index wale no. se sbse chota ho jb mil jaata hai to usko
        //usse replace kr dete hai, fir 1st index se same chiz check krte h , Yha Index ki value ka comparison vhlta h n vo index de dete hai hum
        static void Main(string[] args)
        {
            double[] arr = { 10, 4, 3, 6, 7 };
            for (int mainIndex = 0; mainIndex < arr.Length; mainIndex++)
            {
                var minIndex = mainIndex;
                for (int remainingIndex = mainIndex + 1; remainingIndex < arr.Length; remainingIndex++)
                {
                    if (arr[remainingIndex] < arr[minIndex])
                    {
                        minIndex = remainingIndex;
                    }
                }

                var minValueFound = arr[minIndex];
                arr[minIndex] = arr[mainIndex];
                arr[mainIndex] = minValueFound;
            }

            foreach (var item in arr )
            {
                Console.Write(item + " ");
            }

        }

    }
}
