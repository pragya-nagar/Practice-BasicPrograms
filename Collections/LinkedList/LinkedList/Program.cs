using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //create linked list of string type
            var names = new LinkedList<string>();
            names.AddLast("Pragya");
            names.AddLast("Anamika");
            names.AddLast("Chinu");
            names.AddLast("Pappu");
            names.AddFirst("MeriTappu");

            foreach(var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
