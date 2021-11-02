using System;

namespace ThirdLargestIntergerInArray
{
    class Program
    {
        internal static void ThirdLargestElement(int[] arr)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;

            foreach(var item in arr)
            {
                if(item>max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = item;
                }
                else if(item>max2 && item!=max1)
                {
                    max3 = max2;
                    max2 = item;
                    
                }
                else if(item>max3 && item!=max2 && item!=max1)
                {
                    max3 = item;
                }
            }
            Console.WriteLine(max3);

        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            ThirdLargestElement(arr);
        }
    }
}
