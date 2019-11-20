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
    public class GraphEdge<T>
    {
        public GraphNode<T> From { get; set; }
        public GraphNode<T> To { get; set; }
        public int Weight { get; set; }
        public override string ToString()
        {
            return $"Edge: {From.Data} -> {To.Data}, weight: { Weight}";
        }
    }
}
