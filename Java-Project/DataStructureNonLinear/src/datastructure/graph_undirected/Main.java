package datastructure.graph_undirected;
public class Main {

	public static void main(String[] args) {
		System.out.println("Undirected Graph");
		WeightedGraph graph1 = new WeightedGraph();
		graph1.addNode("A");
		graph1.addNode("B");
		graph1.addNode("C");
		graph1.addEdge("A", "B", 3);
		//graph.addEdge("A", "B", 2);	//TO FIX !!!
		graph1.addEdge("A", "C", 2);
		System.out.println( graph1 ) ;
		
		WeightedGraph graph = new WeightedGraph();
		graph.addNode("A");
		graph.addNode("B");
		graph.addNode("C");
		graph.addEdge("A", "B", 1);
		graph.addEdge("B", "C", 2);
		graph.addEdge("B", "C", 10);
		var path = graph.getShortestPath("A", "C");
		System.out.println(path);
	}

}
