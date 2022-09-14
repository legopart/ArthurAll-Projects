namespace GraphUndirected
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Undirected Graph");
            WeightedGraph graph1 = new WeightedGraph();
            graph1.AddNode("A");
            graph1.AddNode("B");
            graph1.AddNode("C");
            graph1.AddEdge("A", "B", 3);
            graph1.AddEdge("A", "B", 2);
            graph1.AddEdge("A", "C", 2);
            Console.WriteLine(graph1);

            WeightedGraph graph = new WeightedGraph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddEdge("A", "B", 1);
            graph.AddEdge("B", "C", 2);

            graph.AddEdge("B", "C", 10);

              var path = graph.GetShortestPath("A", "C");
            Console.WriteLine(path);
        }
    }
}