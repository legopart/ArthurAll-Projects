using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ewmsCsharp;
using ewmsCsharp.Classes;
using ewmsCsharp.Models;

namespace ewmsCsharp
{

    public class List : Models.List_Functions
    {
        //private set when all functions will done
        public static List<Customer> Customers = new List<Customer>();
        public static List<Item> Items = new List<Item>();
        public static List<ItemInOrder> ItemInOrders = new List<ItemInOrder>();
        public static List<ItemStorage> ItemStorages = new List<ItemStorage>();
        public static List<Order> Orders = new List<Order>();
        public static List<User> Users = new List<User>();

        // See all functions on Models\Functions.cs

        // set every List to Private
        //public class Add { }
        //public static void LoadFromJson() { }
    }


}
