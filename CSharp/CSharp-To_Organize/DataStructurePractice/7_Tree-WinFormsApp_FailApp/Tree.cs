using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeWinFormsApp
{
    public class Tree
    {
        public Hashtable allItems = new Hashtable();
        public const int MAX_ITEMS = 10;
        Random random = new Random();
        public void InitTree()
        {
            Item head = new Item( 0 );
            allItems[0] = head;

            Item lastItem = head;
            for (int i = 1; i < MAX_ITEMS; i++) // ארגון רשימה
            {
                Item newItem = new Item( i );
                allItems.Add(i, newItem);
            }

            for (int i = 1; i < MAX_ITEMS; i++) // הגדרת בנים
            {
                Item parent = (Item) allItems[i];
                if(allItems[i * 2 + 1] !=null)
                    parent.Right = (Item) allItems[i*2+1];
                if (allItems[i * 2] != null)
                    parent.Left = (Item) allItems[i*2];

            }
        }
    }
}
