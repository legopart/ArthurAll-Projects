using System;

namespace Ordering
{
    public class Program
    {
        static void Main(string[] args)
        {
            //printNumFor(100);
            //printNumLoop(100);
            // Console.WriteLine( Multi(3, 4) );
            // Console.WriteLine( Multi_HaimVersion(3, 4) );
             Console.WriteLine(Pow_HaimVersion(3, 4));
            //
            //Power(4);
        }
        static void Power(int a, int result = 1)
        {
            result *= a;
            if (a > 2) Power(--a, result);
            else Console.WriteLine(result);
        }
        static void Pow(int a, int b, int result = 1)
        {
            result *= a;
            if (b > 1) Pow(a, --b, result);
            else Console.WriteLine(result);
        }
        static int Pow_HaimVersion(int a, int b)
        {
            int result = 1;
            if (b > 0) result = a * Pow_HaimVersion(a, b - 1);
            return result;
        }

        static int Multi(int a, int b, int result = 0)
        {
            result += a;
            if (b > 1) return Multi(a, b-1, result);
            return result;
        }
        static int Multi_HaimVersion(int a, int b)
        {
            int result = 0;
            if (b > 0)  result = a + Multi_HaimVersion(a, b-1);
            return result;
        }

        static void printNumFor(int size)
        {
            for (int i = 1; i <= size; i++) Console.Write($"{i}{(i != size ? ", " : "")}"); 
        }
        static void printNumLoop(int sizeRequired, int size=0)
        {
            Console.Write($"{size}{(size != sizeRequired ? ", " : "")}");
            if (sizeRequired > size) printNumLoop(sizeRequired, size+1);
        }

    }



}
