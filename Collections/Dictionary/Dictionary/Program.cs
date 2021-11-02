using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new Dictionary<string, string>();
            names.Add("1", "Pragya");
            names.Add("2", "Anamika");
            //we will get an error if we will try to add duplicate key in dictionary
            //names.Add("2", "Anita");
            names.Add("3", "Anita");

            foreach (var item in names)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

        }
    }
}
