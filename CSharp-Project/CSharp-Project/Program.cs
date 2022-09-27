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
      
        static void Main()
        {
            {
                Console.WriteLine("-");
                A a = new A();
            }

        }


    }
}
           
