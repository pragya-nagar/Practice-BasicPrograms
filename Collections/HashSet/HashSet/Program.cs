using System;
using System.Collections.Generic;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a Hashset of strings
            var names = new HashSet<string>();
            names.Add("Pragya");
            names.Add("Pappu");

            //it will not generate an error for the duplicate element
            names.Add("Pappu");


            foreach( var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
