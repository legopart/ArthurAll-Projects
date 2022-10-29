using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C_Sharp._2_Delegate;

namespace C_Sharp
{
#pragma warning disable  // Variable is assigned but its value is never used

    //Delegate  - הגדרה של חתימת פונקציה, ניתן לצור משתנים שיצביעו על פונקציה רלוונטית, רק לפי התאמת החתימה, ולהעביר כפרמטרים בכל פעם פונקציה שונה ובתנאי שתתאים לחתימה

    public class _2_Delegate
    {
        
            public delegate int CalcFunc(int a, int b);

            public void Run()
            {
                CalcFunc f;
                f = Calc1;
                int r = f(4, 4);

                f = Calc2;
                r = f(4, 4);
                r = Calc2(4, 4);

                CalcTax(200, Calc1);
                CalcTax(200, Calc2);
                CalcTax(200, Calc3);

            }

            public int CalcTax(int price, CalcFunc func)
            {
                return (func(price, 20));
            }

            public int Calc1(int a, int b)
            {
                return a * b;
            }
            public int Calc2(int a, int b)
            {
                return a + b;
            }
            public int Calc3(int a, int b)
            {
                return a - b;
            }

        }
    }

