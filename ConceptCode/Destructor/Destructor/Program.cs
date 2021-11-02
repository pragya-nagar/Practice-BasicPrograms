using System;

namespace Destructor
{
    class Program
    {
        public Program()
        {
            Console.WriteLine("Constructor Invoked");
        }
        ~Program()
        {
            Console.WriteLine("Destructor Invoked");
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            Console.ReadKey();
        }
    }
}
