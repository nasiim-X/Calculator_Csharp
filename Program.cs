﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int num1;
        int num2;
        int result;

        string answer;
        
        Console.WriteLine("Hello, welcome to the calculator program!");
        Console.WriteLine("Please enter your first number : ");

        num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter second number : ");

        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Select type of operation : ");
        Console.WriteLine("Enter a for addition, s for subtraction, m for multiplication, anyother key for division");

        answer = Console.ReadLine();

        if (answer == "a")
        {
            result = num1 + num2;
        }
        else if (answer == "s")
        {
            result = num1 - num2;
        }
        else if (answer == "m")
        {
            result = num1 * num2;
        }
        else 
        {
            result = num1 / num2;
        }

        Console.WriteLine("The result is " + result);




        Console.ReadKey();
    }
}