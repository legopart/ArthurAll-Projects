using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ewmsCsharp.Interfaces
{
    public interface ICustomer
    {
        DateTime BeginingServies { get; set; }
        string PhoneNumber { get; set; }
        string Address { get;  set; }

    }
}
