using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ewmsCsharp.Interfaces;
using ewmsCsharp.Classes;
using ewmsCsharp.Enums;

namespace ewmsCsharp.Interfaces
{
    public interface IItem
    {
        ItemStorage Storage { get; set; }
        ItemEnums.ItemType Type { get; set; }
        ItemEnums.ItemCategory Category { get; set; }
        string Description { get; set; }
       
    }
}
