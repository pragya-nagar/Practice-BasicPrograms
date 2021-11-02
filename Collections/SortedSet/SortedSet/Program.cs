using System;
using System.Collections.Generic;

namespace SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a SortedSet of strings 
            var names = new SortedSet<string>();
            names.Add("Chinu");
            names.Add("Pappu");

            foreach(var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
