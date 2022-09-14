using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphUndirected
{
    public class WeightedGraph
    { // Weighted
        private class Node
        {
            public String Lable { get; private set; }
            public List<Edge> EdgeList { get; private set; } // better Map

            public Node(String lable) { Lable = lable; EdgeList = new(); }

            public void AddEdge(Node to, int weight) { EdgeList.Add(new Edge(this, to, weight)); } //
            public override String ToString() { return Lable; }
        }

        private class Edge
        {
            public Node From { get; private set; }
            public Node To { get; private set; }
            public int Weight { get; private set; }
            public Edge(Node from, Node to, int weight) { From = from; To = to; Weight = weight; }
            public override String ToString() { return From + " " + Weight + "> " + To; } // A->B
        }

        private Dictionary<String, Node> nodes;

        /// private Map<Node, List<Edge>> adjecencyList;
        public WeightedGraph() { nodes = new(); } // adjecencyList = new HashMap<>();

        private bool IsNull(Node node) { return node == null; }

        private bool IsNull(Edge edge) { return edge == null; }

        public void AddNode(String lable) { nodes.TryAdd(lable, new Node(lable)); }

        public void AddEdge(String fromString, String toString, int weight)
        { // relationship
            var from = nodes?[fromString];
            var to = nodes?[toString];
            if (IsNull(from!) || IsNull(to!)) throw new Exception();
            from!.AddEdge(to!, weight);
            to!.AddEdge(from!, weight);
        }

        private class NodePriority
        {
            public Node Node { get; set; }
            public int Priority { get; set; }
            public NodePriority(Node node, int priority) { Node = node; Priority = priority; }
        }

        public List<String> GetShortestPath(String fromString, String toString)
        {
            var fromNode = nodes?[fromString];
            var toNode = nodes?[toString];
            if (IsNull(fromNode!) || IsNull(toNode!)) throw new Exception();
            Dictionary<Node, int> distances = new();
            foreach (var node in nodes!.Values) distances.Add(node, int.MaxValue);
            Dictionary<Node, Node> previousNodes = new();
            HashSet<Node> visited = new();
            PriorityQueue<NodePriority, int> queue = new ();
           //java: PriorityQueue<NodeEntry> queue = new PriorityQueue<>(Comparator.comparingInt(ne->ne.priority));
            queue.Enqueue(new NodePriority(fromNode, 0), 0);  // only item in the queue

            distances[fromNode] = 0; // java: replace(,) // A 0
            while (queue.Count != 0)
            {
                var current = queue.Dequeue().Node;
                visited.Add(current);

                foreach (var edge in current.EdgeList)
                {
                    if (visited.Contains(edge.To)) continue;
                    var newDistance = distances[current] + edge.Weight;
                    if (newDistance < distances[edge.To])
                    {
                        distances[edge.To] = newDistance; // java: replace(,)
                        previousNodes.Add(edge.To, current);
                        queue.Enqueue(new NodePriority(edge.To, newDistance), newDistance);
                    }
                }
            }
            //return distances.get(toNode);
            return buildPath(previousNodes, toNode);
        }
        private List<String> buildPath(Dictionary<Node, Node> previousNodes, Node toNode)
        {
            Stack<Node> stack = new();
            stack.Push(toNode);
            var previous = previousNodes?[toNode];
            while (true) //!IsNull(previous!)
            {
                stack.Push(previous!);
                try { previous = previousNodes[previous]; }
                catch (Exception) { break; } //previous = previousNodes.GetValueOrDefault(previous, null);
            }
            List<String> NodeList = new();
            foreach(var node in stack) NodeList.Add(node.Lable);
            return NodeList;
        }

        public override String ToString()
        {
            StringBuilder str = new("");
            foreach (var node in nodes.Values/* adjecencyList.keySet() */)
            {
                var targets = node.EdgeList;// adjecencyList.get(source);
                if (targets.Count != 0) str.Append(node + " is connected to [" + String.Join(", ", targets) + "]\n");
            }
            return str.ToString();
        }

    }
}
