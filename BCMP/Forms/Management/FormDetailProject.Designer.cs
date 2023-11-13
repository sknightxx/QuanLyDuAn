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
            this.lb_member.AutoSize = true;
            this.lb_member.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_member.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_member.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_member.Location = new System.Drawing.Point(40, 425);
            this.lb_member.Name = "lb_member";
            this.lb_member.Size = new System.Drawing.Size(0, 22);
            this.lb_member.TabIndex = 18;
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 576);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.Black;
            this.bt_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_save.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.ForeColor = System.Drawing.Color.White;
            this.bt_save.Location = new System.Drawing.Point(1051, 521);
            this.bt_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(120, 42);
            this.bt_save.TabIndex = 19;
            this.bt_save.Text = "EDIT";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.White;
            this.bt_cancel.FlatAppearance.BorderSize = 0;
            this.bt_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel.ForeColor = System.Drawing.Color.Black;
            this.bt_cancel.Location = new System.Drawing.Point(907, 521);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(120, 42);
            this.bt_cancel.TabIndex = 20;
            this.bt_cancel.Text = "CANCEL";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            this.bt_cancel.MouseEnter += new System.EventHandler(this.bt_cancel_MouseEnter);
            this.bt_cancel.MouseLeave += new System.EventHandler(this.bt_cancel_MouseLeave);
            // 
            // txt_Description
            // 
            this.txt_Description.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Description.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Description.Location = new System.Drawing.Point(33, 330);
            this.txt_Description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(1067, 116);
            this.txt_Description.TabIndex = 10;
            // 
            // txt_IdProject
            // 
            this.txt_IdProject.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdProject.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_IdProject.Location = new System.Drawing.Point(213, 26);
            this.txt_IdProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_IdProject.Multiline = true;
            this.txt_IdProject.Name = "txt_IdProject";
            this.txt_IdProject.Size = new System.Drawing.Size(279, 35);
            this.txt_IdProject.TabIndex = 14;
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_description.Location = new System.Drawing.Point(31, 293);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(100, 22);
            this.lb_description.TabIndex = 9;
            this.lb_description.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label2.Location = new System.Drawing.Point(731, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "From";
            // 
            // lb_department
            // 
            this.lb_department.AutoSize = true;
            this.lb_department.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_department.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_department.Location = new System.Drawing.Point(31, 214);
            this.lb_department.Name = "lb_department";
            this.lb_department.Size = new System.Drawing.Size(103, 22);
            this.lb_department.TabIndex = 3;
            this.lb_department.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label3.Location = new System.Drawing.Point(939, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "To";
            // 
            // bt_exit
            // 
            this.bt_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_exit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bt_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_exit.FlatAppearance.BorderSize = 0;
            this.bt_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_exit.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.bt_exit.IconColor = System.Drawing.Color.Black;
            this.bt_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_exit.IconSize = 30;
            this.bt_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_exit.Location = new System.Drawing.Point(1128, 9);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Padding = new System.Windows.Forms.Padding(12, 0, 21, 0);
            this.bt_exit.Size = new System.Drawing.Size(60, 30);
            this.bt_exit.TabIndex = 15;
            this.bt_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // cbb_department
            // 
            this.cbb_department.FormattingEnabled = true;
            this.cbb_department.Location = new System.Drawing.Point(213, 214);
            this.cbb_department.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_department.Name = "cbb_department";
            this.cbb_department.Size = new System.Drawing.Size(393, 24);
            this.cbb_department.TabIndex = 6;
            // 
            // dtpkPlannedEnd
            // 
            this.dtpkPlannedEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkPlannedEnd.Location = new System.Drawing.Point(917, 215);
            this.dtpkPlannedEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkPlannedEnd.Name = "dtpkPlannedEnd";
            this.dtpkPlannedEnd.Size = new System.Drawing.Size(183, 22);
            this.dtpkPlannedEnd.TabIndex = 8;
            // 
            // lb_IdProject
            // 
            this.lb_IdProject.AutoSize = true;
            this.lb_IdProject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_IdProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IdProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_IdProject.Location = new System.Drawing.Point(31, 28);
            this.lb_IdProject.Name = "lb_IdProject";
            this.lb_IdProject.Size = new System.Drawing.Size(86, 22);
            this.lb_IdProject.TabIndex = 13;
            this.lb_IdProject.Text = "ID project";
            // 
            // txt_nameProject
            // 
            this.txt_nameProject.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nameProject.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_nameProject.Location = new System.Drawing.Point(213, 113);
            this.txt_nameProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nameProject.Multiline = true;
            this.txt_nameProject.Name = "txt_nameProject";
            this.txt_nameProject.Size = new System.Drawing.Size(887, 35);
            this.txt_nameProject.TabIndex = 12;
            // 
            // dtpkPlannedStart
            // 
            this.dtpkPlannedStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkPlannedStart.Location = new System.Drawing.Point(695, 215);
            this.dtpkPlannedStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkPlannedStart.Name = "dtpkPlannedStart";
            this.dtpkPlannedStart.Size = new System.Drawing.Size(183, 22);
            this.dtpkPlannedStart.TabIndex = 18;
            // 
            // lb_NameProject
            // 
            this.lb_NameProject.AutoSize = true;
            this.lb_NameProject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_NameProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NameProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_NameProject.Location = new System.Drawing.Point(31, 116);
            this.lb_NameProject.Name = "lb_NameProject";
            this.lb_NameProject.Size = new System.Drawing.Size(136, 22);
            this.lb_NameProject.TabIndex = 1;
            this.lb_NameProject.Text = "Name of project";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1203, 576);
            this.panel2.TabIndex = 21;
            // 
            // FormDetailProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 576);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_member);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDetailProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetailProject";
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