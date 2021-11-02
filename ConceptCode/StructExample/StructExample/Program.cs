using System;

namespace StructExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(23,45);
            rectangle.areaOfRectangle();

        }
    }

    public struct Rectangle
    {
        public int width, height;
        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        public void areaOfRectangle()
        {
            Console.WriteLine("Area of rectangle is :" + " " + (width * height));
        }
    }
}
