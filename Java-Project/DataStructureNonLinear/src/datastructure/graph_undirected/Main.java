package datastructure.graph_undirected;
public class Main {

	public static void main(String[] args) {
		System.out.println("Undirected Graph");
		WeightedGraph graph = new WeightedGraph();
		graph.addNode("A");
		graph.addNode("B");
		graph.addNode("C");
		graph.addEdge("A", "B", 3);
		//graph.addEdge("A", "B", 2);	//TO FIX !!!
		graph.addEdge("A", "C", 2);
		System.out.println( graph ) ;
	}

}
