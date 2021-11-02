
using System;

namespace MultiplicationWithoutUsingOperator
{
    //multiplication without using * operator
    class Program
    {
        static void Main(string[] args)
        {
           var result= MulWithOutStarOperator(2,3);
           Console.WriteLine(result);
        }

        
        public  static int MulWithOutStarOperator(int x, int y)
        {
             int value=0;
            for (int z = 1; z <= y; z++)
            {
               
                value = value + x;
            }

            return value;
        }
    }
}
