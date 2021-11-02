using System;
using System.Collections.Generic;

namespace ListUsingCollectionInitializer
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a list using collection initializer
            var names = new List<string>() { "Pragya","Aayu","Puneet"};

            foreach(var item in names)
            {
                Console.WriteLine(item);
            }

        }
    }
}
