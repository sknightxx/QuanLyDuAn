namespace BCMP.Forms
{
    partial class FormAddUser
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
            this.pn_tittleFormAddUser = new System.Windows.Forms.Panel();
            this.bt_exit = new FontAwesome.Sharp.IconButton();
            this.lb_NewProfile = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_department = new System.Windows.Forms.Label();
            this.txt_department = new System.Windows.Forms.TextBox();
            this.lb_placeOfBirth = new System.Windows.Forms.Label();
            this.txt_role = new System.Windows.Forms.TextBox();
            this.bt_saveAddUser = new System.Windows.Forms.Button();
            this.bt_cancelAddUser = new System.Windows.Forms.Button();
            this.pn_containerFormAddUser = new System.Windows.Forms.Panel();
            this.txt_IdStaff = new System.Windows.Forms.TextBox();
            this.lb_IdStaff = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.pn_tittleFormAddUser.SuspendLayout();
            this.pn_containerFormAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_tittleFormAddUser
            // 
            this.pn_tittleFormAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pn_tittleFormAddUser.Controls.Add(this.bt_exit);
            this.pn_tittleFormAddUser.Controls.Add(this.lb_NewProfile);
            this.pn_tittleFormAddUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_tittleFormAddUser.Location = new System.Drawing.Point(0, 0);
            this.pn_tittleFormAddUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn_tittleFormAddUser.Name = "pn_tittleFormAddUser";
            this.pn_tittleFormAddUser.Size = new System.Drawing.Size(674, 58);
            this.pn_tittleFormAddUser.TabIndex = 1;
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
            this.bt_exit.ForeColor = System.Drawing.Color.Transparent;
            this.bt_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.bt_exit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.bt_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_exit.IconSize = 30;
            this.bt_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_exit.Location = new System.Drawing.Point(622, 9);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Padding = new System.Windows.Forms.Padding(9, 0, 16, 0);
            this.bt_exit.Size = new System.Drawing.Size(41, 18);
            this.bt_exit.TabIndex = 16;
            this.bt_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // lb_NewProfile
            // 
            this.lb_NewProfile.AutoSize = true;
            this.lb_NewProfile.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NewProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.lb_NewProfile.Location = new System.Drawing.Point(10, 9);
            this.lb_NewProfile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NewProfile.Name = "lb_NewProfile";
            this.lb_NewProfile.Size = new System.Drawing.Size(114, 23);
            this.lb_NewProfile.TabIndex = 2;
            this.lb_NewProfile.Text = "New profile";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.BackColor = System.Drawing.Color.Transparent;
            this.lb_Email.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.ForeColor = System.Drawing.Color.Black;
            this.lb_Email.Location = new System.Drawing.Point(166, 130);
            this.lb_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(46, 19);
            this.lb_Email.TabIndex = 19;
            this.lb_Email.Text = "Email";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.BackColor = System.Drawing.Color.Transparent;
            this.lb_Name.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.ForeColor = System.Drawing.Color.Black;
            this.lb_Name.Location = new System.Drawing.Point(166, 185);
            this.lb_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(76, 19);
            this.lb_Name.TabIndex = 18;
            this.lb_Name.Text = "Full name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(282, 179);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(194, 27);
            this.txt_name.TabIndex = 21;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(282, 124);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(194, 27);
            this.txt_Email.TabIndex = 20;
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.BackColor = System.Drawing.Color.Transparent;
            this.lb_phone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.ForeColor = System.Drawing.Color.Black;
            this.lb_phone.Location = new System.Drawing.Point(166, 241);
            this.lb_phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(53, 19);
            this.lb_phone.TabIndex = 22;
            this.lb_phone.Text = "Phone";
            // 
            // lb_department
            // 
            this.lb_department.AutoSize = true;
            this.lb_department.BackColor = System.Drawing.Color.Transparent;
            this.lb_department.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_department.ForeColor = System.Drawing.Color.Black;
            this.lb_department.Location = new System.Drawing.Point(166, 294);
            this.lb_department.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_department.Name = "lb_department";
            this.lb_department.Size = new System.Drawing.Size(93, 19);
            this.lb_department.TabIndex = 23;
            this.lb_department.Text = "Department";
            // 
            // txt_department
            // 
            this.txt_department.Location = new System.Drawing.Point(282, 288);
            this.txt_department.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_department.Multiline = true;
            this.txt_department.Name = "txt_department";
            this.txt_department.Size = new System.Drawing.Size(194, 27);
            this.txt_department.TabIndex = 24;
            // 
            // lb_placeOfBirth
            // 
            this.lb_placeOfBirth.AutoSize = true;
            this.lb_placeOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.lb_placeOfBirth.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_placeOfBirth.ForeColor = System.Drawing.Color.Black;
            this.lb_placeOfBirth.Location = new System.Drawing.Point(166, 346);
            this.lb_placeOfBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_placeOfBirth.Name = "lb_placeOfBirth";
            this.lb_placeOfBirth.Size = new System.Drawing.Size(39, 19);
            this.lb_placeOfBirth.TabIndex = 25;
            this.lb_placeOfBirth.Text = "Role";
            // 
            // txt_role
            // 
            this.txt_role.Location = new System.Drawing.Point(281, 343);
            this.txt_role.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_role.Multiline = true;
            this.txt_role.Name = "txt_role";
            this.txt_role.Size = new System.Drawing.Size(194, 27);
            this.txt_role.TabIndex = 26;
            // 
            // bt_saveAddUser
            // 
            this.bt_saveAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.bt_saveAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_saveAddUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.bt_saveAddUser.FlatAppearance.BorderSize = 0;
            this.bt_saveAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_saveAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_saveAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_saveAddUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_saveAddUser.ForeColor = System.Drawing.Color.White;
            this.bt_saveAddUser.Location = new System.Drawing.Point(66, 723);
            this.bt_saveAddUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_saveAddUser.Name = "bt_saveAddUser";
            this.bt_saveAddUser.Size = new System.Drawing.Size(60, 18);
            this.bt_saveAddUser.TabIndex = 4;
            this.bt_saveAddUser.Text = "Save";
            this.bt_saveAddUser.UseVisualStyleBackColor = false;
            // 
            // bt_cancelAddUser
            // 
            this.bt_cancelAddUser.BackColor = System.Drawing.Color.White;
            this.bt_cancelAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancelAddUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_cancelAddUser.FlatAppearance.BorderSize = 2;
            this.bt_cancelAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_cancelAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_cancelAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelAddUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.bt_cancelAddUser.Location = new System.Drawing.Point(-32, 723);
            this.bt_cancelAddUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_cancelAddUser.Name = "bt_cancelAddUser";
            this.bt_cancelAddUser.Size = new System.Drawing.Size(83, 30);
            this.bt_cancelAddUser.TabIndex = 3;
            this.bt_cancelAddUser.Text = "Cancel";
            this.bt_cancelAddUser.UseVisualStyleBackColor = false;
            this.bt_cancelAddUser.MouseEnter += new System.EventHandler(this.bt_cancelAddUser_MouseEnter);
            this.bt_cancelAddUser.MouseLeave += new System.EventHandler(this.bt_cancelAddUser_MouseLeave);
            // 
            // pn_containerFormAddUser
            // 
            this.pn_containerFormAddUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_containerFormAddUser.Controls.Add(this.txt_IdStaff);
            this.pn_containerFormAddUser.Controls.Add(this.lb_IdStaff);
            this.pn_containerFormAddUser.Controls.Add(this.bt_cancel);
            this.pn_containerFormAddUser.Controls.Add(this.bt_save);
            this.pn_containerFormAddUser.Controls.Add(this.txt_phone);
            this.pn_containerFormAddUser.Controls.Add(this.bt_cancelAddUser);
            this.pn_containerFormAddUser.Controls.Add(this.bt_saveAddUser);
            this.pn_containerFormAddUser.Controls.Add(this.txt_role);
            this.pn_containerFormAddUser.Controls.Add(this.lb_placeOfBirth);
            this.pn_containerFormAddUser.Controls.Add(this.txt_department);
            this.pn_containerFormAddUser.Controls.Add(this.lb_department);
            this.pn_containerFormAddUser.Controls.Add(this.lb_phone);
            this.pn_containerFormAddUser.Controls.Add(this.txt_Email);
            this.pn_containerFormAddUser.Controls.Add(this.txt_name);
            this.pn_containerFormAddUser.Controls.Add(this.lb_Name);
            this.pn_containerFormAddUser.Controls.Add(this.lb_Email);
            this.pn_containerFormAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_containerFormAddUser.Location = new System.Drawing.Point(0, 0);
            this.pn_containerFormAddUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn_containerFormAddUser.Name = "pn_containerFormAddUser";
            this.pn_containerFormAddUser.Size = new System.Drawing.Size(674, 550);
            this.pn_containerFormAddUser.TabIndex = 0;
            this.pn_containerFormAddUser.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_containerFormAddUser_Paint);
            // 
            // txt_IdStaff
            // 
            this.txt_IdStaff.Location = new System.Drawing.Point(282, 78);
            this.txt_IdStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_IdStaff.Multiline = true;
            this.txt_IdStaff.Name = "txt_IdStaff";
            this.txt_IdStaff.Size = new System.Drawing.Size(194, 27);
            this.txt_IdStaff.TabIndex = 31;
            // 
            // lb_IdStaff
            // 
            this.lb_IdStaff.AutoSize = true;
            this.lb_IdStaff.BackColor = System.Drawing.Color.Transparent;
            this.lb_IdStaff.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IdStaff.ForeColor = System.Drawing.Color.Black;
            this.lb_IdStaff.Location = new System.Drawing.Point(166, 85);
            this.lb_IdStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_IdStaff.Name = "lb_IdStaff";
            this.lb_IdStaff.Size = new System.Drawing.Size(56, 19);
            this.lb_IdStaff.TabIndex = 30;
            this.lb_IdStaff.Text = "ID Staff";
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.White;
            this.bt_cancel.FlatAppearance.BorderSize = 0;
            this.bt_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.bt_cancel.Location = new System.Drawing.Point(452, 498);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(90, 34);
            this.bt_cancel.TabIndex = 29;
            this.bt_cancel.Text = "CANCEL";
            this.bt_cancel.UseVisualStyleBackColor = false;
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.bt_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_save.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.ForeColor = System.Drawing.Color.White;
            this.bt_save.Location = new System.Drawing.Point(555, 498);
            this.bt_save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(90, 34);
            this.bt_save.TabIndex = 28;
            this.bt_save.Text = "SAVE";
            this.bt_save.UseVisualStyleBackColor = false;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(282, 231);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(194, 27);
            this.txt_phone.TabIndex = 27;
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(674, 550);
            this.Controls.Add(this.pn_tittleFormAddUser);
            this.Controls.Add(this.pn_containerFormAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddUser";
            this.pn_tittleFormAddUser.ResumeLayout(false);
            this.pn_tittleFormAddUser.PerformLayout();
            this.pn_containerFormAddUser.ResumeLayout(false);
            this.pn_containerFormAddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_NewProfile;
        private System.Windows.Forms.Panel pn_tittleFormAddUser;
        private FontAwesome.Sharp.IconButton bt_exit;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_department;
        private System.Windows.Forms.TextBox txt_department;
        private System.Windows.Forms.Label lb_placeOfBirth;
        private System.Windows.Forms.TextBox txt_role;
        private System.Windows.Forms.Button bt_saveAddUser;
        private System.Windows.Forms.Button bt_cancelAddUser;
        private System.Windows.Forms.Panel pn_containerFormAddUser;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.TextBox txt_IdStaff;
        private System.Windows.Forms.Label lb_IdStaff;
    }
}