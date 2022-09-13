using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    public class JumpSearch // לחזור!!
    {
        public static int Search(int[] array, int target)
        {
            int blockSize = (int)Math.Sqrt(array.Length);
            int place = 0;
            int next = blockSize;
            while (place < array.Length && array[next -1] < target)
            {
                place = next;   //if (start >= array.length) break;	//edge case
                next += blockSize;
                if (next > array.Length) next = array.Length;
            }
            for (var i = place; i < next; i++) if (array[i] == target) return i;
            return -1;
        }
    }
}
