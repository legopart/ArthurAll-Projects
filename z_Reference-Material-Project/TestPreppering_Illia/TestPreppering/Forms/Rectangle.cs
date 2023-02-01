using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPreppering.Forms
{
    public class Rectangle
    {


        public static void RectangleEmpty(int a, int b)
        {
            string str = "";

            int i = 1;
            while (i <= a)
            {
                string lineStr = "";
                int j = 1;
                while (j <= b)
                {
                    string bit = " ";
                    if (j == 1) bit = "#";  // |
                    if (j == b) bit = "#";  //   |

                    if (i == 1) bit = "#";  // -
                    if (i == a) bit = "#";  // _

                    lineStr += bit;
                    j++;
                }
                lineStr += "\n";
                str += lineStr;
                i++;
            }

            Console.WriteLine(str);


        }


    }
}
