using System;
using System.Collections.Generic;

namespace LinkedListExample2
{
    //To add lement before and after some specific node
    class Program
    {
        static void Main(string[] args)
        {
            var names = new LinkedList<string>();
            names.AddLast("Pragya");
            names.AddLast("Anamika");
            names.AddLast("Peter");

            //Insert new element before peter
            //this class represents node
            LinkedListNode<string> node = names.Find("Peter");
            names.AddBefore(node, "Anita");
            names.AddAfter(node, "Lucy");

            foreach(var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
