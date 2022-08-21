import java.util.ArrayList;
import java.util.List;
import java.util.LinkedList; 
import java.util.Queue; 

public class Graph {
	List<Arc> list; 
	
	Queue<Link> queue; 
	int lastlevel=0;
	int counter=0;
	int c=0;
	public Graph() {
		list = new ArrayList<Arc> (); 
	}
	
	
	public void add (Link l1, Link l2, int size) {
		Arc arc= new Arc(l1,l2, size);
		list.add(arc);
		l1.list.add(l2);
		l2.list.add(l1);
		counter+=1;
	}
	

	
	int findArc(Link l1, Link l2) {
		for(int i=0;i<list.size();i++) {
			if(list.get(i).id1==l1&&list.get(i).id2==l2) return list.get(i).size;
			//if(list.get(i).id2==l2&&list.get(i).id1==l1) return list.get(i).size;
			}
		return 0;
	}
	
	Arc findArc2(Link l1, Link l2) {
		for(int i=0;i<list.size();i++) {
			if(list.get(i).id1==l1&&list.get(i).id2==l2) return list.get(i);
			//if(list.get(i).id2==l2&&list.get(i).id1==l1) return list.get(i).size;
			}
		return null;}
	
	void bfsRun(Link l1) {
	//	System.out.print(" counter"+c+ " ");
	//	System.out.print(" size"+l1.list.size()+ " ");
		for(int i=0; i<l1.list.size();i++) {
			if (l1.list.get(i).level==0&&l1.list.get(i).id!=1) {
				queue.add(l1.list.get(i));
				l1.list.get(i).level=lastlevel;
				}			//Adding!!!
			if(findArc(l1,l1.list.get(i))!=0)		// ?? Delete 0 that printed, can't find the logic reason
			System.out.print("("+l1.id+","+l1.list.get(i).id+","+findArc(l1,l1.list.get(i))+"), ");
		}	
	}
	
	
	public void bfs(Link l1) {
		queue = new LinkedList<>();
		c=counter;
		lastlevel=1;
		//queue.add(l1);
		bfsRun(l1);


		while (c>1) {
			lastlevel+=1;
			
	//		System.out.println();
			
			for(int i=0; i<queue.size();i++) {
				
				Link tmp=queue.peek();
				queue.remove();
				
				bfsRun(tmp);
				c-=1;
			}	


			
		}
	}
	






List<Link> treeLinks;
List<Link> treeArcLinks;//Checked points
List<Arc> possibleArc; 
Arc minArc;
public void arcString() {
	for(Arc i:  possibleArc)
		System.out.print("["+i.id1.id+","+i.id2.id+","+i.size+"]");
	
}



void primeRun(Link l1) { //TEMP
	
				if(!treeLinks.contains(l1)) {
					treeLinks.add(l1);
				}
				
				for(int i=0; i<l1.list.size();i++) {
					if(!treeLinks.contains(l1.list.get(i) )) {
						treeLinks.add(l1.list.get(i));
					}
					
					
					Arc arc=findArc2(l1,l1.list.get(i));
					if(arc!=null&&!possibleArc.contains(arc)) {possibleArc.add(arc);}
				}			//Adding!!!
				
			
			while(true) {
			minArc=null;
			int minValue=Integer.MAX_VALUE;
			for(int i=0 ; i<possibleArc.size(); i++) {
				if(possibleArc.get(i).size<minValue) {minArc=possibleArc.get(i);minValue=possibleArc.get(i).size;}
			}
		
				
			if(treeArcLinks.contains(minArc.id1)&&treeArcLinks.contains(minArc.id2))possibleArc.remove(minArc);
			else {break;}
			}
			
/////			arcString();
			System.out.print("("+minArc.id1.id+","+minArc.id2.id+","+minArc.size+"), ");	
			
			treeArcLinks.add(minArc.id1);
			treeArcLinks.add(minArc.id2);
			
			possibleArc.remove(minArc);
			
			
			while (c>treeLinks.size()) {
				
				primeRun(minArc.id2);
				
				c-=1;
			}	
				

	
			
			


	}	



void prime(Link l1) {
	
	treeLinks = new ArrayList<Link> ();
	treeArcLinks = new ArrayList<Link> (); 
	possibleArc = new ArrayList<Arc> ();
	c=counter;
		
	primeRun(l1);
	

	
	while(possibleArc.size()>0) {
		primeRun(possibleArc.get(0).id1);
	}
	
	

}







}














