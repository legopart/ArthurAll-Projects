using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.ArrayAndRandom
{
    public struct ArraySizingWithRandomNumbers_ProgramRun
    {
        public static void ProgramRun()
        {
            Console.WriteLine("Please enter some number:");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[x];
            Random rnd = new Random();

            for (int i = 0; i < x; i++) { arr[i] = rnd.Next(1, x); }    //? לא כתוב על לאן להגריל
                                                                        // foreach set
                                                                        // int k = 0;
                                                                        // foreach (int element in arr) {arr[k++] = rnd.Next(1, x);}
            Console.WriteLine("Your array is:");
            foreach (int element in arr) { Console.Write(element + "\t"); }
            Console.WriteLine("\nThanks\n");
        }

    }
}
