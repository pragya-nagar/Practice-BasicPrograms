using System;

namespace AccessingPropertyUsingBaseKeyword
{
    //Accessing property of base class using base keyword
    public class Animal
    {
        public string color = "white";
    }

    public class Dog : Animal
    {
        string color = "black";
        public void ShowColor()
        {
            Console.WriteLine(base.color);
            Console.WriteLine(color);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.ShowColor();
        }
    }
}
