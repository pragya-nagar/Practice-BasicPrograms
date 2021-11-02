using System;

namespace Properties
{
    class Program
    {
        //having logic while setting value, agar hum sirf get use krege to vo read only property bn jaayegi
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value + " " +  "Pragya";
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Name = "Anita";
            Console.WriteLine("Employee Name" + program.Name + " " );
        }
    }
}
