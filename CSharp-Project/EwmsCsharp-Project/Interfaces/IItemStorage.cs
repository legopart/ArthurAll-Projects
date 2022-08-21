using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ewmsCsharp.Interfaces
{
    public interface IItemStorage
    {
        double Quantity { get; set; }
        string Measurments { get; set; }
        string Location { get; set; }
        double Price { get; set; }

        string ToString();
        
    }
}
