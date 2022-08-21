package stream;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Comparator;
import java.util.List;


public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
	      // initialize array of Employees
	      Employee[] employees = {
	         new Employee("Jason", "Red", 5000, "IT"),
	         new Employee("Ashley", "Green", 7600, "IT"),
	         new Employee("Matthew", "Indigo", 3587.5, "Sales"),
	         new Employee("James", "Indigo", 4700.77, "Marketing"),
	         new Employee("Luke", "Indigo", 6200, "IT"),
	         new Employee("Jason", "Blue", 3200, "Sales"),
	         new Employee("Wendy", "Brown", 4236.4, "Marketing")};

	      // get List view of the Employees
	      List<Employee> list = Arrays.asList(employees);
	      List<Employee> list2=new ArrayList<>();
	      
	      list.stream()
          .filter(e -> (e.getSalary() >= 4000 && e.getSalary() <= 6000))
          .sorted(Comparator.comparing(Employee::getSalary)) //.thenComparing(
          .forEach(e -> list2.add(e));
	      
	      
	      System.out.println(list2);
	}

}
