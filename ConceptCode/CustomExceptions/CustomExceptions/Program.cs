using System;

namespace CustomExceptions
{
    //to create custom exception we need to inherit Exception class
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Validate(12);

            }
            catch(InvalidAgeException e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Rest Of the code");
        }

        static void Validate(int age)
        {
            if(age<18)
            {
                throw new InvalidAgeException("Sorry, Age must be greater than 18");
            }
        }
    }

    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {

        }
    }

}
