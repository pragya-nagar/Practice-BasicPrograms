using System;

namespace ReverseEachWordInSentence
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = "I am a developer";
            string revString = "";
            foreach (var word in s.Split(' '))
            {
                string temp = " ";
                foreach (var item in word.ToCharArray())
                {
                    temp = item + temp;

                }
                revString = revString + temp + " ";
            }
            Console.WriteLine(revString);
            Console.ReadKey();
        }
    }
}
