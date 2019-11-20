//--------------------settings form to set application configurations-------------
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


    public partial class Settings : Form
    {
        private Configuration config;
        private int ave;
        private int maxRelations;
        private string regEx;
        public Settings()
        {
            InitializeComponent();
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ave = int.Parse(config.AppSettings.Settings["average"].Value);
            regEx = config.AppSettings.Settings["regex"].Value;
            maxRelations = int.Parse(config.AppSettings.Settings["maxrelations"].Value);
            txt_aveStandard.Text = ave.ToString();
            txt_regExStandard.Text = regEx;
            txt_maxRelations.Text = maxRelations.ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(txt_aveStandard.Text, out ave) && int.TryParse(txt_maxRelations.Text, out maxRelations))
            {
                if (MessageBox.Show("Are you sure you want to save changes?", "Confirm Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    config.AppSettings.Settings["average"].Value = txt_aveStandard.Text;
                    config.AppSettings.Settings["regex"].Value = txt_regExStandard.Text;
                    config.AppSettings.Settings["maxrelations"].Value = txt_maxRelations.Text;
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Average lines/method and maximum relationships/class must be a number.");
            }

        }
    }
}
