using System;

namespace StarPattern1
{
    //*
    //**
    //***
    //****
    //*****
    //******
    //This will print 7 stars
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 6; i++)
            {
                for (int j = 0; j <=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
