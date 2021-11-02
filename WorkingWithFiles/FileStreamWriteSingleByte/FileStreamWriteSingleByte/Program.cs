using System;
using System.IO;

namespace FileStreamWriteSingleByte
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("d:\\b.txt", FileMode.OpenOrCreate);
            f.WriteByte(65);//writing byte 
            f.Close();

        }
    }
}
