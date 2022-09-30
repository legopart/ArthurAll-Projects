using System;
using System.Transactions;


namespace CSharp_Project
{

    class A
    {

        
        int aInt;
        B? adjast; 

        ~A() { Console.WriteLine("ByeA");  }
    }

    class B 
    {
        int aInt;
        A? adjast;
        ~B() { Console.WriteLine("ByeA"); }
    }
    class Program
    {

        static void foo(int[] arr) { arr[2] = 5; }

        static void Main()
        {
            {
                //Console.WriteLine("-");
                //A a = new A();

                int[] arr = { 1, 2, 3 };
                foo(arr);
                Console.WriteLine(String.Join(", ", arr)); //{ 1, 2, 5 }

            }

        }


    }
}
           
