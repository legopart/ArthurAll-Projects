using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.ArrayAndRandom
{
    public struct MatritzatHamazalNuDoubleElementsInsideArray_ProgramRun
    {
        public static void ProgramRun()
        {
            int arrSize = 10;
            int[] arr = new int[arrSize];
            Random rnd = new Random();


            int i = 0;
            while (i < arrSize)
            {
                int random = rnd.Next(1, 100);
                if (!arrContains(arr, random))
                {
                    arr[i] = random;
                    i++;
                }

            }

            bool arrContains(int[] array, int value)
            {
                foreach (int element in array) { if (element == value) { return true; } }
                return false;
            }

            Console.WriteLine("Your unique array is:");
            foreach (int element in arr) { Console.Write(element + "\t"); }
            Console.WriteLine("\nThanks\n");
        }

    }
}
