//------------------------------------------Object class of a single association assessment-----------------------------------
//-----------------------------------------contains properties set by the constructor--------------------------------------
using AppAssessor.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAssessor.Models
{
    class AssociationAssessment
    {
        public Assembly assembly { get; set; }
        public BindingFlags bindingFlags { get; set; }
        public Type[] classes { get; set; }

        public Graph<Type> graph { get; set; } = new Graph<Type>(false, false);

        public AssociationAssessment(string fileName)
        {
            assembly = Assembly.LoadFrom(fileName);
            classes = assembly.GetTypes();
            bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

            foreach (Type t in classes)
            {
                graph.AddNode(t);
            }

            foreach (Type t in classes)
            {
                foreach (FieldInfo field in t.GetFields(bindingFlags))
                {
                    graph.AddEdge(graph.Nodes.Where(x => x.Data == t).FirstOrDefault(),graph.Nodes.Where(x => x.Data == field.FieldType).FirstOrDefault());
                }
            }
        }
    }
}
