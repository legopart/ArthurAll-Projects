using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPreppering
{
    internal class _3
    {

        void MagenDavidEmpty(int a)
        {
            string str = "";

            int centerTop = a;
            int centerR = centerTop;
            int centerL = centerTop;

            int fourth = a / 4 + 1;

            int R = 1;
            int L = a * 2 - 1;

            int i = 1;
            while (i <= a + fourth)
            {
                int j = 1;
                while (j <= a * 2 - 1)
                {
                    if (
                        (i < centerTop + 1
                            && (j == centerR || j == centerL || i == a))
                        || (i > fourth
                            && (j == R || j == L || i == fourth + 1))
                        )
                        str += "#";
                    else str += " ";
                    j++;
                }
                str += "\n";
                if (i < centerTop)
                {
                    centerR++;
                    centerL--;
                }
                if (i > fourth)
                {
                    R++;
                    L--;
                }
                i++;
            }

            Console.WriteLine(str);

        }


        void TriangleEmptyReversed2(int a)
        {
            string str = "";
            int R = 1;
            int L = a * 2 - 1;

            int i = 1;
            while (i <= a)
            {
                int j = 1;
                while (j <= a * 2 - 1)
                {
                    if (j == R || j == L || i == 1)
                        str += "#";
                    else str += " ";
                    j++;
                }
                str += "\n";
                R++;
                L--;
                i++;
            }

            Console.WriteLine(str);

        }

        void TriangleEmptyReversed1(int a)
        {
            string str = "";
            int centerTop = a;
            int centerR = centerTop;
            int centerL = centerTop;

            int i = 1;
            while (i <= a)
            {
                string strInternal = "";
                int j = 1;
                while (j <= a * 2 - 1)
                {
                    if (j == centerL || j == centerR || i == a)
                        strInternal += "#";
                    else strInternal += " ";
                    j++;
                }
                strInternal += "\n";

                str = strInternal + str; // סימטריה

                centerR++;
                centerL--;
                i++;
            }

            Console.WriteLine(str);

        }

        void TriangleEmpty(int a)
        {
            string str = "";
            int centerTop = a;
            int centerR = centerTop;
            int centerL = centerTop;

            int i = 1;
            while (i <= a)
            {
                int j = 1;
                while (j <= a * 2 - 1)
                {
                    if (j == centerL || j == centerR || i == a)
                        str += "#";
                    else str += " ";
                    j++;
                }
                str += "\n";
                centerR++;
                centerL--;
                i++;
            }

            Console.WriteLine(str);

        }
    }
}
