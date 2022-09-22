using System;
using System.Transactions;

namespace CSharp_Project
{
    //oop polymorphism example
    class Person
    {
        public virtual String SayHi() 
        {
            return "hi";
        }
    }

    class Italiano : Person
    {
        public override String SayHi() 
        {
            String personSayHi = base.SayHi();  //hi
            return "olla";
        }

    }


    class Program
    {
        static void Main()
        {

            Person person1 = new Person();  //hi
            Console.WriteLine("Person1 sayHi: " + person1.SayHi());

            Person italian1 = new Italiano();   //olla
            Console.WriteLine("Italian sayHi: " + italian1.SayHi());

            int[] arr = { 1, 2, 3, 52};
            Console.WriteLine("Recursion Array: " + ArrayCount(arr));
            Console.WriteLine("Recursion Power: " + Power(5, 3));
            Console.WriteLine("Recursion Fibonacci: " + Fib(5));
        }



        public static int Fib(int a)
        {
            if (a < 1) throw new Exception();
            if (a == 1) return 1;
            if (a == 2) return 1;
            return Fib(a - 1) + Fib(a - 2);
        }



        public static int Power(int a, int times) 
        {
            if (times == 0) return 1; 
            return a * Power(a, times - 1);
        }



        private static int ArrayCount(int[] arr)
        {
            return ArrayCount(arr, 0);
        }
        public static int ArrayCount(int[] arr, int index) {
            //if (arr[index] == 52) return 1;
            try { var isNext = arr[index]; } catch (Exception) { return 0; }
            return 1 + ArrayCount(arr, index + 1) ;
        }


    }
}
           
