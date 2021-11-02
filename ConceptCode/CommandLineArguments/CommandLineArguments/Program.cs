using System;

namespace CommandLineArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
           // Console.WriteLine("Argument Length:" + args.Length);
            Console.WriteLine("Supplied Arguments are:");
            foreach(Object obj in args)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Argument Length:" + args.Length);
            Console.ReadKey();
        }
    }
}
