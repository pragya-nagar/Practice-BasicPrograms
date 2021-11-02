using System;

namespace Generic
{
    //Example of generic class
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> gen = new GenericClass<string>("This is string generic class");
            GenericClass<int> gen1 = new GenericClass<int>(101);
            GenericClass<char> gen2 = new GenericClass<char>('I');
        }
    }

    public class GenericClass<T>
    {
        public GenericClass(T msg)
        {
            Console.WriteLine(msg);
        }
    }
}
