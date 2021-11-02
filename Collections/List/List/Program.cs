using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //create list of strings
            var names = new List<string>();
            names.Add("Pragya");
            names.Add("Abhishek");
            names.Add("Gagan");
            names.Add("Shruti");
            names.Add("Anamika");
            names.Add("AmanJi");

            //iterate list elements using foreach loop like an array
            foreach(var item in names)
            {
                Console.WriteLine(item);
            }

        }
    }
}
