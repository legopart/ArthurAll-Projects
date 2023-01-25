﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ex05.entities
{
    public class MainManager
    {
        private MainManager() { }
        private static readonly MainManager insance= new MainManager();
        public static MainManager Instance { get { return insance; } }

        public ProductManager ProductM = new ProductManager();

        public MessageManegaer MessageM = new MessageManegaer();
    }
}
