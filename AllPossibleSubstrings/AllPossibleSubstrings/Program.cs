using System;
using System.Text;

namespace AllPossibleSubstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            AllSubstring("Pragya");
            Console.ReadKey();
        }

        static void AllSubstring(string str)
        {
            //length is 6 but indexing start from 0 that is why less than not equal to
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i; j < str.Length; j++)
                {
                    stringBuilder.Append(str[j]);
                    Console.WriteLine(stringBuilder );
                }
            }
        }
    }
}
