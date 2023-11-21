namespace BCMP.Forms.Management
{
    partial class FormDetailProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetailProject));
            this.lb_member = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.txt_IdProject = new System.Windows.Forms.TextBox();
            this.lb_description = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_department = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_exit = new FontAwesome.Sharp.IconButton();
            this.cbb_department = new System.Windows.Forms.ComboBox();
            this.dtpkPlannedEnd = new System.Windows.Forms.DateTimePicker();
            this.lb_IdProject = new System.Windows.Forms.Label();
            this.txt_nameProject = new System.Windows.Forms.TextBox();
            this.dtpkPlannedStart = new System.Windows.Forms.DateTimePicker();
            this.lb_NameProject = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_member
            // 
            resources.ApplyResources(this.lb_member, "lb_member");
            this.lb_member.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_member.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_member.Name = "lb_member";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.bt_save);
            this.panel1.Controls.Add(this.bt_cancel);
            this.panel1.Controls.Add(this.txt_Description);
            this.panel1.Controls.Add(this.txt_IdProject);
            this.panel1.Controls.Add(this.lb_description);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lb_department);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bt_exit);
            this.panel1.Controls.Add(this.cbb_department);
            this.panel1.Controls.Add(this.dtpkPlannedEnd);
            this.panel1.Controls.Add(this.lb_IdProject);
            this.panel1.Controls.Add(this.txt_nameProject);
            this.panel1.Controls.Add(this.dtpkPlannedStart);
            this.panel1.Controls.Add(this.lb_NameProject);
            this.panel1.Controls.Add(this.panel2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.bt_save, "bt_save");
            this.bt_save.ForeColor = System.Drawing.Color.White;
            this.bt_save.Name = "bt_save";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.White;
            this.bt_cancel.FlatAppearance.BorderSize = 0;
            this.bt_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.bt_cancel, "bt_cancel");
            this.bt_cancel.ForeColor = System.Drawing.Color.Black;
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            this.bt_cancel.MouseEnter += new System.EventHandler(this.bt_cancel_MouseEnter);
            this.bt_cancel.MouseLeave += new System.EventHandler(this.bt_cancel_MouseLeave);
            // 
            // txt_Description
            // 
            resources.ApplyResources(this.txt_Description, "txt_Description");
            this.txt_Description.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.ReadOnly = true;
            // 
            // txt_IdProject
            // 
            resources.ApplyResources(this.txt_IdProject, "txt_IdProject");
            this.txt_IdProject.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_IdProject.Name = "txt_IdProject";
            this.txt_IdProject.ReadOnly = true;
            // 
            // lb_description
            // 
            resources.ApplyResources(this.lb_description, "lb_description");
            this.lb_description.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_description.Name = "lb_description";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label2.Name = "label2";
            // 
            // lb_department
            // 
            resources.ApplyResources(this.lb_department, "lb_department");
            this.lb_department.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_department.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_department.Name = "lb_department";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label3.Name = "label3";
            // 
            // bt_exit
            // 
            resources.ApplyResources(this.bt_exit, "bt_exit");
            this.bt_exit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bt_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_exit.FlatAppearance.BorderSize = 0;
            this.bt_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.bt_exit.IconColor = System.Drawing.Color.Black;
            this.bt_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_exit.IconSize = 30;
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // cbb_department
            // 
            this.cbb_department.FormattingEnabled = true;
            resources.ApplyResources(this.cbb_department, "cbb_department");
            this.cbb_department.Name = "cbb_department";
            // 
            // dtpkPlannedEnd
            // 
            this.dtpkPlannedEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtpkPlannedEnd, "dtpkPlannedEnd");
            this.dtpkPlannedEnd.Name = "dtpkPlannedEnd";
            // 
            // lb_IdProject
            // 
            resources.ApplyResources(this.lb_IdProject, "lb_IdProject");
            this.lb_IdProject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_IdProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_IdProject.Name = "lb_IdProject";
            // 
            // txt_nameProject
            // 
            resources.ApplyResources(this.txt_nameProject, "txt_nameProject");
            this.txt_nameProject.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_nameProject.Name = "txt_nameProject";
            this.txt_nameProject.ReadOnly = true;
            // 
            // dtpkPlannedStart
            // 
            this.dtpkPlannedStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtpkPlannedStart, "dtpkPlannedStart");
            this.dtpkPlannedStart.Name = "dtpkPlannedStart";
            // 
            // lb_NameProject
            // 
            resources.ApplyResources(this.lb_NameProject, "lb_NameProject");
            this.lb_NameProject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_NameProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_NameProject.Name = "lb_NameProject";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // FormDetailProject
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_member);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDetailProject";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_member;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.TextBox txt_IdProject;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_department;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton bt_exit;
        private System.Windows.Forms.ComboBox cbb_department;
        private System.Windows.Forms.DateTimePicker dtpkPlannedEnd;
        private System.Windows.Forms.Label lb_IdProject;
        private System.Windows.Forms.TextBox txt_nameProject;
        private System.Windows.Forms.DateTimePicker dtpkPlannedStart;
        private System.Windows.Forms.Label lb_NameProject;
        private System.Windows.Forms.Panel panel2;
    }
}