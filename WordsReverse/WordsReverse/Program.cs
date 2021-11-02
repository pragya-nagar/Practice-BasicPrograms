using System;

namespace WordsReverse
{
    public class Program
    {
        public void ReverseWord(string str)
        {
            //var str = "I love programmimg very much";
            var words = str.Split(' ');
           for(int i= words.Length-1; i>=0; i--)
            {
                Console.Write(words[i] + " ");
            }
            Console.ReadKey();
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            program.ReverseWord("I love programmimg very much");
            Console.ReadKey();
        }

        /// <summary>
        /// Alternative way is to use Reverse method of an array class
        /// </summary>
        //string str = "I am going to reverse myself";
        //string result = string.Join(" ", str.Split(' ').Select(x => new string(x.Reverse().ToArray())));
        //Console.WriteLine(result);
        //    Console.ReadKey();


    }
}
