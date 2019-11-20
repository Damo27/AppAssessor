//Code adapted from:
//Author: Marcin Jamro
//Book: C# Data Structures and Algorithms
//Publisher: Packt Publishing
//Year: 2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAssessor.Models
{
    public class TreeNode<T>
    {
        public T Data { get; set; }
        public TreeNode<T> Parent { get; set; }
        public List<TreeNode<T>> Children { get; set; }

        public TreeNode treeNode { get; set; }
        public int GetHeight()
        {
            int height = 1;
            TreeNode<T> current = this;
            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }
            return height;
        }
    }
}
