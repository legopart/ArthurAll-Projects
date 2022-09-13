namespace Sorting
{
    class Program
    {
        static void Main()
        {
            int[] array;
            array = new int[] { 7, 3, 1, 4, 6, 2, 3 };
            BubbleSort.Sort(array);
            Console.WriteLine("BubbleSort.Sort: " + String.Join(", ", array));
            Console.WriteLine();

            array = new int[] { 7, 3, 1, 4, 6, 2, 3 };
            SelectionSort.Sort(array);
            Console.WriteLine("SelectionSort.Sort: " + String.Join(", ", array));
            array = new int[] { 7, 3, 1, 4, 6, 2, 3 };
            SelectionSort.Sort2(array);
            Console.WriteLine("SelectionSort.Sort2: " + String.Join(", ", array));
            Console.WriteLine();


            array = new int[] { 7, 3, 1, 4, 6, 2, 3 };
            InsertionSort.Sort(array);
            Console.WriteLine("InsertionSort.Sort: " + String.Join(", ", array));
            Console.WriteLine();

        }
    }
}