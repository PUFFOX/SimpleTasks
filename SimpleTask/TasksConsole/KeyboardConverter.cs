using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTask.TasksConsole
{
    public class KeyboardConverter
    {

        public static void Run()
        {
            Console.WriteLine("================================\n");
            Console.WriteLine("Keyboard Converter - English to Ukrainian");
            const string en = "qwertyuiop[]asdfghjkl;'zxcvbnm,./?";
            const string ua = "йцукенгшщзхїфівапролджєячсмитьбю.,";
            do
            {
                Console.WriteLine("Enter text to translate:");
                Console.WriteLine("0 - Back to menu");

                string input = Console.ReadLine().ToLower();
                char[] inputChars = input.ToCharArray();

                if(input == "0")
                {
                    return;
                }

                for (int i = 0; i < inputChars.Length; i++)
                {
                    int index = en.IndexOf(inputChars[i]);
                    if (index >= 0)
                    {
                        inputChars[i] = ua[index];
                    }
                }

                Console.WriteLine(new string(inputChars));
                Console.WriteLine("================================\n");


            }
            while (true);
            

        }
    }
}

