//---------------------------------Hierarchy assessor form allows user to view hierarchy of classes in treeview from a loaded assembly------------------------
//---------------------------------2nd listview displays all classes which when selected display respective hierarchy in treeview-----------------------------
//---------------------------------the hierarchy of the assembly can be printed to a text file of the users choosing------------------------------------------
using AppAssessor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAssessor.Forms
{
    public partial class HierarchyAssessor : Form
    {
        private HierarchyAssessment hierarchy;
        private int greatestDepth = 0;
        public HierarchyAssessor()
        {
            InitializeComponent();
        }

        private void btn_loadAssembly_Click(object sender, EventArgs e)
        {
            if (fileDialog_Hierarchy.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    hierarchy = new HierarchyAssessment(fileDialog_Hierarchy.FileName);
                    lst_classes.DataSource = hierarchy.allTypes;
                    treeView.Nodes.Clear();
                    foreach (Tree<Type> tree in hierarchy.typeTrees)
                    {
                        treeView.Nodes.Add(tree.Root.treeNode);
                        if (tree.getDepth() > greatestDepth)
                        {
                            greatestDepth = tree.getDepth();
                        } 
                    }
                    lbl_depth.Text = greatestDepth.ToString();
                    lbl_numClasses.Text = hierarchy.allTypes.Count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private TreeNode populateTreeView(List<Type> allTypes, Type type)
        {

            Type temp = type;
            Type tempBase = type;
            List<Type> types = new List<Type>();
            List<TreeNode> treeNodes = new List<TreeNode>();

            //Add all BaseTypes to top of list
            while (tempBase != null)
            {
                types.Insert(0, tempBase);
                treeNodes.Add(new TreeNode(tempBase.Name));
                temp = tempBase;
                tempBase = tempBase.BaseType;
            }

            types = types.Distinct().ToList();
            foreach (Type baseType in types)
            {
                foreach (Type subType in types.Where(x => x.BaseType == baseType))
                {
                    treeNodes.Where(m => m.Text == baseType.Name).FirstOrDefault().Nodes.Add(treeNodes.Where(m => m.Text == subType.Name).FirstOrDefault());
                }
            }

            TreeNode treeNode = treeNodes.Where(x => x.Text == types.ElementAt(0).Name).FirstOrDefault(); ;
            return treeNode;
        }

        private void lst_classes_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
            Type type = (Type)lst_classes.SelectedItem;
            TreeNode treeNode = populateTreeView(hierarchy.allTypes, type);
            lbl_depth.Text = (treeNode.GetNodeCount(true) + 1).ToString();
            treeView.Nodes.Add(treeNode);

            treeView.ExpandAll();
        }

        private void btn_saveToFile_Click(object sender, EventArgs e)
        {

            foreach (Tree<Type> tree in hierarchy.typeTrees)
            {
                if (saveFileDialog_Hierarchy.ShowDialog() == DialogResult.OK)
                {
                    tree.sw = new StreamWriter(saveFileDialog_Hierarchy.FileName);
                    tree.print();
                    tree.sw.Close();
                    MessageBox.Show("File saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(saveFileDialog_Hierarchy.FileName);
                }
            }
        }

        private void loadAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_loadAssembly_Click(sender, e);
        }

        private void printHierarchyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_saveToFile_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
