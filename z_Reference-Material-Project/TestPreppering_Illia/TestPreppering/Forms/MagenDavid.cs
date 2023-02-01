using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPreppering.Forms
{
    public class MagenDavid
    {

        public static void MagenDavidEmpty(int a)
        {
            string str = "";
            //string strSimetry = "";
            int centerTop = a;
            int centerR = centerTop;
            int centerL = centerTop;

            int fourthHigh = a / 4 + 1;

            int R = 1;
            int L = a * 2 - 1;

            int i = 1;
            while (i <= a + fourthHigh)
            {
                string lineStr = "";
                int j = 1;
                while (j <= a * 2 - 1)
                {
                    string bit = " ";
                    if (i < a + 1) // /\ Triangle up to a
                    {
                        if (j == centerL) bit = "#";
                        if (j == centerR) bit = "#";
                        if (i == a) bit = "#";
                    }
                    if (i > fourthHigh) // \/ Reversed triangle from the fourthHigh (1/4) [a/4]
                    {
                        if (j == L) bit = "#";
                        if (j == R) bit = "#";
                        if (i == fourthHigh + 1) bit = "#";
                    }

                    lineStr += bit;
                    j++;
                }
                lineStr += "\n";
                str += lineStr;


                if (i < centerTop /*&& centerR!=1 && centerL!=a*2-1*/) // /\ extend top triangle center points up to corner dots
                {
                    centerR++;
                    centerL--;
                }

                if (i > fourthHigh /*&& R!=center && L!=center*/) // \/shrink reversed triangle corner dots up to the center
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
