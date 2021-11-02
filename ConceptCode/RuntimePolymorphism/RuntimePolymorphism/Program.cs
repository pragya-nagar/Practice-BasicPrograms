using System;

namespace RuntimePolymorphism
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing...");
        }
    }

    public  class Rectangle : Shape
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
            Console.WriteLine("Drawing Circle..");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape;
            shape = new Shape();
            shape.Draw();
            shape = new Rectangle();
            shape.Draw();
            shape = new Circle();
            shape.Draw();
        }
    }
}
