using System;
using System.Collections.Generic;

namespace SortedDictionary
{
    class Program
    {
        //this will print the list in ascending order on the basis of key
        static void Main(string[] args)
        {
            SortedDictionary<string, string> names = new SortedDictionary<string, string>();
            names.Add("2", "Pragya");
            names.Add("1", "Anamika");

            foreach(var item in names)
            {
                Console.WriteLine(item.Key + " " + item.Value); 
            }
        }
    }
}
