
using Elias_DependencyInjection.drinks;
using System;

namespace Elias_DependencyInjection2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IDrink drink = new Pepsi();
        }

   
    }
}
