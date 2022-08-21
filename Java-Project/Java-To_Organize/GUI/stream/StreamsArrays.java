package stream;
// Fig. 17.6: ArraysAndStreams.java
// Demonstrating lambdas and streams with an array of Integers.
import java.util.Arrays;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;
import java.security.SecureRandom;
import java.util.Map;
import java.util.function.Function;
import java.util.stream.IntStream;
import java.util.stream.Collectors;

public class StreamsArrays
{
   public static void main(String[] args)
   {
      Integer[] values = {2, 9, 5, 0, 3, 7, 1, 4, 8, 6};

      // display original values
      System.out.printf("Original values: %s%n", Arrays.asList(values));

      // sort values in ascending order with streams
      System.out.printf("Sorted values: %s%n", 
         Arrays.stream(values)
               .sorted()
               .collect(Collectors.toList()));

      // values greater than 4
      List<Integer> greaterThan4 =
         Arrays.stream(values)
               .filter(value -> value > 4)
               .collect(Collectors.toList());
      System.out.printf("Values greater than 4: %s%n", greaterThan4);

      // filter values greater than 4 then sort the results
      System.out.printf("Sorted values greater than 4: %s%n",
         Arrays.stream(values)
               .filter(value -> value > 4)
               .sorted()
               .collect(Collectors.toList()));

      // greaterThan4 List sorted with streams
      System.out.printf(
         "Values greater than 4 (ascending with streams): %s%n",
         greaterThan4.stream()
               .sorted()
               .collect(Collectors.toList()));
      
      System.out.println();
      System.out.println();
      System.out.println();
      System.out.println();
      
      
      String[] strings = 
          {"Red", "orange", "Yellow", "green", "Blue", "indigo", "Violet"};

       // display original strings
       System.out.printf("Original strings: %s%n", Arrays.asList(strings));

       // strings in uppercase
       System.out.printf("strings in uppercase: %s%n",
          Arrays.stream(strings)
                .map(String::toUpperCase)
                .collect(Collectors.toList()));

       // strings greater than "m" (case insensitive) sorted ascending
       System.out.printf("strings greater than m sorted ascending: %s%n",
          Arrays.stream(strings)
                .filter(s -> s.compareToIgnoreCase("m") > 0)
                .sorted(String.CASE_INSENSITIVE_ORDER)
                .collect(Collectors.toList()));

       // strings greater than "m" (case insensitive) sorted descending
       System.out.printf("strings greater than m sorted descending: %s%n",
          Arrays.stream(strings)
                .filter(s -> s.compareToIgnoreCase("m") > 0)
                .sorted(String.CASE_INSENSITIVE_ORDER.reversed())
                .collect(Collectors.toList()));
       
       
       
       System.out.println();
       System.out.println();
       System.out.println();
       System.out.println();    
       
       
       SecureRandom random = new SecureRandom();

       // roll a die 6,000,000 times and summarize the results
       System.out.printf("%-6s%s%n", "Face", "Frequency");
       random.ints(6_000_000, 1, 7)
             .boxed()
             .collect(Collectors.groupingBy(Function.identity(),
                Collectors.counting()))
             .forEach((face, frequency) -> 
                System.out.printf("%-6d%d%n", face, frequency));
   }
   
   
   
} // end class ArraysAndStreams

/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
