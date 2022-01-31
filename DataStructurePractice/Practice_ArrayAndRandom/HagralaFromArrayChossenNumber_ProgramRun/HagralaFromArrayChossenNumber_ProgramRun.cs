using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.ArrayAndRandom
{
    public struct HagralaFromArrayChossenNumber_ProgramRun
    {
        public static void ProgramRun()
        {
            Console.WriteLine("Please enter some number 1-100:");
            int enteredNum = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[100];
            Random rnd = new Random();
            int isNumber = 0;

            int k = 0;
            foreach (int element in arr) { arr[k++] = rnd.Next(1, 100); }

            Console.WriteLine("Your array is:");
            foreach (int element in arr)
            {
                if (element == enteredNum) { isNumber++; }
                Console.Write(element + "\t");
            }

            if (isNumber > 1)
            {
                GreenWrite("\nMulti zhiya!!!");
            }
            else if (isNumber == 1)
            {
                GreenWrite("\nZhiya!!!");

            }

            Console.WriteLine("\nThanks\n");


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
