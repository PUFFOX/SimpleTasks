using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTask.TasksConsole
{
    internal class SumOfDigits
    {
        internal static void Run()
        {
            Console.WriteLine("================================\n");
            Console.WriteLine("Sum of Digits");
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine() ?? "";

            int sum = 0;

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    sum += int.Parse(c.ToString());
                }
            }
            Console.WriteLine($"The sum of the digits in {input} is: {sum}");
        }
    }
}
