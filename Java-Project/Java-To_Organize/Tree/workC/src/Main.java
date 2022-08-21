import java.util.Scanner;
public class Main {
	public static Scanner in = new Scanner(System.in);

	public static void main(String[] args) {
		Graph g1=new Graph();
		Link l1=new Link(1);
		Link l2=new Link(2);
		Link l3=new Link(3);
		Link l4=new Link(4);
		Link l5=new Link(5);
		Link l6=new Link(6);
		Link l7=new Link(7);
		Link l9=new Link(9);
		
		
		g1.add(l1,l2,12);
		g1.add(l1,l3,4);
		
		g1.add(l2,l4,2);
		g1.add(l2,l5,13);
		
		g1.add(l3,l7,4);
		
		g1.add(l4,l6,9);
		g1.add(l5,l6,1);
		g1.add(l6,l9,5);
		
		/**/
		
		
		
		System.out.print("1- BFS: ");
		g1.bfs(l1);
		System.out.println("");
		
		System.out.print("2- Prim: ");
		g1.prime(l1);
		System.out.println("");
		
	
		
		}

	}

				
	


