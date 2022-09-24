using System;

namespace _5_RoadConnectionFromFiles_1File
{
    internal class Program
    {
        static void Main(string[] args)
        {

            RoadsManager roadManager = new RoadsManager();
            roadManager.LoadFromFileRoads();
            roadManager.PrintRoads();

            while (true)
            {

                Console.WriteLine("Pleae enter awailable road order as: road-forward-left-right:");
                Console.WriteLine("For exit enter: Exit ");
                string userRequest = Console.ReadLine();
                if (userRequest == "Exit" || userRequest == "exit") break;

                if (Functions.setRoadConnection(roadManager, userRequest))
                {
                    Console.WriteLine("For save enter: Y ");
                    string userRequest2 = Console.ReadLine();
                    if (userRequest2 == "Y" || userRequest2 == "y")
                    {

                        string str = "";
                        foreach (Object o in roadManager.RoadsTable.Keys)
                        {
                            Road currRoad = (Road)roadManager.RoadsTable[o];
                            int right = currRoad?.Right?.Num == null ? 0 : currRoad.Right.Num;
                            int left = currRoad?.Left?.Num == null ? 0 : currRoad.Left.Num;
                            int forward = currRoad?.Forward?.Num == null ? 0 : currRoad.Forward.Num;
                            // לשנות לפונקצייה שמחזירה 0 אם null ^
                            str += $"{currRoad?.Name},{currRoad?.Num},{currRoad?.Length},{currRoad?.NetivimKamut},{currRoad?.CostMoney},";
                            if (right != 0 || left != 0 || forward != 0)
                                str += $"{right}-{left}-{forward}";
                            str += "\r\n";
                        }
                        File.WriteAllText(RoadsManager.FILE_NAME_ROADS, str);
                        Console.Clear();
                        Console.WriteLine("File Saved.");
                        Console.WriteLine();
                        roadManager.PrintRoads();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Table changed, file not saved.");
                        Console.WriteLine();
                        roadManager.PrintRoads();

                    }


                }
            }

        }
    }
}
