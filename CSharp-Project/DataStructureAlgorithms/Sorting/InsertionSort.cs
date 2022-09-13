using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class InsertionSort
    {
        public static void Sort(int[] array)    //לחזור
        {

            for (var i = 1; i < array.Length; ++i)  //sorted half
            {
                var value = array[i];
                var place = i;
                while(place > 0 && array[place - 1] > value)
                {
                    array[place] = array[place - 1];
                    place--;
                }
                array[place] = value;
            }
        }
    }
}
