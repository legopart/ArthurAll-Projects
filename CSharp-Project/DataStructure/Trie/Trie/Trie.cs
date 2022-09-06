using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
    public class Trie
    {
        private class Node
        {
            private Dictionary<char, Node> words;           //use words instead chileds !
            private char value;
            public Boolean isEndOfWord;
            public Node(char ch)
            {
                value = ch;
                words = new Dictionary<char, Node>();
                isEndOfWord = false;
            }
            public bool IsEmpty() { return words.Count == 0; }
            public Node GetChild(char ch) { return words.GetValueOrDefault(ch, null); }
            public bool HasChild(char ch) { return words.ContainsKey(ch); }
            public void AddChild(char ch) { words.Add(ch, new Node(ch)); }
            public Node[] GetWords() { return words.Values.ToArray(); }     //use words instead chileds !
            public bool HasWords() { return words.Count != 0; }             //use words instead chileds !
            public void RemoveChild(char ch) { words.Remove(ch); }          //use words instead chileds !
        }
        Node root;
        public Trie()  {  root = new Node(' ');  }
        private bool IsNull(Node node) { return node == null; }
        private bool IsNull(String word) { return word == null; }

        public void Insert(String word) 
        {
            if (IsNull(word)) throw new Exception();
            var current = root;
            foreach(char ch in word.ToLower().ToCharArray())
            {
                if (!current.HasChild(ch)) {
                    current.AddChild(ch); 
                }
                current = current.GetChild(ch);
            }
            current.isEndOfWord = true;
        }
        public bool Contains(String word)
        {
            if (IsNull(word)) throw new Exception();
            var current = root;
            foreach (char ch in word.ToLower().ToCharArray())
            {
                if (!current.HasChild(ch)) return false;
                current = current.GetChild(ch);
            }
            return current.isEndOfWord;
        }

        //Traverse


/*        public override String ToString() { return root.ToString();  }*/
    }
}
