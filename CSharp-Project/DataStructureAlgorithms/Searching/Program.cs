namespace Searching
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

        }
    }
}
