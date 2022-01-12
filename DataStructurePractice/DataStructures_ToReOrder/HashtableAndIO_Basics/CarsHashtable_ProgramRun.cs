using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.HashtableAndIO_Basics.Classes;

namespace DataStructures.HashtableAndIO_Basics
{
    public struct CarsHashtable_ProgramRun
    {
        public static void ProgramRun()
        {
            Car subaro = new Car()
            {
                name = "Legacy",
                year = 1999
            };
            Car mazda = new Car()
            {
                name = "3",
                year = 2000
            };


            Hashtable carHash = new Hashtable();
            carHash.Add(11, subaro);
            carHash.Add(12, mazda);

            Car f = (Car)carHash[11];
            Console.WriteLine(f.name);

            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");
            Hashtable hashTable = new Hashtable();

            hashTable.Add(123, "moshe");
            hashTable.Add(43, "fgdfgdv");
            hashTable.Add(534, "fhfh");
            hashTable.Add(0x5a, "rete");
            hashTable.Remove(43);
            string s = (string)hashTable[534];

            var o = hashTable[1111]; // ערך לא קיים
            bool k = hashTable.ContainsKey(123);
        }
    }

}

