using System.Data;

namespace Heap
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("heap");
            Heap heap = new Heap();
            heap.Insert(20);
            heap.Insert(10);
            heap.Insert(5);
            heap.Insert(2);
            heap.Remove();
            Console.WriteLine(heap);
        }
    }
}