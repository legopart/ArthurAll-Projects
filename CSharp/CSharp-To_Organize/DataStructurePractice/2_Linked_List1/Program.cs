using System;

namespace _2_Linked_List1
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedListDev linkedList = new LinkedListDev();

            Item itemHead = new Item();
            itemHead.name = "Cola";
            itemHead.price = 10;
            linkedList.ListAdd(itemHead);
            Console.WriteLine($"List of items");
            Console.WriteLine($"Item name: {linkedList.head.name}\t\tItem price: {linkedList.head.price}");

            Item someItem = new Item();
            someItem.name = "Bisli";
            someItem.price = 20;
            linkedList.ListAdd(someItem);

            // itemHead.next = someItem;
            // someItem.prev = itemHead;

            Console.WriteLine();


            linkedList.ListAdd("bamba", 30);
            linkedList.ListAdd("water", 40);

            linkedList.Remove("bamba");

            linkedList.PrintList();
        }
    }
}
