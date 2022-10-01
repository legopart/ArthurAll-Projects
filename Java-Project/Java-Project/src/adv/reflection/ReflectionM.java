package adv.reflection;

import java.util.Map;

public class ReflectionM {

	public static void main(String[] args) {
		System.out.println("Refl0extion");
		ReflectionM reflectionM = new ReflectionM();
		
		Class<?> cl = reflectionM.getClass();
		int[] arr = new int[10];
		Class<?> c2 = arr.getClass();
		Class<?> c3 = "word".getClass();
		Class<?> c4 = Integer.valueOf(5).getClass();
		

		//System.out.println(c1);		//?
		System.out.println(c2);	//[I
		System.out.println(c3);	//java.lang.String
		System.out.println(c4);	//java.lang.Integer
		Class<?> c11 = ReflectionM.class;	//adv.reflection.ReflectionM
		Class<?> c31 = int[].class;	//[I

		System.out.println(c11);
		
		
		
		try {
			Class<?> c32 = Class.forName("java.lang.String");
			Class<?> c12 = Class.forName("[I");
			System.out.println(c32);	//java.lang.String
			System.out.println(c12);	//[I
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
		
		Class<?> c5 = Integer.class.getSuperclass(); //java.lang.Number
		System.out.println(c5);	
		Class<?> c51 = Integer.class.getEnclosingClass(); //null
		System.out.println(c51);	
		Class<?> c52 = Map.Entry.class.getEnclosingClass(); //java.util.Map
		System.out.println(c52);	
	}

}
