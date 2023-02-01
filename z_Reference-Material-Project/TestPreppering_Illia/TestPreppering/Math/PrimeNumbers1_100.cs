using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPreppering.Math
{
    public class PrimeNumbers1_100
    {
        public static void PrimeNumbers()
        {
            for (int i = 2; i <= 100; i++)
            {
                if (IsPrime(i)) Console.WriteLine(i);
            }

            bool IsPrime(int x)
            {
                for (int i = 2; i < x; i++)
                {
                    if ((double)x % i == 0) return false;

                }
                return true;

            }

        }
    }
}
