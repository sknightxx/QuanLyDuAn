﻿namespace BCMP.Forms
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
            this.lb_newProject = new System.Windows.Forms.Label();
            this.lb_NameProject = new System.Windows.Forms.Label();
            this.lb_department = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_department = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lb_description = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lb_member = new System.Windows.Forms.Label();
            this.txt_nameProject = new System.Windows.Forms.TextBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_exit = new FontAwesome.Sharp.IconButton();
            this.pn_tittleAddProject = new System.Windows.Forms.Panel();
            this.pn_containerAddProject = new System.Windows.Forms.Panel();
            this.txt_management = new System.Windows.Forms.TextBox();
            this.lb_Management = new System.Windows.Forms.Label();
            this.txt_IdProject = new System.Windows.Forms.TextBox();
            this.lb_IdProject = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_tittleAddProject.SuspendLayout();
            this.pn_containerAddProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_newProject
            // 
            this.lb_newProject.AutoSize = true;
            this.lb_newProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_newProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(144)))));
            this.lb_newProject.Location = new System.Drawing.Point(10, 9);
            this.lb_newProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_newProject.Name = "lb_newProject";
            this.lb_newProject.Size = new System.Drawing.Size(122, 24);
            this.lb_newProject.TabIndex = 0;
            this.lb_newProject.Text = "New project";
            // 
            // lb_NameProject
            // 
            this.lb_NameProject.AutoSize = true;
            this.lb_NameProject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_NameProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NameProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_NameProject.Location = new System.Drawing.Point(21, 138);
            this.lb_NameProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NameProject.Name = "lb_NameProject";
            this.lb_NameProject.Size = new System.Drawing.Size(114, 18);
            this.lb_NameProject.TabIndex = 1;
            this.lb_NameProject.Text = "Name of project";
            // 
            // lb_department
            // 
            this.lb_department.AutoSize = true;
            this.lb_department.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_department.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_department.Location = new System.Drawing.Point(22, 224);
            this.lb_department.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_department.Name = "lb_department";
            this.lb_department.Size = new System.Drawing.Size(85, 18);
            this.lb_department.TabIndex = 3;
            this.lb_department.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label2.Location = new System.Drawing.Point(366, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label3.Location = new System.Drawing.Point(522, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "To";
            // 
            // cbb_department
            // 
            this.cbb_department.FormattingEnabled = true;
            this.cbb_department.Location = new System.Drawing.Point(26, 254);
            this.cbb_department.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_department.Name = "cbb_department";
            this.cbb_department.Size = new System.Drawing.Size(296, 21);
            this.cbb_department.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(353, 254);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(506, 256);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_description.Location = new System.Drawing.Point(22, 302);
            this.lb_description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(83, 18);
            this.lb_description.TabIndex = 9;
            this.lb_description.Text = "Description";
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(26, 337);
            this.txt_Description.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(618, 95);
            this.txt_Description.TabIndex = 10;
            // 
            // lb_member
            // 
            this.lb_member.AutoSize = true;
            this.lb_member.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_member.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_member.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_member.Location = new System.Drawing.Point(30, 372);
            this.lb_member.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_member.Name = "lb_member";
            this.lb_member.Size = new System.Drawing.Size(0, 18);
            this.lb_member.TabIndex = 11;
            // 
            // txt_nameProject
            // 
            this.txt_nameProject.Location = new System.Drawing.Point(25, 166);
            this.txt_nameProject.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nameProject.Multiline = true;
            this.txt_nameProject.Name = "txt_nameProject";
            this.txt_nameProject.Size = new System.Drawing.Size(618, 29);
            this.txt_nameProject.TabIndex = 12;
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(144)))));
            this.bt_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_save.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.ForeColor = System.Drawing.Color.White;
            this.bt_save.Location = new System.Drawing.Point(553, 489);
            this.bt_save.Margin = new System.Windows.Forms.Padding(2);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(90, 34);
            this.bt_save.TabIndex = 13;
            this.bt_save.Text = "SAVE";
            this.bt_save.UseVisualStyleBackColor = false;
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.White;
            this.bt_cancel.FlatAppearance.BorderSize = 0;
            this.bt_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(144)))));
            this.bt_cancel.Location = new System.Drawing.Point(450, 489);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(90, 34);
            this.bt_cancel.TabIndex = 14;
            this.bt_cancel.Text = "CANCEL";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            this.bt_cancel.MouseEnter += new System.EventHandler(this.bt_cancel_MouseEnter);
            this.bt_cancel.MouseLeave += new System.EventHandler(this.bt_cancel_MouseLeave);
            // 
            // bt_exit
            // 
            this.bt_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_exit.BackColor = System.Drawing.Color.Transparent;
            this.bt_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_exit.FlatAppearance.BorderSize = 0;
            this.bt_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_exit.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(144)))));
            this.bt_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.bt_exit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(144)))));
            this.bt_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_exit.IconSize = 30;
            this.bt_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_exit.Location = new System.Drawing.Point(618, 9);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(2);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Padding = new System.Windows.Forms.Padding(9, 0, 16, 0);
            this.bt_exit.Size = new System.Drawing.Size(45, 24);
            this.bt_exit.TabIndex = 15;
            this.bt_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // pn_tittleAddProject
            // 
            this.pn_tittleAddProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pn_tittleAddProject.Controls.Add(this.lb_newProject);
            this.pn_tittleAddProject.Controls.Add(this.bt_exit);
            this.pn_tittleAddProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_tittleAddProject.Location = new System.Drawing.Point(0, 0);
            this.pn_tittleAddProject.Margin = new System.Windows.Forms.Padding(2);
            this.pn_tittleAddProject.Name = "pn_tittleAddProject";
            this.pn_tittleAddProject.Size = new System.Drawing.Size(674, 58);
            this.pn_tittleAddProject.TabIndex = 16;
            // 
            // pn_containerAddProject
            // 
            this.pn_containerAddProject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_containerAddProject.Controls.Add(this.txt_management);
            this.pn_containerAddProject.Controls.Add(this.lb_Management);
            this.pn_containerAddProject.Controls.Add(this.txt_IdProject);
            this.pn_containerAddProject.Controls.Add(this.lb_IdProject);
            this.pn_containerAddProject.Controls.Add(this.txt_Description);
            this.pn_containerAddProject.Controls.Add(this.lb_department);
            this.pn_containerAddProject.Controls.Add(this.label2);
            this.pn_containerAddProject.Controls.Add(this.txt_nameProject);
            this.pn_containerAddProject.Controls.Add(this.label3);
            this.pn_containerAddProject.Controls.Add(this.lb_NameProject);
            this.pn_containerAddProject.Controls.Add(this.cbb_department);
            this.pn_containerAddProject.Controls.Add(this.dateTimePicker1);
            this.pn_containerAddProject.Controls.Add(this.lb_description);
            this.pn_containerAddProject.Controls.Add(this.dateTimePicker2);
            this.pn_containerAddProject.Controls.Add(this.panel1);
            this.pn_containerAddProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_containerAddProject.Location = new System.Drawing.Point(0, 0);
            this.pn_containerAddProject.Margin = new System.Windows.Forms.Padding(2);
            this.pn_containerAddProject.Name = "pn_containerAddProject";
            this.pn_containerAddProject.Size = new System.Drawing.Size(674, 550);
            this.pn_containerAddProject.TabIndex = 17;
            this.pn_containerAddProject.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_containerAddProject_Paint);
            // 
            // txt_management
            // 
            this.txt_management.Location = new System.Drawing.Point(353, 96);
            this.txt_management.Margin = new System.Windows.Forms.Padding(2);
            this.txt_management.Multiline = true;
            this.txt_management.Name = "txt_management";
            this.txt_management.Size = new System.Drawing.Size(290, 29);
            this.txt_management.TabIndex = 16;
            // 
            // lb_Management
            // 
            this.lb_Management.AutoSize = true;
            this.lb_Management.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Management.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Management.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_Management.Location = new System.Drawing.Point(350, 68);
            this.lb_Management.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Management.Name = "lb_Management";
            this.lb_Management.Size = new System.Drawing.Size(94, 18);
            this.lb_Management.TabIndex = 15;
            this.lb_Management.Text = "Management";
            // 
            // txt_IdProject
            // 
            this.txt_IdProject.Location = new System.Drawing.Point(26, 96);
            this.txt_IdProject.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IdProject.Multiline = true;
            this.txt_IdProject.Name = "txt_IdProject";
            this.txt_IdProject.Size = new System.Drawing.Size(210, 29);
            this.txt_IdProject.TabIndex = 14;
            // 
            // lb_IdProject
            // 
            this.lb_IdProject.AutoSize = true;
            this.lb_IdProject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_IdProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IdProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_IdProject.Location = new System.Drawing.Point(22, 68);
            this.lb_IdProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_IdProject.Name = "lb_IdProject";
            this.lb_IdProject.Size = new System.Drawing.Size(71, 18);
            this.lb_IdProject.TabIndex = 13;
            this.lb_IdProject.Text = "ID project";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 550);
            this.panel1.TabIndex = 17;
            // 
            // FormAddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(674, 550);
            this.Controls.Add(this.pn_tittleAddProject);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.lb_member);
            this.Controls.Add(this.pn_containerAddProject);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddProject";
            this.pn_tittleAddProject.ResumeLayout(false);
            this.pn_tittleAddProject.PerformLayout();
            this.pn_containerAddProject.ResumeLayout(false);
            this.pn_containerAddProject.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
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
        private System.Windows.Forms.TextBox txt_management;
        private System.Windows.Forms.Label lb_Management;
        private System.Windows.Forms.Panel panel1;
    }
}