using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ewmsCsharp.Interfaces
{
    public interface IDataDate
    {
        DateTime CreateDate { get; }
        DateTime EditDate { get; }
        DateTime OnProcessDate { get; } //crossing proccess protector
        bool Active { get; protected set; } // Check if works to chenge only inside the 

        public string DataString();
    }
}
