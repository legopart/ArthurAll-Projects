using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphUndirected
{
    public class Path
    {
        private List<String> NodeList { get; set; }
        public Path() { NodeList = new(); }
        public void Add(String node) { NodeList.Add(node); }
        public override String ToString() { return String.Join(", ", NodeList); }
    }
}
