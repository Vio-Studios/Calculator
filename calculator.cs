using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter operation (+, -, *, /): ");
        string operation = Console.ReadLine();

        int result = 0;

        if (operation == "+")
        {
            result = num1 + num2;
        }
        else if (operation == "-")
        {
            result = num1 - num2;
        }
        else if (operation == "*")
        {
            result = num1 * num2;
        }
        else if (operation == "/")
        {
            if (num2 != 0)
                result = num1 / num2;
            else
            {
                Console.WriteLine("Cannot divide by zero!");
                return;
            }
        }
        else
        {
            Console.WriteLine("Invalid operation.");
            return;
        }

        Console.WriteLine("The result is: " + result);
    }
}
