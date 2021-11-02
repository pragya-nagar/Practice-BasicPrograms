using System;

namespace GenericMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass gen = new GenericClass();
            gen.GenericMethod("This is generic method");
            gen.GenericMethod(101);
            gen.GenericMethod('U');
        }
    }
    class GenericClass
    {
        public void GenericMethod<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
}
