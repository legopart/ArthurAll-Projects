using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPreppering.Math
{
    public static class Duplicate1_100
    {
        public static void DuplicateTable()
        {
            string str = "";
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if ((i * j + "").Length == 1) { str += " "; }
                    str += i * j;
                    if (j != 10) { str += "|"; }
                }
                if (i != 1 || i != 10) str += "\n-------------------------------\n";
            }
            Console.WriteLine(str);
        }

    }
}
