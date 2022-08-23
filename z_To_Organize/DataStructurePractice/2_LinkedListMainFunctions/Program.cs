using System;

namespace _2_LinkedListMainFunctions
{
    public class Program
    {
        static void Main(string[] args)
        {

            Item head = new Item();
            head.name = "Cola";
            head.price = 10;
            Console.WriteLine($"List of items");
            Console.WriteLine($"Item name: {head.name}\t\tItem price: {head.price}");


            Item someItem = new Item();
            someItem.name = "Bisli";
            someItem.price = 20;

            head.next = someItem;
            someItem.prev = head;


            Console.WriteLine();


            ListAdd(head, "bamba", 30);
            ListAdd(head, "water", 40);

            Remove(ref head, "bamba");

            PrintList(head);
        }


        static void ListAdd(Item head, string name, int price)
        {
            //מגיעים לאיבר האחרון שלאחריו יש null
            Item actualItem = head;
            while (actualItem.next != null)
            {
                actualItem = actualItem.next;
            }

            Item NewItem = new Item();
            NewItem.name = name;
            NewItem.price = price;
            NewItem.prev = actualItem;
            actualItem.next = NewItem;
        }

        static void PrintList(Item head)
        {
            Item actualItem = head;
            Console.WriteLine($"List of items:");
            while (actualItem != null)
            {
                Console.WriteLine($"Item name: {actualItem.name} \t \t   Item price: {actualItem.price}");
                actualItem = actualItem.next;
            }
        }

        static void Remove(ref Item head, string name)
        {
            Item actualItem = head;

            //במקרה שמסירים איבר ראשון
            if (actualItem.name == name)
            {
                actualItem.next.prev = null;
                head = actualItem.next;
                return;
            }

            while (actualItem.next != null)
            {
                if (actualItem.name == name)
                {
                    actualItem.prev.next = actualItem.next;
                    actualItem.next.prev = actualItem.prev;
                    return;
                }
                actualItem = actualItem.next;
            }
            //במקרה שמסירים איבר אחרון
            if (actualItem.name == name)
            {
                actualItem.prev.next = null;
            }

        }
    }
}
