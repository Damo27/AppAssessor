//------------------------------------------Object class of a single hierarchy assessment-----------------------------------
//-----------------------------------------contains properties set by the constructor--------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAssessor.Models
{
    class HierarchyAssessment
    {
        public Assembly assembly { get; set; }
        public Tree<Type> hierarchyTree { get; set; }
        public List<Type> types { get; set; }
        public List<Type> baseClasses { get; set; }
        public List<Type> allTypes { get; set; }
        public List<Tree<Type>> typeTrees { get; set; }
        public List<TreeNode> treeNodes { get; set; }
        public List<TreeNode<Type>> myTreeNodes { get; set; }

        public HierarchyAssessment(String file)
        {
            assembly = Assembly.LoadFrom(file);

            types = assembly.GetTypes().ToList();
            baseClasses = new List<Type>();
            allTypes = new List<Type>();
            treeNodes = new List<TreeNode>();
            myTreeNodes = new List<TreeNode<Type>>();
            typeTrees = new List<Tree<Type>>();

            foreach (Type type in types)
            {
                Type temp = type;
                Type tempBase = type;

                while (tempBase != null)
                {
                    allTypes.Add(tempBase);
                    temp = tempBase;
                    tempBase = tempBase.BaseType;
                }
                baseClasses.Add(temp);
            }

            baseClasses = baseClasses.Distinct().ToList();
            allTypes = allTypes.Distinct().ToList();
            foreach (Type type in allTypes)
            {
                treeNodes.Add(new TreeNode(type.Name));
                myTreeNodes.Add(new TreeNode<Type> { Data = type, treeNode = new TreeNode(type.Name), Children = new List<TreeNode<Type>>() });
            }

            foreach (Type baseType in allTypes)
            {
                foreach (Type subType in allTypes.Where(x => x.BaseType == baseType))
                {
                    treeNodes.Where(m => m.Text == baseType.Name).FirstOrDefault().Nodes.Add(treeNodes.Where(m => m.Text == subType.Name).FirstOrDefault());
                    myTreeNodes.Where(m => m.Data == baseType).FirstOrDefault().Children.Add(myTreeNodes.Where(m => m.Data == subType).FirstOrDefault());
                    myTreeNodes.Where(m => m.Data == subType).FirstOrDefault().Parent = myTreeNodes.Where(m => m.Data == baseType).FirstOrDefault();
                    myTreeNodes.Where(m => m.Data == baseType).FirstOrDefault().treeNode.Nodes.Add(myTreeNodes.Where(m => m.Data == subType).FirstOrDefault().treeNode);
                }
            }

            foreach (Type type in baseClasses)
            {
                typeTrees.Add(new Tree<Type>() { Root = myTreeNodes.Where(m => m.Data == type).FirstOrDefault()});
            }

        }

    }
}
