using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        //peek method tells which element is there at last which can be removed
        static void Main(string[] args)
        {
            var names = new Stack<string>();
            names.Push("Pragya");
            names.Push("Anamika");
            names.Push("Puneet");
            names.Push("Aayu");


            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Peek Element" + " " + names.Peek());
            Console.WriteLine("Pop element" + " " + names.Pop());
            Console.WriteLine("Peek Element" + " " + names.Peek());
        }
    }
}
