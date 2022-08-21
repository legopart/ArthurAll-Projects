import java.util.List;
public class Linkedlist {
protected	Link root;
			int size=0;
			

public		Linkedlist() {
				root= null;
			}

public	Link place(int x) {
	Link current=root;
	while(current!=null){
	if(x==1) {return current;}
	x--;
	current=current.next;
	}
	
	return null;
}


public	void swap(Link A, Link B) { //הגירסה הקצרה
	int tmp=A.number1; 
	String tmpCategory=A.category;
	A.number1=B.number1;
	A.category=B.category;
	B.number1=tmp;	
	B.category=tmpCategory;
}


public		int maxHeap() {return maxHeapLink().number1;}

public		Link maxHeapLink() {return root;}

public		void insertHeap(int data, String category) {
					Link current=root;
					if(current==null) {
								root=new Link(data, category);
								root.back=null;
								size++;
					} //אם האיבר הוא הראשון שמוכנס
					else {
						while(current.next!=null){current=current.next;}
						current.next=new Link(data, category);
						current.next.back=current;
						size++;

						int placeSize=size;
						int parantPlace;
						Link parant;
						Link sun;
						
						while (placeSize>1) {
								parantPlace=placeSize/2;
								parant=place(parantPlace);
								sun=place(placeSize);
							if(parant.number1<sun.number1) {
								swap(parant,sun);
								
								placeSize=parantPlace;
						
					}}}
								}
public		void insertHeap(int data) {
										insertHeap(data, "");
										};

public		void deleteNode(int data) {
								Link current=root;
								int countPlace=0;
								while(current!=null&&current.number1!=data){current=current.next;countPlace++;}
								if(current.number1==data) {
												swap(current,place(size));
												if(place(size).back!=null) place(size).back.next=null;
												else {root=null;}
												size--;
												
						
												int sunsPlace;
												//sift down
												int lastLevel=(int) (Math.sqrt(size-1)+1);
												while (lastLevel>0) {
															sunsPlace=(countPlace+1)*2; /******/
														

															if(sunsPlace<size) {
															if(place(sunsPlace).number1<place(sunsPlace+1).number1)
																sunsPlace+=1;
															if(place(sunsPlace).number1>current.number1)
																swap(current,place(sunsPlace));
																current=place(sunsPlace);
															}
															
											
																countPlace=sunsPlace-1;
																lastLevel--;
													}
												}
								}

public		void deleteMax() {deleteNode(maxHeap());}

public		String  searchHeap(int data) {				
											Link current=root;
											while(current!=null){
												if(current.number1==data)return data + " " + current.category;
												current=current.next;
											}
											 return "The value \"" + data + "\"not awailable!";
										}

public		int countHeap() {return size;} 

public		String printHeap() {
											String str=new String();
											str="[";
											String tree=new String();
											tree="";
											int lastLevel=(int) (Math.sqrt(size-1)+2);
											int countLevel=0;
											int heapsPerLevel=0;
											int heapsCount=0;
											
											Link current=root;
											while(current!=null){
												//רשימה
												str+=current.number1;
												str+=", ";
												
												//עץ
												heapsPerLevel=(int) Math.pow(2, countLevel);
												for(int i=0; i<=Math.pow(2,lastLevel-countLevel)/1.4; i++) {tree+=" ";}
												tree+=current.number1;
												heapsCount++;
												if(heapsPerLevel-heapsCount==0) {tree+="\n\n";heapsCount=0;countLevel++;}
												
												current=current.next;
											}
											str+="]\n";
	return (str+tree);
	} 
}