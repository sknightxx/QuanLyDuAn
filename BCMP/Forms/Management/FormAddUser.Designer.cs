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
            this.lb_placeOfBirth = new System.Windows.Forms.Label();
            this.bt_saveAddUser = new System.Windows.Forms.Button();
            this.bt_cancelAddUser = new System.Windows.Forms.Button();
            this.pn_containerFormAddUser = new System.Windows.Forms.Panel();
            this.lb_Valid_UserId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.pn_tittleFormAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pn_tittleFormAddUser.Controls.Add(this.bt_exit);
            this.pn_tittleFormAddUser.Controls.Add(this.lb_NewProfile);
            this.pn_tittleFormAddUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_tittleFormAddUser.Location = new System.Drawing.Point(0, 0);
            this.pn_tittleFormAddUser.Margin = new System.Windows.Forms.Padding(2);
            this.pn_tittleFormAddUser.Name = "pn_tittleFormAddUser";
            this.pn_tittleFormAddUser.Size = new System.Drawing.Size(842, 72);
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
            this.bt_exit.IconColor = System.Drawing.Color.Black;
            this.bt_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_exit.IconSize = 30;
            this.bt_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_exit.Location = new System.Drawing.Point(778, 11);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(2);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.bt_exit.Size = new System.Drawing.Size(51, 22);
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
            this.lb_NewProfile.ForeColor = System.Drawing.Color.Black;
            this.lb_NewProfile.Location = new System.Drawing.Point(12, 11);
            this.lb_NewProfile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NewProfile.Name = "lb_NewProfile";
            this.lb_NewProfile.Size = new System.Drawing.Size(138, 27);
            this.lb_NewProfile.TabIndex = 2;
            this.lb_NewProfile.Text = "New profile";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.BackColor = System.Drawing.Color.Transparent;
            this.lb_Email.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.ForeColor = System.Drawing.Color.Black;
            this.lb_Email.Location = new System.Drawing.Point(208, 158);
            this.lb_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(52, 21);
            this.lb_Email.TabIndex = 19;
            this.lb_Email.Text = "Email";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.BackColor = System.Drawing.Color.Transparent;
            this.lb_Name.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.ForeColor = System.Drawing.Color.Black;
            this.lb_Name.Location = new System.Drawing.Point(208, 219);
            this.lb_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(87, 21);
            this.lb_Name.TabIndex = 18;
            this.lb_Name.Text = "Full name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(384, 214);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(242, 33);
            this.txt_name.TabIndex = 21;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            this.txt_name.Leave += new System.EventHandler(this.txt_name_Leave);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(384, 152);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(242, 33);
            this.txt_Email.TabIndex = 20;
            this.txt_Email.Leave += new System.EventHandler(this.txt_Email_Leave);
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.BackColor = System.Drawing.Color.Transparent;
            this.lb_phone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.ForeColor = System.Drawing.Color.Black;
            this.lb_phone.Location = new System.Drawing.Point(208, 278);
            this.lb_phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(62, 21);
            this.lb_phone.TabIndex = 22;
            this.lb_phone.Text = "Phone";
            // 
            // lb_department
            // 
            this.lb_department.AutoSize = true;
            this.lb_department.BackColor = System.Drawing.Color.Transparent;
            this.lb_department.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_department.ForeColor = System.Drawing.Color.Black;
            this.lb_department.Location = new System.Drawing.Point(208, 328);
            this.lb_department.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_department.Name = "lb_department";
            this.lb_department.Size = new System.Drawing.Size(113, 21);
            this.lb_department.TabIndex = 23;
            this.lb_department.Text = "Department";
            // 
            // lb_placeOfBirth
            // 
            this.lb_placeOfBirth.AutoSize = true;
            this.lb_placeOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.lb_placeOfBirth.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_placeOfBirth.ForeColor = System.Drawing.Color.Black;
            this.lb_placeOfBirth.Location = new System.Drawing.Point(208, 376);
            this.lb_placeOfBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_placeOfBirth.Name = "lb_placeOfBirth";
            this.lb_placeOfBirth.Size = new System.Drawing.Size(45, 21);
            this.lb_placeOfBirth.TabIndex = 25;
            this.lb_placeOfBirth.Text = "Role";
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
            this.bt_saveAddUser.Location = new System.Drawing.Point(82, 904);
            this.bt_saveAddUser.Margin = new System.Windows.Forms.Padding(2);
            this.bt_saveAddUser.Name = "bt_saveAddUser";
            this.bt_saveAddUser.Size = new System.Drawing.Size(75, 22);
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
            this.bt_cancelAddUser.Location = new System.Drawing.Point(-40, 904);
            this.bt_cancelAddUser.Margin = new System.Windows.Forms.Padding(2);
            this.bt_cancelAddUser.Name = "bt_cancelAddUser";
            this.bt_cancelAddUser.Size = new System.Drawing.Size(104, 38);
            this.bt_cancelAddUser.TabIndex = 3;
            this.bt_cancelAddUser.Text = "Cancel";
            this.bt_cancelAddUser.UseVisualStyleBackColor = false;
            this.bt_cancelAddUser.MouseEnter += new System.EventHandler(this.bt_cancelAddUser_MouseEnter);
            this.bt_cancelAddUser.MouseLeave += new System.EventHandler(this.bt_cancelAddUser_MouseLeave);
            // 
            // pn_containerFormAddUser
            // 
            this.pn_containerFormAddUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_containerFormAddUser.Controls.Add(this.lb_Valid_UserId);
            this.pn_containerFormAddUser.Controls.Add(this.textBox1);
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
            this.pn_containerFormAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_containerFormAddUser.Location = new System.Drawing.Point(0, 0);
            this.pn_containerFormAddUser.Margin = new System.Windows.Forms.Padding(2);
            this.pn_containerFormAddUser.Name = "pn_containerFormAddUser";
            this.pn_containerFormAddUser.Size = new System.Drawing.Size(842, 688);
            this.pn_containerFormAddUser.TabIndex = 0;
            this.pn_containerFormAddUser.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_containerFormAddUser_Paint);
            // 
            // lb_Valid_UserId
            // 
            this.lb_Valid_UserId.AutoSize = true;
            this.lb_Valid_UserId.Location = new System.Drawing.Point(634, 106);
            this.lb_Valid_UserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Valid_UserId.Name = "lb_Valid_UserId";
            this.lb_Valid_UserId.Size = new System.Drawing.Size(44, 16);
            this.lb_Valid_UserId.TabIndex = 46;
            this.lb_Valid_UserId.Text = "label1";
            this.lb_Valid_UserId.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(385, 432);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 33);
            this.textBox1.TabIndex = 45;
            // 
            // lb_outsource
            // 
            this.lb_outsource.AutoSize = true;
            this.lb_outsource.BackColor = System.Drawing.Color.Transparent;
            this.lb_outsource.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_outsource.ForeColor = System.Drawing.Color.Black;
            this.lb_outsource.Location = new System.Drawing.Point(208, 431);
            this.lb_outsource.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_outsource.Name = "lb_outsource";
            this.lb_outsource.Size = new System.Drawing.Size(97, 21);
            this.lb_outsource.TabIndex = 44;
            this.lb_outsource.Text = "Outsource";
            // 
            // lb_ValidConfirm
            // 
            this.lb_ValidConfirm.AutoSize = true;
            this.lb_ValidConfirm.Location = new System.Drawing.Point(634, 570);
            this.lb_ValidConfirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ValidConfirm.Name = "lb_ValidConfirm";
            this.lb_ValidConfirm.Size = new System.Drawing.Size(44, 16);
            this.lb_ValidConfirm.TabIndex = 43;
            this.lb_ValidConfirm.Text = "label6";
            this.lb_ValidConfirm.Visible = false;
            // 
            // lb_ValidPassword
            // 
            this.lb_ValidPassword.AutoSize = true;
            this.lb_ValidPassword.Location = new System.Drawing.Point(634, 502);
            this.lb_ValidPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ValidPassword.Name = "lb_ValidPassword";
            this.lb_ValidPassword.Size = new System.Drawing.Size(44, 16);
            this.lb_ValidPassword.TabIndex = 42;
            this.lb_ValidPassword.Text = "label5";
            this.lb_ValidPassword.Visible = false;
            // 
            // lb_ValidPhone
            // 
            this.lb_ValidPhone.AutoSize = true;
            this.lb_ValidPhone.Location = new System.Drawing.Point(634, 282);
            this.lb_ValidPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ValidPhone.Name = "lb_ValidPhone";
            this.lb_ValidPhone.Size = new System.Drawing.Size(44, 16);
            this.lb_ValidPhone.TabIndex = 41;
            this.lb_ValidPhone.Text = "label4";
            this.lb_ValidPhone.Visible = false;
            // 
            // lb_ValidEmail
            // 
            this.lb_ValidEmail.AutoSize = true;
            this.lb_ValidEmail.Location = new System.Drawing.Point(632, 162);
            this.lb_ValidEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ValidEmail.Name = "lb_ValidEmail";
            this.lb_ValidEmail.Size = new System.Drawing.Size(44, 16);
            this.lb_ValidEmail.TabIndex = 40;
            this.lb_ValidEmail.Text = "label2";
            this.lb_ValidEmail.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(634, 439);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // lb_ValidFullname
            // 
            this.lb_ValidFullname.AutoSize = true;
            this.lb_ValidFullname.Location = new System.Drawing.Point(634, 224);
            this.lb_ValidFullname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ValidFullname.Name = "lb_ValidFullname";
            this.lb_ValidFullname.Size = new System.Drawing.Size(44, 16);
            this.lb_ValidFullname.TabIndex = 38;
            this.lb_ValidFullname.Text = "label3";
            this.lb_ValidFullname.Visible = false;
            // 
            // txt_confirmPassword
            // 
            this.txt_confirmPassword.Location = new System.Drawing.Point(385, 560);
            this.txt_confirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txt_confirmPassword.Multiline = true;
            this.txt_confirmPassword.Name = "txt_confirmPassword";
            this.txt_confirmPassword.Size = new System.Drawing.Size(242, 33);
            this.txt_confirmPassword.TabIndex = 37;
            this.txt_confirmPassword.Leave += new System.EventHandler(this.txt_checkpassword_Leave);
            // 
            // lb_confirmPassword
            // 
            this.lb_confirmPassword.AutoSize = true;
            this.lb_confirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lb_confirmPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_confirmPassword.ForeColor = System.Drawing.Color.Black;
            this.lb_confirmPassword.Location = new System.Drawing.Point(208, 565);
            this.lb_confirmPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_confirmPassword.Name = "lb_confirmPassword";
            this.lb_confirmPassword.Size = new System.Drawing.Size(158, 21);
            this.lb_confirmPassword.TabIndex = 36;
            this.lb_confirmPassword.Text = "Confirm password";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(385, 492);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(242, 33);
            this.txt_password.TabIndex = 35;
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.BackColor = System.Drawing.Color.Transparent;
            this.lb_password.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.ForeColor = System.Drawing.Color.Black;
            this.lb_password.Location = new System.Drawing.Point(208, 495);
            this.lb_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(88, 21);
            this.lb_password.TabIndex = 34;
            this.lb_password.Text = "Password";
            // 
            // cb_Role
            // 
            this.cb_Role.FormattingEnabled = true;
            this.cb_Role.Location = new System.Drawing.Point(385, 378);
            this.cb_Role.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Role.Name = "cb_Role";
            this.cb_Role.Size = new System.Drawing.Size(242, 24);
            this.cb_Role.TabIndex = 33;
            // 
            // cb_Department
            // 
            this.cb_Department.FormattingEnabled = true;
            this.cb_Department.Location = new System.Drawing.Point(385, 329);
            this.cb_Department.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Department.Name = "cb_Department";
            this.cb_Department.Size = new System.Drawing.Size(242, 24);
            this.cb_Department.TabIndex = 32;
            // 
            // txt_IdStaff
            // 
            this.txt_IdStaff.Location = new System.Drawing.Point(384, 95);
            this.txt_IdStaff.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IdStaff.Multiline = true;
            this.txt_IdStaff.Name = "txt_IdStaff";
            this.txt_IdStaff.Size = new System.Drawing.Size(242, 33);
            this.txt_IdStaff.TabIndex = 31;
            this.txt_IdStaff.TextChanged += new System.EventHandler(this.txt_IdStaff_TextChanged);
            this.txt_IdStaff.Leave += new System.EventHandler(this.txt_IdStaff_Leave);
            // 
            // lb_IdStaff
            // 
            this.lb_IdStaff.AutoSize = true;
            this.lb_IdStaff.BackColor = System.Drawing.Color.Transparent;
            this.lb_IdStaff.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IdStaff.ForeColor = System.Drawing.Color.Black;
            this.lb_IdStaff.Location = new System.Drawing.Point(208, 101);
            this.lb_IdStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_IdStaff.Name = "lb_IdStaff";
            this.lb_IdStaff.Size = new System.Drawing.Size(70, 21);
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
            this.bt_cancel.ForeColor = System.Drawing.Color.Black;
            this.bt_cancel.Location = new System.Drawing.Point(565, 622);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(112, 42);
            this.bt_cancel.TabIndex = 29;
            this.bt_cancel.Text = "CANCEL";
            this.bt_cancel.UseVisualStyleBackColor = false;
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.Black;
            this.bt_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_save.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.ForeColor = System.Drawing.Color.White;
            this.bt_save.Location = new System.Drawing.Point(694, 622);
            this.bt_save.Margin = new System.Windows.Forms.Padding(2);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(112, 42);
            this.bt_save.TabIndex = 28;
            this.bt_save.Text = "SAVE";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(385, 272);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(2);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(242, 33);
            this.txt_phone.TabIndex = 27;
            this.txt_phone.TextChanged += new System.EventHandler(this.txt_phone_TextChanged);
            this.txt_phone.Leave += new System.EventHandler(this.txt_phone_Leave);
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(842, 688);
            this.Controls.Add(this.pn_tittleFormAddUser);
            this.Controls.Add(this.pn_containerFormAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_outsource;
    }
}