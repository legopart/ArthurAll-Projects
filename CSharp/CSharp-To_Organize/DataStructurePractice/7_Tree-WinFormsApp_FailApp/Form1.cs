using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeWinFormsApp
{
    public partial class Form1 : Form
    {
        public Tree myTree = new Tree();
        public Form1()
        {
            InitializeComponent();
            myTree.InitTree();


            TreeNode[] treenode = new TreeNode[Tree.MAX_ITEMS + 1];

            var place = treeView1.Nodes.Add(((Item)myTree.allItems[0]).Id.ToString());

            var place2 = place.Nodes.Add(((Item)myTree.allItems[1]).Id.ToString());

            var place4 = place2.Nodes.Add(((Item)myTree.allItems[3]).Id.ToString());
            var place5 = place2.Nodes.Add(((Item)myTree.allItems[4]).Id.ToString());

            place4.Nodes.Add(((Item)myTree.allItems[7]).Id.ToString());
            place4.Nodes.Add(((Item)myTree.allItems[8]).Id.ToString());
            place5.Nodes.Add(((Item)myTree.allItems[9]).Id.ToString());

            var place3 = place.Nodes.Add(((Item)myTree.allItems[2]).Id.ToString());

            var place6 = place3.Nodes.Add(((Item)myTree.allItems[5]).Id.ToString());
            var place7 = place3.Nodes.Add(((Item)myTree.allItems[6]).Id.ToString());

        }


    }
}
