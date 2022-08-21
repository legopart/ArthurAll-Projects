using ExternalDll;
using MyToolsLibarary;
using System;
using System.Collections;
using System.Collections.Generic;
namespace ConsoleApp2TimeStamp
{
    internal class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine($"From ExternalDll: {MyTools.GetMyName("Arthur")}");


            DateTime dt1 = new DateTime();
            DateTime dt2 = new DateTime();
            TimeSpan ts1;
            TimeSpan ts2;
            dt1 = DateTime.Now;
            dt2 = DateTime.Now;

            TimeTaker timetaker = new TimeTaker();

            int size = 1000000;

            timetaker.Start();
            for (int i = 0; i < size; i++)
            {
                // Console.WriteLine(i);
            }
            timetaker.Stop();
            Console.WriteLine($"for ({size} times):{timetaker.GetDiff()}");

            timetaker.Start();
            dt1 = DateTime.Now;
            Hashtable ht = new System.Collections.Hashtable();
            for (int i = 0; i < size; i++)
            {
                ht.Add(i, i);
            }
            dt2 = DateTime.Now;
            ts1 = new TimeSpan(dt1.Ticks);
            ts2 = new TimeSpan(dt2.Ticks);
            timetaker.Stop();
            Console.WriteLine($"Hashtable ({size} times): {(ts2 - ts1).TotalMilliseconds} -previus main method");
            Console.WriteLine($"Hashtable ({size} times):{timetaker.GetDiff()} - newer reference method");

            timetaker.Start();
            Queue<int> q = new Queue<int>();
            for (int i = 0; i < size; i++)
            {
                q.Enqueue(i);
            }
            timetaker.Stop();
            Console.WriteLine($"Queue ({size} times):{timetaker.GetDiff()}");

            timetaker.Start();
            Stack<int> s = new Stack<int>();
            for (int i = 0; i < size; i++)
            {
                s.Push(i);
            }
            timetaker.Stop();
            Console.WriteLine($"Stack ({size} times):{timetaker.GetDiff()}");
        }
    }
}
