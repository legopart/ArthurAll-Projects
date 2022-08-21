using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using ewmsCsharp.Classes;
using static ewmsCsharp.Interfaces.Json_Interfaces;

namespace ewmsCsharp.Classes
{
    public class Json_Classes
    {
        public class Json_LoadToListClasses
        {
            public InternalData Data { get; set; } //example for sub usage
        }

        public class InternalData
        {
            public List<Customer> CustomerList { get; set; }
            public List<Item> ItemList { get; set; }
            public List<ItemStorageAdd> ItemStorageList { get; set; }   //Internal
            public List<User> UserList { get; set; }
            public List<ItemInOrderAdd> ItemInOrderList { get; set; }  //Internal
            public List<OrderAdd> OrderList { get; set; }  //Internal
        }

            public class ItemStorageAdd : IItemStorageAdd
        {
            public string ItemId { get; private set; }
            public ItemStorage ItemStorage { get; private set; }
            [JsonConstructor]
            public ItemStorageAdd(string itemId, ItemStorage itemStorage)
            {
                ItemId = itemId;
                ItemStorage = itemStorage;
            }
        }

        public class OrderAdd : IOrderAdd
        {
            public string OrderId { get; private set; }
            public string UserId { get; private set; }
            public string CustomerId { get; private set; }
            public List<ItemInOrderAdd> ItemInOrderList { get; set; }

            [JsonConstructor]
            public OrderAdd(string orderId, string userId, string customerId, List<ItemInOrderAdd> itemInOrderList)
            {
                OrderId = orderId;
                UserId = userId;
                CustomerId = customerId;
                ItemInOrderList = itemInOrderList;
            }
        }

        public class ItemInOrderAdd : IItemInOrderAdd
        {
            public string ItemId { get; private set; }
            public double QuantityRequired { get; private set; }
            [JsonConstructor]
            public ItemInOrderAdd(string itemId, double quantityRequired)
            {
                ItemId = itemId;
                QuantityRequired = quantityRequired;
            }

        }

    }
}
