using System;

namespace CanConstruct_CountConstruct_AllConstruct
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(CanConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" })); // true
            Console.WriteLine(CanConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "boar" })); // false
            Console.WriteLine(CanConstruct("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" })); // true

            Console.WriteLine("Count Construct Brut " + CountConstructBrut("purple", new string[] { "purp", "p", "ur", "le", "purpl" })); // true

            Console.WriteLine("Count Construct Memo " + CountConstruct("purple", new string[] { "purp", "p", "ur", "le", "purpl" })); // true
            Console.WriteLine("Count Construct Memo " + CountConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] { "e", "ee", "eee", "eeeee", "eeeeeee" })); // true

            Console.WriteLine("////");

      //      Console.WriteLine("HowSum Brut: " + String.Join(",", HowSum(7, new int[] { 2, 3 })));


        }




        public static int CountConstruct(String target, String[] wordsBank)
        {
            Dictionary<string, int> memo = new Dictionary<string, int>() { /*[0] = true*/ };
            //memo[0] = true;
            return CountConstruct(target, wordsBank, memo);
        }
        private static int CountConstruct(String target, String[] wordsBank, Dictionary<string, int> memo) //  O(n^m) <-O(n^hmax) space O(m^2)    m=targer sum n=array length
        {
            if (target is null) return 0;
            if (memo.ContainsKey(target)) return memo[target];
            if (target.Length == 0) return 1;

            int totalCount = 0;
            foreach (var word in wordsBank) //only prefixes
            {
                if (target.IndexOf(word) == 0)
                {
                    var suffix = target.Substring(word.Length);
                    var numberWays = CountConstruct(suffix, wordsBank, memo);
                    totalCount += numberWays;
                    
                }
            }
            memo[target] = totalCount;
            return totalCount;
        }





        public static int CountConstructBrut(String target, String[] wordsBank) //  O(n^m) <-O(n^hmax) space O(m^2)    m=targer sum n=array length
        {
            if (target is null) return 0;
            if (target.Length == 0) return 1;
            int totalCount = 0;
            foreach (var word in wordsBank) //only prefixes
            {
                if (target.IndexOf(word) == 0)
                {
                    var suffix = target.Substring(word.Length);
                    if (CountConstructBrut(suffix, wordsBank) == 1)
                    {
                        totalCount += 1;
                    }
                }
            }
            return totalCount;
        }






        // CanSum
        public static bool CanConstruct(String target, String[] wordsBank)
        {
            Dictionary<string, bool> memo = new Dictionary<string, bool>() { /*[0] = true*/ };
            //memo[0] = true;
            return CanConstruct(target, wordsBank, memo);
        }
        private static bool CanConstruct(String target, String[] wordsBank, Dictionary<string, bool> memo) //  O(n^m) <-O(n^hmax) space O(m^2)    m=targer sum n=array length
        {
            if (target is null) return false;
            if (memo.ContainsKey(target)) return memo[target];
            if (target.Length == 0) return true;
            foreach (var word in wordsBank) //only prefixes
            {
                if (target.IndexOf(word) == 0)
                {
                    var suffix = target.Substring(word.Length);

                    if (CanConstruct(suffix, wordsBank, memo)) 
                    {
                        memo[suffix] = true;    //he used  memo[target]
                        return true; 
                    }
                }
            }
            return false;
        }



        // canSum(7, [5, 3, 4, 7]) -> true
        //          7
        //      2   4   3   0   for7 , after traveling

        // canSum(7, [2, 4]) -> false

        public static bool CanConstructBrut(String target, String[] wordsBank) //  O(n^m) <-O(n^hmax) space O(m^2)    m=targer sum n=array length
        {
            if (target is null) return false;
            if (target.Length == 0) return true;
            foreach (var word in wordsBank) //only prefixes
            {
                if (target.IndexOf(word) == 0)
                {
                    var suffix = target.Substring(word.Length);
                    if ( CanConstructBrut(suffix, wordsBank) ) return true;
                }
            }
            return false;
        }




    }
}