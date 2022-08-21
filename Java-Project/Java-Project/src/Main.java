//package newProject;
///2
import java.awt.Point;
import java.util.Arrays;
import java.util.Date;
import java.util.Scanner;

public class Main {
	
    public static void main(String args[]) {
    	int age = 30, temprature = 20;
    	age = 35;
    	long a = 3_121_234_343L;
    	float b = 10.99F;
    	Date now = new Date();
    	//now.getTime();
    	Point point1 = new Point(1, 1); //x=1, y=1
    	Point point2 = point1;	//Reference in memory
        System.out.println("hello world");
        
        String str = "abc";
        str.length();
        System.out.println(  str.indexOf("bc") ); //1
        System.out.println( str.replace("bc", "xyz") );	//parameters = arguments
        str.trim();
        str.toLowerCase();
        System.out.println( str );	//still abc !!
        
        int[] numbers = new int[5];
        numbers[0] = 1;
        numbers[1] = 2;
        System.out.println(  Arrays.toString(numbers) );	//method overloading
        
        int[] numbers2= {2, 4 ,6 ,1 ,4};
        System.out.println(  numbers2.length );
        
        Arrays.sort(numbers2);
        System.out.println(  Arrays.toString(numbers2) );
        
        int[][] numbers3 = new int[5][5];
        Arrays.deepToString(numbers3);
        
        short x = 1;
        int y = x + 2;	// Implicit Casting // byte > short > int > long > float > double
        				// no chance data lost
        
        //explicit
        String e = "1";
        double f = 1.1;
        int g = (int)f + 1 + Integer.parseInt(e);	//3	//parse have to use try/catch
        System.out.println(  g );
        Math.round(f);	//1
        Math.ceil(f);	//2
        Math.floor(f);
        Math.max(1, 2);
        int rnd = (int) (Math.random()*100);
        System.out.println(  rnd );
        
        
        
        Scanner scanner = new Scanner(System.in);
        //String strr = scanner.nextLine();
        //int aaaa = scanner.nextInt();
        
        
        //strInput.equals("hello")
    }
    
    
}
