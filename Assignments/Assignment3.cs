using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Assignment3
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter the first number:");
                string input1 = Console.ReadLine();

                Console.WriteLine("Enter the second number:");
                string input2 = Console.ReadLine();

                Console.WriteLine("Enter the opertaor:");
                string op = Console.ReadLine();

                if (double.TryParse(input1, out double num1) && (double.TryParse(input2, out double num2)))
                {
                    double result = 0;
                    bool res = true;
                    switch (op)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            if (num2 != 0)
                            {
                                result = num1 / num2;
                            }
                            else
                            {
                                Console.WriteLine("Cannot divide by zero ");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            break;

                    }
                    if (res)
                    {
                        Console.WriteLine($"Result:{result}");
                    }
                    else
                    {
                        Console.WriteLine("please enter valid numbers");
                    }
                }
                Console.WriteLine("Calculator is closed");
            }
        }
    }
}
