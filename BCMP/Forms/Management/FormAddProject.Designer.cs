namespace BCMP.Forms
{
    partial class FormAddProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddProject));
            this.lb_newProject = new System.Windows.Forms.Label();
            this.lb_NameProject = new System.Windows.Forms.Label();
            this.lb_department = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_department = new System.Windows.Forms.ComboBox();
            this.dtpkPlannedEnd = new System.Windows.Forms.DateTimePicker();
            this.lb_description = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lb_member = new System.Windows.Forms.Label();
            this.txt_nameProject = new System.Windows.Forms.TextBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.pn_tittleAddProject = new System.Windows.Forms.Panel();
            this.pn_containerAddProject = new System.Windows.Forms.Panel();
            this.txt_IdProject = new System.Windows.Forms.TextBox();
            this.lb_IdProject = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_ValidDesciption = new System.Windows.Forms.Label();
            this.lb_ValidNameProject = new System.Windows.Forms.Label();
            this.lb_ValidIdProject = new System.Windows.Forms.Label();
            this.dtpkPlannedStart = new System.Windows.Forms.DateTimePicker();
            this.bt_exit = new FontAwesome.Sharp.IconButton();
            this.pn_tittleAddProject.SuspendLayout();
            this.pn_containerAddProject.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_newProject
            // 
            resources.ApplyResources(this.lb_newProject, "lb_newProject");
            this.lb_newProject.ForeColor = System.Drawing.Color.Black;
            this.lb_newProject.Name = "lb_newProject";
            // 
            // lb_NameProject
            // 
            resources.ApplyResources(this.lb_NameProject, "lb_NameProject");
            this.lb_NameProject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_NameProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_NameProject.Name = "lb_NameProject";
            // 
            // lb_department
            // 
            resources.ApplyResources(this.lb_department, "lb_department");
            this.lb_department.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_department.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_department.Name = "lb_department";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label3.Name = "label3";
            // 
            // cbb_department
            // 
            resources.ApplyResources(this.cbb_department, "cbb_department");
            this.cbb_department.FormattingEnabled = true;
            this.cbb_department.Name = "cbb_department";
            this.cbb_department.Leave += new System.EventHandler(this.cbb_department_Leave);
            // 
            // dtpkPlannedEnd
            // 
            resources.ApplyResources(this.dtpkPlannedEnd, "dtpkPlannedEnd");
            this.dtpkPlannedEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkPlannedEnd.Name = "dtpkPlannedEnd";
            // 
            // lb_description
            // 
            resources.ApplyResources(this.lb_description, "lb_description");
            this.lb_description.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_description.Name = "lb_description";
            // 
            // txt_Description
            // 
            resources.ApplyResources(this.txt_Description, "txt_Description");
            this.txt_Description.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Enter += new System.EventHandler(this.txt_Description_Enter);
            this.txt_Description.Leave += new System.EventHandler(this.txt_Description_Leave);
            // 
            // lb_member
            // 
            resources.ApplyResources(this.lb_member, "lb_member");
            this.lb_member.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_member.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_member.Name = "lb_member";
            // 
            // txt_nameProject
            // 
            resources.ApplyResources(this.txt_nameProject, "txt_nameProject");
            this.txt_nameProject.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_nameProject.Name = "txt_nameProject";
            this.txt_nameProject.Enter += new System.EventHandler(this.txt_nameProject_Enter);
            this.txt_nameProject.Leave += new System.EventHandler(this.txt_nameProject_Leave);
            // 
            // bt_save
            // 
            resources.ApplyResources(this.bt_save, "bt_save");
            this.bt_save.BackColor = System.Drawing.Color.Black;
            this.bt_save.ForeColor = System.Drawing.Color.White;
            this.bt_save.Name = "bt_save";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_cancel
            // 
            resources.ApplyResources(this.bt_cancel, "bt_cancel");
            this.bt_cancel.BackColor = System.Drawing.Color.White;
            this.bt_cancel.FlatAppearance.BorderSize = 0;
            this.bt_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_cancel.ForeColor = System.Drawing.Color.Black;
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            this.bt_cancel.MouseEnter += new System.EventHandler(this.bt_cancel_MouseEnter);
            this.bt_cancel.MouseLeave += new System.EventHandler(this.bt_cancel_MouseLeave);
            // 
            // pn_tittleAddProject
            // 
            resources.ApplyResources(this.pn_tittleAddProject, "pn_tittleAddProject");
            this.pn_tittleAddProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pn_tittleAddProject.Controls.Add(this.lb_newProject);
            this.pn_tittleAddProject.Controls.Add(this.bt_exit);
            this.pn_tittleAddProject.Name = "pn_tittleAddProject";
            // 
            // pn_containerAddProject
            // 
            resources.ApplyResources(this.pn_containerAddProject, "pn_containerAddProject");
            this.pn_containerAddProject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_containerAddProject.Controls.Add(this.txt_IdProject);
            this.pn_containerAddProject.Controls.Add(this.lb_IdProject);
            this.pn_containerAddProject.Controls.Add(this.txt_Description);
            this.pn_containerAddProject.Controls.Add(this.lb_department);
            this.pn_containerAddProject.Controls.Add(this.label2);
            this.pn_containerAddProject.Controls.Add(this.txt_nameProject);
            this.pn_containerAddProject.Controls.Add(this.label3);
            this.pn_containerAddProject.Controls.Add(this.lb_NameProject);
            this.pn_containerAddProject.Controls.Add(this.cbb_department);
            this.pn_containerAddProject.Controls.Add(this.lb_description);
            this.pn_containerAddProject.Controls.Add(this.dtpkPlannedEnd);
            this.pn_containerAddProject.Controls.Add(this.panel1);
            this.pn_containerAddProject.Name = "pn_containerAddProject";
            this.pn_containerAddProject.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_containerAddProject_Paint);
            // 
            // txt_IdProject
            // 
            resources.ApplyResources(this.txt_IdProject, "txt_IdProject");
            this.txt_IdProject.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_IdProject.Name = "txt_IdProject";
            this.txt_IdProject.TextChanged += new System.EventHandler(this.txt_IdProject_TextChanged);
            this.txt_IdProject.Enter += new System.EventHandler(this.txt_IdProject_Enter);
            this.txt_IdProject.Leave += new System.EventHandler(this.txt_IdProject_Leave);
            // 
            // lb_IdProject
            // 
            resources.ApplyResources(this.lb_IdProject, "lb_IdProject");
            this.lb_IdProject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_IdProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_IdProject.Name = "lb_IdProject";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.lb_ValidDesciption);
            this.panel1.Controls.Add(this.lb_ValidNameProject);
            this.panel1.Controls.Add(this.lb_ValidIdProject);
            this.panel1.Controls.Add(this.dtpkPlannedStart);
            this.panel1.Name = "panel1";
            // 
            // lb_ValidDesciption
            // 
            resources.ApplyResources(this.lb_ValidDesciption, "lb_ValidDesciption");
            this.lb_ValidDesciption.Name = "lb_ValidDesciption";
            // 
            // lb_ValidNameProject
            // 
            resources.ApplyResources(this.lb_ValidNameProject, "lb_ValidNameProject");
            this.lb_ValidNameProject.Name = "lb_ValidNameProject";
            // 
            // lb_ValidIdProject
            // 
            resources.ApplyResources(this.lb_ValidIdProject, "lb_ValidIdProject");
            this.lb_ValidIdProject.Name = "lb_ValidIdProject";
            // 
            // dtpkPlannedStart
            // 
            resources.ApplyResources(this.dtpkPlannedStart, "dtpkPlannedStart");
            this.dtpkPlannedStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkPlannedStart.Name = "dtpkPlannedStart";
            // 
            // bt_exit
            // 
            resources.ApplyResources(this.bt_exit, "bt_exit");
            this.bt_exit.BackColor = System.Drawing.Color.Transparent;
            this.bt_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_exit.FlatAppearance.BorderSize = 0;
            this.bt_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(144)))));
            this.bt_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.bt_exit.IconColor = System.Drawing.Color.Black;
            this.bt_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_exit.IconSize = 30;
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // FormAddProject
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pn_tittleAddProject);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.lb_member);
            this.Controls.Add(this.pn_containerAddProject);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddProject";
            this.pn_tittleAddProject.ResumeLayout(false);
            this.pn_tittleAddProject.PerformLayout();
            this.pn_containerAddProject.ResumeLayout(false);
            this.pn_containerAddProject.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_newProject;
        private System.Windows.Forms.Label lb_NameProject;
        private System.Windows.Forms.Label lb_department;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_department;
        private System.Windows.Forms.DateTimePicker dtpkPlannedEnd;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label lb_member;
        private System.Windows.Forms.TextBox txt_nameProject;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_cancel;
        private FontAwesome.Sharp.IconButton bt_exit;
        private System.Windows.Forms.Panel pn_tittleAddProject;
        private System.Windows.Forms.Panel pn_containerAddProject;
        private System.Windows.Forms.TextBox txt_IdProject;
        private System.Windows.Forms.Label lb_IdProject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpkPlannedStart;
        private System.Windows.Forms.Label lb_ValidDesciption;
        private System.Windows.Forms.Label lb_ValidNameProject;
        private System.Windows.Forms.Label lb_ValidIdProject;
    }
}