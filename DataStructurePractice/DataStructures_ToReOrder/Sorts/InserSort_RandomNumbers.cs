using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sorts
{
    public struct InserSort_RandomNumbers
    {
        public static void ProgramRun() 
        {
            int arrSize = 10;
            int[] arr = new int[arrSize];
            Random rnd = new Random();

            for (int i = 0; i < arrSize; i++) { arr[i] = rnd.Next(1, 100); }

            int biggest = arr[0];
            int biggestPlace = int.MinValue; //0 //-1
            int[] arrNew = new int[arrSize];

            Console.WriteLine("Your array is:");
            foreach (int element in arr) { Console.Write(element + "\t"); }
            Console.WriteLine("\n");

            for (int j = 0; j < arrSize; j++)
            {
                for (int k = 0; k < arrSize; k++)
                    if (arr[k] > biggest) { biggest = arr[k]; biggestPlace = k; }
                arrNew[j] = arr[biggestPlace]; // = biggest;
                arr[biggestPlace] = int.MinValue; //0 //-1
                biggest = int.MinValue; //0 //-1
            }

            Console.WriteLine("Your new sorted array is:");
            foreach (int element in arrNew) { Console.Write(element + "\t"); }
            Console.WriteLine("\nThanks\n");
        }

    }
}
