using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Graph
    {
        private class Node
        {
            public String Lable { get; private set; }
            public Node(String lable) { this.Lable = lable; }
            public override String ToString() { return Lable; }
        }
        private Dictionary<String, Node> nodes;
        private Dictionary<Node, List<Node>> adjecencyList;
        public Graph()
        {
            nodes = new();
            adjecencyList = new();
        }

        private bool IsNull(Node node) { return node == null; }

        public void AddNode(String lable)
        {
            var node = new Node(lable);
            nodes.TryAdd(lable, node);
            adjecencyList.TryAdd(node, new());
        }
        public void RemoveNode(String label)
        {
            var node = nodes[label];
            if (IsNull(node)) return;
            foreach (var n in adjecencyList.Keys) adjecencyList[n].Remove(node);
            adjecencyList.Remove(node);
            nodes.Remove(label);
        }

        public void AddEdge(String from, String to)
        {   //relationship
            Node? fromNode = nodes!.GetValueOrDefault(from, null);
            Node? toNode = nodes!.GetValueOrDefault(to, null);
            if (IsNull(fromNode!) || IsNull(toNode!)) throw new Exception();
            adjecencyList[fromNode!].Add(toNode!);
            //bidirectional graph: adjecenccyList.get(toNode).add(fromNode);
        }
        public void RemoveEdge(String from, String to)
        {
            Node? fromNode = nodes!.GetValueOrDefault(from, null);
            Node? toNode = nodes!.GetValueOrDefault(to, null);
            if (IsNull(fromNode!) || IsNull(toNode!)) return;
            adjecencyList[fromNode!].Remove(toNode!);
            //adjecenccyList.get(toNode).remove(fromNode);
        }

        public bool HasCycle()  //לתקן
        {
            HashSet<Node> all = new();
            all.UnionWith(nodes.Values); //A.Concat(B).ToHashSet()
            HashSet<Node> visiting = new();
            HashSet<Node> visited = new();
            foreach(var current in all)  if (HasCycle(current, all, visiting, visited)) return true; ;
            
            return false;
        }
        private bool HasCycle(Node node, HashSet<Node> all, HashSet<Node> visiting, HashSet<Node> visited)
        {
            all.Remove(node);
            visiting.Add(node);
            foreach (var neighbour in adjecencyList[node])
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
            Stack<Node> stack = new();
            HashSet<Node> visited = new();
            foreach (var node in nodes.Values) TopologicalSort(node, visited, stack);
            List<String> sortedList = new();
            while (stack.Count != 0) sortedList.Add(stack.Pop().Lable);
            return sortedList;
        }
        private void TopologicalSort(Node node, HashSet<Node> visited, Stack<Node> stack)
        {
            if (visited.Contains(node)) return;
            visited.Add(node);
            foreach (var neighbour in adjecencyList[node])
                TopologicalSort(neighbour, visited, stack);
            stack.Push(node);
        }

        public void TraverseBreadthFirsy(String rootString)
        {
            var node = nodes[rootString];
            if (IsNull(node)) return;
            HashSet<Node> visited = new();
            Queue<Node> queue = new();
            queue.Enqueue(node);
            while (queue.Count != 0)
            {
                var current = queue.Dequeue();
                if (visited.Contains(current)) continue;
                visited.Add(current);
                Console.Write(current + " ");
                foreach (var neighbour in adjecencyList[current]) if (!visited.Contains(neighbour)) queue.Enqueue(neighbour);
            }
        }

        //Iteration
        public void TraverseDepthFirsy(String rootString)
        {
            var node = nodes[rootString];
            if (IsNull(node)) return;
            HashSet<Node> visited = new();
            Stack<Node> stack = new();
            stack.Push(node);
            while (stack.Count != 0)
            {
                var current = stack.Pop();
                if (visited.Contains(current)) continue;
                visited.Add(current);
                Console.Write(current + " ");
                foreach (var neighbour in adjecencyList[current]) if (!visited.Contains(neighbour)) stack.Push(neighbour);
            }
        }


        public void TraverseDepthFirsy_recursion(String rootString)
        {
            Node? node = nodes!.GetValueOrDefault(rootString, null);
            if (IsNull(node!)) return;
            traverseDepthFirsy_recursion(node!, new());
            Console.WriteLine();
        }
        private void traverseDepthFirsy_recursion(Node root, HashSet<Node> visited)
        {
            Console.Write(root + " ");
            visited.Add(root);
            foreach (var node in adjecencyList[root])
                if (!visited.Contains(node)) traverseDepthFirsy_recursion(node, visited);
        }

        public override String ToString()
        {
            String str = "";
            foreach (var source in adjecencyList.Keys)
            {
                var targets = adjecencyList[source];
                if (targets.Count != 0) str += source + " is connected to " + targets.First() + "\n";
            }
            return str;
        }
    }
}
