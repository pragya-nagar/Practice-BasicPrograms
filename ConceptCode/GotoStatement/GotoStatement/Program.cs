﻿using System;

namespace GotoStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            ineligible: Console.WriteLine("You are not eligible to vote");

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age<18)
            {
                goto ineligible;
            }
            else
            {
                Console.WriteLine("You are eligible to vote");
            }
        }
    }
}
