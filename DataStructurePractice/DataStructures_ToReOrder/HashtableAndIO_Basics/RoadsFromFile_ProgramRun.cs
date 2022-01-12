using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.HashtableAndIO_Basics.Classes;

namespace DataStructures.HashtableAndIO_Basics
{
    internal class RoadsFromFile_ProgramRun
    {
        public static void ProgramRun()
        {
            string s1 = "11,Line In File";
            File.WriteAllText(@"C:\1\file.txt", s1);

            File.AppendAllText(@"C:\1\file.txt", "\r\n12, Another Line");

            const string FILE_NAME = @"C:\1\Roads.txt";
            string[] fileContent = File.ReadAllLines(FILE_NAME);
            //קורא לפי \r\n

            Hashtable Roads = new Hashtable();

            for (int i = 0; i < fileContent.Length; i++)
            {
                string ContentData = fileContent[i];
                string[] data = ContentData.Split(',');
                Road road = new Road();
                road.Name = data[0];
                road.Num = Int32.Parse(data[1]);
                road.Length = Int32.Parse(data[2]);
                road.Netivim = byte.Parse(data[3]);
                road.CostMoney = bool.Parse(data[4]);
                Roads.Add(road.Num, road);
            }

            foreach (Object o in Roads.Keys)
            {
                Road currRoad = (Road)Roads[o];
                Console.WriteLine($"Road{currRoad.Num} Name: {currRoad.Name}");
            }
        }
    }
}
