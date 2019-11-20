//------------------------------------------Home screen for navigation to different forms-----------------------------

using AppAssessor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAssessor
{
    public partial class frm_home : Form
    {
        public frm_home()
        {
            InitializeComponent();
        }

        private void btn_assembly_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssemblyAssessor assemblyAssessor = new AssemblyAssessor();
            assemblyAssessor.ShowDialog();
            assemblyAssessor = null;
            this.Show();
        }

        private void btn_classes_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClassAssessor classAssessor = new ClassAssessor();
            classAssessor.ShowDialog();
            classAssessor = null;
            this.Show();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settings = new Settings();
            settings.ShowDialog();
            settings = null;
            this.Show();
        }

        private void btn_interface_Click(object sender, EventArgs e)
        {
            this.Hide();
            InterfaceAssessor interfaceAssessor = new InterfaceAssessor();
            interfaceAssessor.ShowDialog();
            interfaceAssessor = null;
            this.Show();
        }

        private void btn_hierarchy_Click(object sender, EventArgs e)
        {
            this.Hide();
            HierarchyAssessor hierarchyAssessor = new HierarchyAssessor();
            hierarchyAssessor.ShowDialog();
            hierarchyAssessor = null;
            this.Show();
        }

        private void btn_association_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssociationAssessor associationAssessor = new AssociationAssessor();
            associationAssessor.ShowDialog();
            associationAssessor = null;
            this.Show();
        }

        private void assessAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_assembly_Click(sender, e);
        }

        private void assessClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_classes_Click(sender, e);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_settings_Click(sender, e);
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void assessHierarchyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_hierarchy_Click(sender, e);
        }

        private void assessAssociationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_association_Click(sender, e);
        }

    }
}
