using ewmsCsharp.Models;


using Newtonsoft.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ewmsCsharp.Classes;

/**
 * Copyright:
 *  Author: Arthur Zarankin
 *  Email: w3arthur@gmail.com
 *  Site: http://www.arthur.tk
 *  Begin Date: 14/11/2021
 *  Edited At:  27/11/2021
*/

namespace ewmsCsharp
{
    class Program{

        private static ILogger<object> _logger = Logging.setLogger<Program>();

        static void Main(string[] args)
        {

            DataBase.LoadToList(); //Load all User(s), Customer(s), Item(s), Item(s)InStorage, Item(s)InOrder, Order(s) List

            try  // Load all data from Json file
            {
                List.LoadFromJson();
            }
            catch (Exception ex) { _logger.LogError(ex.Message); }


            Console.WriteLine("Print All Customers + Items + Orders + Users :\n" +
                "Press Enter to show.");
            Console.ReadLine();

            Console.WriteLine(List.PrintList.PrintAll());

            


            //Console.WriteLine(List.PrintList.ItemInOrder());
        }

    }
}

