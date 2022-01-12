using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.RoadConnectionFromFiles_MyVersion2Files
{
    
    public class RoadsManager
    {
        public const string FILE_NAME_ROADS = @"c:\1\Roads.txt";
        public const string FILE_NAME_ROADS_CONNECTION = @"c:\1\RoadsConnection.txt";

        public Hashtable RoadsTable = new Hashtable();
        public Hashtable RoadsConnectionTable = new Hashtable();


        public void LoadFromFilRodesConnection()
        {
            string[] fileContent = File.ReadAllLines(FILE_NAME_ROADS_CONNECTION); //Read by line \r\n
            for (int i = 0; i < fileContent.Length; i++)
            {
                string roadData = fileContent[i];
                string[] oneRecord = roadData.Split('-');
                int mainRoad = Int32.Parse(oneRecord[0]);
                int roardRight = Int32.Parse(oneRecord[1]);
                int roardLeft = Int32.Parse(oneRecord[2]);
                int roardForward = Int32.Parse(oneRecord[3]);
                ConectRoad(mainRoad, roardRight, roardLeft, roardForward);
            }
        }

        public void ConectRoad(int mainRoad, int roardRight, int roardLeft, int roardForward)
        {
            // find in Hash table by key // find in Hash right, left, forward // set main road 
            RoadConnection newRoadConnection = new RoadConnection();
            newRoadConnection.MainRoad = mainRoad;
            newRoadConnection.RoardRight = roardRight;
            newRoadConnection.RoardLeft = roardLeft;
            newRoadConnection.RoardForward = roardForward;

            RoadsConnectionTable.Add(newRoadConnection.MainRoad, newRoadConnection);
        }

        public void RoadsConnectPrint()
        {
            Console.WriteLine("The Roads Connection Hash Table List:");
            foreach (Object o in RoadsConnectionTable.Keys)
            {
                RoadConnection currRoadsConnection = (RoadConnection) RoadsConnectionTable[o];
                Console.WriteLine($"Road {currRoadsConnection?.MainRoad}\t\tForward: {currRoadsConnection?.RoardForward}\t\tLeft: {currRoadsConnection?.RoardLeft}\t\tRight: {currRoadsConnection?.RoardRight}");
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
            }

            public void PrintRoads()
            {
                Console.WriteLine("The Roads Hash Table List:");
                foreach (Object o in RoadsTable.Keys)
                {
                    // Console.WriteLine(o);
                    Road currRoad = (Road)RoadsTable[o];
                    //if (currRoad == null) continue;   //לא צריך, הגודל מוגדר במדוייק
                    Console.WriteLine($"Road {currRoad?.Num} Name: {currRoad?.Name}");
                }
            }
    

    }
}