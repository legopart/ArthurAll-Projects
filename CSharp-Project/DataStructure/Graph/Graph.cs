﻿using Microsoft.VisualBasic;
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
            public Vertice(String lable) { Lable = lable; }
            public override String ToString() { return Lable; }
        }

        private Dictionary<String, Vertice> VerticeList { get; set; } //NodeList
        private Dictionary<Vertice, List<Vertice>> AdjecencyList { get; set; } //EdgeList
        public Graph() { VerticeList = new(); AdjecencyList = new(); }

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
            AdjecencyList.Remove(node);
            VerticeList.Remove(label);
        }

        public void AddEdge(String fromString, String toString)
        {   //relationship from -> to
            try { AdjecencyList[VerticeList[fromString]].Add(VerticeList[toString]); }
            catch (Exception) { throw new Exception(); }    //IsNull
        }
        public void RemoveEdge(String fromString, String toString)
        {   //remove from.to
            try { AdjecencyList[VerticeList[fromString]].Remove(VerticeList[toString]); }
            catch (Exception) { return; }    //IsNull
        }

        //Iteration
        public void TraverseDepthFirsy(String rootString)
        {
            HashSet<Vertice> visited = new();
            Stack<Vertice> stack = new();
            var root = VerticeList?[rootString];
            if (IsNull(root!)) return;
            stack.Push(root!);   //Link
            while (stack.Count != 0)
            {
                var node = stack.Pop(); //currernt
                if (visited.Contains(node)) continue;
                else visited.Add(node);
                Console.Write(node + " ");
                foreach (var neighbour in AdjecencyList[node])   //Links
                    if (!visited.Contains(neighbour)) stack.Push(neighbour);
            }
        }

        public void TraverseBreadthFirsy(String rootString)
        {
            HashSet<Vertice> visited = new();
            Queue<Vertice> queue = new();
            var root = VerticeList?[rootString];
            if (IsNull(root!)) return;
            queue.Enqueue(root!);   //Link
            while (queue.Count != 0)
            {
                var node = queue.Dequeue(); //currernt
                if (visited.Contains(node)) continue;
                else visited.Add(node);
                Console.Write(node + " ");
                foreach (var neighbour in AdjecencyList[node])   //Links
                    if (!visited.Contains(neighbour)) queue.Enqueue(neighbour);
            }
        }


        public void TraverseDepthFirsy_recursion(String rootString)
        {
            try 
            {
                Vertice root = VerticeList[rootString];
                TraverseDepthFirsy_recursion(root, new());
                Console.WriteLine();
            } catch (Exception) { return; }
        }
        private void TraverseDepthFirsy_recursion(Vertice node, HashSet<Vertice> visited)
        {
            Console.Write(node + " ");
            visited.Add(node);
            foreach (var neighbour in AdjecencyList[node])
                if (!visited.Contains(neighbour)) TraverseDepthFirsy_recursion(neighbour, visited);
        }




        public List<String> TopologicalSort()  //לחזור 
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


        public bool HasCycle()  //לחזור ולתקן
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
