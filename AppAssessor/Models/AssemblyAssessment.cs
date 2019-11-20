//------------------------------------------Object class of a single assembly assessment-----------------------------------
//-----------------------------------------contains properties set by the constructor--------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AppAssessor.Models
{
    class AssemblyAssessment
    {
        public Assembly assembly { get; set; }
        public List<Type> classes { get; set; }
        public List<AssemblyName> assemblyNames { get; set; }

        public AssemblyAssessment(string file)
        {
            assembly = Assembly.LoadFrom(file);
            classes = assembly.GetTypes().Where(x => x.IsClass).OrderByDescending(x => x.GetMethods().Count()).ToList();
            assemblyNames = assembly.GetReferencedAssemblies().ToList();
        }
    }
}
