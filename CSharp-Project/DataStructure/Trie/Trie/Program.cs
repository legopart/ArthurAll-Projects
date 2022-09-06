using System.Data;

namespace Trie
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Main Method");
            Trie trie = new Trie();
            trie.Insert("cat");
            trie.Insert("can");
            trie.Insert("cant");
            trie.Insert("cant");
            System.Console.WriteLine(trie.Contains("cat"));
            System.Console.WriteLine(trie.Contains("caty"));
        }
    }
}