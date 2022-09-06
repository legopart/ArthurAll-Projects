﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Trie
{
    public class Trie
    {
        private class Node
        {
            private Dictionary<char, Node> Words{ get; set; }      //jave HashMap       //used Words instead Chileds !
            public char Value { get; set; }
            public Boolean IsEndOfWord { get; set; }
            public Node(char ch)
            {
                Value = ch;
                Words = new Dictionary<char, Node>();
                IsEndOfWord = false;
            }
            public bool IsEmpty() { return Words.Count == 0; }
            public Node? GetWord(char ch) { return Words.GetValueOrDefault(ch, null); } //used Word instead Chiled !
            public bool HasWord(char ch) { return Words.ContainsKey(ch); }              //used Word instead Chiled !
            public void AddWord(char ch) { Words.Add(ch, new Node(ch)); }               //used Word instead Chiled !
            public void RemoveWord(char ch) { Words.Remove(ch); }                      //used Word instead Chiled !
            public Node[] GetWords() { return Words.Values.ToArray(); }                 //used Words instead Chileds !
            public bool HasWords() { return Words.Count != 0; }                         //used Words instead Chileds !

        }
        private Node Root { get; set; }
        public Trie()  {  Root = new Node(' ');  }
        private bool IsNull(Node? node) { return node == null; }
        private bool IsNull(String? word) { return word == null; }

        public void Insert(String word) 
        {
            if (IsNull(word)) throw new Exception();
            var current = Root;
            foreach(char ch in word.ToLower().ToCharArray())
            {
                if (!current.HasWord(ch))  current.AddWord(ch); 
                current = current.GetWord(ch);
            }
            current.IsEndOfWord = true;
        }
        public bool Contains(String word)
        {
            if (IsNull(word)) throw new Exception();
            var current = Root;
            foreach (char ch in word.ToLower().ToCharArray())
            {
                if (!current.HasWord(ch)) return false;
                current = current.GetWord(ch);
            }
            return current.IsEndOfWord;
        }

        public void Remove(String word) { Remove(word, 0, Root); }

        private void Remove(String word, int index, Node? node)
        {   //לחזור
            if (index == word.Length)
            {
                node!.IsEndOfWord = false;
                Console.WriteLine("last:" + node.Value);
                return;
            }
            var ch = word[index];
            var next = node.GetWord(ch);
            if (IsNull(next)) return;
            Remove(word, index +1, next);
            if (!next.HasWords() && !next.IsEndOfWord) node.RemoveWord(ch); //!!!
            Console.WriteLine("0:" + node.Value);

        }

        //Traverse
        public String TraversePreOrder() { String str=""; TraversePreOrder(Root, ref str); return str.Trim() + "\n"; }
        private void TraversePreOrder(Node node, ref String str)
        {
            str += node.Value;  //Console.Write(node.Value);
            foreach (var ch in node.GetWords()) TraversePreOrder(ch, ref str);
            str += " ";         //Console.Write(" ");
        }

        public void TraversePostOrder() { TraversePostOrder(Root); }
        private void TraversePostOrder(Node node)
        {
            Console.Write(" ");
            foreach (var ch in node.GetWords()) TraversePostOrder(ch);
            Console.Write(node.Value);
        }

        public List<String> FindWords(string word) //לחזור
        {
            List<String> wordList = new List<String>();    //java ArrayList<>
            var startNode = FindWordEnd(word);    //startPoint
            FindWords(word, wordList, startNode);
            return wordList;
        }
        private void FindWords(string word, /*ref*/ List<String> wordList, Node node)
        {
            if (node.IsEndOfWord) wordList.Add(word);
            foreach(var ch in node.GetWords()) FindWords(word + ch.Value, wordList, ch);
        }
        private Node? FindWordEnd(string word)
        {
            var current = Root;
            foreach (var ch in word.ToArray())
            {
                var next = current.GetWord(ch);
                if (IsNull(next)) return null;
                current = next;
            }
            return current;
        }

        public override String ToString() { return TraversePreOrder();  }
    }
}
