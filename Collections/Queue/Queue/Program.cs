using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new Queue<string>();
            names.Enqueue("AAyu");
            names.Enqueue("Puneet");
            names.Enqueue("Pragya");
            names.Enqueue("MeriTappu");

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Peek element" + " " + names.Peek()); //queue.peek()
            Console.WriteLine("Remove Element" + " " + names.Dequeue());
            Console.WriteLine("Peek element again" + " " + names.Peek());


        }
    }
}
