using System;
using System.Threading;

namespace ThreadSynchronization
{
    //with synchronization
    class Program
    {
        static void Main(string[] args)
        {
            Different different = new Different();
            Thread t1 = new Thread(different.PrintTable);
            Thread t2 = new Thread(different.PrintTable);
            t1.Start();
            t2.Start();
        }
    }

    class Different
    {
        public void PrintTable()
        {

            lock (this)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Thread.Sleep(100);
                    Console.WriteLine(i);
                }
            }
        }
    }
}
