using ewmsCsharp.Classes;
using ewmsCsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ewmsCsharp.Interfaces
{
    public interface Json_Interfaces
    {

        public interface IItemStorageAdd
        {
            string ItemId { get; }
            ItemStorage ItemStorage { get; }
        }

        public interface IOrderAdd
        {
            string CustomerId { get; }
            List<Json_Classes.ItemInOrderAdd> ItemInOrderList { get; set; }
            string OrderId { get; }
            string UserId { get; }
        }

        public interface IItemInOrderAdd
        {
            string ItemId { get; }
            double QuantityRequired { get; }
        }

    }
}
