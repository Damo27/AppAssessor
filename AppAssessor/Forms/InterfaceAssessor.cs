//---------------------------------Interface assessor form allows user to view interfaces in 1st listview from a loaded assembly------------------------
//---------------------------------2nd listview displays all classes which implement the selected interface.--------------------------------------------
using AppAssessor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAssessor.Forms
{
    public partial class InterfaceAssessor : Form
    {
        private InterfaceAssessment interfaceAssessment;
        private List<Type> interfaces;
        private List<Type> classes;
        private Configuration config;
        private string regEx;

        public InterfaceAssessor()
        {
            InitializeComponent();
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            regEx = config.AppSettings.Settings["regex"].Value;
            lst_classes.DisplayMember = "Name";
            lst_interfaces.DisplayMember = "Name";
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
                    interfaceAssessment = new InterfaceAssessment(fileDialog_Assembly.FileName);
                    interfaces = interfaceAssessment.interfaces;
                    classes = interfaceAssessment.classes;
                    lst_interfaces.DataSource = interfaces;

                    lbl_numInterfaces.Text = interfaceAssessment.interfaces.Count.ToString();
                   
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        //when selection changes re-populate classes based on selected interface
        private void lst_interfaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst_classes.DataSource = classes.Where(x => x.GetInterfaces().Contains(lst_interfaces.SelectedItem)).ToList();
            lbl_numClasses.Text = lst_classes.Items.Count.ToString();
            lbl_classes.Text = String.Format("{0}\n{1}","Classes implementing",((Type)lst_interfaces.SelectedItem).Name);
        }

        //Draw item method allows text to be drawn in different colours in the list
        private void lst_interfaces_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();
                Brush myBrush = Brushes.Black;
                String name = String.Empty;
                Type type = (Type)((ListBox)sender).Items[e.Index];
                //Confirms with regEx and is implemented
                if (classes.Where(x => x.GetInterfaces().Contains(type)).Any() && Regex.IsMatch(type.Name, regEx))
                {
                    myBrush = Brushes.Green;
                }
                //Doesnt conform with regex and is not implemented
                else if (!classes.Where(x => x.GetInterfaces().Contains(type)).Any() && !Regex.IsMatch(type.Name, regEx))
                {
                    myBrush = Brushes.Maroon;
                }
                //Doesnt conform with Regex
                else if (!Regex.IsMatch(type.Name, regEx))
                {
                    myBrush = Brushes.Red;
                }
                //Not Implemented
                else
                {
                    myBrush = Brushes.Orange;
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


        private void loadAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_loadAssembly_Click(sender, e);
        }

        //toggle to change display members of the lists to fullnames or vice versa
        private void chk_toggleNames_CheckedChanged(object sender, EventArgs e)
        {
            if (!chk_toggleNames.Checked)
            {
                lst_classes.DisplayMember = "Name";
                lst_interfaces.DisplayMember = "Name";
            }
            else
            {
                lst_classes.DisplayMember = "FullName";
                lst_interfaces.DisplayMember = "FullName";
            }
        }
    }
}
