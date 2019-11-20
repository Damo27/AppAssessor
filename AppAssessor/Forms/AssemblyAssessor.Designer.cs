namespace AppAssessor.Forms
{
    partial class AssemblyAssessor
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
            this.fileDialog_Assembly = new System.Windows.Forms.OpenFileDialog();
            this.lbl_loadAssembly = new System.Windows.Forms.Label();
            this.btn_loadAssembly = new System.Windows.Forms.Button();
            this.lst_extRefs = new System.Windows.Forms.ListBox();
            this.lst_classes = new System.Windows.Forms.ListBox();
            this.lst_methods = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.lbl_numExtRefs = new System.Windows.Forms.Label();
            this.lbl_numClasses = new System.Windows.Forms.Label();
            this.lbl_numMethods = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbo_filterMethods = new System.Windows.Forms.ComboBox();
            this.lbl_filter = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAssemblyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileDialog_Assembly
            // 
            this.fileDialog_Assembly.FileName = "openFileDialog1";
            // 
            // lbl_loadAssembly
            // 
            this.lbl_loadAssembly.AutoSize = true;
            this.lbl_loadAssembly.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loadAssembly.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loadAssembly.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_loadAssembly.Location = new System.Drawing.Point(176, 385);
            this.lbl_loadAssembly.Name = "lbl_loadAssembly";
            this.lbl_loadAssembly.Size = new System.Drawing.Size(155, 25);
            this.lbl_loadAssembly.TabIndex = 6;
            this.lbl_loadAssembly.Text = "Load Assembly";
            this.lbl_loadAssembly.Click += new System.EventHandler(this.lbl_loadAssembly_Click);
            // 
            // btn_loadAssembly
            // 
            this.btn_loadAssembly.BackColor = System.Drawing.Color.Transparent;
            this.btn_loadAssembly.BackgroundImage = global::AppAssessor.Properties.Resources.assembly;
            this.btn_loadAssembly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_loadAssembly.FlatAppearance.BorderSize = 0;
            this.btn_loadAssembly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadAssembly.Location = new System.Drawing.Point(395, 362);
            this.btn_loadAssembly.Name = "btn_loadAssembly";
            this.btn_loadAssembly.Size = new System.Drawing.Size(97, 74);
            this.btn_loadAssembly.TabIndex = 5;
            this.btn_loadAssembly.UseVisualStyleBackColor = false;
            this.btn_loadAssembly.Click += new System.EventHandler(this.btn_loadAssembly_Click);
            // 
            // lst_extRefs
            // 
            this.lst_extRefs.FormattingEnabled = true;
            this.lst_extRefs.Location = new System.Drawing.Point(45, 77);
            this.lst_extRefs.Name = "lst_extRefs";
            this.lst_extRefs.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lst_extRefs.Size = new System.Drawing.Size(328, 238);
            this.lst_extRefs.Sorted = true;
            this.lst_extRefs.TabIndex = 7;
            this.lst_extRefs.SelectedIndexChanged += new System.EventHandler(this.lst_extRefs_SelectedIndexChanged);
            // 
            // lst_classes
            // 
            this.lst_classes.FormattingEnabled = true;
            this.lst_classes.Location = new System.Drawing.Point(395, 77);
            this.lst_classes.Name = "lst_classes";
            this.lst_classes.Size = new System.Drawing.Size(270, 238);
            this.lst_classes.TabIndex = 8;
            this.lst_classes.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // lst_methods
            // 
            this.lst_methods.FormattingEnabled = true;
            this.lst_methods.Location = new System.Drawing.Point(689, 103);
            this.lst_methods.Name = "lst_methods";
            this.lst_methods.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lst_methods.Size = new System.Drawing.Size(270, 212);
            this.lst_methods.Sorted = true;
            this.lst_methods.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 50);
            this.label1.TabIndex = 10;
            this.label1.Text = "External\r\nReferences";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(390, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Classes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(684, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Methods in Class";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.BackColor = System.Drawing.Color.Transparent;
            this.lbl_count.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_count.Location = new System.Drawing.Point(40, 318);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(70, 25);
            this.lbl_count.TabIndex = 13;
            this.lbl_count.Text = "Count";
            this.lbl_count.Click += new System.EventHandler(this.lbl_count_Click);
            // 
            // lbl_numExtRefs
            // 
            this.lbl_numExtRefs.AutoSize = true;
            this.lbl_numExtRefs.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numExtRefs.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numExtRefs.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_numExtRefs.Location = new System.Drawing.Point(347, 318);
            this.lbl_numExtRefs.Name = "lbl_numExtRefs";
            this.lbl_numExtRefs.Size = new System.Drawing.Size(26, 25);
            this.lbl_numExtRefs.TabIndex = 14;
            this.lbl_numExtRefs.Text = "0";
            this.lbl_numExtRefs.Click += new System.EventHandler(this.lbl_numExtRefs_Click);
            // 
            // lbl_numClasses
            // 
            this.lbl_numClasses.AutoSize = true;
            this.lbl_numClasses.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numClasses.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numClasses.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_numClasses.Location = new System.Drawing.Point(639, 318);
            this.lbl_numClasses.Name = "lbl_numClasses";
            this.lbl_numClasses.Size = new System.Drawing.Size(26, 25);
            this.lbl_numClasses.TabIndex = 15;
            this.lbl_numClasses.Text = "0";
            this.lbl_numClasses.Click += new System.EventHandler(this.lbl_numClasses_Click);
            // 
            // lbl_numMethods
            // 
            this.lbl_numMethods.AutoSize = true;
            this.lbl_numMethods.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numMethods.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numMethods.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_numMethods.Location = new System.Drawing.Point(933, 318);
            this.lbl_numMethods.Name = "lbl_numMethods";
            this.lbl_numMethods.Size = new System.Drawing.Size(26, 25);
            this.lbl_numMethods.TabIndex = 16;
            this.lbl_numMethods.Text = "0";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.checkBox1.Location = new System.Drawing.Point(782, 387);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(177, 25);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Toggle Full Names";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbo_filterMethods
            // 
            this.cbo_filterMethods.FormattingEnabled = true;
            this.cbo_filterMethods.Items.AddRange(new object[] {
            "All",
            "Abstract",
            "Constructor",
            "Private",
            "Public",
            "Static",
            "Virtual"});
            this.cbo_filterMethods.Location = new System.Drawing.Point(841, 67);
            this.cbo_filterMethods.Name = "cbo_filterMethods";
            this.cbo_filterMethods.Size = new System.Drawing.Size(118, 21);
            this.cbo_filterMethods.TabIndex = 18;
            this.cbo_filterMethods.SelectedIndexChanged += new System.EventHandler(this.cbo_filterMethods_SelectedIndexChanged);
            // 
            // lbl_filter
            // 
            this.lbl_filter.AutoSize = true;
            this.lbl_filter.BackColor = System.Drawing.Color.Transparent;
            this.lbl_filter.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filter.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_filter.Location = new System.Drawing.Point(685, 68);
            this.lbl_filter.Name = "lbl_filter";
            this.lbl_filter.Size = new System.Drawing.Size(79, 20);
            this.lbl_filter.TabIndex = 19;
            this.lbl_filter.Text = "Filter by:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
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
            // AssemblyAssessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppAssessor.Properties.Resources.blue_butterfly_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1038, 450);
            this.Controls.Add(this.lbl_filter);
            this.Controls.Add(this.cbo_filterMethods);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lbl_numMethods);
            this.Controls.Add(this.lbl_numClasses);
            this.Controls.Add(this.lbl_numExtRefs);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_methods);
            this.Controls.Add(this.lst_classes);
            this.Controls.Add(this.lst_extRefs);
            this.Controls.Add(this.lbl_loadAssembly);
            this.Controls.Add(this.btn_loadAssembly);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AssemblyAssessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assembly Assessor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog fileDialog_Assembly;
        private System.Windows.Forms.Label lbl_loadAssembly;
        private System.Windows.Forms.Button btn_loadAssembly;
        private System.Windows.Forms.ListBox lst_extRefs;
        private System.Windows.Forms.ListBox lst_classes;
        private System.Windows.Forms.ListBox lst_methods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label lbl_numExtRefs;
        private System.Windows.Forms.Label lbl_numClasses;
        private System.Windows.Forms.Label lbl_numMethods;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cbo_filterMethods;
        private System.Windows.Forms.Label lbl_filter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAssemblyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}