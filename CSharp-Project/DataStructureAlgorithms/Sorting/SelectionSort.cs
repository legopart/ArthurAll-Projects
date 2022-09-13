using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SelectionSort
    {

        public static void Sort(int[] array)
        {
            for (var i = 0; i < array.Length; ++i)
            {
                var selection = i;
                for (var j = i; j < array.Length - 1; ++j)
                    if (array[selection] > array[j]) selection = j;
                swap(array, i, selection);
            }
        }

        public static void Sort2(int[] array)
        {
            for (var i = 0; i < array.Length; ++i)
            {
                swap(array, i, FindMinIndex(array, i));
            }
        }

        public static int FindMinIndex(int[] array, int i)
        {
            var selection = i;
            for (var j = 0; j < array.Length; ++j)
                if (array[selection] > array[j]) selection = j;
            return selection;
        }

        private static void swap(int[] array, int a, int b)
        {
            var tmp = array[a];
            array[a] = array[b];
            array[b] = tmp;
        }
    }
}
