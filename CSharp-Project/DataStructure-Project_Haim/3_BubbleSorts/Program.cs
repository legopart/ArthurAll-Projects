using System;

namespace _3_BubbleSorts
{
    public class Program
    {
        static void Main(string[] args)
        {
            int arrSize = 10;
            int[] arr = new int[arrSize];
            Random rnd = new Random();
            for (int i = 0; i < arrSize; i++) { arr[i] = rnd.Next(1, 100); }
            int switchKey;
            bool stopFlag = true;

            Console.WriteLine("Your array is:");
            foreach (int element in arr) { Console.Write(element + "\t"); }
            Console.WriteLine("\n");

            for (int j = 0; j < arrSize - 1; j++)
            {
                for (int k = 0; k < arrSize - 1; k++)
                {
                    if (arr[k] > arr[k + 1])
                    {
                        switchKey = arr[k];
                        arr[k] = arr[k + 1];
                        arr[k + 1] = switchKey;
                        stopFlag = false;
                    }
                }
                if (stopFlag) break;
            }
            Console.WriteLine("Your new bubble sorted array is:");
            foreach (int element in arr) { Console.Write(element + "\t"); }
            Console.WriteLine("\nThanks\n");
        }
    }
}
