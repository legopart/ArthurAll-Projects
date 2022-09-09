using System.Data;

namespace Hashtable
{
    class Program
    {
        static void Main()
        {
            //לחזור על HashSet
            Dictionary<int, String> map = new Dictionary<int, String>();
            map.Add(1, "Mosh");
            map.Add(2, "Josh");
            map.Add(3, "Mary");
            map.Remove(2);
            map.Select(i => $"{i.Key}: {i.Value}").ToList().ForEach((x) => Console.Write(" | " + x + " | "));
            Console.WriteLine();
            Console.WriteLine(map[3]);
            Console.WriteLine(map.ContainsKey(3)); //O(1)
            Console.WriteLine(map.ContainsValue("Mosh")); //O(n)
            foreach (var item in map) Console.Write(item.Key + " " + item.Value + "\n");
            //Values /Keys


            Console.WriteLine(firstNonRepeatedChar("A Green Apple"));
        }
        static public char? firstNonRepeatedChar(String str) 
        {   // A Green Apple
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (var ch in str.ToLower()) {
                if (map.ContainsKey(ch)) map[ch]++;
                else map[ch] = 1;
            }
            foreach (var item in map) {
                if (item.Value == 1) return item.Key;
            }

            return null;
        }
/*        static public String reverseString(String str) 
        {
        }*/
    }
}