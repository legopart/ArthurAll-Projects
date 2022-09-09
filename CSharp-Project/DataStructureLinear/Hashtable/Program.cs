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


            Console.WriteLine(FirstNonRepeatedChar("A Green Apple"));   //g
            Console.WriteLine(FirstRepeatedChar("A Green Apple"));      //e

        }

        static public char? FirstNonRepeatedChar(String str) 
        {   // A Green Apple
            Dictionary<char, int> map = new Dictionary<char, int>();    //HashMap
            foreach (var ch in str.ToLower()) {
                if (map.ContainsKey(ch)) map[ch]++;
                else map[ch] = 1;
            }
            foreach (var item in map)  if (item.Value == 1) return item.Key;
            // foreach (var ch in str.ToLower())  if (map[ch] == 1) return ch;
            return null;// char.MinValue;
        }

        static public char? FirstRepeatedChar(String str)
        {   // A Green Apple
            HashSet<char> set = new HashSet<char>(); //Set
            foreach (var ch in str.ToLower())
            {
                if (set.Contains(ch)) return ch;
                else set.Add(ch);
            }
            return null;// char.MinValue;
        }

    }
}