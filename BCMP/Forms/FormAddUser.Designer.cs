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
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lb_placeOfBirth = new System.Windows.Forms.Label();
            this.txt_checkpassword = new System.Windows.Forms.TextBox();
            this.bt_saveAddUser = new System.Windows.Forms.Button();
            this.bt_cancelAddUser = new System.Windows.Forms.Button();
            this.pn_containerFormAddUser = new System.Windows.Forms.Panel();
            this.txt_IdStaff = new System.Windows.Forms.TextBox();
            this.lb_IdStaff = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbuserid = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.lbphone = new System.Windows.Forms.Label();
            this.lbpassword = new System.Windows.Forms.Label();
            this.lbcheckpassword = new System.Windows.Forms.Label();
            this.lbdepartment = new System.Windows.Forms.Label();
            this.lbrole = new System.Windows.Forms.Label();
            this.pn_tittleFormAddUser.SuspendLayout();
            this.pn_containerFormAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_tittleFormAddUser
            // 
            this.pn_tittleFormAddUser.BackColor = System.Drawing.Color.White;
            this.pn_tittleFormAddUser.Controls.Add(this.bt_exit);
            this.pn_tittleFormAddUser.Controls.Add(this.lb_NewProfile);
            this.pn_tittleFormAddUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_tittleFormAddUser.Location = new System.Drawing.Point(0, 0);
            this.pn_tittleFormAddUser.Name = "pn_tittleFormAddUser";
            this.pn_tittleFormAddUser.Size = new System.Drawing.Size(843, 73);
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
            this.bt_exit.Location = new System.Drawing.Point(779, 11);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.bt_exit.Size = new System.Drawing.Size(40, 22);
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
            this.lb_NewProfile.Location = new System.Drawing.Point(12, 11);
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
            this.lb_Email.Location = new System.Drawing.Point(207, 163);
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
            this.lb_Name.Location = new System.Drawing.Point(207, 231);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(87, 21);
            this.lb_Name.TabIndex = 18;
            this.lb_Name.Text = "Full name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(353, 224);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(242, 33);
            this.txt_name.TabIndex = 3;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            this.txt_name.Leave += new System.EventHandler(this.txt_name_Leave);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(353, 155);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(242, 33);
            this.txt_Email.TabIndex = 2;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            this.txt_Email.Leave += new System.EventHandler(this.txt_Email_Leave);
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.BackColor = System.Drawing.Color.Transparent;
            this.lb_phone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.ForeColor = System.Drawing.Color.Black;
            this.lb_phone.Location = new System.Drawing.Point(207, 301);
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
            this.lb_department.Location = new System.Drawing.Point(207, 491);
            this.lb_department.Name = "lb_department";
            this.lb_department.Size = new System.Drawing.Size(113, 21);
            this.lb_department.TabIndex = 23;
            this.lb_department.Text = "Department";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(353, 360);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '•';
            this.txt_password.Size = new System.Drawing.Size(242, 33);
            this.txt_password.TabIndex = 5;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // lb_placeOfBirth
            // 
            this.lb_placeOfBirth.AutoSize = true;
            this.lb_placeOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.lb_placeOfBirth.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_placeOfBirth.ForeColor = System.Drawing.Color.Black;
            this.lb_placeOfBirth.Location = new System.Drawing.Point(214, 558);
            this.lb_placeOfBirth.Name = "lb_placeOfBirth";
            this.lb_placeOfBirth.Size = new System.Drawing.Size(45, 21);
            this.lb_placeOfBirth.TabIndex = 25;
            this.lb_placeOfBirth.Text = "Role";
            // 
            // txt_checkpassword
            // 
            this.txt_checkpassword.Location = new System.Drawing.Point(351, 429);
            this.txt_checkpassword.Multiline = true;
            this.txt_checkpassword.Name = "txt_checkpassword";
            this.txt_checkpassword.PasswordChar = '•';
            this.txt_checkpassword.Size = new System.Drawing.Size(242, 33);
            this.txt_checkpassword.TabIndex = 6;
            this.txt_checkpassword.UseSystemPasswordChar = true;
            this.txt_checkpassword.Leave += new System.EventHandler(this.txt_checkpassword_Leave);
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
            this.bt_saveAddUser.Location = new System.Drawing.Point(83, 904);
            this.bt_saveAddUser.Name = "bt_saveAddUser";
            this.bt_saveAddUser.Size = new System.Drawing.Size(75, 23);
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
            this.bt_cancelAddUser.Name = "bt_cancelAddUser";
            this.bt_cancelAddUser.Size = new System.Drawing.Size(104, 37);
            this.bt_cancelAddUser.TabIndex = 3;
            this.bt_cancelAddUser.Text = "Cancel";
            this.bt_cancelAddUser.UseVisualStyleBackColor = false;
            this.bt_cancelAddUser.MouseEnter += new System.EventHandler(this.bt_cancelAddUser_MouseEnter);
            this.bt_cancelAddUser.MouseLeave += new System.EventHandler(this.bt_cancelAddUser_MouseLeave);
            // 
            // pn_containerFormAddUser
            // 
            this.pn_containerFormAddUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_containerFormAddUser.Controls.Add(this.lbrole);
            this.pn_containerFormAddUser.Controls.Add(this.lbdepartment);
            this.pn_containerFormAddUser.Controls.Add(this.lbcheckpassword);
            this.pn_containerFormAddUser.Controls.Add(this.lbpassword);
            this.pn_containerFormAddUser.Controls.Add(this.lbphone);
            this.pn_containerFormAddUser.Controls.Add(this.lbname);
            this.pn_containerFormAddUser.Controls.Add(this.lbemail);
            this.pn_containerFormAddUser.Controls.Add(this.lbuserid);
            this.pn_containerFormAddUser.Controls.Add(this.label2);
            this.pn_containerFormAddUser.Controls.Add(this.label1);
            this.pn_containerFormAddUser.Controls.Add(this.cb_role);
            this.pn_containerFormAddUser.Controls.Add(this.cb_department);
            this.pn_containerFormAddUser.Controls.Add(this.txt_IdStaff);
            this.pn_containerFormAddUser.Controls.Add(this.lb_IdStaff);
            this.pn_containerFormAddUser.Controls.Add(this.bt_cancel);
            this.pn_containerFormAddUser.Controls.Add(this.bt_save);
            this.pn_containerFormAddUser.Controls.Add(this.txt_phone);
            this.pn_containerFormAddUser.Controls.Add(this.bt_cancelAddUser);
            this.pn_containerFormAddUser.Controls.Add(this.bt_saveAddUser);
            this.pn_containerFormAddUser.Controls.Add(this.txt_checkpassword);
            this.pn_containerFormAddUser.Controls.Add(this.lb_placeOfBirth);
            this.pn_containerFormAddUser.Controls.Add(this.txt_password);
            this.pn_containerFormAddUser.Controls.Add(this.lb_department);
            this.pn_containerFormAddUser.Controls.Add(this.lb_phone);
            this.pn_containerFormAddUser.Controls.Add(this.txt_Email);
            this.pn_containerFormAddUser.Controls.Add(this.txt_name);
            this.pn_containerFormAddUser.Controls.Add(this.lb_Name);
            this.pn_containerFormAddUser.Controls.Add(this.lb_Email);
            this.pn_containerFormAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_containerFormAddUser.Location = new System.Drawing.Point(0, 0);
            this.pn_containerFormAddUser.Name = "pn_containerFormAddUser";
            this.pn_containerFormAddUser.Size = new System.Drawing.Size(843, 688);
            this.pn_containerFormAddUser.TabIndex = 0;
            this.pn_containerFormAddUser.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_containerFormAddUser_Paint);
            // 
            // txt_IdStaff
            // 
            this.txt_IdStaff.Location = new System.Drawing.Point(353, 98);
            this.txt_IdStaff.Multiline = true;
            this.txt_IdStaff.Name = "txt_IdStaff";
            this.txt_IdStaff.Size = new System.Drawing.Size(242, 33);
            this.txt_IdStaff.TabIndex = 1;
            this.txt_IdStaff.TextChanged += new System.EventHandler(this.txt_IdStaff_TextChanged);
            this.txt_IdStaff.Leave += new System.EventHandler(this.txt_IdStaff_Leave);
            // 
            // lb_IdStaff
            // 
            this.lb_IdStaff.AutoSize = true;
            this.lb_IdStaff.BackColor = System.Drawing.Color.Transparent;
            this.lb_IdStaff.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IdStaff.ForeColor = System.Drawing.Color.Black;
            this.lb_IdStaff.Location = new System.Drawing.Point(207, 106);
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
            this.bt_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.bt_cancel.Location = new System.Drawing.Point(565, 622);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(113, 43);
            this.bt_cancel.TabIndex = 10;
            this.bt_cancel.Text = "CANCEL";
            this.bt_cancel.UseVisualStyleBackColor = false;
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.bt_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_save.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.ForeColor = System.Drawing.Color.White;
            this.bt_save.Location = new System.Drawing.Point(694, 622);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(113, 43);
            this.bt_save.TabIndex = 9;
            this.bt_save.Text = "SAVE";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(353, 289);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(242, 33);
            this.txt_phone.TabIndex = 4;
            this.txt_phone.TextChanged += new System.EventHandler(this.txt_phone_TextChanged);
            this.txt_phone.Leave += new System.EventHandler(this.txt_phone_Leave);
            // 
            // cb_department
            // 
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Location = new System.Drawing.Point(351, 492);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(242, 24);
            this.cb_department.TabIndex = 7;
            // 
            // cb_role
            // 
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Location = new System.Drawing.Point(353, 555);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(242, 24);
            this.cb_role.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(207, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(197, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Check Password";
            // 
            // lbuserid
            // 
            this.lbuserid.AutoSize = true;
            this.lbuserid.ForeColor = System.Drawing.Color.Black;
            this.lbuserid.Location = new System.Drawing.Point(601, 115);
            this.lbuserid.Name = "lbuserid";
            this.lbuserid.Size = new System.Drawing.Size(44, 16);
            this.lbuserid.TabIndex = 36;
            this.lbuserid.Text = "label3";
            this.lbuserid.Visible = false;
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(601, 172);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(44, 16);
            this.lbemail.TabIndex = 37;
            this.lbemail.Text = "label4";
            this.lbemail.Visible = false;
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(601, 241);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(44, 16);
            this.lbname.TabIndex = 38;
            this.lbname.Text = "label5";
            this.lbname.Visible = false;
            // 
            // lbphone
            // 
            this.lbphone.AutoSize = true;
            this.lbphone.Location = new System.Drawing.Point(601, 305);
            this.lbphone.Name = "lbphone";
            this.lbphone.Size = new System.Drawing.Size(44, 16);
            this.lbphone.TabIndex = 39;
            this.lbphone.Text = "label6";
            this.lbphone.Visible = false;
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Location = new System.Drawing.Point(601, 376);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(44, 16);
            this.lbpassword.TabIndex = 40;
            this.lbpassword.Text = "label7";
            this.lbpassword.Visible = false;
            // 
            // lbcheckpassword
            // 
            this.lbcheckpassword.AutoSize = true;
            this.lbcheckpassword.Location = new System.Drawing.Point(601, 445);
            this.lbcheckpassword.Name = "lbcheckpassword";
            this.lbcheckpassword.Size = new System.Drawing.Size(44, 16);
            this.lbcheckpassword.TabIndex = 41;
            this.lbcheckpassword.Text = "label8";
            this.lbcheckpassword.Visible = false;
            // 
            // lbdepartment
            // 
            this.lbdepartment.AutoSize = true;
            this.lbdepartment.Location = new System.Drawing.Point(601, 500);
            this.lbdepartment.Name = "lbdepartment";
            this.lbdepartment.Size = new System.Drawing.Size(44, 16);
            this.lbdepartment.TabIndex = 42;
            this.lbdepartment.Text = "label9";
            this.lbdepartment.Visible = false;
            // 
            // lbrole
            // 
            this.lbrole.AutoSize = true;
            this.lbrole.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbrole.Location = new System.Drawing.Point(601, 562);
            this.lbrole.Name = "lbrole";
            this.lbrole.Size = new System.Drawing.Size(51, 16);
            this.lbrole.TabIndex = 43;
            this.lbrole.Text = "label10";
            this.lbrole.Visible = false;
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(843, 688);
            this.Controls.Add(this.pn_tittleFormAddUser);
            this.Controls.Add(this.pn_containerFormAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lb_placeOfBirth;
        private System.Windows.Forms.TextBox txt_checkpassword;
        private System.Windows.Forms.Button bt_saveAddUser;
        private System.Windows.Forms.Button bt_cancelAddUser;
        private System.Windows.Forms.Panel pn_containerFormAddUser;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.TextBox txt_IdStaff;
        private System.Windows.Forms.Label lb_IdStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.Label lbrole;
        private System.Windows.Forms.Label lbdepartment;
        private System.Windows.Forms.Label lbcheckpassword;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.Label lbphone;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbuserid;
    }
}