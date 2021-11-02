using System;

namespace ObjectTypeParams
{
    class Program
    {
        public void show(params object[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.show("Pragya", "Nagar", 100, "%", "right");
        }
    }
}
