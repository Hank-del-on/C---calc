using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insert number 1:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insert operator (+, -, *, /):");
        string op = Console.ReadLine();

        Console.WriteLine("Insert number 2:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;
        bool validOperation = true; // Flag to check if the operation is valid

        // Perform the operation based on the input operator
        if (op == "+")
        {
            result = num1 + num2;
        }
        else if (op == "-")
        {
            result = num1 - num2;
        }
        else if (op == "*")
        {
            result = num1 * num2;
        }
        else if (op == "/")
        {
            if (num2 != 0) // Check for division by zero
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                validOperation = false; // Set the flag to false if operation is invalid
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid operator. Please use +, -, *, or /.");
            validOperation = false; // Set the flag to false if operation is invalid
        }

        // Print the result only if the operation was valid
        if (validOperation)
        {
            Console.WriteLine("The result is: " + result);
        }
    }
}
