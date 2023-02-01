// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;

using System;
using System.Net;
using System.Text;  // For class Encoding
using System.IO;
using System.Net.Http;
using System.Collections.Generic;



namespace NewConsoleApp1
{
    public class Program
    {

        class SomeList
        {
            public List<int> list = new();
        }


        private static void Main(string[] args)
        {



                //stor memoization by place

            Dictionary<int, SomeList> dic = new();
            dic.Add(1, new SomeList());
            dic.Add(2, new SomeList());
            dic.Add(3, new SomeList());


            Dictionary<int, SomeList> visited = new();
            var place1 = dic[1];
            visited.Add(1, place1);
            visited.Add(2, dic[2]);
            visited.Add(3, dic[3]);


            visited[2].list.Add(10);
            visited[2].list.Add(20);
            visited[2].list.Add(30);
            visited[2].list.Add(50);


            Console.WriteLine ( 
                "The 2nd place in dic is:"
                + string.Join(",", dic[2].list) 
            );




        }
    }
}

