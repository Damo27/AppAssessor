//-----------------------------------------Objext class for a single object of an assessed interface--------------------------------
//-------------------------------------contains properties which are populated by the constructor-------------------------------
//------constructor receives a file name and iterates through all lines of the file to increment the respective accumulator-----
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AppAssessor.Models
{
    class InterfaceAssessment
    {
        public Assembly assembly { get; set; }
        public List<Type> classes { get; set; }
        public List<Type> interfaces { get; set; }

        public InterfaceAssessment(string file)
        {
            assembly = Assembly.LoadFrom(file);

            //select all types that are interfaces order be descending based on method count
            interfaces = assembly.GetTypes().Where(x => x.IsInterface).OrderByDescending(x => x.GetMethods().Count()).ToList();

            //select all types that are classes order be descending based on method count
            classes = assembly.GetTypes().Where(x => x.IsClass).OrderByDescending(x => x.GetMethods().Count()).ToList();

        }
    }
}
