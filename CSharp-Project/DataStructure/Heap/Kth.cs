using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class Kth
    {
        public static int getKthLargest(int[] array, int kth)
        {
            if (kth > array.Length || kth < 1) throw new Exception();
            var heap = new Heap();
            foreach (var number in array) heap.Insert(number);

            for (int i = 0; i < kth -1; i++) heap.Remove();
            return heap.Max();//heap.Remove();
        }
    }
}
