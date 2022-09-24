using System;
using System.IO;

namespace _5_RoadConnectionFromFiles_MyVersion2Files
{
    internal class Program
    {
        static void Main(string[] args)
        {

            RoadsManager roadmanager = new RoadsManager();
            roadmanager.LoadFromFileRoads();
            roadmanager.PrintRoads();
            Console.WriteLine();

            roadmanager.LoadFromFilRodesConnection();
            roadmanager.RoadsConnectPrint();
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Pleae enter awailable road order as: road-forward-left-right:");
                Console.WriteLine("For exit enter: Exit ");
                string userRequest = Console.ReadLine();
                if (userRequest == "Exit" || userRequest == "exit") break;
                if (Functions.setRoadConnection(roadmanager, userRequest))
                {
                    Console.WriteLine("For save to file enter: Y ");
                    string userRequest2 = Console.ReadLine();
                    if (userRequest2 == "Y" || userRequest2 == "y")
                    { File.AppendAllText(RoadsManager.FILE_NAME_ROADS_CONNECTION, $"{userRequest}\r\n"); }
                }
            }

        }
    }
}
