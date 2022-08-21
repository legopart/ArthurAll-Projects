using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.ArrayAndRandom
{
    public struct BullPgia_ProgramRun
    {
        public static void ProgramRun()
        {
            int num;
            Random rnd = new Random();
            int random = rnd.Next(1, 9);

            int i = 0;
            while (i < 5)
            {

                Console.WriteLine($"Please enter some number:{(i == 0 ? $" (the wining number is { random })" : "")}");
                num = Convert.ToInt32(Console.ReadLine());

                Console.Write("The Result is: ");
                if (num == random)
                {
                    GreenWrite("Bul");
                    Console.WriteLine("\nThanks for using this app");
                    break;
                }
                else if (num == random - 1 || num == random + 1)
                {
                    RedWrite("Pgia");
                }

                else
                {
                    RedWrite($"You are wrong! {(i < 4 ? " please try again" : "")}");
                }

                Console.WriteLine("\n");
                i++;
            }

            void GreenWrite(string text) { ColorWrite(text, ConsoleColor.Green); }
            void RedWrite(string text) { ColorWrite(text, ConsoleColor.Red); }
            void ColorWrite(string text, ConsoleColor color)
            {
                var defultFC = Console.ForegroundColor;
                Console.ForegroundColor = color;
                Console.Write(text);
                Console.ForegroundColor = defultFC;
            }
        }
    }
}
