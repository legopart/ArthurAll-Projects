using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeWinFormsApp
{
    public class Item
    {
        public int Id;
        //public Item Head = null;
        public Item Left = null;
        public Item Right = null;

        public Item (int id)
        {
            Id = id;
        }
}
}
