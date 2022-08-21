using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ewmsCsharp;
using ewmsCsharp.Classes;
using ewmsCsharp.Models;

using Microsoft.Extensions.Logging;

namespace ewmsCsharp
{
    public class DataBase
    {
        private static ILogger<object> _logger = Logging.setLogger<DataBase>();
        public static void LoadToList() {

            _logger.LogInformation("DataBase data load");


            try
            {
                //List.Add
             
            List.Add.Item(new(id: "00002", name: "item2"));
            List.Add.Item(new(id: "00003", name: "item3"));
            List.Add.Item(new(id: "00002", name: "item4")); // ERROR, same id added check
            List.Add.Item(new(id: "00005", name: "item5"));
                


            List.Add.Customer(new(id: "001", name: "custumer1"));
            List.Add.Customer(new(id: "002", name: "custumer2"));
            List.Add.Customer(new(id: "003", name: "custumer3"));
            List.Add.Customer(new(id: "004", name: "custumer4"));
            Customer customer4 = new(id: "004", name: "custumer5");  // ERROR, same id added check
            List.Add.Customer(customer4);

            }
            catch (Exception ex) { _logger.LogError(ex.Message); }
        }

    }
}
