﻿using System;

namespace Can_Sum
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(CanSum(7, new int[] { 5, 3, 4, 7 })); // true
            Console.WriteLine(CanSum(7, new int[] { 2, 4 })); // false

            Console.WriteLine(CanSumImproved(7, new int[] { 5, 3, 4, 7 })); // true
            Console.WriteLine(CanSumImproved(7, new int[] { 2, 4 })); // false


            Console.WriteLine("////");
            Console.WriteLine(  String.Join("," ,HowSum(7, new int[] { 5, 3, 4, 7 })));
        }




        public static List<int>? HowSum(int sumTarget, int[] numbers) //  O(n^m) <-O(n^hmax) space O(m)    m=targer sum n=array length
        {
            Dictionary<int, List<int>> memo = new Dictionary<int, List<int>>() { /*[0] = true*/ };
            //memo[0] = true;
            return HowSum(sumTarget, numbers, memo);
        }
        public static List<int>? HowSum(int sumTarget, int[] numbers, Dictionary<int, List<int>> memo) //  O(n^m) <-O(n^hmax) space O(m)    m=targer sum n=array length
        {

            if (memo.ContainsKey(sumTarget)) return memo[sumTarget];
            if (sumTarget == 0) { return new(); } //{  }
            if (sumTarget < 0) return null;
            foreach (var num in numbers)
            {
                var remainder = sumTarget - num;


                List<int>? remainderList = HowSum(remainder, numbers, memo);

                if (remainderList != null) { remainderList.Add(remainder); return remainderList; /*memo[remainder]*/ }   //reminder from the sum
            }
            memo[sumTarget] = null;
            return null; /*memo[sumTarget]*/
        }




        // CanSum
        public static bool CanSumImproved(int sumTarget, int[] numbers) //  O(n^m) <-O(n^hmax) space O(m)    m=targer sum n=array length
        {
            Dictionary<int, bool> memo = new Dictionary<int, bool>() { /*[0] = true*/ };
            //memo[0] = true;
            return CanSumImproved(sumTarget, numbers, memo);
        }
        private static bool CanSumImproved(int sumTarget, int[] numbers, Dictionary<int, bool> memo) //  O(n^m) <-O(n^hmax) space O(m)    m=targer sum n=array length
        {
            if (sumTarget == 0) { return true; }
            if (sumTarget < 0) return false;
            foreach (var num in numbers) 
            {
                var remainder = sumTarget - num;
                if (CanSumImproved(remainder, numbers, memo)) { memo[remainder] = true; return true; /*memo[remainder]*/ }   //reminder from the sum
            }
            memo[sumTarget] = false;
            return false; /*memo[sumTarget]*/
        }



        // canSum(7, [5, 3, 4, 7]) -> true
        //          7
        //      2   4   3   0   for7 , after traveling

        // canSum(7, [2, 4]) -> false

        public static bool CanSum(int sumTarget, int[] numbers) //  O(n^m) <-O(n^hmax) space O(m)    m=targer sum n=array length
        {
            if (sumTarget == 0) return true;
            if (sumTarget < 0) return false;
            foreach (var num in numbers)    //after all possibilities
            {
                var remainder = sumTarget - num;
                if(CanSum(remainder, numbers)) return true ;    //reminder from the sum
            }
            return false;
        }




    }
}