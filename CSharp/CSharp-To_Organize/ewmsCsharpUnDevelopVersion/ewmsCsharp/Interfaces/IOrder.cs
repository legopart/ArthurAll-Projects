using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ewmsCsharp.Classes;

namespace ewmsCsharp.Interfaces
{
    public interface IOrder
    {
        User User { get; set; }   //order created by
        Customer Customer { get; set; } // order created for
        List<ItemInOrder> ItemsInOrder { get; set; } // items inside the order

    }
}
