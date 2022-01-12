using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public class LinkedListDev
    {
        public Item head;

        public LinkedListDev () 
        {
            head = null;
        }

        public void ListAdd(Item item) { ListAdd(item.name, item.price); }


        public void ListAdd(string name, int price)
        {
            Item NewItem = new Item();
            NewItem.name = name;
            NewItem.price = price;
            if (head == null) { head = NewItem; return; }


                //מגיעים לאיבר האחרון שלאחריו יש null
                Item actualItem = head;
            while (actualItem.next != null)
            {
                actualItem = actualItem.next;
            }
            NewItem.prev = actualItem;
            actualItem.next = NewItem;
        }

        public void PrintList()
        {
            Item actualItem = head;
            Console.WriteLine($"List of items:");
            while (actualItem != null)
            {
                Console.WriteLine($"Item name: {actualItem.name} \t \t   Item price: {actualItem.price}");
                actualItem = actualItem.next;
            }
        }

        public void Remove(string name)
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
