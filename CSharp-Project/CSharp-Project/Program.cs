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

    //reverse and order the file

    class Program
    {
        static void Main()
        {

            Person person1 = new Person();  //hi
            Console.WriteLine("Person1 sayHi: " + person1.SayHi());

            Person italian1 = new Italiano();   //olla
            Console.WriteLine("Italian sayHi: " + italian1.SayHi());


        }



    }
}
           
