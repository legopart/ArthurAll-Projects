using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
//using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5_RoadConnectionFromFiles_MyVersion2Files
{
    public struct Functions
    {
        public static bool setRoadConnection(RoadsManager roadmanager, string userRequest)
        {
            //Conditions before splite:
            Regex regexExpression = new Regex(@"^[0-9]+[-][0-9]+[-][0-9]+[-][0-9]+$");
            // not empty
            if (userRequest == "")
                { Console.WriteLine("Not set any values"); return false; }

            // wrong pattern
            if (! regexExpression.Match(userRequest).Success)
                {Console.WriteLine("string not match the required pattern (12-34-56-78)");return false; }

            string[] oneRecord = userRequest.Split('-');

            int mainRoad = Int32.Parse(oneRecord[0]);
            int roardForward = Int32.Parse(oneRecord[1]);
            int roardLeft = Int32.Parse(oneRecord[2]);
            int roardRight = Int32.Parse(oneRecord[3]);



            //Condition Before Set
            int[] roadConnections = { mainRoad, roardForward, roardLeft, roardRight };

            //not set same road twice in different direction
            if (mainRoad == 0)
            {
                Console.WriteLine("Main Road Cant set as null (0)");
                return false;
            }

            //check if the road not exist in the RoadTable (or 0) (main road cant value 0)
            int i = 0;
            while (i < roadConnections.Length)
            {
                int j = 0;
                while (j < roadConnections.Length)
                {
                    if (i == j) { j++; continue; }
                    if (roadConnections[i] == roadConnections[j] || roadConnections[i] == 0)
                        {Console.WriteLine("Can't set the same road in the different direction (awailable 0 for null)"); return false; }
                    j++;
                }

                if(roadmanager.RoadsTable.Contains(roadConnections[i]) || ( i != 0 && roadConnections[i] == 0 ) )
                    { Console.WriteLine("Can't set the road that not actually exist in RoadsTable (or 0 for null)"); return false; }
                i++;
            }

            //check if the main road set inside the ConnectionTable
            if (roadmanager.RoadsConnectionTable.ContainsKey(mainRoad))
                { Console.WriteLine("This Main Road already set for Road Connection!");return false; }



            //Set the road
            roadmanager.ConectRoad(mainRoad, roardRight, roardLeft, roardForward);
            return true;
        }

    }

}
