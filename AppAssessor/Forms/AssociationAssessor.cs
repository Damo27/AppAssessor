//---------------------------------Association assessor form allows user to view classes in 1st listview from a loaded assembly------------------------
//---------------------------------2nd listview displays all classes which relate to the selected class from list1.--------------------------------------------

using AppAssessor.DataStructures;
using AppAssessor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAssessor.Forms
{
    public partial class AssociationAssessor : Form
    {
        AssociationAssessment associationAssessment;
        private int maxRelations;
        private Configuration config;
        public AssociationAssessor()
        {
            InitializeComponent();
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            maxRelations = int.Parse(config.AppSettings.Settings["maxrelations"].Value);
            lst_classes.DisplayMember = "Name";
            lst_relatedClasses.DisplayMember = "Name";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_loadAssembly_Click(object sender, EventArgs e)
        {
            if (fileDialog_Assembly.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    associationAssessment = new AssociationAssessment(fileDialog_Assembly.FileName);
                    lst_classes.DataSource = associationAssessment.classes;
                    lbl_numClasses.Text = associationAssessment.classes.Count().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void loadAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_loadAssembly_Click(sender, e);
        }

        private void chk_toggleNames_CheckedChanged(object sender, EventArgs e)
        {
            if (!chk_toggleNames.Checked)
            {
                lst_classes.DisplayMember = "Name";
                lst_relatedClasses.DisplayMember = "Name";
            }
            else
            {
                lst_classes.DisplayMember = "FullName";
                lst_relatedClasses.DisplayMember = "FullName";
            }
        }

        private void lst_classes_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Type> relations = new List<Type>();
            foreach (GraphNode<Type> node in associationAssessment.graph.Nodes.Where(x => x.Data == (Type)lst_classes.SelectedItem).FirstOrDefault().Neighbors)
            {
                relations.Add(node.Data);
            }
            lst_relatedClasses.DataSource = relations;
            lbl_relationCount.Text = relations.Count.ToString();
            chk_toggleNames_CheckedChanged(sender, e);
        }

        private void lst_classes_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();
                Brush myBrush = Brushes.Black;
                String name = String.Empty;
                Type type = (Type)((ListBox)sender).Items[e.Index];

                if (associationAssessment.graph.Nodes.Where(x => x.Data == type).FirstOrDefault().Neighbors.Count > maxRelations)
                {
                    myBrush = Brushes.Red;
                }
                else
                {
                    myBrush = Brushes.Green;
                }

                if (chk_toggleNames.Checked)
                {
                    name = ((Type)((ListBox)sender).Items[e.Index]).FullName;
                }
                else
                {
                    name = ((Type)((ListBox)sender).Items[e.Index]).Name;
                }

                e.Graphics.DrawString(name, e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            } 
        }
    }
}
