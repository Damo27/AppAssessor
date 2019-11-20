namespace AppAssessor.Forms
{
    partial class HierarchyAssessor
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
            this.treeView = new System.Windows.Forms.TreeView();
            this.fileDialog_Hierarchy = new System.Windows.Forms.OpenFileDialog();
            this.btn_loadAssembly = new System.Windows.Forms.Button();
            this.lbl_loadAssembly = new System.Windows.Forms.Label();
            this.lbl_numClasses = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_classes = new System.Windows.Forms.ListBox();
            this.saveFileDialog_Hierarchy = new System.Windows.Forms.SaveFileDialog();
            this.lbl_countTxt = new System.Windows.Forms.Label();
            this.lbl_depthTxt = new System.Windows.Forms.Label();
            this.lbl_depth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_saveToFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAssemblyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printHierarchyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(35, 68);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(270, 244);
            this.treeView.TabIndex = 0;
            // 
            // fileDialog_Hierarchy
            // 
            this.fileDialog_Hierarchy.FileName = "openFileDialog1";
            // 
            // btn_loadAssembly
            // 
            this.btn_loadAssembly.BackColor = System.Drawing.Color.Transparent;
            this.btn_loadAssembly.BackgroundImage = global::AppAssessor.Properties.Resources.assembly;
            this.btn_loadAssembly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_loadAssembly.FlatAppearance.BorderSize = 0;
            this.btn_loadAssembly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadAssembly.Location = new System.Drawing.Point(208, 351);
            this.btn_loadAssembly.Name = "btn_loadAssembly";
            this.btn_loadAssembly.Size = new System.Drawing.Size(97, 74);
            this.btn_loadAssembly.TabIndex = 6;
            this.btn_loadAssembly.UseVisualStyleBackColor = false;
            this.btn_loadAssembly.Click += new System.EventHandler(this.btn_loadAssembly_Click);
            // 
            // lbl_loadAssembly
            // 
            this.lbl_loadAssembly.AutoSize = true;
            this.lbl_loadAssembly.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loadAssembly.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loadAssembly.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_loadAssembly.Location = new System.Drawing.Point(30, 374);
            this.lbl_loadAssembly.Name = "lbl_loadAssembly";
            this.lbl_loadAssembly.Size = new System.Drawing.Size(155, 25);
            this.lbl_loadAssembly.TabIndex = 7;
            this.lbl_loadAssembly.Text = "Load Assembly";
            // 
            // lbl_numClasses
            // 
            this.lbl_numClasses.AutoSize = true;
            this.lbl_numClasses.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numClasses.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numClasses.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_numClasses.Location = new System.Drawing.Point(688, 315);
            this.lbl_numClasses.Name = "lbl_numClasses";
            this.lbl_numClasses.Size = new System.Drawing.Size(26, 25);
            this.lbl_numClasses.TabIndex = 18;
            this.lbl_numClasses.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(431, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Classes";
            // 
            // lst_classes
            // 
            this.lst_classes.FormattingEnabled = true;
            this.lst_classes.Location = new System.Drawing.Point(436, 68);
            this.lst_classes.Name = "lst_classes";
            this.lst_classes.Size = new System.Drawing.Size(270, 238);
            this.lst_classes.TabIndex = 16;
            this.lst_classes.SelectedIndexChanged += new System.EventHandler(this.lst_classes_SelectedIndexChanged);
            // 
            // saveFileDialog_Hierarchy
            // 
            this.saveFileDialog_Hierarchy.DefaultExt = "txt";
            // 
            // lbl_countTxt
            // 
            this.lbl_countTxt.AutoSize = true;
            this.lbl_countTxt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_countTxt.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_countTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_countTxt.Location = new System.Drawing.Point(439, 315);
            this.lbl_countTxt.Name = "lbl_countTxt";
            this.lbl_countTxt.Size = new System.Drawing.Size(70, 25);
            this.lbl_countTxt.TabIndex = 20;
            this.lbl_countTxt.Text = "Count";
            // 
            // lbl_depthTxt
            // 
            this.lbl_depthTxt.AutoSize = true;
            this.lbl_depthTxt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_depthTxt.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_depthTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_depthTxt.Location = new System.Drawing.Point(30, 315);
            this.lbl_depthTxt.Name = "lbl_depthTxt";
            this.lbl_depthTxt.Size = new System.Drawing.Size(72, 25);
            this.lbl_depthTxt.TabIndex = 21;
            this.lbl_depthTxt.Text = "Depth";
            // 
            // lbl_depth
            // 
            this.lbl_depth.AutoSize = true;
            this.lbl_depth.BackColor = System.Drawing.Color.Transparent;
            this.lbl_depth.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_depth.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_depth.Location = new System.Drawing.Point(279, 315);
            this.lbl_depth.Name = "lbl_depth";
            this.lbl_depth.Size = new System.Drawing.Size(26, 25);
            this.lbl_depth.TabIndex = 22;
            this.lbl_depth.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tree";
            // 
            // btn_saveToFile
            // 
            this.btn_saveToFile.BackColor = System.Drawing.Color.Transparent;
            this.btn_saveToFile.BackgroundImage = global::AppAssessor.Properties.Resources.print;
            this.btn_saveToFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_saveToFile.FlatAppearance.BorderSize = 0;
            this.btn_saveToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveToFile.Location = new System.Drawing.Point(609, 351);
            this.btn_saveToFile.Name = "btn_saveToFile";
            this.btn_saveToFile.Size = new System.Drawing.Size(97, 74);
            this.btn_saveToFile.TabIndex = 24;
            this.btn_saveToFile.UseVisualStyleBackColor = false;
            this.btn_saveToFile.Click += new System.EventHandler(this.btn_saveToFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(439, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Print Hierarchy";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAssemblyToolStripMenuItem,
            this.printHierarchyToolStripMenuItem,
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
            this.loadAssemblyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadAssemblyToolStripMenuItem.Text = "Load Assembly";
            this.loadAssemblyToolStripMenuItem.Click += new System.EventHandler(this.loadAssemblyToolStripMenuItem_Click);
            // 
            // printHierarchyToolStripMenuItem
            // 
            this.printHierarchyToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.printHierarchyToolStripMenuItem.Name = "printHierarchyToolStripMenuItem";
            this.printHierarchyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printHierarchyToolStripMenuItem.Text = "Print Hierarchy";
            this.printHierarchyToolStripMenuItem.Click += new System.EventHandler(this.printHierarchyToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // HierarchyAssessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppAssessor.Properties.Resources.blue_butterfly_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_saveToFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_depth);
            this.Controls.Add(this.lbl_depthTxt);
            this.Controls.Add(this.lbl_countTxt);
            this.Controls.Add(this.lbl_numClasses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_classes);
            this.Controls.Add(this.lbl_loadAssembly);
            this.Controls.Add(this.btn_loadAssembly);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HierarchyAssessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HierarchyAssessor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.OpenFileDialog fileDialog_Hierarchy;
        private System.Windows.Forms.Button btn_loadAssembly;
        private System.Windows.Forms.Label lbl_loadAssembly;
        private System.Windows.Forms.Label lbl_numClasses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_classes;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_Hierarchy;
        private System.Windows.Forms.Label lbl_countTxt;
        private System.Windows.Forms.Label lbl_depthTxt;
        private System.Windows.Forms.Label lbl_depth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_saveToFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAssemblyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printHierarchyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}