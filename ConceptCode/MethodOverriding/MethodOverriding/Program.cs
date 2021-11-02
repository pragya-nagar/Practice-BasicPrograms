using System;

namespace MethodOverriding
{
    public class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eating..");
        }

    }
    public class Dog : Animal
    {
        public void Eat()
        {
            base.Eat();
            Console.WriteLine("Eating Bread...");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Dog a = new Dog();
            a.Eat();
            // a = new Dog();

            //Dog dog = new Dog();
            //dog.Eat();
        }
    }
}
