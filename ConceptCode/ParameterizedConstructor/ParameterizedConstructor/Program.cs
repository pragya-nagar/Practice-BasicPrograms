using System;

namespace ParameterizedConstructor
{
    public class Program
    {
        public int id;
        public string name;
        public float salary;

        public Program(int i, string n, float s)
        {
            id = i;
            name = n;
            salary = s;
        }

        public void Display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }

        static void Main(string[] args)
        {
            Program program = new Program(121, "Pragya", 2000);
            program.Display();
        }
    }
}
