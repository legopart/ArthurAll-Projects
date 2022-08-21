using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Tergol_Classes.Interfaces;
using ewmsCsharp.Classes;

namespace ewmsCsharp.Interfaces
{
    public interface IItemInOrder
    {

        Item Item { get; set; }
        double QuantityRequired { get; set; }
        bool RequiredSupplied { get; set; }
        double QuantityOutSourcing { get; set; }
        bool OutSourcingSupplied { get; set; }
        double PriceOrderedItem { get; set; }

    }
}
