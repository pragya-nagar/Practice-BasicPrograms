using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            var grade = 'B';
            switch(grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Good");
                    break;
                case 'C':
                    Console.WriteLine("Need more Hard-work");
                    break;
                default:
                    Console.WriteLine("No match found");
                    break;
            }
            Console.WriteLine("You got grade {0}", grade);
            Console.ReadKey();
        }
    }
}
