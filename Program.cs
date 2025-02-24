static void Main(string[] args)
    {

        Console.WriteLine("insert number1");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("insert operator");
        string op = Console.ReadLine();

        Console.WriteLine("insert number2");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        if (op == "+")
            result = num1 + num2;
        else if (op == "-")
            result = num1 - num2;
        else if (op == "*")
            result = num1 * num2;
        else if (op == "/")
            result = num1 / num2;
        Console.WriteLine(result);
    }
    