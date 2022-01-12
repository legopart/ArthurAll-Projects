using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataStructures.RoadConnectionFromFiles_1File
{
    public class RoadsManager
    {
        public const string FILE_NAME_ROADS = @"c:\1\Roads.txt";
        public Hashtable RoadsTable = new Hashtable();
        public Regex REGULAR_EXEPTION = new Regex(@"^[0-9]+[-][0-9]+[-][0-9]+$");

        public void ConectRoad(int mainRoad, int roardRight, int roardLeft, int roardForward)
        {
            if (RoadsTable.Contains(mainRoad))
            {
                Road mainRoadSet = (Road)RoadsTable[mainRoad];
                if (RoadsTable.Contains(roardRight))
                    mainRoadSet.Right = (Road)RoadsTable[roardRight];
                if (RoadsTable.Contains(roardLeft))
                    mainRoadSet.Left = (Road)RoadsTable[roardLeft];
                if (RoadsTable.Contains(roardForward))
                    mainRoadSet.Forward = (Road)RoadsTable[roardForward];
            }
        }




        public void LoadFromFileRoads()
        {
            string[] fileContent = File.ReadAllLines(RoadsManager.FILE_NAME_ROADS); //קורא לפי \r\n
            for (int i = 0; i < fileContent.Length; i++)
            {
                string roadData = fileContent[i];
                string[] oneRecord = roadData.Split(',');
                Road newRoard = new Road();
                newRoard.Name = oneRecord[0];
                newRoard.Num = Int32.Parse(oneRecord[1]);
                newRoard.Length = Int32.Parse(oneRecord[2]);
                newRoard.NetivimKamut = Byte.Parse(oneRecord[3]);
                newRoard.CostMoney = bool.Parse(oneRecord[4]);
                
                RoadsTable.Add(newRoard.Num, newRoard);
            }

            for (int i = 0; i < fileContent.Length; i++)
            {
                string roadData = fileContent[i];
                string[] oneRecord = roadData.Split(',');
                int main = Int32.Parse(oneRecord[1]);

                if ( REGULAR_EXEPTION.Match(oneRecord[5]).Success )  
                {
                    string[] oneRecord2 = (oneRecord[5]).Split('-');
                    int right = Int32.Parse(oneRecord2[0]);
                    int left = Int32.Parse(oneRecord2[1]);
                    int forward = Int32.Parse(oneRecord2[2]);
                    ConectRoad(main, right, left, forward);
                }
            }



        }

        public void PrintRoads()
        {
            Console.WriteLine("The Roads Hash Table List:");
            foreach (Object o in RoadsTable.Keys)
            {
                Road currRoad = (Road)RoadsTable[o];
                Console.WriteLine($"Road {currRoad?.Num} Name: {currRoad?.Name}");
            }
            Console.WriteLine();

            Console.WriteLine("The Roads Connection Hash Table List:");
            foreach (Object o2 in RoadsTable.Keys)
            {
                Road currRoad = (Road)RoadsTable[o2];
                int? main = currRoad?.Num;
                int? forward = currRoad.Forward?.Num == null ? 0 : currRoad.Forward.Num;
                int? right = currRoad.Right?.Num == null ? 0 : currRoad.Right.Num;
                int? left = currRoad.Left?.Num == null ? 0 : currRoad.Left.Num;
                if (right != 0 || left != 0 || forward != 0)
                    Console.WriteLine($"Road {main}\t\tForward: {forward}\t\tLeft: {left} \t\tRight: {right}");
            }
            Console.WriteLine();

            Console.WriteLine();

        }
    
    

    }
}