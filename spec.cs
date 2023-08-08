using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");

            while (true)
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter operator (+, -, *, /): ");
                char op = Console.ReadKey().KeyChar;
                Console.WriteLine();

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                            Console.WriteLine("Cannot divide by zero.");
                        break;
                    default:
                        Console.WriteLine("Invalid operator.");
                        break;
                }

                Console.WriteLine("Result: " + result);
                Console.WriteLine("Do you want to perform another calculation? (y/n): ");
                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (choice != 'y' && choice != 'Y')
                    break;
            }
        }
    }
}
