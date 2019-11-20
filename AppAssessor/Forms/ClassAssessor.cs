//-------------------------------Class Assessor form uses an openFileDialog to choose multiple classes--------------------
//-------------------------------and populates 2 Listviews with the collected data using streamreader------------------------

using AppAssessor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAssessor.Forms
{
    public partial class ClassAssessor : Form
    {
        List<ClassAssessment> classes = new List<ClassAssessment>();
        List<ClassAssessment> classesBelow = new List<ClassAssessment>();
        List<ClassAssessment> classesAbove = new List<ClassAssessment>();
        Configuration config;
        int ave;
        public ClassAssessor()
        {
            InitializeComponent();
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ave = int.Parse(config.AppSettings.Settings["average"].Value);
        }

        //onClick method to call openFileDialog for user to select multiple classes
        private void btn_loadClasses_Click(object sender, EventArgs e)
        {
            if (fileDialog_Class.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach (string file in fileDialog_Class.FileNames)
                    {
                        classes.Add(new ClassAssessment(file));                    
                    }
                    sortLists();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        //method to sort and repopulate lists
        private void sortLists()
        {
            lst_allClasses.DataSource = classes.OrderByDescending(x => x.ave).ToList();
        }

        private void loadClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_loadClasses_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Draw item method allows text to be drawn in different colours in the list
        private void lst_allClasses_DrawItem(object sender, DrawItemEventArgs e)
        {
            Brush myBrush = Brushes.Green;
            ClassAssessment type = (ClassAssessment)((ListBox)sender).Items[e.Index];
            String name = type.ToString();

            if (type.ave > ave)
            {
                myBrush = Brushes.Red;
            }
            e.Graphics.DrawString(name, e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
        }
    }
}
