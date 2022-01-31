using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static HttpClient ApiClient { get; set; }
        static async Task Main(string[] args)
        {

            //private file will incluad the keys and the app for Twitte
            Console.WriteLine("Hello World!");
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            string url = "https://api.twitter.com/1.1/search/tweets.json?q=%40legopart";



            using HttpResponseMessage response = await ApiClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStreamAsync(); //ReadAsAsync

                //   return result.Results;
            }
        }
    }
}
