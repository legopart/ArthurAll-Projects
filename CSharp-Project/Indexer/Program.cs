

namespace Indexer
{ 
    public class HttpCookie
    {
        readonly private Dictionary<String, String> _dictionary;
        public DateTime Expiry { get; set; }
        public HttpCookie()
        {
            _dictionary = new Dictionary<String, String>();
        }
        public String this[String key] 
        {  
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
        // longer
        public void SetItem(String key, String value) { _dictionary[key] = value; }
        public string GetItem(String key) { return _dictionary[key]; }
    }



    public class Indexer
    {
        public static void Main()
        {
            Console.WriteLine("Indexer:");
            var cookie = new HttpCookie();
            cookie["Name"] = "Arthur";

            Console.WriteLine(cookie["Name"]);


        }
    }
}