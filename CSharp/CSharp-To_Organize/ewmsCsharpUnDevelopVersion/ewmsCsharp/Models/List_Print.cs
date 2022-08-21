using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ewmsCsharp.Models
{
    public class List_Print
    {
        public static string PrintData<T>(List<T> list)
        {
            string str = $"Print all {typeof(T).Name}s: \n";
            foreach (var i in list)
                str += i;
            return $"{str} \n";
        }
    }
}
