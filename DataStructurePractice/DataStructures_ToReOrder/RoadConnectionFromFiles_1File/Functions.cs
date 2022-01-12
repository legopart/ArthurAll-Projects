using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
//using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataStructures.RoadConnectionFromFiles_1File
{
    public  class Functions
    {
        public static bool setRoadConnection(RoadsManager roadmanager, string userRequest)
        {
            //Conditions before splite:
            Regex regexExpression2 = new Regex(@"^[0-9]+[-][0-9]+[-][0-9]+[-][0-9]+$");
            
            // not empty
            if (userRequest == "")
                { Console.WriteLine("Not set any values"); return false; }

            // wrong pattern
            if (! regexExpression2.Match(userRequest).Success)
                {Console.WriteLine("string not match the required pattern (12-34-56-78)");return false; }

            string[] oneRecord = userRequest.Split('-');

            int mainRoad = Int32.Parse(oneRecord[0]);
            int roardForward = Int32.Parse(oneRecord[1]);
            int roardLeft = Int32.Parse(oneRecord[2]);
            int roardRight = Int32.Parse(oneRecord[3]);

            //not set the main road as null
            if (mainRoad == 0)
                {Console.WriteLine("Main Road Cant set as null (0)"); return false;}

            //not set all the connected roads as null
            if (roardForward == 0 && roardLeft == 0 && roardRight == 0)
                { Console.WriteLine("Cant set all the connected as roads null (#-0-0-0)"); return false; }


            //check if the road not exist in the RoadTable (or 0) (main road cant value 0)
            //not set same road twice in different direction
            int[] road = { mainRoad, roardForward, roardLeft, roardRight };
            int i = 0;
            while (i < road.Length)
            {
                int j = 0;
                while (j < road.Length)
                {
                    if (i == j) { j++; continue; }
                    if (road[i] != 0 && road[i] == road[j])
                        {Console.WriteLine("Can't set the same road in the different direction (awailable 0 for null)"); return false; }
                    j++;
                }

                if( road[i] != 0 && ! roadmanager.RoadsTable.Contains(road[i]) )

                { Console.WriteLine("Cant set the road that not actually exist in RoadsTable (or 0 for null)"); return false; }
                i++;
            }
            

            //check if the main road set inside the ConnectionTable
            Road mawinRoadSet = (Road) roadmanager.RoadsTable[mainRoad];
            if (mawinRoadSet.Forward != null || mawinRoadSet.Right != null || mawinRoadSet.Left != null )
                { Console.WriteLine("This Main Road already set for Road Connection!");return false; }


            //Set the road
            roadmanager.ConectRoad(mainRoad, roardRight, roardLeft, roardForward);

            return true;
        }


    }

}
