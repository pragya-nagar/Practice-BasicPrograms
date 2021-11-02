using System;

namespace SingleLevelInheritance
{
    //With the help of derived class object we can access properties and method of base class also
    public class Employee
    {
        public float salary = 40000;
    }
    class Program : Employee
    {
        public float bonus = 10000;
    }

    class TestInheritance
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Salary and bonus are {0} {1}", program.salary, program.bonus);
            Console.ReadKey();
        }
    }
}
