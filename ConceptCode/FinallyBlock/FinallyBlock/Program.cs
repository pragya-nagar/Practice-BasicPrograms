using System;

namespace FinallyBlock
{
    class Program
    {
        //does finally block will execute if exception is not handled?

       // Finally block always execute whether exception handle or not. if any exception occurred before try block then finally block will not execute(It depends on type of exception).
        static void Main(string[] args)
        {
            try
            {
                int a = 2;
                int b = 0;
                int x = a / b;
            }
            //if exception is not handled finally block does not execute
            catch(NullReferenceException  e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Finally block is executed");
            }
            Console.WriteLine("Rest of the Code!");
        }
    }
}
