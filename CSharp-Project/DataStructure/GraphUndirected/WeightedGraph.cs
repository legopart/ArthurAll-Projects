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
        private class Vertice   //Node
        {
            public String Lable { get; private set; }
     /*!*/  public List<Edge> EdgeList { get; private set; } // better Map
            public Vertice(String lable) { Lable = lable; EdgeList = new(); }
     /*!*/  public void AddEdge(Vertice to, int weight) { EdgeList.Add(new Edge(/*this,*/ to, weight)); } //
            public override String ToString() { return Lable; }
        }

        private class Edge
        {
           // public Vertice From { get; private set; }
            public Vertice To { get; private set; }
            public int Weight { get; private set; }
            public Edge(/*Vertice from,*/ Vertice to, int weight) { /*From = from;*/ To = to; Weight = weight; }
            public override String ToString() { return /*From +*/ "<" + Weight + ">" + To; } // A->B
        }
/*        private class NodePriority
        {
            public Vertice Node { get; set; }
            public int Priority { get; set; }
            public NodePriority(Vertice node, int priority) { Node = node; Priority = priority; }
        }
*/

        private Dictionary<String, Vertice> nodes;

        /// private Map<Node, List<Edge>> adjecencyList;
        public WeightedGraph() { nodes = new(); }

        private bool IsNull(Vertice node) { return node == null; }

        public void AddNode(String lable) { nodes.TryAdd(lable, new Vertice(lable)); }

        public void AddEdge(String fromString, String toString, int weight)
        { // relationship
            var from = nodes?[fromString];
            var to = nodes?[toString];
            if (IsNull(from!) || IsNull(to!)) throw new Exception();
            from!.AddEdge(to!, weight);
            to!.AddEdge(from!, weight);
        }



        public List<String> GetShortestPath(String fromString, String toString)
        {
            var fromNode = nodes?[fromString];
            var toNode = nodes?[toString];
            if (IsNull(fromNode!) || IsNull(toNode!)) throw new Exception();

            Dictionary<Vertice, int> distances = new();
            foreach (var node in nodes!.Values) distances.Add(node, int.MaxValue);
            Dictionary<Vertice, Vertice> previousNodes = new();
            HashSet<Vertice> visited = new();
            PriorityQueue<Vertice, int> queue = new ();
           //java: PriorityQueue<NodeEntry> queue = new PriorityQueue<>(Comparator.comparingInt(ne->ne.priority));
            queue.Enqueue(fromNode!, 0);  // only item in the queue

            distances[fromNode] = 0; // java: replace(,) // A 0
            while (queue.Count != 0)
            {
                var current = queue.Dequeue();
                visited.Add(current);

                foreach (var edge in current.EdgeList)
                {
                    if (visited.Contains(edge.To)) continue;
                    var newDistance = distances[current] + edge.Weight;
                    if (newDistance < distances[edge.To])
                    {
                        distances[edge.To] = newDistance; // java: replace(,)
                        previousNodes.Add(edge.To, current);
                        queue.Enqueue(edge.To, newDistance);
                    }
                }
            }
            //return distances.get(toNode);
            return buildPath(previousNodes, toNode!);
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
            foreach (var node in stack) NodeList.Add(node.Lable);
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
