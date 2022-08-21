using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            
            




            Console.WriteLine("Hello World!");
        }











        public static async Task fooAsync() 
        {
            ApiAccessor _apiAccessor = new ApiAccessor();
        //    var isSueedded = await _apiAccessor.SendAsync(textBoxName.Text, int.Parse(maskedTextBoxValue.Text));
        }



        class ApiAccessor
        {
           // private readonly APIDemo.Client _client = new APIDemo.Client(new HttpClient());
            public async Task<bool> SendAsync(string name, int value)
            {
                try
                {
                 //   await _client.SendAsync(new APIDemo.Data { Name = name, Value = value });
                    return true;
                }catch { return false; }
                
            }
        }

    }
}
