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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUser));
            this.pn_tittleFormAddUser = new System.Windows.Forms.Panel();
            this.bt_exit = new FontAwesome.Sharp.IconButton();
            this.lb_NewProfile = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_department = new System.Windows.Forms.Label();
            this.lb_placeOfBirth = new System.Windows.Forms.Label();
            this.bt_saveAddUser = new System.Windows.Forms.Button();
            this.bt_cancelAddUser = new System.Windows.Forms.Button();
            this.pn_containerFormAddUser = new System.Windows.Forms.Panel();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lb_Valid_UserId = new System.Windows.Forms.Label();
            this.lb_outsource = new System.Windows.Forms.Label();
            this.lb_ValidConfirm = new System.Windows.Forms.Label();
            this.lb_ValidPassword = new System.Windows.Forms.Label();
            this.lb_ValidPhone = new System.Windows.Forms.Label();
            this.lb_ValidEmail = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_ValidFullname = new System.Windows.Forms.Label();
            this.txt_confirmPassword = new System.Windows.Forms.TextBox();
            this.lb_confirmPassword = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.cb_Role = new System.Windows.Forms.ComboBox();
            this.cb_Department = new System.Windows.Forms.ComboBox();
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
            resources.ApplyResources(this.pn_tittleFormAddUser, "pn_tittleFormAddUser");
            this.pn_tittleFormAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pn_tittleFormAddUser.Controls.Add(this.bt_exit);
            this.pn_tittleFormAddUser.Controls.Add(this.lb_NewProfile);
            this.pn_tittleFormAddUser.Name = "pn_tittleFormAddUser";
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
            this.bt_exit.ForeColor = System.Drawing.Color.Transparent;
            this.bt_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.bt_exit.IconColor = System.Drawing.Color.Black;
            this.bt_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_exit.IconSize = 30;
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // lb_NewProfile
            // 
            resources.ApplyResources(this.lb_NewProfile, "lb_NewProfile");
            this.lb_NewProfile.ForeColor = System.Drawing.Color.Black;
            this.lb_NewProfile.Name = "lb_NewProfile";
            // 
            // lb_Email
            // 
            resources.ApplyResources(this.lb_Email, "lb_Email");
            this.lb_Email.BackColor = System.Drawing.Color.Transparent;
            this.lb_Email.ForeColor = System.Drawing.Color.Black;
            this.lb_Email.Name = "lb_Email";
            // 
            // lb_Name
            // 
            resources.ApplyResources(this.lb_Name, "lb_Name");
            this.lb_Name.BackColor = System.Drawing.Color.Transparent;
            this.lb_Name.ForeColor = System.Drawing.Color.Black;
            this.lb_Name.Name = "lb_Name";
            // 
            // txt_name
            // 
            resources.ApplyResources(this.txt_name, "txt_name");
            this.txt_name.Name = "txt_name";
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            this.txt_name.Leave += new System.EventHandler(this.txt_name_Leave);
            // 
            // txt_Email
            // 
            resources.ApplyResources(this.txt_Email, "txt_Email");
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Leave += new System.EventHandler(this.txt_Email_Leave);
            // 
            // lb_phone
            // 
            resources.ApplyResources(this.lb_phone, "lb_phone");
            this.lb_phone.BackColor = System.Drawing.Color.Transparent;
            this.lb_phone.ForeColor = System.Drawing.Color.Black;
            this.lb_phone.Name = "lb_phone";
            // 
            // lb_department
            // 
            resources.ApplyResources(this.lb_department, "lb_department");
            this.lb_department.BackColor = System.Drawing.Color.Transparent;
            this.lb_department.ForeColor = System.Drawing.Color.Black;
            this.lb_department.Name = "lb_department";
            // 
            // lb_placeOfBirth
            // 
            resources.ApplyResources(this.lb_placeOfBirth, "lb_placeOfBirth");
            this.lb_placeOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.lb_placeOfBirth.ForeColor = System.Drawing.Color.Black;
            this.lb_placeOfBirth.Name = "lb_placeOfBirth";
            // 
            // bt_saveAddUser
            // 
            resources.ApplyResources(this.bt_saveAddUser, "bt_saveAddUser");
            this.bt_saveAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.bt_saveAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_saveAddUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.bt_saveAddUser.FlatAppearance.BorderSize = 0;
            this.bt_saveAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_saveAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_saveAddUser.ForeColor = System.Drawing.Color.White;
            this.bt_saveAddUser.Name = "bt_saveAddUser";
            this.bt_saveAddUser.UseVisualStyleBackColor = false;
            // 
            // bt_cancelAddUser
            // 
            resources.ApplyResources(this.bt_cancelAddUser, "bt_cancelAddUser");
            this.bt_cancelAddUser.BackColor = System.Drawing.Color.White;
            this.bt_cancelAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancelAddUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_cancelAddUser.FlatAppearance.BorderSize = 2;
            this.bt_cancelAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_cancelAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_cancelAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.bt_cancelAddUser.Name = "bt_cancelAddUser";
            this.bt_cancelAddUser.UseVisualStyleBackColor = false;
            this.bt_cancelAddUser.MouseEnter += new System.EventHandler(this.bt_cancelAddUser_MouseEnter);
            this.bt_cancelAddUser.MouseLeave += new System.EventHandler(this.bt_cancelAddUser_MouseLeave);
            // 
            // pn_containerFormAddUser
            // 
            resources.ApplyResources(this.pn_containerFormAddUser, "pn_containerFormAddUser");
            this.pn_containerFormAddUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_containerFormAddUser.Controls.Add(this.cbType);
            this.pn_containerFormAddUser.Controls.Add(this.lb_Valid_UserId);
            this.pn_containerFormAddUser.Controls.Add(this.lb_outsource);
            this.pn_containerFormAddUser.Controls.Add(this.lb_ValidConfirm);
            this.pn_containerFormAddUser.Controls.Add(this.lb_ValidPassword);
            this.pn_containerFormAddUser.Controls.Add(this.lb_ValidPhone);
            this.pn_containerFormAddUser.Controls.Add(this.lb_ValidEmail);
            this.pn_containerFormAddUser.Controls.Add(this.label7);
            this.pn_containerFormAddUser.Controls.Add(this.lb_ValidFullname);
            this.pn_containerFormAddUser.Controls.Add(this.txt_confirmPassword);
            this.pn_containerFormAddUser.Controls.Add(this.lb_confirmPassword);
            this.pn_containerFormAddUser.Controls.Add(this.txt_password);
            this.pn_containerFormAddUser.Controls.Add(this.lb_password);
            this.pn_containerFormAddUser.Controls.Add(this.cb_Role);
            this.pn_containerFormAddUser.Controls.Add(this.cb_Department);
            this.pn_containerFormAddUser.Controls.Add(this.txt_IdStaff);
            this.pn_containerFormAddUser.Controls.Add(this.lb_IdStaff);
            this.pn_containerFormAddUser.Controls.Add(this.bt_cancel);
            this.pn_containerFormAddUser.Controls.Add(this.bt_save);
            this.pn_containerFormAddUser.Controls.Add(this.txt_phone);
            this.pn_containerFormAddUser.Controls.Add(this.bt_cancelAddUser);
            this.pn_containerFormAddUser.Controls.Add(this.bt_saveAddUser);
            this.pn_containerFormAddUser.Controls.Add(this.lb_placeOfBirth);
            this.pn_containerFormAddUser.Controls.Add(this.lb_department);
            this.pn_containerFormAddUser.Controls.Add(this.lb_phone);
            this.pn_containerFormAddUser.Controls.Add(this.txt_Email);
            this.pn_containerFormAddUser.Controls.Add(this.txt_name);
            this.pn_containerFormAddUser.Controls.Add(this.lb_Name);
            this.pn_containerFormAddUser.Controls.Add(this.lb_Email);
            this.pn_containerFormAddUser.Name = "pn_containerFormAddUser";
            this.pn_containerFormAddUser.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_containerFormAddUser_Paint);
            // 
            // cbType
            // 
            resources.ApplyResources(this.cbType, "cbType");
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            resources.GetString("cbType.Items"),
            resources.GetString("cbType.Items1")});
            this.cbType.Name = "cbType";
            // 
            // lb_Valid_UserId
            // 
            resources.ApplyResources(this.lb_Valid_UserId, "lb_Valid_UserId");
            this.lb_Valid_UserId.Name = "lb_Valid_UserId";
            // 
            // lb_outsource
            // 
            resources.ApplyResources(this.lb_outsource, "lb_outsource");
            this.lb_outsource.BackColor = System.Drawing.Color.Transparent;
            this.lb_outsource.ForeColor = System.Drawing.Color.Black;
            this.lb_outsource.Name = "lb_outsource";
            // 
            // lb_ValidConfirm
            // 
            resources.ApplyResources(this.lb_ValidConfirm, "lb_ValidConfirm");
            this.lb_ValidConfirm.Name = "lb_ValidConfirm";
            // 
            // lb_ValidPassword
            // 
            resources.ApplyResources(this.lb_ValidPassword, "lb_ValidPassword");
            this.lb_ValidPassword.Name = "lb_ValidPassword";
            // 
            // lb_ValidPhone
            // 
            resources.ApplyResources(this.lb_ValidPhone, "lb_ValidPhone");
            this.lb_ValidPhone.Name = "lb_ValidPhone";
            // 
            // lb_ValidEmail
            // 
            resources.ApplyResources(this.lb_ValidEmail, "lb_ValidEmail");
            this.lb_ValidEmail.Name = "lb_ValidEmail";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // lb_ValidFullname
            // 
            resources.ApplyResources(this.lb_ValidFullname, "lb_ValidFullname");
            this.lb_ValidFullname.Name = "lb_ValidFullname";
            // 
            // txt_confirmPassword
            // 
            resources.ApplyResources(this.txt_confirmPassword, "txt_confirmPassword");
            this.txt_confirmPassword.Name = "txt_confirmPassword";
            this.txt_confirmPassword.UseSystemPasswordChar = true;
            this.txt_confirmPassword.Leave += new System.EventHandler(this.txt_checkpassword_Leave);
            // 
            // lb_confirmPassword
            // 
            resources.ApplyResources(this.lb_confirmPassword, "lb_confirmPassword");
            this.lb_confirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lb_confirmPassword.ForeColor = System.Drawing.Color.Black;
            this.lb_confirmPassword.Name = "lb_confirmPassword";
            // 
            // txt_password
            // 
            resources.ApplyResources(this.txt_password, "txt_password");
            this.txt_password.Name = "txt_password";
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // lb_password
            // 
            resources.ApplyResources(this.lb_password, "lb_password");
            this.lb_password.BackColor = System.Drawing.Color.Transparent;
            this.lb_password.ForeColor = System.Drawing.Color.Black;
            this.lb_password.Name = "lb_password";
            // 
            // cb_Role
            // 
            resources.ApplyResources(this.cb_Role, "cb_Role");
            this.cb_Role.FormattingEnabled = true;
            this.cb_Role.Name = "cb_Role";
            // 
            // cb_Department
            // 
            resources.ApplyResources(this.cb_Department, "cb_Department");
            this.cb_Department.FormattingEnabled = true;
            this.cb_Department.Name = "cb_Department";
            // 
            // txt_IdStaff
            // 
            resources.ApplyResources(this.txt_IdStaff, "txt_IdStaff");
            this.txt_IdStaff.Name = "txt_IdStaff";
            this.txt_IdStaff.TextChanged += new System.EventHandler(this.txt_IdStaff_TextChanged);
            this.txt_IdStaff.Leave += new System.EventHandler(this.txt_IdStaff_Leave);
            // 
            // lb_IdStaff
            // 
            resources.ApplyResources(this.lb_IdStaff, "lb_IdStaff");
            this.lb_IdStaff.BackColor = System.Drawing.Color.Transparent;
            this.lb_IdStaff.ForeColor = System.Drawing.Color.Black;
            this.lb_IdStaff.Name = "lb_IdStaff";
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
            // txt_phone
            // 
            resources.ApplyResources(this.txt_phone, "txt_phone");
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.TextChanged += new System.EventHandler(this.txt_phone_TextChanged);
            this.txt_phone.Leave += new System.EventHandler(this.txt_phone_Leave);
            // 
            // FormAddUser
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.pn_tittleFormAddUser);
            this.Controls.Add(this.pn_containerFormAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddUser";
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
        private System.Windows.Forms.Label lb_placeOfBirth;
        private System.Windows.Forms.Button bt_saveAddUser;
        private System.Windows.Forms.Button bt_cancelAddUser;
        private System.Windows.Forms.Panel pn_containerFormAddUser;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.TextBox txt_IdStaff;
        private System.Windows.Forms.Label lb_IdStaff;
        private System.Windows.Forms.TextBox txt_confirmPassword;
        private System.Windows.Forms.Label lb_confirmPassword;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.ComboBox cb_Role;
        private System.Windows.Forms.ComboBox cb_Department;
        private System.Windows.Forms.Label lb_ValidFullname;
        private System.Windows.Forms.Label lb_ValidConfirm;
        private System.Windows.Forms.Label lb_ValidPassword;
        private System.Windows.Forms.Label lb_ValidPhone;
        private System.Windows.Forms.Label lb_ValidEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_Valid_UserId;
        private System.Windows.Forms.Label lb_outsource;
        private System.Windows.Forms.ComboBox cbType;
    }
}