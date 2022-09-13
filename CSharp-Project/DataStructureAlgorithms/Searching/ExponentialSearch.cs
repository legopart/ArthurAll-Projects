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
            int bound = 1;
            while (bound < array.Length && array[bound] < target) bound *= 2;
            int[] newArray = array[(bound/2)..Math.Min(bound, array.Length)];
            return bound/2 + Array.BinarySearch(newArray, target);//BinarySearch.SearchRecursion(newArray, target);
        }
    }
}
