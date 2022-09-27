namespace Searching
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[] { 7, 3, 1, 4, 6, 2, 3 };
            int target = 4;
            
            Console.WriteLine("LinearSearch.Searp0-=[ch: " + LinearSearch.Search(array, target) );
            Console.WriteLine();

            Array.Sort(array);  //!!! after sorting the array!

            Console.WriteLine("BinarySearch.SearchIterative " + BinarySearch.SearchIterative(array, target));
            Console.WriteLine("BinarySearch.SearchRecursion " + BinarySearch.SearchRecursion(array, target));
            Console.WriteLine();

            Console.WriteLine("TernarySearch.Search " + TernarySearch.Search(array, target));
            Console.WriteLine();

            Console.WriteLine("JumpSearch.Search " + JumpSearch.Search(array, target));
            Console.WriteLine();

            Console.WriteLine("ExponentialSearch.Search " + ExponentialSearch.Search(array, target));
            Console.WriteLine();
        }
    }
}
