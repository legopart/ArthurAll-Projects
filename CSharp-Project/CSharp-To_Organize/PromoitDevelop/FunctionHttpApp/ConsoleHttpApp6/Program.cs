using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace ConsoleApp1
{


    public class Program
    {

        static async Task Main(string[] args)
        {

        Console.ReadLine();
            Calc.CalcCode client = new Calc.CalcCode(new HttpClient());
            try
            {
                var Sueedded = await client.RunAsync("", "1", "2");
                Console.WriteLine("Sueedded");
            }
            catch (Exception ex) { Console.WriteLine("Fail"); Console.WriteLine(ex); }

            
        }





    }
}
