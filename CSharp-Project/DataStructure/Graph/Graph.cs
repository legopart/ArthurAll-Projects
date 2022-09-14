using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Graph
    {
        private class Vertice //Node
        {
            public String Lable { get; private set; }
            public Vertice(String lable) { this.Lable = lable; }
            public override String ToString() { return Lable; }
        }

        private Dictionary<String, Vertice> VerticeList { get; set; }
        private Dictionary<Vertice, List<Vertice>> AdjecencyList { get; set; }
        public Graph()
        {
            VerticeList = new();
            AdjecencyList = new();
        }

        private bool IsNull(Vertice node) { return node == null; }

        public void AddNode(String label)
        {
            VerticeList.TryAdd(label, new Vertice(label));
            var node = VerticeList[label];
            AdjecencyList.TryAdd(node, new());  //new List
        }
        public void RemoveNode(String label)
        {
            var node = VerticeList[label];
            if (IsNull(node)) return;
            foreach (var key in AdjecencyList.Keys) AdjecencyList[key].Remove(node); //O(n) O(k)
            AdjecencyList.Remove(node);
            VerticeList.Remove(label);
        }

        public void AddEdge(String fromString, String toString)
        {   //relationship from -> to
            try { AdjecencyList[VerticeList[fromString]].Add(VerticeList[toString]); }
            catch (Exception) { throw new Exception(); }
        }
        public void RemoveEdge(String fromString, String toString)
        {   //remove from.to
            try { AdjecencyList[VerticeList[fromString]].Remove(VerticeList[toString]); }
            catch (Exception) { return; }
        }

        public bool HasCycle()  //לתקן
        {
            HashSet<Vertice> all = new();
            all.UnionWith(VerticeList.Values); //A.Concat(B).ToHashSet()
            HashSet<Vertice> visiting = new();
            HashSet<Vertice> visited = new();
            foreach(var current in all)  if (HasCycle(current, all, visiting, visited)) return true; ;
            
            return false;
        }
        private bool HasCycle(Vertice node, HashSet<Vertice> all, HashSet<Vertice> visiting, HashSet<Vertice> visited)
        {
            all.Remove(node);
            visiting.Add(node);
            foreach (var neighbour in AdjecencyList[node])
            {
                if (visited.Contains(neighbour)) continue;
                if (visiting.Contains(neighbour)) return true;
                if (HasCycle(neighbour, all, visiting, visited)) return true;
            }
            visiting.Remove(node);
            visited.Add(node);
            return false;
        }

        public List<String> TopologicalSort()
        {
            Stack<Vertice> stack = new();
            HashSet<Vertice> visited = new();
            foreach (var node in VerticeList.Values) TopologicalSort(node, visited, stack);
            List<String> sortedList = new();
            while (stack.Count != 0) sortedList.Add(stack.Pop().Lable);
            return sortedList;
        }
        private void TopologicalSort(Vertice node, HashSet<Vertice> visited, Stack<Vertice> stack)
        {
            if (visited.Contains(node)) return;
            visited.Add(node);
            foreach (var neighbour in AdjecencyList[node])
                TopologicalSort(neighbour, visited, stack);
            stack.Push(node);
        }

        public void TraverseBreadthFirsy(String rootString)
        {
            var node = VerticeList[rootString];
            if (IsNull(node)) return;
            HashSet<Vertice> visited = new();
            Queue<Vertice> queue = new();
            queue.Enqueue(node);
            while (queue.Count != 0)
            {
                var current = queue.Dequeue();
                if (visited.Contains(current)) continue;
                visited.Add(current);
                Console.Write(current + " ");
                foreach (var neighbour in AdjecencyList[current]) if (!visited.Contains(neighbour)) queue.Enqueue(neighbour);
            }
        }

        //Iteration
        public void TraverseDepthFirsy(String rootString)
        {
            var node = VerticeList[rootString];
            if (IsNull(node)) return;
            HashSet<Vertice> visited = new();
            Stack<Vertice> stack = new();
            stack.Push(node);
            while (stack.Count != 0)
            {
                var current = stack.Pop();
                if (visited.Contains(current)) continue;
                visited.Add(current);
                Console.Write(current + " ");
                foreach (var neighbour in AdjecencyList[current]) if (!visited.Contains(neighbour)) stack.Push(neighbour);
            }
        }

        public void TraverseDepthFirsy_recursion(String rootString)
        {
            Vertice? node = VerticeList!.GetValueOrDefault(rootString, null);
            if (IsNull(node!)) return;
            traverseDepthFirsy_recursion(node!, new());
            Console.WriteLine();
        }
        private void traverseDepthFirsy_recursion(Vertice root, HashSet<Vertice> visited)
        {
            Console.Write(root + " ");
            visited.Add(root);
            foreach (var node in AdjecencyList[root])
                if (!visited.Contains(node)) traverseDepthFirsy_recursion(node, visited);
        }

        public override String ToString()
        {
            String str = "";
            foreach (var source in AdjecencyList.Keys)
            {
                var targets = AdjecencyList[source];
                if (targets.Count != 0) str += source + " is connected to [" + String.Join(", ", targets) + "]\n";
            }
            return str;
        }
    }
}
