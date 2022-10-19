using System;
using System.Drawing;
using System.Reflection;
using System.Transactions;
using System.Runtime.InteropServices;




namespace MainLoop
{
    class Program
    {

        static private int count = 0;
        static void Main()
        {

            Console.WriteLine("main loop " + count ++ + " please press a key");
            Console.ReadLine();
            Main();
        }


    }
}








