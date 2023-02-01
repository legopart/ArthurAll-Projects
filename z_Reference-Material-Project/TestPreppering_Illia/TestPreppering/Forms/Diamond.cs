using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPreppering.Forms
{
    public class Diamond
    {
        public static void DiamondEmpty(int a)
        {
            string str = "";
            //string strSimetry = "";
            int centerTop = a;
            int centerR = centerTop;
            int centerL = centerTop;

            //int fourth = a / 4 + 1;

            int R = 1;
            int L = a * 2 - 1;

            int i = 1;
            while (i <= a * 2 - 1)
            {
                string lineStr = "";
                int j = 1;
                while (j <= a * 2 - 1)
                {
                    string bit = " ";
                    if (i <= a)
                    {
                        if (j == centerL) bit = "#";
                        if (j == centerR) bit = "#";
                    }
                    if (i >= a)
                    {
                        if (j == L) bit = "#";
                        if (j == R) bit = "#";
                    }

                    lineStr += bit;
                    j++;
                }
                lineStr += "\n";
                str += lineStr;

                if (i <= a)
                {
                    centerR++;
                    centerL--;
                }
                if (i >= a)
                {
                    R++;
                    L--;
                }

                i++;
            }

            Console.WriteLine(str);
        }




    }
}
