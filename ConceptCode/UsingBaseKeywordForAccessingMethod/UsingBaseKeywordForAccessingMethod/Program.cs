using System;

namespace UsingBaseKeywordForAccessingMethod
{
    public class Animal
    {
        public virtual  void eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    public class Dog : Animal
    {
        public override void eat()
        {
            base.eat();
            Console.WriteLine("Eating Bread");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.eat();
        }
    }
}
