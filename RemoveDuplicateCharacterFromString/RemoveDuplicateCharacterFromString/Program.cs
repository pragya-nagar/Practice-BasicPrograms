using System;

namespace RemoveDuplicateCharacterFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the string");
            string input = "Pragya Nagar";
            string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (!result.Contains(input[i]))
                {
                    result += input[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
