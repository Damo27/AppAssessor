namespace AppAssessor.Forms
{
    partial class InterfaceAssessor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAssemblyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_numClasses = new System.Windows.Forms.Label();
            this.lbl_numInterfaces = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.lbl_classes = new System.Windows.Forms.Label();
            this.lbl_interfaces = new System.Windows.Forms.Label();
            this.lst_classes = new System.Windows.Forms.ListBox();
            this.lst_interfaces = new System.Windows.Forms.ListBox();
            this.lbl_loadAssembly = new System.Windows.Forms.Label();
            this.btn_loadAssembly = new System.Windows.Forms.Button();
            this.fileDialog_Assembly = new System.Windows.Forms.OpenFileDialog();
            this.chk_toggleNames = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAssemblyToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.exitToolStripMenuItem.Text = "Close";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lbl_numClasses
            // 
            this.lbl_numClasses.AutoSize = true;
            this.lbl_numClasses.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numClasses.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numClasses.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_numClasses.Location = new System.Drawing.Point(678, 333);
            this.lbl_numClasses.Name = "lbl_numClasses";
            this.lbl_numClasses.Size = new System.Drawing.Size(26, 25);
            this.lbl_numClasses.TabIndex = 24;
            this.lbl_numClasses.Text = "0";
            // 
            // lbl_numInterfaces
            // 
            this.lbl_numInterfaces.AutoSize = true;
            this.lbl_numInterfaces.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numInterfaces.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numInterfaces.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_numInterfaces.Location = new System.Drawing.Point(273, 333);
            this.lbl_numInterfaces.Name = "lbl_numInterfaces";
            this.lbl_numInterfaces.Size = new System.Drawing.Size(26, 25);
            this.lbl_numInterfaces.TabIndex = 23;
            this.lbl_numInterfaces.Text = "0";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.BackColor = System.Drawing.Color.Transparent;
            this.lbl_count.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_count.Location = new System.Drawing.Point(22, 333);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(70, 25);
            this.lbl_count.TabIndex = 22;
            this.lbl_count.Text = "Count";
            // 
            // lbl_classes
            // 
            this.lbl_classes.AutoSize = true;
            this.lbl_classes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_classes.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_classes.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_classes.Location = new System.Drawing.Point(429, 39);
            this.lbl_classes.Name = "lbl_classes";
            this.lbl_classes.Size = new System.Drawing.Size(214, 50);
            this.lbl_classes.TabIndex = 21;
            this.lbl_classes.Text = "Classes implementing\r\nclass";
            // 
            // lbl_interfaces
            // 
            this.lbl_interfaces.AutoSize = true;
            this.lbl_interfaces.BackColor = System.Drawing.Color.Transparent;
            this.lbl_interfaces.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_interfaces.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_interfaces.Location = new System.Drawing.Point(22, 39);
            this.lbl_interfaces.Name = "lbl_interfaces";
            this.lbl_interfaces.Size = new System.Drawing.Size(109, 25);
            this.lbl_interfaces.TabIndex = 20;
            this.lbl_interfaces.Text = "Interfaces";
            // 
            // lst_classes
            // 
            this.lst_classes.FormattingEnabled = true;
            this.lst_classes.Location = new System.Drawing.Point(434, 92);
            this.lst_classes.Name = "lst_classes";
            this.lst_classes.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lst_classes.Size = new System.Drawing.Size(270, 238);
            this.lst_classes.TabIndex = 19;
            // 
            // lst_interfaces
            // 
            this.lst_interfaces.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lst_interfaces.FormattingEnabled = true;
            this.lst_interfaces.Location = new System.Drawing.Point(27, 92);
            this.lst_interfaces.Name = "lst_interfaces";
            this.lst_interfaces.Size = new System.Drawing.Size(270, 238);
            this.lst_interfaces.Sorted = true;
            this.lst_interfaces.TabIndex = 18;
            this.lst_interfaces.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lst_interfaces_DrawItem);
            this.lst_interfaces.SelectedIndexChanged += new System.EventHandler(this.lst_interfaces_SelectedIndexChanged);
            // 
            // lbl_loadAssembly
            // 
            this.lbl_loadAssembly.AutoSize = true;
            this.lbl_loadAssembly.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loadAssembly.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loadAssembly.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_loadAssembly.Location = new System.Drawing.Point(22, 402);
            this.lbl_loadAssembly.Name = "lbl_loadAssembly";
            this.lbl_loadAssembly.Size = new System.Drawing.Size(155, 25);
            this.lbl_loadAssembly.TabIndex = 17;
            this.lbl_loadAssembly.Text = "Load Assembly";
            // 
            // btn_loadAssembly
            // 
            this.btn_loadAssembly.BackColor = System.Drawing.Color.Transparent;
            this.btn_loadAssembly.BackgroundImage = global::AppAssessor.Properties.Resources.assembly;
            this.btn_loadAssembly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_loadAssembly.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_loadAssembly.FlatAppearance.BorderSize = 0;
            this.btn_loadAssembly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadAssembly.Location = new System.Drawing.Point(202, 379);
            this.btn_loadAssembly.Name = "btn_loadAssembly";
            this.btn_loadAssembly.Size = new System.Drawing.Size(97, 74);
            this.btn_loadAssembly.TabIndex = 16;
            this.btn_loadAssembly.UseVisualStyleBackColor = false;
            this.btn_loadAssembly.Click += new System.EventHandler(this.btn_loadAssembly_Click);
            // 
            // fileDialog_Assembly
            // 
            this.fileDialog_Assembly.FileName = "openFileDialog1";
            // 
            // chk_toggleNames
            // 
            this.chk_toggleNames.AutoSize = true;
            this.chk_toggleNames.BackColor = System.Drawing.Color.Transparent;
            this.chk_toggleNames.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_toggleNames.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.chk_toggleNames.Location = new System.Drawing.Point(434, 402);
            this.chk_toggleNames.Name = "chk_toggleNames";
            this.chk_toggleNames.Size = new System.Drawing.Size(177, 25);
            this.chk_toggleNames.TabIndex = 25;
            this.chk_toggleNames.Text = "Toggle Full Names";
            this.chk_toggleNames.UseVisualStyleBackColor = false;
            this.chk_toggleNames.CheckedChanged += new System.EventHandler(this.chk_toggleNames_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(303, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 14);
            this.label3.TabIndex = 26;
            this.label3.Text = "Compliant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(303, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 14);
            this.label1.TabIndex = 27;
            this.label1.Text = "Non-Compliant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(303, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 14);
            this.label2.TabIndex = 28;
            this.label2.Text = "Not Implemented";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(303, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 28);
            this.label4.TabIndex = 29;
            this.label4.Text = "Non-compliant +\r\nNot Implemented";
            // 
            // InterfaceAssessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppAssessor.Properties.Resources.blue_butterfly_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 487);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chk_toggleNames);
            this.Controls.Add(this.lbl_numClasses);
            this.Controls.Add(this.lbl_numInterfaces);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.lbl_classes);
            this.Controls.Add(this.lbl_interfaces);
            this.Controls.Add(this.lst_classes);
            this.Controls.Add(this.lst_interfaces);
            this.Controls.Add(this.lbl_loadAssembly);
            this.Controls.Add(this.btn_loadAssembly);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InterfaceAssessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interface Assessor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAssemblyToolStripMenuItem;
        private System.Windows.Forms.Label lbl_numClasses;
        private System.Windows.Forms.Label lbl_numInterfaces;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label lbl_classes;
        private System.Windows.Forms.Label lbl_interfaces;
        private System.Windows.Forms.ListBox lst_classes;
        private System.Windows.Forms.ListBox lst_interfaces;
        private System.Windows.Forms.Label lbl_loadAssembly;
        private System.Windows.Forms.Button btn_loadAssembly;
        private System.Windows.Forms.OpenFileDialog fileDialog_Assembly;
        private System.Windows.Forms.CheckBox chk_toggleNames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}