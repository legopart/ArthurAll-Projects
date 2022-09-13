using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BubbleSort
    {
        public static void Sort(int[] array) 
        {
            for (int i = 0; i < array.Length; ++i)
            {
                bool isSorted = true;
                for (int j = i; j < array.Length; ++j)
                    if (array[i] > array[j]) 
                    {
                        swap(array, i, j);
                        isSorted = false;
                    }
                if (isSorted) return;
            }
        }
        private static void swap(int[] array, int a, int b) 
        {
            var tmp = array[a];
            array[a] = array[b];
            array[b] = tmp;
        }
    }
}
