﻿using System;

namespace StarPattern2
{
    //******
    //*****
    //****
    //***
    //**
    //*
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 6; i >= 1; i--)
            {
                for (int j = 1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
