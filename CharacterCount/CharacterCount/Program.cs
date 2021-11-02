using System;
using System.Collections.Generic;
using System.Globalization;

namespace CharacterCount
{
    public class Program
    {

        /// <summary>
        /// Occurence of each character in string excluding white space 
        /// </summary>
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        internal void CharCounter(string str)
        {
            foreach (var character in str)
            {
                if (character != ' ')
                {
                    if (!charCount.ContainsKey(character))
                    {
                        charCount.Add(character, 1);
                    }
                    else
                    {
                        charCount[character]++;
                    }
                }
            }
            foreach(var chara in charCount)
            {
                Console.WriteLine("{0}:{1}",chara.Key, chara.Value);
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.CharCounter("Pragya Nagar");
            Console.ReadKey();
        }
    }
}
