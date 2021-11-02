using System;

namespace InternalAcessSpecifier
{
    class Program
    {
        static void Main(string[] args)
        {
            InternalSpecifierTest internalSpecifierTest = new InternalSpecifierTest();
            Console.WriteLine(internalSpecifierTest.name);
            internalSpecifierTest.Message("Anita");

        }
    }

     class InternalSpecifierTest
    {
        internal string name = "Pragya";
        internal void Message(string message)
        {
            Console.Write("Hello" + " " + message);
        }
    }
}
