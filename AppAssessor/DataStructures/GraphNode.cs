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

namespace AppAssessor.DataStructures
{
    public class GraphNode<T>
    {
        public int Index { get; set; }
        public T Data { get; set; }
        public List<GraphNode<T>> Neighbors { get; set; } = new List<GraphNode<T>>();
        public List<int> Weights { get; set; } = new List<int>();

    }
}
