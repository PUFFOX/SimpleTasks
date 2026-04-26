using SimpleTask.TasksConsole;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SimpleTask
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("================================\n");
                Console.WriteLine("Select a task:");
                Console.WriteLine("1 - Translate text");
                Console.WriteLine("2 - Sum of digits");
                Console.WriteLine("3 - Simple Calculator");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("--------------------------------\n");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exiting...");
                        return;

                    case 1:
                        KeyboardConverter.Run();
                        break;

                    case 2:
                        SumOfDigits.Run();
                        break;

                    case 3:
                        Calculator.Run();
                        break;


                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            
        }
    }
}
