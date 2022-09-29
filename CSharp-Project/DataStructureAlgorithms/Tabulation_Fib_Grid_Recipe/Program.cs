using System;

namespace Tabulation_Fib_Grid_Recipe
{
    class Program
    {
        static void Main()
        {

            // Time O(n) search iside the array Space O(n) for the array
            Console.WriteLine("Tabulation: ");

            Console.WriteLine("Fib Tabulation: " + FibTabulation(6));

            ;
        }




        //Fib Tabulation:

        public static int FibTabulation2(int n) // Time O(n) Space O(n) 
        {
            var size = n + 1;
            var table = new int[size];
           // for (int i = 0; i < size; ++i) table[i] = 0; //Array fill with 0s
            table[0] = 0;
            table[1] = 1;
            for (int i = 2; i < size; ++i)
                table[i] += table[i - 1] + table[i - 2];
            return table[n];
        }

        public static int FibTabulation(int n) // Time O(n) Space O(n) 
        {
            var size = n + 2;
            var table = new int[size] ;
            //for (int i = 0; i < size; ++i) table[i] = 0; //Array fill with 0s
            table[0] = 0;
            table[1] = 1;
            for (int i = 0; i < n; ++i)
            {
                table[i + 1] += table[i];
                table[i + 2] += table[i];
            }
            return table[n];
        }




    }
}