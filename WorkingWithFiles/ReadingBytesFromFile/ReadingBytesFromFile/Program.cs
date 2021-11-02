using System;
using System.IO;

namespace ReadingBytesFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("d:\\b.txt", FileMode.OpenOrCreate);
            int i = 0;
            while((i=f.ReadByte())!=-1)
            {
                Console.WriteLine((char)i);
            }
            f.Close();
        }
    }
}
