using System;
using System.Net;
using System.Text;  // For class Encoding
using System.IO;
using System.Net.Http;
using System.Collections.Generic;

namespace FunctionCallConsole
{
    public class Program
    {
        static async Task Main(string[] args)
        {

            string url = "http://localhost:7071/api/GetUser";
            
            while (true)
            {
                Console.WriteLine("Posting Program");
                Console.WriteLine("Please set the name:");
                System.ConsoleColor originalColor = Console.ForegroundColor;
                Console.ForegroundColor = System.ConsoleColor.Blue;

                string name = Console.ReadLine();

                Console.ForegroundColor = originalColor;

                //PostRequest(url, name.Trim());

                //get
                if (!string.IsNullOrEmpty(name.Trim())) url += $"?name={name.Trim()}";
                GetRequest(url);

                System.Threading.Thread.Sleep(3500);
                Console.WriteLine();
            }
        }

        /*
        public async static Task<TOut> PostRequestAlon<TIn, TOut>(string url, TIn data = default(TIn))
        {
            var a = FormatRequestUri(url);

                return null;
        }
        */


        async static void PostRequest(string url, string name) // another check method 
        {
            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("name", name)

            };
            using HttpContent q = new FormUrlEncodedContent(queries);
            using HttpClient client = new HttpClient();

            using HttpResponseMessage response = await client.PostAsync(url, q);
            using HttpContent content = response.Content;

            string mycontent = await content.ReadAsStringAsync();
            Console.WriteLine("Post order sent ...");

                System.ConsoleColor originalColor = Console.ForegroundColor;
                Console.ForegroundColor = System.ConsoleColor.Green;

            Console.WriteLine(mycontent);

                Console.ForegroundColor = originalColor;  
        }

        async static void GetRequest(string url)
        {
                using HttpClient client = new HttpClient();

                using HttpResponseMessage response = await client.GetAsync(url);

                using HttpContent content = response.Content;
                    
                string mycontent = await content.ReadAsStringAsync();
                Console.WriteLine("Get order sent ...");

                //Response
                System.ConsoleColor originalColor = Console.ForegroundColor;
                Console.ForegroundColor = System.ConsoleColor.Green;
                Console.WriteLine(mycontent);
                Console.ForegroundColor = originalColor;
                    
                
            
        }

    }
}

