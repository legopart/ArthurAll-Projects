using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ewmsCsharp.Classes;

using Microsoft.Extensions.Logging;

namespace ewmsCsharp.Models
{
    public class List_Functions
    {

        private static ILogger<object> _logger = Logging.setLogger<List_Functions>();

        /// <summary>
        /// active function that will add all the Classes to Static List(s) (List file)
        /// </summary>
        public static void LoadFromJson() => Json_LoadToList.LoadFromJson();

        public class PrintList
        {
            public static string PrintAll() => Customer() + Item() + User() + Order();
            public static string Customer() => List_Print.PrintData(List.Customers);
            public static string Item() => List_Print.PrintData(List.Items);
            public static string ItemInOrder() => List_Print.PrintData(List.ItemInOrders);
            public static string ItemStorage() => List_Print.PrintData(List.ItemStorages);
            public static string Order() => List_Print.PrintData(List.Orders);
            public static string User() => List_Print.PrintData(List.Users);

        }

        public class Add
        {

            public static void Customer(Customer customer) { List_Add.AddData(List.Customers, customer); }
            public static void Item(Item item) { List_Add.AddData/*<Item>*/(List.Items, item); }
            public static void ItemInOrder(ItemInOrder itemInOrder) { List_Add.AddData(List.ItemInOrders, itemInOrder); }
            public static void ItemStorage(string itemid, ItemStorage itemStorage) {
                List_Add.AddStorage(itemid, itemStorage);
            }
            public static void Order(string orderId, string userID, string custumerID, List<Json_Classes.ItemInOrderAdd> itemInOrderAdd) { 
                List_Add.AddOrder(orderId, userID, custumerID, itemInOrderAdd); 
            }
            public static void User(User user) { List_Add.AddData(List.Users, user); }

        }

       

        

    }


}

