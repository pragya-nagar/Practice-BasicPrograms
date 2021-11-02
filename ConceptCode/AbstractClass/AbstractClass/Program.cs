using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Rectangle();
            s.Draw();
            s = new Circle();
            s.Draw();
        }
    }

    public abstract class Shape
    {
        public abstract void Draw();
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drwaing Rectangle..");
        }
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drwaing Circle");
        }
    }
}
