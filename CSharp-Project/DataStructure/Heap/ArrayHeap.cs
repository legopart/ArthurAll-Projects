using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class ArrayHeap
    {
        public static void Heapify(int[] array)
        {
            for (var i = array.Length / 2 - 1; i  >=0; i--) Heapify(array, i);
            //for(var i = 0; i < array.length; i++) heapify(array, i);
        }
        private static void Heapify(int[] array, int i)
        {
            var largerIndex = i;
            var leftIndex = i * 2 + 1;
            var rightIndex = i * 2 + 2;
            if (leftIndex < array.Length && array[leftIndex] > array[largerIndex]) largerIndex = leftIndex;
            if (rightIndex < array.Length && array[rightIndex] > array[largerIndex]) largerIndex = rightIndex;
            if (i == largerIndex) return;
            Swap(array, i, largerIndex);

        }
        private static void Swap(int[] array, int a, int b)
        {
            var temp = array[a];
            array[a] = array[b];
            array[a] = temp;
        }
    }
}
