using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp42
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój PESEL..");
            string userInput = Console.ReadLine();
            long numberInput = 0;


            if (long.TryParse(userInput, out numberInput))
            {
                Console.Clear();
                Console.WriteLine("Twój nr. PESEL to: " + userInput);

                if (userInput.Length == 11)
                {
                    if (userInput[9] % 2 == 0)
                    {
                        Console.WriteLine("Ten pesel należy do kobiety.");
                    }
                    else
                    {
                        Console.WriteLine("Ten pesel należy do mężczyzny");
                    }
                }
                else
                {
                    Console.WriteLine("Twój pesel nie ma 11 znaków");
                }
            }
            else
            {
                Console.WriteLine("Twój PESEL posiada niedozwolne znaki.");
            }
            Console.ReadKey();
        }
    }
}

