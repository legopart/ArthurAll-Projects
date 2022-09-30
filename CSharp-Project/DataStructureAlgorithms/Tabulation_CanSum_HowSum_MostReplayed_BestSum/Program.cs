using System;

namespace Tabulation_CanSum_HowSum_MostReplayed_BestSum
{
    class Program
    {
        static void Main()
        {

            // Time O(n) search iside the array Space O(n) for the array
            Console.WriteLine("Tabulation: ");

            Console.WriteLine("Can Sum Tabulation: " + CanSumTabulation(6, new int[]{ 1, 2, 3 } ) );


        }
        //applied from the bottom to the top




        public static bool CanSumTabulation(int targetSum, int[] numbers) // Time O(n*m) Space O(n) 
        {
            var size = targetSum + 1;
            var table = new bool[size]; //Array fill with false
            table[0] = true;
            for(int i = 0; i < size; ++i)
            {
                if (table[i])
                {
                    foreach(var num in numbers)
                        if(i + num < size)
                            table[i + num] = true;
                }
            }
            return table[size - 1];
        }



    }
}