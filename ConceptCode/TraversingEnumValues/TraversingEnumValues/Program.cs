using System;

namespace TraversingEnumValues
{
    class Program
    {
        //Values of the enum constants can fetched using GetValues method of enum
        public enum Days
        {
            Mon = 1,
            Tue,
            Wed,
            Thur,
            Fri,
            Sat,
            Sun
        }
        static void Main(string[] args)
        {
            foreach (var day in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(day);
            }
            Console.ReadKey();
        }
    }
}
