using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ewmsCsharp.Classes;

using Newtonsoft.Json;

namespace ewmsCsharp.Models
{
    public class Json_LoadToList : Json_Classes
    {
        public static void LoadFromJson()
        {
            string exePath = Path.GetDirectoryName(typeof(Program).Assembly.Location);
            string filename = Path.Combine(exePath, "Data", "Data.json");
            string text = File.ReadAllText(filename);
            if (text == String.Empty) { throw new Exception("JSON file is empty!"); }
            Json_LoadToListClasses dataFromFile = JsonConvert.DeserializeObject<Json_LoadToListClasses>(text);

            // Exeption
            if (dataFromFile.Data == null) { throw new Exception("JSON file not included Data!"); }


            var cunstomers = dataFromFile.Data.CustomerList;
            var items = dataFromFile.Data.ItemList;
            var itemStorages = dataFromFile.Data.ItemStorageList;
            var users = dataFromFile.Data.UserList;

            var orders = dataFromFile.Data.OrderList;
            var itemsInOrder = dataFromFile.Data.ItemInOrderList;


            if (cunstomers != null)      //Cunstomers add      
                foreach (var i in cunstomers)
                    List.Add.Customer(i);
            if (items != null)          //Items add
                foreach (var i in items)
                    List.Add.Item(i);
            if (itemStorages != null)   //Item Storages add
                foreach (var i in itemStorages)
                    List.Add.ItemStorage(i.ItemId, i.ItemStorage);
            if (users != null)          //Users add
                foreach (var i in users)
                    List.Add.User(i);

            //  Do not use
            //      if (itemsInOrder != null)   //Items In Order add

            //          foreach (var i in itemsInOrder)
            //              List.Add.ItemInOrder(i);
            if (orders != null)         //Orders add
                foreach (var i in orders) 
                    List.Add.Order(i.OrderId, i.UserId, i.CustomerId, i.ItemInOrderList);

                    


        }



        //load all the data 
        //add try catch with logs
    }

 


}
