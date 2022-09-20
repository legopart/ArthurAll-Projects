using System.Transactions;

namespace CSharp_Project
{
    //polymorphism example
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

            Person person1 = new Person();
            Console.WriteLine("Person1 sayHi: " + person1.SayHi());

            Person italian1 = new Italiano();
            Console.WriteLine("Italian sayHi: " + italian1.SayHi());

        }
    }
}
           
