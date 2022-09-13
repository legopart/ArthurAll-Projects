using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    public class ExponentialSearch
    {
        public static int Search(int[] array, int target)
        {
            int range = 1;
            while (range < array.Length && array[range] < target) range *= 2;
            int[] newArray = array[(range/2)..(Math.Min(range, array.Length) + 1)];
            return range/2 + Array.BinarySearch(newArray, target);//BinarySearch.SearchRecursion(newArray, target);
        }
    }
}
