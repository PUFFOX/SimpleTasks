using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTask.TasksConsole
{
    internal class Calculator
    {
        internal static void Run()
        {
            while (true)
            {
                Console.WriteLine("================================\n");
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("Enter an expression:");
                

                string input = Console.ReadLine();
                if (input == "0")
                {
                    return;
                }
                else
                {
                    if (input.Contains("+"))
                    {
                        string[] parts = input.Split('+');
                        double num1 = double.Parse(parts[0]);
                        double num2 = double.Parse(parts[1]);
                        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    }
                    if (input.Contains("-"))
                    {
                        string[] parts = input.Split('-');
                        double num1 = double.Parse(parts[0]);
                        double num2 = double.Parse(parts[1]);
                        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    }
                    if (input.Contains('*'))
                    {
                        string[] parts = input.Split('*');
                        double num1 = double.Parse(parts[0]);
                        double num2 = double.Parse(parts[1]);
                        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    }
                    if (input.Contains('/'))
                    {
                        string[] parts = input.Split('/');
                        double num1 = double.Parse(parts[0]);
                        double num2 = double.Parse(parts[1]);
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    }
                }

                Console.WriteLine("Next example:");
                Console.WriteLine("0 - Back to menu");

            }
        }
    }
}
