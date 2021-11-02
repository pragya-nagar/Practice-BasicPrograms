using System;

namespace ReflectionTypeInformation
{
    //Type information as in what type it is , class, interface , object?
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(System.String);
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.BaseType);
            Console.WriteLine(t.IsClass);
            Console.WriteLine(t.IsEnum);
            Console.WriteLine(t.IsInterface);

        }
    }
}
