﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number - ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number - ");
        double num2 = double.Parse(Console.ReadLine());

        double sum = num1 + num2;
        Console.WriteLine("the sum of these two numbers is - " + sum);
            }
}