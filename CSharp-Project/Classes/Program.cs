using System;
using System.Net;
using System.Text;  // For class Encoding
using System.IO;
using System.Net.Http;
using System.Collections.Generic;

namespace Classes
{


    public class Person
    {
        public String Name;
        public void Intruduce(String to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
        static public Person Parse(String name)
        {
            Person person = new Person();
            person.Name = name;
            return person;

        }
    }


    public interface IAAA
    {
        static int b;
        int a { get; set; }
    }

    public class AAA : IAAA
    {
        public int a { get; set; }
    }



    class A
    {
        public virtual void a() { Console.Write("this is A"); }
    }
    class B: A
    {
        private void p() { Console.Write("this is B, a private methos"); }

        public override void a() { p(); }
    }

    public class Program
    {

        private static void Main(string[] args)
        {


            A a = new B();
            a.a();

            Person john = Person.Parse("John");
            john.Intruduce("Mosh");

            IAAA aaa = new AAA();

        }
    }
}

