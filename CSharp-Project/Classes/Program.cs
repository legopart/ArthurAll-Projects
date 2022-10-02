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

    public class Program
    {

        private static void Main(string[] args)
        {
            Person john = Person.Parse("John");
            john.Intruduce("Mosh");

        }
    }
}

