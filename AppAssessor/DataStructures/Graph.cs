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
    public class Graph<T>
    {
        private bool _isDirected = false;
        private bool _isWeighted = false;
        public List<GraphNode<T>> Nodes { get; set; } = new List<GraphNode<T>>();

        public Graph(bool isDirected, bool isWeighted)
        {
            _isDirected = isDirected;
            _isWeighted = isWeighted;
        }
        public GraphEdge<T> this[int from, int to]
        {
            get
            {
                GraphNode<T> nodeFrom = Nodes[from];
                GraphNode<T> nodeTo = Nodes[to];
                int i = nodeFrom.Neighbors.IndexOf(nodeTo);
                if (i >= 0)
                {
                    GraphEdge<T> edge = new GraphEdge<T>()
                    {
                        From = nodeFrom,
                        To = nodeTo,
                        Weight = i < nodeFrom.Weights.Count
                    ? nodeFrom.Weights[i] : 0
                    };
                    return edge;
                }
                return null;
            }
        }
        private void UpdateIndices()
        {
            int i = 0;
            Nodes.ForEach(n => n.Index = i++);
        }

        public void RemoveNode(GraphNode<T> nodeToRemove)
        {
            Nodes.Remove(nodeToRemove);
            UpdateIndices();
            foreach (GraphNode<T> node in Nodes)
            {
                RemoveEdge(node, nodeToRemove);
            }
        }

        public GraphNode<T> AddNode(T value)
        {
            GraphNode<T> node = new GraphNode<T>() { Data = value };
            Nodes.Add(node);
            UpdateIndices();
            return node;
        }

        public List<GraphEdge<T>> GetEdges()
        {
            List<GraphEdge<T>> edges = new List<GraphEdge<T>>();
            foreach (GraphNode<T> from in Nodes)
            {
                for (int i = 0; i < from.Neighbors.Count; i++)
                {
                    GraphEdge<T> edge = new GraphEdge<T>()
                    {
                        From = from,
                        To = from.Neighbors[i],
                        Weight = i < from.Weights.Count
                    ? from.Weights[i] : 0
                    };
                    edges.Add(edge);
                }
            }
            return edges;
        }

        public void RemoveEdge(GraphNode<T> from, GraphNode<T> to)
        {
            int index = from.Neighbors.FindIndex(n => n == to);
            if (index >= 0)
            {
                from.Neighbors.RemoveAt(index);
                if (_isWeighted)
                {
                    from.Weights.RemoveAt(index);
                }
            }
        }

        public void AddEdge(GraphNode<T> from, GraphNode<T> to, int weight = 0)
        {
            from.Neighbors.Add(to);
            if (_isWeighted)
            {
                from.Weights.Add(weight);
            }
            if (!_isDirected)
            {
                to.Neighbors.Add(from);
                if (_isWeighted)
                {
                    to.Weights.Add(weight);
                }
            }
        }
        public List<GraphNode<T>> DFS()
        {
            bool[] isVisited = new bool[Nodes.Count];
            List<GraphNode<T>> result = new List<GraphNode<T>>();
            DFS(isVisited, Nodes[0], result);
            return result;
        }

        private void DFS(bool[] isVisited, GraphNode<T> node, List<GraphNode<T>> result)
        {
            result.Add(node);
            isVisited[node.Index] = true;
            foreach (GraphNode<T> neighbor in node.Neighbors)
            {
                if (!isVisited[neighbor.Index])
                {
                    DFS(isVisited, neighbor, result);
                }
            }
        }

    }
}
