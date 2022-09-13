namespace Searching
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[] { 7, 3, 1, 4, 6, 2, 3 };
            int index = 4;
            
            Console.WriteLine("LinearSearch.Search: " + LinearSearch.Search(array, index) );
            Console.WriteLine();

            Array.Sort(array);

            Console.WriteLine("BinarySearch.SearchIterative " + BinarySearch.SearchIterative(array, index));
            Console.WriteLine("BinarySearch.SearchRecursion " + BinarySearch.SearchRecursion(array, index));
            Console.WriteLine();

            Console.WriteLine("TernarySearch.Search " + TernarySearch.Search(array, index));
            Console.WriteLine();

        }
    }
}
