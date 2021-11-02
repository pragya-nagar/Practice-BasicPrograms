using System;

namespace ProtectedSpecifier
{
    class Program : ProtectedSpecifierTest
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Hello" + program.name);
            program.Message("Tinkuu");
            Console.ReadKey();
        }
    }

    class ProtectedSpecifierTest
    {
        protected string name = "Pragya";
        protected void Message(string msg)
        {
            Console.WriteLine("Hello" + msg);
        }
    }
}
