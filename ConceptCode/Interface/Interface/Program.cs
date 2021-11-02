using System;

namespace Interface
{
    //same like abstract class
    class Program
    {
        static void Main(string[] args)
        {
            Drawable d;
            d = new Rectangle();
            d.Draw();
            d = new Circle();
            d.Draw();
        }

    }

    public interface Drawable
    {
        void Draw();
    }
    public class Rectangle : Drawable
    {
        public void Draw()
        {
            Console.WriteLine("Drwaing Rectangle..");
        }
    }

    public class Circle : Drawable
    {
        public void Draw()
        {
            Console.WriteLine("Draw Circle...");
        }
    }
}
