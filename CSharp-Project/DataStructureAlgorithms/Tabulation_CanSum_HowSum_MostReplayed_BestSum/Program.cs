using System;

namespace Tabulation_CanSum_HowSum_MostReplayed_BestSum
{
    class Program
    {
        static void Main()
        {

            // Time O(n) search iside the array Space O(n) for the array
            Console.WriteLine("Tabulation: ");

            Console.WriteLine("Can Sum Tabulation: " + CanSumTabulation(6, new int[] { 1, 2, 3 }));
            Console.WriteLine("How Sum Tabulation: " + String.Join(", " ,HowSumTabulation(6, new int[] { 1, 2, 3 })));


        }
        //applied from the bottom to the top




        public static List<int> HowSumTabulation(int targetSum, int[] numbers) // Time O(n*m * m) => O(n*m^2) {worst case, m for the internal array size} Space O(m^2)  m for additional array internal size
        {
            var size = targetSum + 1;
            var table = new List<int>[size]; //Array fill with false
            table[0] = new();
            for (int i = 0; i < size; ++i)
            {
                if (table[i] != null)
                {
                    foreach (var num in numbers) { 
                        if (i + num < size)
                        {
                            table[i + num] = new(table[i]) { num };
                            //table[i + num].Add(num);
                        }  
                        //shorter way for first result/ can work without
                        if (table[size - 1] != null) return table[size - 1];  //faster exit
                    }
                }
            }
            return table[size - 1];
        }




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