//-------------------------------Assembly Assessor form uses an openFileDialog to choose an assembly--------------------
//-------------------------------and populates 3 Listviews with the collected data using reflection------------------------

using AppAssessor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAssessor.Forms
{
    public partial class AssemblyAssessor : Form
    {
        List<MethodInfo> methodInfos;

        public AssemblyAssessor()
        {
            InitializeComponent();
            lst_classes.DisplayMember = "Name";
            lst_methods.DisplayMember = "Name";
            lst_extRefs.DisplayMember = "Name";
        }

        //onclick method to call openFileDialog for user to select single assembly.
        private void btn_loadAssembly_Click(object sender, EventArgs e)
        {
            if (fileDialog_Assembly.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    AssemblyAssessment assemblyAssessment = new AssemblyAssessment(fileDialog_Assembly.FileName);
                    lst_extRefs.DataSource = assemblyAssessment.assemblyNames;
                    lst_classes.DataSource = assemblyAssessment.classes;

                    lbl_numExtRefs.Text = assemblyAssessment.assemblyNames.Count.ToString();
                    lbl_numClasses.Text = assemblyAssessment.classes.Count.ToString();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        //onChange method to repopulate the methods in the listBox to the methods in the selected class
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Type type = (Type)lst_classes.SelectedItem;
            methodInfos = type.GetMethods().ToList();
            lst_methods.DataSource = methodInfos;

            cbo_filterMethods_SelectedIndexChanged(sender, e);
            lbl_numMethods.Text = methodInfos.Count().ToString();

        }
        //onChange method allows the user to toggle between full and short names
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                lst_classes.DisplayMember = "Name";
                lst_methods.DisplayMember = "Name";
                lst_extRefs.DisplayMember = "Name";
            }
            else
            {
                lst_classes.DisplayMember = "FullName";
                lst_methods.DisplayMember = "";
                lst_extRefs.DisplayMember = "FullName";
            }
        }
        //onChange method to filter methods depending on user selection in cbo
        private void cbo_filterMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cbo_filterMethods.SelectedIndex)
                {
                    case 0:
                        {
                            lst_methods.DataSource = methodInfos;
                            break;
                        }
                    case 1:
                        {
                            lst_methods.DataSource = methodInfos.Where(x => x.IsAbstract).ToList();
                            break;
                        }
                    case 2:
                        {
                            lst_methods.DataSource = methodInfos.Where(x => x.IsConstructor).ToList();
                            break;
                        }
                    case 3:
                        {
                            lst_methods.DataSource = methodInfos.Where(x => x.IsPrivate).ToList();
                            break;
                        }
                    case 4:
                        {
                            lst_methods.DataSource = methodInfos.Where(x => x.IsPublic).ToList();
                            break;
                        }
                    case 5:
                        {
                            lst_methods.DataSource = methodInfos.Where(x => x.IsStatic).ToList();
                            break;
                        }
                    case 6:
                        {
                            lst_methods.DataSource = methodInfos.Where(x => x.IsVirtual).ToList();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Please load an assembly.");
            }
        }
        
        private void loadAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_loadAssembly_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_numExtRefs_Click(object sender, EventArgs e)
        {

        }

        private void lbl_count_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lst_extRefs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_loadAssembly_Click(object sender, EventArgs e)
        {

        }

        private void lbl_numClasses_Click(object sender, EventArgs e)
        {

        }
    }
}
