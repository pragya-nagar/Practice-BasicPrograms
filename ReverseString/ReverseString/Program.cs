using System;

namespace ReverseString
{
    class Program
    {
        /// <summary>
        /// Ye program sentence ko v reverse krege n har ek word ko v reverse krega
        /// space between the words is treated as string
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string  reverse = "";
            int length = 0;
            Console.WriteLine("Enter a word");
            var str = "i am a hunter" ;
            length = str.Length - 1;
            while(length>=0)
            {
                reverse = reverse + str[length];
                length--;
            }
            //Displaying the reverse word
            Console.WriteLine("Reverse word is" + " " + reverse);
            Console.ReadKey();
        }
    }
}
