using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{
    public class HashtableLinkedList
    {
        private class Pair
        {
            public int Key { get; set; }
            public String Value { get; set; }
            public Pair(int key, String value) { Key = key; Value = value; }
        }
        private List<Pair>[] Pairs { get; set; }
        public HashtableLinkedList() { Pairs = new List<Pair>[5]; } //5 !!!
        private int Hash(int key) { return key % Pairs.Length; }
        private bool StartList(int key)
        {
            var list = GetList(key);
            if (list == null) { Pairs[Hash(key)] = new List<Pair>(); return true; }
            return false;
        }
        private List<Pair> GetList(int key) { return (List<Pair>)Pairs.GetValue(Hash(key))!; }
        private Pair? GetPair(int key)
        {
            var list = GetList(key);
            if (list is null) return null;
            foreach (var pair in list) if (pair.Key == key) return pair;
            return null;
        }
        public String? GetValue(int key)
        {
            var pair = GetPair(key);
            return pair is null ? null : pair.Value;
        }

        public void Put(int key, String value)
        {   // לחזור!
            var bucket = GetList(key);
            var pair = GetPair(key);
            if (! (StartList(key) || pair is null)) { pair.Value = value; return; }
            Pairs[Hash(key)].Add(new Pair(key, value));   //add last ?
        }

        public void Remove(int key)
        {
            var list = GetList(key);
            var pair = GetPair(key);
            if (list is null) throw new Exception();
            //foreach (var e in list) if (e.Key == key) { list.Remove(e); return; }
            list.Remove(pair!);
        }
        public override string ToString()
        {
            String str = "";
            int i = 1;
            foreach ( var list in Pairs)
            {
                if (list is null) continue;
                foreach (var pair in list) 
                {
                    str += " | " + i + ")" + pair.Key + " " + pair.Value + " | ";
                }
                i++;
            }
            return str;
        }
    }
}
