using System;

namespace Deligates
{
    internal class Program
    {
        // deligate = functional interface
        public delegate int Ex(int i1, int i2); //string str
        public static void Aa(Ex ex)
        {
            Console.WriteLine("aa");
            ex(1, 2);
        }

        public static void Bb(Func<int, int, int> ex)
        {
            Console.WriteLine("bb");
            ex(1, 2);
        }


        delegate double MathExternal(double d1, double d2);

        static void Main(string[] args)
        {
            int Xx(int i1, int i2) { Console.WriteLine("cc" + (i1 + i2)); return 0; }

            Aa(Xx);
            Console.WriteLine();
            Bb(Xx);


            double Add(double x, double y) { return x + y; }
            double Multiple(double x, double y) { return x * y; }

            double Action(double x, double y, MathExternal externalFunction)
                => externalFunction(x, y);

            //double Action(double x, double y, Func<double, double, double> externalFunction)
            //    => externalFunction(x, y);

            Console.WriteLine("Math, Add");
            Console.WriteLine(Action(2, 3, Add)); //5
            Console.WriteLine("Math, Multiple");
            Console.WriteLine(Action(2, 3, Multiple)); //6

        }
    }
}
