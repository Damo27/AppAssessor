namespace AppAssessor.Forms
{
    partial class ClassAssessor
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
            this.fileDialog_Class = new System.Windows.Forms.OpenFileDialog();
            this.lbl_loadClasses = new System.Windows.Forms.Label();
            this.btn_loadClasses = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lst_allClasses = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileDialog_Class
            // 
            this.fileDialog_Class.FileName = "openFileDialog1";
            this.fileDialog_Class.Multiselect = true;
            // 
            // lbl_loadClasses
            // 
            this.lbl_loadClasses.AutoSize = true;
            this.lbl_loadClasses.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loadClasses.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loadClasses.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_loadClasses.Location = new System.Drawing.Point(27, 410);
            this.lbl_loadClasses.Name = "lbl_loadClasses";
            this.lbl_loadClasses.Size = new System.Drawing.Size(136, 25);
            this.lbl_loadClasses.TabIndex = 8;
            this.lbl_loadClasses.Text = "Load Classes";
            // 
            // btn_loadClasses
            // 
            this.btn_loadClasses.BackColor = System.Drawing.Color.Transparent;
            this.btn_loadClasses.BackgroundImage = global::AppAssessor.Properties.Resources._class;
            this.btn_loadClasses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_loadClasses.FlatAppearance.BorderSize = 0;
            this.btn_loadClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadClasses.Location = new System.Drawing.Point(169, 387);
            this.btn_loadClasses.Name = "btn_loadClasses";
            this.btn_loadClasses.Size = new System.Drawing.Size(97, 74);
            this.btn_loadClasses.TabIndex = 7;
            this.btn_loadClasses.UseVisualStyleBackColor = false;
            this.btn_loadClasses.Click += new System.EventHandler(this.btn_loadClasses_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(390, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadClassesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadClassesToolStripMenuItem
            // 
            this.loadClassesToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.loadClassesToolStripMenuItem.Name = "loadClassesToolStripMenuItem";
            this.loadClassesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.loadClassesToolStripMenuItem.Text = "Load Classes";
            this.loadClassesToolStripMenuItem.Click += new System.EventHandler(this.loadClassesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Close";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lst_allClasses
            // 
            this.lst_allClasses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lst_allClasses.FormattingEnabled = true;
            this.lst_allClasses.Location = new System.Drawing.Point(34, 62);
            this.lst_allClasses.Name = "lst_allClasses";
            this.lst_allClasses.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lst_allClasses.Size = new System.Drawing.Size(232, 264);
            this.lst_allClasses.TabIndex = 18;
            this.lst_allClasses.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lst_allClasses_DrawItem);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Classes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(158, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 14);
            this.label2.TabIndex = 20;
            this.label2.Text = "(ave lines/method)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(272, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "Compliant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(272, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 14);
            this.label4.TabIndex = 22;
            this.label4.Text = "Non-Compliant";
            // 
            // ClassAssessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppAssessor.Properties.Resources.blue_butterfly_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(390, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_allClasses);
            this.Controls.Add(this.lbl_loadClasses);
            this.Controls.Add(this.btn_loadClasses);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClassAssessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Assessor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog fileDialog_Class;
        private System.Windows.Forms.Label lbl_loadClasses;
        private System.Windows.Forms.Button btn_loadClasses;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox lst_allClasses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}