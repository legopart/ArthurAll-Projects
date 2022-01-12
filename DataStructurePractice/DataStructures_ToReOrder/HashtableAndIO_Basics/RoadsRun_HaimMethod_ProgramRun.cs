using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.HashtableAndIO_Basics.Classes;

namespace DataStructures.HashtableAndIO_Basics
{
    public struct RoadsRun_HaimMethod_ProgramRun
    {
        public static void ProgramRun()
        {
            Hashtable Roads = new Hashtable();

            for (int i = 0; i < 5; i++)
            {
                Road newRoad = new Road();
                Console.WriteLine("please enter Roard Name");

                newRoad.Name = Console.ReadLine();

                Console.WriteLine("Enter num");
                string s = Console.ReadLine();
                newRoad.Num = int.Parse(s);

                Console.WriteLine("Enter Length");
                s = Console.ReadLine();
                newRoad.Length = int.Parse(s);

                Console.WriteLine("Enter Netivim");
                s = Console.ReadLine();
                newRoad.Netivim = byte.Parse(s);

                Console.WriteLine("Enter Cost money");
                s = Console.ReadLine();
                newRoad.CostMoney = bool.Parse(s);

                Roads.Add(newRoad.Num, newRoad);

            }


            foreach (Object o in Roads.Keys)
            {
                Road currRoard = (Road)Roads[o];
                Console.WriteLine(currRoard.Name);
                Console.WriteLine(currRoard.Netivim);
                Console.WriteLine(currRoard.Num);
            }
        }
    }

}

