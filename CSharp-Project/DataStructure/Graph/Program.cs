﻿
namespace Graph
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Graph");    //לחזור
            var graph1 = new Graph();
            graph1.AddNode("A");
            graph1.AddNode("B");
            graph1.AddNode("C");
            graph1.AddNode("D");
            graph1.AddEdge("A", "B");
            graph1.AddEdge("A", "C");
            graph1.AddEdge("A", "D");
            graph1.RemoveEdge("A", "C");
            graph1.RemoveEdge("A", "E"); // no E !
            graph1.RemoveNode("B");
            graph1.RemoveNode("A");
            graph1.AddEdge("C", "D");
            // graph1.AddEdge("C", "W"); //fail edge
            graph1.AddNode("W");
            graph1.AddEdge("W", "C");
            Console.WriteLine(graph1);
            Console.WriteLine("");

            var graph2 = new Graph();
            graph2.AddNode("A");
            graph2.AddNode("B");
            graph2.AddNode("C");
            graph2.AddNode("D");
            graph2.AddNode("E");
            graph2.AddEdge("A", "B");
            graph2.AddEdge("A", "E");
            graph2.AddEdge("B", "D");
            graph2.AddEdge("B", "C");
            graph2.AddEdge("C", "D");
            graph2.TraverseDepthFirsy_recursion("A"); // A B C D E
            graph2.TraverseDepthFirsy_recursion("C"); // C D
            graph2.TraverseDepthFirsy_recursion("G"); // 
            Console.WriteLine("");
            graph2.TraverseDepthFirsy("A");
            Console.WriteLine("");

            Console.WriteLine("");
            var graph = new Graph();
            graph.AddNode("X");
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("P");
            graph.AddEdge("X", "A");
            graph.AddEdge("X", "B");
            graph.AddEdge("A", "P");
            graph.AddEdge("B", "P");
            var list = graph.TopologicalSort();
            Console.WriteLine(String.Join(", ", list));

        }
    }
}