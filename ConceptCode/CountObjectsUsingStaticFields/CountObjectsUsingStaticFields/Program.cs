using System;

namespace CountObjectsUsingStaticFields
{
    public class Program
    {
        public int accNo;
        public string name;
        public static int count = 0;
        public Program(int a, string n)
        {
            this.accNo = a;
            this.name = n;
            count++;
        }
        static void Main(string[] args)
        {
            Program program = new Program(1234, "pragya");
            Program program1 = new Program(12346, "DK");
            Console.WriteLine(" No. of Objects" + " " +  Program.count);
        }
    }
}
