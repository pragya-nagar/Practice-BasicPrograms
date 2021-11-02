using System;
using System.Collections.Generic;

namespace SortedList
{
    class Program
    {
        //Sorted list is like sorted dictionary
        static void Main(string[] args)
        {
            SortedList<string, string> names = new SortedList<string, string>();
            names.Add("2", "Anamika");
            names.Add("1", "Pragya");

            foreach(KeyValuePair<string,string> item in names)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
