using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPreppering.Forms
{
    public class TriangleReversed
    {


        public static void TriangleReversedEmpty(int a)
        {
            string str = "";
            //string strSimetry = "";
            //int centerTop = a;
            //int centerR = centerTop;
            //int centerL = centerTop;

            //int fourth = a / 4 + 1;

            int R = 1;
            int L = a * 2 - 1;

            int i = 1;
            while (i <= a)
            {
                string lineStr = "";
                int j = 1;
                while (j <= a * 2 - 1)
                {
                    string bit = " ";
                    if (j == L) bit = "#";
                    if (j == R) bit = "#";
                    if (i == 1) bit = "#";

                    lineStr += bit;
                    j++;
                }
                lineStr += "\n";
                str += lineStr;

                R++;
                L--;
                i++;
            }

            Console.WriteLine(str);

        }

    }
}
