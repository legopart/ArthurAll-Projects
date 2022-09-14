using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphUndirected
{
    public class Path
    {
        private List<String> Nodes { get; set; }
        public Path() { Nodes = new(); }
        public void Add(String node) { Nodes.Add(node); }
        public override String ToString() { return Nodes.ToString() ?? ""; }
    }
}
