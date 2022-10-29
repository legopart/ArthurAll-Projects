using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_08.RestSharp
{
    internal class Todo
    {
        public string title { get; set; }
        public string description { get; set; }
        public bool doneStatus { get; set; }
        public int id { get; set; }
    }
}
