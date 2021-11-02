using System;

namespace ReflectionGetType
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Type type = a.GetType();
            // Type type = Type.GetType("ReflectionGetType.Program");
            Console.WriteLine(type);
        }
    }
}
