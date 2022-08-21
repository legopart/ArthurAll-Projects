using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperWinForms
{
    internal class DeligateFuncs
    {

        public delegate double CalcMathFunc(double i1, double i2); //string str
        public static double CalcRequest(CalcMathFunc callback, double x, double y)
        {
            return callback(x, y);
        }

        public static void CalcRequest2(Func<int, int, int> callback)
        {
            callback(5, 6);
        }


        public static double Add(double x, double y) { return x + y; }
        public static double Multiple(double x, double y) { return x * y; }

        public CalcMathFunc a = Add;

    }
}
