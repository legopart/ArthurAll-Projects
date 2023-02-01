using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPreppering.Math
{
    public class PrimeNumbers1_100_Shortly_wCounter
    {

        public static void PrimeNumbers_wCounter()
        {
            int ctr = 3;
            var primeLice = new List<int>();

            int lastPrime = 2;



            for (int i = 2; i <= 100; i++)
            {
                if (IsPrime_wCounter(i)) Console.WriteLine(i);
            }


            Console.WriteLine($"Counter ={ctr}");



            bool IsPrime_wCounter(int x)
            {
                if (x == 2) { return true; }
                if (x % 2 == 0) { return false; }
                if (primeLice.Any(prime => x % prime == 0)) { return false; }

                for (int i = lastPrime; i < x; i += 2)
                {
                    ctr++;
                    if ((double)x % i == 0) return false;

                }
                primeLice.Add(x);
                lastPrime = x;

                return true;

            }

            
        }
    }
}
