using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ewmsCsharp.Interfaces
{
    public interface IData
    {
        object Id { get; }
        string Name { get; set; }
        string Notes { get; set; }

        string ToString();

        /*
         void Add();
         void Edit();
         void Delete();
        */
    }
}
