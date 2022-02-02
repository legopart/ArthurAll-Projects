using System;
using System.Collections.Generic;

namespace Elias_DependencyInjection
{
    public class Program
    {

        public static string GetStudentNameByIdBasedOnLIts(string name)
        {
         
           // o(n)
            // get from db into list
            List<string> names= new List<string>();
            names.Add("elias");
            names.Add("avi");
            names.Add("rondalo");
            names.Add("misse");
            names.Add("kim");
            // another 9 milion names
            foreach (var nameIn in names)
            {
                if (nameIn == name)
                {
                    return nameIn;
                }
            }

            return "";
        }


        public static string GetStudentNameByIdOnDic(int id)
        {
            // o(1)
            Dictionary<int,string> namesDic = new Dictionary<int,string>();
            namesDic[1] = "elias";
            namesDic[2] = "ronaldo";
            namesDic[3] = "misse";
            // another 9 milion
            return namesDic[id];
        }
        static void Main(string[] args)
        {

            var manader = SudentDataManager.Instance();
            var manader2 = SudentDataManager.Instance();
            var manader3 = SudentDataManager.Instance();
            var manader4 = SudentDataManager.Instance();
            var manader5 = SudentDataManager.Instance();

            // List vs array
            // Dic
            // Linq
            // Ilogger
            // DI & IOC



            string[] arr = new string[4]; // init is done from here have a max sie

            List<string> listOfNames = new List<string>(); // there is no limit

            Dictionary<int,string> dictionary = new Dictionary<int,string>();
            dictionary[201298411] = "elias";




            Console.WriteLine("Hello World!");
        }
    }
}
