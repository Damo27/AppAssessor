namespace AppAssessor.Forms
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_aveStandard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_regExStandard = new System.Windows.Forms.TextBox();
            this.lbl_loadAssembly = new System.Windows.Forms.Label();
            this.lbl_maxRelations = new System.Windows.Forms.Label();
            this.txt_maxRelations = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BackgroundImage = global::AppAssessor.Properties.Resources.save;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_save.Location = new System.Drawing.Point(353, 272);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 82);
            this.btn_save.TabIndex = 19;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_aveStandard
            // 
            this.txt_aveStandard.Location = new System.Drawing.Point(338, 48);
            this.txt_aveStandard.Name = "txt_aveStandard";
            this.txt_aveStandard.Size = new System.Drawing.Size(115, 20);
            this.txt_aveStandard.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "Required Average lines per method:\r\n(Class Assessor)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(12, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 60);
            this.label2.TabIndex = 20;
            this.label2.Text = "Regular Expression for Interface\r\nnaming conventions:\r\n(Interface Assessor)";
            // 
            // txt_regExStandard
            // 
            this.txt_regExStandard.Location = new System.Drawing.Point(338, 219);
            this.txt_regExStandard.Name = "txt_regExStandard";
            this.txt_regExStandard.Size = new System.Drawing.Size(115, 20);
            this.txt_regExStandard.TabIndex = 21;
            // 
            // lbl_loadAssembly
            // 
            this.lbl_loadAssembly.AutoSize = true;
            this.lbl_loadAssembly.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loadAssembly.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loadAssembly.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_loadAssembly.Location = new System.Drawing.Point(210, 298);
            this.lbl_loadAssembly.Name = "lbl_loadAssembly";
            this.lbl_loadAssembly.Size = new System.Drawing.Size(137, 25);
            this.lbl_loadAssembly.TabIndex = 22;
            this.lbl_loadAssembly.Text = "Save Settings";
            // 
            // lbl_maxRelations
            // 
            this.lbl_maxRelations.AutoSize = true;
            this.lbl_maxRelations.BackColor = System.Drawing.Color.Transparent;
            this.lbl_maxRelations.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maxRelations.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_maxRelations.Location = new System.Drawing.Point(12, 128);
            this.lbl_maxRelations.Name = "lbl_maxRelations";
            this.lbl_maxRelations.Size = new System.Drawing.Size(261, 40);
            this.lbl_maxRelations.TabIndex = 24;
            this.lbl_maxRelations.Text = "Maximum relationships per class:\r\n(Association Assessor)";
            // 
            // txt_maxRelations
            // 
            this.txt_maxRelations.Location = new System.Drawing.Point(338, 129);
            this.txt_maxRelations.Name = "txt_maxRelations";
            this.txt_maxRelations.Size = new System.Drawing.Size(115, 20);
            this.txt_maxRelations.TabIndex = 23;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppAssessor.Properties.Resources.blue_butterfly_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(494, 366);
            this.Controls.Add(this.lbl_maxRelations);
            this.Controls.Add(this.txt_maxRelations);
            this.Controls.Add(this.lbl_loadAssembly);
            this.Controls.Add(this.txt_regExStandard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_aveStandard);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_aveStandard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_regExStandard;
        private System.Windows.Forms.Label lbl_loadAssembly;
        private System.Windows.Forms.Label lbl_maxRelations;
        private System.Windows.Forms.TextBox txt_maxRelations;
    }
}