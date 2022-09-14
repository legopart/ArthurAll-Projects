using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GraphUndirected
{
    public class WeightedGraph
    { // Weighted
        private class Vertice   //Node
        {
            public String Label { get; private set; }
     /*!*/  public List<Edge> EdgeList { get; private set; } // better Map
            public Vertice(String lable) { Label = lable; EdgeList = new(); }
     /*!*/  public void AddEdge(Vertice to, int weight) { EdgeList.Add(new Edge(this, to, weight)); }
            public override String ToString() { return Label; }
        }

        private class Edge
        {
            public Vertice From { get; private set; }
            public Vertice To { get; private set; }
            public int Weight { get; private set; }
            public Edge(Vertice from, Vertice to, int weight) { From = from; To = to; Weight = weight; }
            public override String ToString() { return "<" + Weight + ">" + To; } // A->B
        }
    /*   private class NodePriority
         {
            public Vertice Node { get; set; }
            public int Priority { get; set; }
            public NodePriority(Vertice node, int priority) { Node = node; Priority = priority; }
         }*/

        private Dictionary<String, Vertice> Nodes { get; set; }
        // private Map<Node, List<Edge>> adjecencyList;
        
        public WeightedGraph() { Nodes = new(); }

        private bool IsNull(Vertice node) { return node == null; }

        private void AddNode(Vertice node) { AddNode(node.Label); }
        public void AddNode(String lable) { Nodes.TryAdd(lable, new Vertice(lable)); }

        private void AddEdge(Vertice from, Vertice to, Edge edge) { AddEdge(from.Label, to.Label, edge.Weight); }
        public void AddEdge(String fromString, String toString, int weight)
        { // relationship
            var from = Nodes?[fromString];
            var to = Nodes?[toString];
            if (IsNull(from!) || IsNull(to!)) throw new Exception();
            from!.AddEdge(to!, weight);
            to!.AddEdge(from!, weight);
        }



        public List<String> GetShortestPath(String fromString, String toString)
        {
            var from = Nodes?[fromString];
            var to = Nodes?[toString];
            if (IsNull(from!) || IsNull(to!)) throw new Exception();

            Dictionary<Vertice, int> distances = new();
            foreach (var node in Nodes!.Values) distances.Add(node, int.MaxValue);
            distances[from!] = 0; // java: replace(,) // A 0

            Dictionary<Vertice, Vertice> previousNodes = new();

            HashSet<Vertice> visited = new();

            PriorityQueue<Vertice, int> queue = new (); //java: PriorityQueue<NodeEntry> queue = new PriorityQueue<>(Comparator.comparingInt(ne->ne.priority));
            queue.Enqueue(from!, 0);  // only item in the queue

            while (queue.Count != 0)
            {
                var current = queue.Dequeue();
                visited.Add(current);

                foreach (var edge in current.EdgeList)
                {
                    if (visited.Contains(edge.To)) continue;
            /*!*/   var newDistance = distances[current] + edge.Weight;
                    if (newDistance < distances[edge.To])
                    {
                        distances[edge.To] = newDistance; // java: replace(,)
                        previousNodes.Add(edge.To, current);
                        queue.Enqueue(edge.To, newDistance);
                    }
                }
            }
            //return distances.get(toNode);
            return buildPath(previousNodes, to!);
        }
        private List<String> buildPath(Dictionary<Vertice, Vertice> previousNodes, Vertice toNode)
        {
            Stack<Vertice> stack = new();
            stack.Push(toNode);
            var previous = previousNodes?[toNode];
            while (true) //!IsNull(previous!)
            {
                stack.Push(previous!);
                try { previous = previousNodes![previous!]; }
                catch (Exception) { break; } //previous = previousNodes.GetValueOrDefault(previous, null);
            }
            return ToList(stack);
        }

        private List<String> ToList(Stack<Vertice> stack)
        {
            List<String> NodeList = new();
            foreach (var node in stack) NodeList.Add(node.Label);
            return NodeList;
        }




        public bool HasCycle()
        {
            HashSet<Vertice> visited = new();
            foreach (var node in  Nodes.Values)
                if (!visited.Contains(node)
                        && HasCycle(node, null, visited)) return true;
            return false;
        }

        //לחזור !
        private bool HasCycle(Vertice node, Vertice? parant, HashSet<Vertice> visited)
        {
            visited.Add(node);
            foreach (var edge in node.EdgeList)
            {
                if (edge.To == parant) continue;
                if (visited.Contains((edge.To))
                        || HasCycle(edge.To, node, visited)) return true;
            }
            return false;
        }

        public WeightedGraph GetMinimumSpanningTree()
        {
            WeightedGraph tree = new WeightedGraph();
            if (Nodes.Count == 0) return tree;
            PriorityQueue<Edge, int> edges = new();
            var startNode = Nodes.First().Value; //java: nodes.values().iterator().next();
            foreach (var edge in startNode.EdgeList) edges.Enqueue(edge, edge.Weight);
            tree.AddNode(startNode.Label);

            if (edges.Count == 0) return tree;

            while (tree.Nodes.Count < Nodes.Count)
            {
                var minEdge = edges.Dequeue();
                var nextNode = minEdge.To;
                if (tree.ContainsNode(nextNode.Label)) continue;
                tree.AddNode(nextNode);
                tree.AddEdge(minEdge.From, nextNode, minEdge);
                foreach (var edge in nextNode.EdgeList)
                    if (!tree.ContainsNode(edge.To))
                        edges.Enqueue(edge, edge.Weight);
            }
            return tree;
        }


        public bool ContainsNode(String label) { return Nodes.ContainsKey(label); }
        private bool ContainsNode(Vertice node) { return Nodes.ContainsKey(node.Label); }
        // להוסיף remove node

        public override String ToString()
        {
            StringBuilder str = new("");
            foreach (var node in Nodes.Values/* adjecencyList.keySet() */)
            {
                var targets = node.EdgeList;// adjecencyList.get(source);
                if (targets.Count != 0) str.Append(node + " is connected to [" + String.Join(", ", targets) + "]\n");
            }
            return str.ToString();
        }

    }
}
