package datastructure.graph_undirected;

import java.awt.print.Printable;
import java.util.ArrayList;
import java.util.Comparator;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.PriorityQueue;

public class WeightedGraph { // Weighted
	private class Node {
		private String lable;
		private List<Edge> edges; // better Map

		public Node(String lable) {
			this.lable = lable;
			edges = new ArrayList<>();
		}

		public void addEdge(Node to, int weight) {
			edges.add(new Edge(this, to, weight)); //
		}

		public List<Edge> getEdges() {
			return edges;
		}

		@Override
		public String toString() {
			return lable;
		}
	}

	private class Edge {
		private Node from;
		private Node to;
		private int weight;

		public Edge(Node from, Node to, int weight) {
			this.from = from;
			this.to = to;
			this.weight = weight;
		}

		@Override
		public String toString() {
			return from + " " + weight + "> " + to;
		} // A->B
	}

	private Map<String, Node> nodes;

	/// private Map<Node, List<Edge>> adjecencyList;
	public WeightedGraph() {
		nodes = new HashMap<>();
		// adjecencyList = new HashMap<>();
	}

	private boolean isNull(Node node) {
		return node == null;
	}

	private boolean isNull(Edge edge) {
		return edge == null;
	}

	public void addNode(String lable) {
		nodes.putIfAbsent(lable, new Node(lable));
		// adjecencyList.putIfAbsent(node, new ArrayList<>());
		// Edges will initialize automatically
	}
	/*
	 * public void removeNode(String label) { var node = nodes.get(label);
	 * if(isNull(node)) return; for(var n : adjecencyList.keySet())
	 * adjecencyList.get(n).remove(node); adjecencyList.remove(node);
	 * nodes.remove(node); }
	 */

	public void addEdge(String from, String to, int weight) { // relationship
		var fromNode = nodes.get(from);
		var toNode = nodes.get(to);
		if (isNull(fromNode) || isNull(toNode))
			throw new IllegalArgumentException();
		fromNode.addEdge(toNode, weight);
		toNode.addEdge(fromNode, weight);
		// adjecencyList.get(fromNode).add(new Edge(fromNode, toNode, weight));
		/// *!*/adjecencyList.get(toNode).add(new Edge(toNode, fromNode, weight));
	}

	private class NodeEntry {
		private Node node;
		private int priority;

		public NodeEntry(Node node, int priority) {
			this.node = node;
			this.priority = priority;
		}
	}

	public int getShortestDistance(String from, String to) {
		
		  PriorityQueue<NodeEntry> queue = 
				  new PriorityQueue<>( Comparator.comparingInt(ne -> ne.priority ) );
		 
		return 0;
	}

	@Override
	public String toString() {
		String str = "";
		for (var node : nodes.values()/* adjecencyList.keySet() */) {
			var targets = node.getEdges();// adjecencyList.get(source);
			if (!targets.isEmpty())
				str += node + " is connected to " + targets + "\n";
		}
		return str;
	}

}
