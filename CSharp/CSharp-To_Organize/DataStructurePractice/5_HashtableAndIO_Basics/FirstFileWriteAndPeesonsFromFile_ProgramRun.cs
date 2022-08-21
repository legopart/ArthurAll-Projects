using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _5_HashtableAndIO_Basics.Classes;

namespace _5_HashtableAndIO_Basics
{
    public struct FirstFileWriteAndPeesonsFromFile_ProgramRun
    {
    public static void ProgramRun()
        {
            string s = "111111111";
            File.WriteAllText(@"c:\1\myFirstFile.txt", s);

            s = "\r\n2222222222";
            File.AppendAllText(@"c:\1\myFirstFile.txt", s);
            s = "\r\n33333333";
            File.AppendAllText(@"c:\1\myFirstFile.txt", s);
            s = "\r\n4444444";
            File.AppendAllText(@"c:\1\myFirstFile.txt", s);


            string fileContent = File.ReadAllText(@"c:\1\myFirstFile.txt");
            Console.WriteLine(fileContent);

            string[] allLines = File.ReadAllLines(@"c:\1\myFirstFile.txt");

            string[] allPersons = File.ReadAllLines(@"c:\1\persons.txt");

            Hashtable personsTable = new Hashtable();

            for (int i = 0; i < allPersons.Length; i++)
            {
                string PersonData = allPersons[i];
                string[] data = PersonData.Split(',');
                Person p = new Person();
                p.name = data[1];

                p.age = Int32.Parse(data[0]);
                p.email = data[2];

                personsTable.Add(p.age, p);
            }

            Person per = (Person)personsTable[20];
            Console.WriteLine("Person age 20 name:"+per.name);

        }
    }
}
