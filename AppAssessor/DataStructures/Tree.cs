//Code adapted from:
//Author: Marcin Jamro
//Book: C# Data Structures and Algorithms
//Publisher: Packt Publishing
//Year: 2018

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAssessor.Models
{
    public class Tree<T>
    {
        public TreeNode<T> Root { get; set; }
        private StringBuilder spaceString = new StringBuilder();
        private int depth = 0, greatestDepth = 0;
        public StreamWriter sw;

        public void print()
        {
            print(Root);
        }

        public void print(TreeNode<T> treeNode)
        {
            sw.WriteLine(String.Format("{0}{1}",spaceString,treeNode.Data.ToString()));
            foreach (TreeNode<T> child in treeNode.Children)
            {
                spaceString.Append("|    ");
                print(child);
                spaceString.Remove(0, 5);
            }
        }

        public int getDepth()
        {
            depth++;
            getDepth(Root);
            depth--;
            return greatestDepth;
        }

        public int getDepth(TreeNode<T> treeNode)
        {
            foreach (TreeNode<T> child in treeNode.Children)
            {
                depth++;
                if (depth > greatestDepth)
                {
                    greatestDepth = depth;
                }
                getDepth(child);
                depth--;
            }
            return greatestDepth;
        }
    }
}
