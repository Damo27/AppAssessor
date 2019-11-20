namespace AppAssessor
{
    partial class frm_home
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assessAssemblyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assessClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assessInterfacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assessHierarchyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_assembly = new System.Windows.Forms.Button();
            this.btn_classes = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.lbl_assembly = new System.Windows.Forms.Label();
            this.lbl_classes = new System.Windows.Forms.Label();
            this.lbl_settings = new System.Windows.Forms.Label();
            this.lbl_interface = new System.Windows.Forms.Label();
            this.btn_interface = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_hierarchy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_association = new System.Windows.Forms.Button();
            this.assessAssociationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assessAssemblyToolStripMenuItem,
            this.assessClassToolStripMenuItem,
            this.assessInterfacesToolStripMenuItem,
            this.assessHierarchyToolStripMenuItem,
            this.assessAssociationToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // assessAssemblyToolStripMenuItem
            // 
            this.assessAssemblyToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.assessAssemblyToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.assessAssemblyToolStripMenuItem.Name = "assessAssemblyToolStripMenuItem";
            this.assessAssemblyToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.assessAssemblyToolStripMenuItem.Text = "Assess Assembly";
            this.assessAssemblyToolStripMenuItem.Click += new System.EventHandler(this.assessAssemblyToolStripMenuItem_Click);
            // 
            // assessClassToolStripMenuItem
            // 
            this.assessClassToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.assessClassToolStripMenuItem.Name = "assessClassToolStripMenuItem";
            this.assessClassToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.assessClassToolStripMenuItem.Text = "Assess Class";
            this.assessClassToolStripMenuItem.Click += new System.EventHandler(this.assessClassToolStripMenuItem_Click);
            // 
            // assessInterfacesToolStripMenuItem
            // 
            this.assessInterfacesToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.assessInterfacesToolStripMenuItem.Name = "assessInterfacesToolStripMenuItem";
            this.assessInterfacesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.assessInterfacesToolStripMenuItem.Text = "Assess Interfaces";
            // 
            // assessHierarchyToolStripMenuItem
            // 
            this.assessHierarchyToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.assessHierarchyToolStripMenuItem.Name = "assessHierarchyToolStripMenuItem";
            this.assessHierarchyToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.assessHierarchyToolStripMenuItem.Text = "Assess Hierarchy";
            this.assessHierarchyToolStripMenuItem.Click += new System.EventHandler(this.assessHierarchyToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btn_assembly
            // 
            this.btn_assembly.BackColor = System.Drawing.Color.Transparent;
            this.btn_assembly.BackgroundImage = global::AppAssessor.Properties.Resources.assembly;
            this.btn_assembly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_assembly.FlatAppearance.BorderSize = 0;
            this.btn_assembly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_assembly.Location = new System.Drawing.Point(226, 78);
            this.btn_assembly.Name = "btn_assembly";
            this.btn_assembly.Size = new System.Drawing.Size(87, 74);
            this.btn_assembly.TabIndex = 1;
            this.btn_assembly.UseVisualStyleBackColor = false;
            this.btn_assembly.Click += new System.EventHandler(this.btn_assembly_Click);
            // 
            // btn_classes
            // 
            this.btn_classes.BackColor = System.Drawing.Color.Transparent;
            this.btn_classes.BackgroundImage = global::AppAssessor.Properties.Resources._class;
            this.btn_classes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_classes.FlatAppearance.BorderSize = 0;
            this.btn_classes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_classes.Location = new System.Drawing.Point(226, 206);
            this.btn_classes.Name = "btn_classes";
            this.btn_classes.Size = new System.Drawing.Size(87, 74);
            this.btn_classes.TabIndex = 2;
            this.btn_classes.UseVisualStyleBackColor = false;
            this.btn_classes.Click += new System.EventHandler(this.btn_classes_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_settings.BackgroundImage = global::AppAssessor.Properties.Resources.settings2;
            this.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Location = new System.Drawing.Point(521, 336);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(87, 74);
            this.btn_settings.TabIndex = 3;
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // lbl_assembly
            // 
            this.lbl_assembly.AutoSize = true;
            this.lbl_assembly.BackColor = System.Drawing.Color.Transparent;
            this.lbl_assembly.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_assembly.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_assembly.Location = new System.Drawing.Point(12, 112);
            this.lbl_assembly.Name = "lbl_assembly";
            this.lbl_assembly.Size = new System.Drawing.Size(165, 25);
            this.lbl_assembly.TabIndex = 4;
            this.lbl_assembly.Text = "Assess Assembly";
            // 
            // lbl_classes
            // 
            this.lbl_classes.AutoSize = true;
            this.lbl_classes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_classes.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_classes.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_classes.Location = new System.Drawing.Point(31, 229);
            this.lbl_classes.Name = "lbl_classes";
            this.lbl_classes.Size = new System.Drawing.Size(146, 25);
            this.lbl_classes.TabIndex = 5;
            this.lbl_classes.Text = "Assess Classes";
            // 
            // lbl_settings
            // 
            this.lbl_settings.AutoSize = true;
            this.lbl_settings.BackColor = System.Drawing.Color.Transparent;
            this.lbl_settings.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_settings.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_settings.Location = new System.Drawing.Point(378, 359);
            this.lbl_settings.Name = "lbl_settings";
            this.lbl_settings.Size = new System.Drawing.Size(88, 25);
            this.lbl_settings.TabIndex = 6;
            this.lbl_settings.Text = "Settings";
            // 
            // lbl_interface
            // 
            this.lbl_interface.AutoSize = true;
            this.lbl_interface.BackColor = System.Drawing.Color.Transparent;
            this.lbl_interface.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_interface.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_interface.Location = new System.Drawing.Point(339, 112);
            this.lbl_interface.Name = "lbl_interface";
            this.lbl_interface.Size = new System.Drawing.Size(174, 25);
            this.lbl_interface.TabIndex = 8;
            this.lbl_interface.Text = "Assess Interfaces";
            // 
            // btn_interface
            // 
            this.btn_interface.BackColor = System.Drawing.Color.Transparent;
            this.btn_interface.BackgroundImage = global::AppAssessor.Properties.Resources._class;
            this.btn_interface.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_interface.FlatAppearance.BorderSize = 0;
            this.btn_interface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_interface.Location = new System.Drawing.Point(521, 78);
            this.btn_interface.Name = "btn_interface";
            this.btn_interface.Size = new System.Drawing.Size(87, 74);
            this.btn_interface.TabIndex = 7;
            this.btn_interface.UseVisualStyleBackColor = false;
            this.btn_interface.Click += new System.EventHandler(this.btn_interface_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(338, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Assess Hierarchy";
            // 
            // btn_hierarchy
            // 
            this.btn_hierarchy.BackColor = System.Drawing.Color.Transparent;
            this.btn_hierarchy.BackgroundImage = global::AppAssessor.Properties.Resources.hierarchy;
            this.btn_hierarchy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hierarchy.FlatAppearance.BorderSize = 0;
            this.btn_hierarchy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hierarchy.Location = new System.Drawing.Point(521, 206);
            this.btn_hierarchy.Name = "btn_hierarchy";
            this.btn_hierarchy.Size = new System.Drawing.Size(87, 74);
            this.btn_hierarchy.TabIndex = 9;
            this.btn_hierarchy.UseVisualStyleBackColor = false;
            this.btn_hierarchy.Click += new System.EventHandler(this.btn_hierarchy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(43, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Assess Association";
            // 
            // btn_association
            // 
            this.btn_association.BackColor = System.Drawing.Color.Transparent;
            this.btn_association.BackgroundImage = global::AppAssessor.Properties.Resources.association;
            this.btn_association.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_association.FlatAppearance.BorderSize = 0;
            this.btn_association.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_association.Location = new System.Drawing.Point(226, 336);
            this.btn_association.Name = "btn_association";
            this.btn_association.Size = new System.Drawing.Size(87, 74);
            this.btn_association.TabIndex = 11;
            this.btn_association.UseVisualStyleBackColor = false;
            this.btn_association.Click += new System.EventHandler(this.btn_association_Click);
            // 
            // assessAssociationToolStripMenuItem
            // 
            this.assessAssociationToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.assessAssociationToolStripMenuItem.Name = "assessAssociationToolStripMenuItem";
            this.assessAssociationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.assessAssociationToolStripMenuItem.Text = "Assess Association";
            this.assessAssociationToolStripMenuItem.Click += new System.EventHandler(this.assessAssociationToolStripMenuItem_Click);
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::AppAssessor.Properties.Resources.blue_butterfly_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(694, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_association);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_hierarchy);
            this.Controls.Add(this.lbl_interface);
            this.Controls.Add(this.btn_interface);
            this.Controls.Add(this.lbl_settings);
            this.Controls.Add(this.lbl_classes);
            this.Controls.Add(this.lbl_assembly);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_classes);
            this.Controls.Add(this.btn_assembly);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assessAssemblyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assessClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button btn_assembly;
        private System.Windows.Forms.Button btn_classes;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Label lbl_assembly;
        private System.Windows.Forms.Label lbl_classes;
        private System.Windows.Forms.Label lbl_settings;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assessInterfacesToolStripMenuItem;
        private System.Windows.Forms.Label lbl_interface;
        private System.Windows.Forms.Button btn_interface;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_hierarchy;
        private System.Windows.Forms.ToolStripMenuItem assessHierarchyToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_association;
        private System.Windows.Forms.ToolStripMenuItem assessAssociationToolStripMenuItem;
    }
}

