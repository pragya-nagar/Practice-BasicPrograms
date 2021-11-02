using System;

namespace ContinueStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            ///continue statements skips the  code at some specified condition like in this example it will not print 5
            for(int i =1;i<=10;i++)
            {
                if(i==5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}
