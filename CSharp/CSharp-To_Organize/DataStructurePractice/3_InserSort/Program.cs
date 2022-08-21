using System;

namespace _3_InserSort
{
    public class Program
    {
        static void Main(string[] args)
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
