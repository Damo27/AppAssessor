namespace AppAssessor.Forms
{
    partial class AssociationAssessor
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
            this.lbl_countTxt = new System.Windows.Forms.Label();
            this.lbl_numClasses = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_classes = new System.Windows.Forms.ListBox();
            this.lbl_loadAssembly = new System.Windows.Forms.Label();
            this.btn_loadAssembly = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_relationCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lst_relatedClasses = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_toggleNames = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAssemblyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileDialog_Assembly = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_countTxt
            // 
            this.lbl_countTxt.AutoSize = true;
            this.lbl_countTxt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_countTxt.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_countTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_countTxt.Location = new System.Drawing.Point(52, 330);
            this.lbl_countTxt.Name = "lbl_countTxt";
            this.lbl_countTxt.Size = new System.Drawing.Size(70, 25);
            this.lbl_countTxt.TabIndex = 24;
            this.lbl_countTxt.Text = "Count";
            // 
            // lbl_numClasses
            // 
            this.lbl_numClasses.AutoSize = true;
            this.lbl_numClasses.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numClasses.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numClasses.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_numClasses.Location = new System.Drawing.Point(301, 330);
            this.lbl_numClasses.Name = "lbl_numClasses";
            this.lbl_numClasses.Size = new System.Drawing.Size(26, 25);
            this.lbl_numClasses.TabIndex = 23;
            this.lbl_numClasses.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(44, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Classes";
            // 
            // lst_classes
            // 
            this.lst_classes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lst_classes.FormattingEnabled = true;
            this.lst_classes.Location = new System.Drawing.Point(49, 83);
            this.lst_classes.Name = "lst_classes";
            this.lst_classes.Size = new System.Drawing.Size(270, 238);
            this.lst_classes.TabIndex = 21;
            this.lst_classes.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lst_classes_DrawItem);
            this.lst_classes.SelectedIndexChanged += new System.EventHandler(this.lst_classes_SelectedIndexChanged);
            // 
            // lbl_loadAssembly
            // 
            this.lbl_loadAssembly.AutoSize = true;
            this.lbl_loadAssembly.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loadAssembly.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loadAssembly.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_loadAssembly.Location = new System.Drawing.Point(44, 412);
            this.lbl_loadAssembly.Name = "lbl_loadAssembly";
            this.lbl_loadAssembly.Size = new System.Drawing.Size(155, 25);
            this.lbl_loadAssembly.TabIndex = 26;
            this.lbl_loadAssembly.Text = "Load Assembly";
            // 
            // btn_loadAssembly
            // 
            this.btn_loadAssembly.BackColor = System.Drawing.Color.Transparent;
            this.btn_loadAssembly.BackgroundImage = global::AppAssessor.Properties.Resources.assembly;
            this.btn_loadAssembly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_loadAssembly.FlatAppearance.BorderSize = 0;
            this.btn_loadAssembly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadAssembly.Location = new System.Drawing.Point(222, 389);
            this.btn_loadAssembly.Name = "btn_loadAssembly";
            this.btn_loadAssembly.Size = new System.Drawing.Size(97, 74);
            this.btn_loadAssembly.TabIndex = 25;
            this.btn_loadAssembly.UseVisualStyleBackColor = false;
            this.btn_loadAssembly.Click += new System.EventHandler(this.btn_loadAssembly_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(449, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Count";
            // 
            // lbl_relationCount
            // 
            this.lbl_relationCount.AutoSize = true;
            this.lbl_relationCount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_relationCount.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_relationCount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_relationCount.Location = new System.Drawing.Point(698, 330);
            this.lbl_relationCount.Name = "lbl_relationCount";
            this.lbl_relationCount.Size = new System.Drawing.Size(26, 25);
            this.lbl_relationCount.TabIndex = 29;
            this.lbl_relationCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(449, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Related Classes";
            // 
            // lst_relatedClasses
            // 
            this.lst_relatedClasses.FormattingEnabled = true;
            this.lst_relatedClasses.Location = new System.Drawing.Point(454, 83);
            this.lst_relatedClasses.Name = "lst_relatedClasses";
            this.lst_relatedClasses.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lst_relatedClasses.Size = new System.Drawing.Size(270, 238);
            this.lst_relatedClasses.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(333, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 14);
            this.label3.TabIndex = 32;
            this.label3.Text = "Non-Compliant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(333, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 14);
            this.label5.TabIndex = 31;
            this.label5.Text = "Compliant";
            // 
            // chk_toggleNames
            // 
            this.chk_toggleNames.AutoSize = true;
            this.chk_toggleNames.BackColor = System.Drawing.Color.Transparent;
            this.chk_toggleNames.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_toggleNames.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.chk_toggleNames.Location = new System.Drawing.Point(547, 414);
            this.chk_toggleNames.Name = "chk_toggleNames";
            this.chk_toggleNames.Size = new System.Drawing.Size(177, 25);
            this.chk_toggleNames.TabIndex = 33;
            this.chk_toggleNames.Text = "Toggle Full Names";
            this.chk_toggleNames.UseVisualStyleBackColor = false;
            this.chk_toggleNames.CheckedChanged += new System.EventHandler(this.chk_toggleNames_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAssemblyToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadAssemblyToolStripMenuItem
            // 
            this.loadAssemblyToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.loadAssemblyToolStripMenuItem.Name = "loadAssemblyToolStripMenuItem";
            this.loadAssemblyToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.loadAssemblyToolStripMenuItem.Text = "Load Assembly";
            this.loadAssemblyToolStripMenuItem.Click += new System.EventHandler(this.loadAssemblyToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fileDialog_Assembly
            // 
            this.fileDialog_Assembly.FileName = "openFileDialog1";
            // 
            // AssociationAssessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppAssessor.Properties.Resources.blue_butterfly_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 476);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.chk_toggleNames);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_relationCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lst_relatedClasses);
            this.Controls.Add(this.lbl_loadAssembly);
            this.Controls.Add(this.btn_loadAssembly);
            this.Controls.Add(this.lbl_countTxt);
            this.Controls.Add(this.lbl_numClasses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_classes);
            this.Name = "AssociationAssessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssociationAssessor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_countTxt;
        private System.Windows.Forms.Label lbl_numClasses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_classes;
        private System.Windows.Forms.Label lbl_loadAssembly;
        private System.Windows.Forms.Button btn_loadAssembly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_relationCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lst_relatedClasses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk_toggleNames;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAssemblyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog fileDialog_Assembly;
    }
}