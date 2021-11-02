using System;

namespace MultiLevelInheritance
{

    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating..");
        }

    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barkingg..");
        }
    }

    public class BabyDog : Dog
    {
        public void Weep()
        {
            Console.WriteLine("Weeping...");
        }
    }
    class TestInheritance
    {
        static void Main(string[] args)
        {
            BabyDog babyDog = new BabyDog();
            babyDog.eat();
            babyDog.Bark();
            babyDog.Weep();
        }
    }
}
