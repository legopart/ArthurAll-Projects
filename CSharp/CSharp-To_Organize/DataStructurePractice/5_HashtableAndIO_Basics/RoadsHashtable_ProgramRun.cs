using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _5_HashtableAndIO_Basics.Classes;

namespace _5_HashtableAndIO_Basics
{
    public struct RoadsHashtable_ProgramRun
    {
        public static void ProgramRun()
        {
            Road a = new Road()
            {
                Name = "TelAviv",
                Num = 5,
                Length = 100
            };
            Road b = new Road()
            {
                Name = "TelAviv",
                Num = 7,
                Length = 200
            };

            Road c = new Road()
            {
                Name = "TelAviv",
                Num = 4,
                Length = 300
            };

            Hashtable ht = new Hashtable();

            void addRoad(Hashtable hashtable, Road road)
            {
                hashtable.Add(road.Num, road);
            }

            addRoad(ht, a);
            addRoad(ht, b);
            addRoad(ht, c);

            Road r = (Road)ht[4];
            if (r != null)
                Console.WriteLine($"Road name: {r.Name} \t Road number: {r.Num} \t Road length: {r.Length}");
        }
    }

}

