using System;

namespace Tabulation_CanConstruct_CountConstruct_AllConstruct
{
    class Program
    {
        static void Main()
        {

            // Time O(n) search iside the array Space O(n) for the array
            Console.WriteLine("Tabulation: ");

            Console.WriteLine("Fib Tabulation: " + GridTraveler(6, 6));


        }
        //applied from the bottom to the top




        public static int GridTraveler(int m, int n) // Time O(n*m) Space O(n*m) 
        {
            var size1 = n + 2;  //rows
            var size2 = m + 2;  //cols
            var table = new int[size1, size2]; //Array fill with 0s
            table[0, 0] = 0;
            table[1, 1] = 1;
            for (int i = 0; i < size1 - 1; ++i)
            {
                for (int j = 0; j < size2 - 1; ++j)
                {
                    int current = table[i, j];
                    table[i, j + 1] += current;
                    table[i + 1, j] += current;
                }
            }
            return table[m, n];
        }



    }
}