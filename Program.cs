using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello, welcome to the calculator program!");
        Console.WriteLine("Please enter your first number : ");

        double num1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter second number : ");

        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Select type of operation : ");
        Console.WriteLine("Enter a for addition, s for subtraction, m for multiplication, anyother key for division");

        string answer = Console.ReadLine();
        string operation = answer.ToLower();
        string display = answer.ToUpper();

        double result;
        string operationName;
        


        if (operation == "a")
        {
            result = num1 + num2;
            operationName = "Addition";
        }
        else if (operation == "s")
        {
            result = num1 - num2;
            operationName = "Subtraction";
        }
        else if (operation == "m")
        {
            result = num1 * num2;
            operationName = "Multiplication";
        }
        else 
        {
            if(num2 == 0)
            {
                Console.WriteLine("Division by Zero is not allowed !");
                return;
            }
            result = num1 / num2;
            operationName = "Division";
        }

        Console.WriteLine($"\nYou chose : \'{display}' for '{operationName}'");
        //Console.WriteLine("The result is " + result);
        Console.WriteLine($"\nThe Result is : \'{result}'");


        Console.ReadKey();
    }
}