using System;

namespace LambdaExpression
{
    class Program
    {
        delegate int Square(int num);
        static void Main(string[] args)
        {

            Square GetSquare = x => x * x;
            int j = GetSquare(5);

            Console.WriteLine("Square" + j);
        }
    }
}
