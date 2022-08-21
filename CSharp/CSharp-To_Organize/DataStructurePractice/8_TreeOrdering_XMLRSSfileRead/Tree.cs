using System;
using System.Collections.Generic;
namespace ConsoleApp1study
{
    public class Tree
    {
        public SortedTreeNode Root { get; set; }
        public List<SortedTreeNode> Nodes { get; set; }

        public void Init(int val)
        { 
            Root = new SortedTreeNode();
            Root.Val = val;
            Root.Level = 0;
        }



        public void AddItem(int val)
        {
            SortedTreeNode previuesNode = Root;
            SortedTreeNode currentNode = Root;
            int currentLevel = 0; //currentNode.Level
            while (currentNode != null)
            {
                previuesNode = currentNode;
                if (currentNode.Val <= val)
                    currentNode = currentNode.Right;
                else
                    currentNode = currentNode.Left;
                currentLevel++;
            }

            currentNode = new SortedTreeNode();
            currentNode.Val = val;
            currentNode.Level = currentLevel + 1;

            if (previuesNode.Val <= val)
                previuesNode.Right = currentNode;
            else
                previuesNode.Left = currentNode;
        }

        public void printLeft(SortedTreeNode node) 
        {
            if(node != null)
            {
                printLeft(node.Left);
                Console.Write($"{node.Val}, ");
                printLeft(node.Right);
            }
        }

        public void PrintSortedTree() => printLeft(Root);

        }
}
