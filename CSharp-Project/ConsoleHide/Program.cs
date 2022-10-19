using System;
using System.Drawing;
using System.Reflection;
using System.Transactions;
using System.Runtime.InteropServices;
static class ConsoleExtension
{
    const int SW_HIDE = 0;
    const int SW_SHOW = 5;
    readonly static IntPtr handle = GetConsoleWindow();
    [DllImport("kernel32.dll")] static extern IntPtr GetConsoleWindow();
    [DllImport("user32.dll")] static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    public static void Hide()
    {
        ShowWindow(handle, SW_HIDE); //hide the console
    }
    public static void Show()
    {
        ShowWindow(handle, SW_SHOW); //show the console
    }
}










namespace ConsoleHide
{
    class Program
    {


        static void Main()
        {   // try avoid to use it in debugger
            ConsoleExtension.Show();
            Console.WriteLine("console hide, please press key ");
            Console.ReadLine();
            ConsoleExtension.Hide();
            Console.WriteLine("now console is hidden ");
            Console.ReadLine();
        }
        ~Program(){ ConsoleExtension.Show(); }

    }
}








