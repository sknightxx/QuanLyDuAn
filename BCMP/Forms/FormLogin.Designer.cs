namespace BCMP
{
    partial class FormLogin
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
            this.pn_left = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_logo = new System.Windows.Forms.Label();
            this.ptb_logo = new System.Windows.Forms.PictureBox();
            this.pn_right = new System.Windows.Forms.Panel();
            this.txt_userID = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.bt_IconUser = new FontAwesome.Sharp.IconButton();
            this.lb_gachngang = new System.Windows.Forms.Label();
            this.bt_iconPass = new FontAwesome.Sharp.IconButton();
            this.bt_login = new System.Windows.Forms.Button();
            this.llb_forgotpassword = new System.Windows.Forms.LinkLabel();
            this.lb_gachngang2 = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.Label();
            this.bt_iconExit = new FontAwesome.Sharp.IconButton();
            this.pn_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            this.pn_right.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_left
            // 
            this.pn_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pn_left.Controls.Add(this.pictureBox1);
            this.pn_left.Controls.Add(this.lb_logo);
            this.pn_left.Controls.Add(this.ptb_logo);
            this.pn_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_left.Location = new System.Drawing.Point(0, 0);
            this.pn_left.Margin = new System.Windows.Forms.Padding(2);
            this.pn_left.Name = "pn_left";
            this.pn_left.Size = new System.Drawing.Size(333, 498);
            this.pn_left.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BCMP.Properties.Resources.z4821246153762_f7cf5b667b259876816633f716183abb;
            this.pictureBox1.Location = new System.Drawing.Point(166, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lb_logo
            // 
            this.lb_logo.AutoSize = true;
            this.lb_logo.BackColor = System.Drawing.Color.Transparent;
            this.lb_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_logo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_logo.Location = new System.Drawing.Point(116, 269);
            this.lb_logo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_logo.Name = "lb_logo";
            this.lb_logo.Size = new System.Drawing.Size(80, 26);
            this.lb_logo.TabIndex = 2;
            this.lb_logo.Text = "BCMP";
            this.lb_logo.Click += new System.EventHandler(this.lb_logo_Click);
            // 
            // ptb_logo
            // 
            this.ptb_logo.Image = global::BCMP.Properties.Resources._629235f0ad752419f8ecfe84;
            this.ptb_logo.Location = new System.Drawing.Point(37, 134);
            this.ptb_logo.Margin = new System.Windows.Forms.Padding(2);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.Size = new System.Drawing.Size(111, 119);
            this.ptb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_logo.TabIndex = 2;
            this.ptb_logo.TabStop = false;
            // 
            // pn_right
            // 
            this.pn_right.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_right.Controls.Add(this.bt_iconExit);
            this.pn_right.Controls.Add(this.txt_userID);
            this.pn_right.Controls.Add(this.txt_Password);
            this.pn_right.Controls.Add(this.bt_IconUser);
            this.pn_right.Controls.Add(this.lb_gachngang);
            this.pn_right.Controls.Add(this.bt_iconPass);
            this.pn_right.Controls.Add(this.bt_login);
            this.pn_right.Controls.Add(this.llb_forgotpassword);
            this.pn_right.Controls.Add(this.lb_gachngang2);
            this.pn_right.Controls.Add(this.lb_password);
            this.pn_right.Controls.Add(this.lb_id);
            this.pn_right.Controls.Add(this.lb_login);
            this.pn_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_right.Location = new System.Drawing.Point(333, 0);
            this.pn_right.Margin = new System.Windows.Forms.Padding(2);
            this.pn_right.Name = "pn_right";
            this.pn_right.Size = new System.Drawing.Size(333, 498);
            this.pn_right.TabIndex = 2;
            // 
            // txt_userID
            // 
            this.txt_userID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_userID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_userID.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userID.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_userID.Location = new System.Drawing.Point(31, 137);
            this.txt_userID.Multiline = true;
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.Size = new System.Drawing.Size(234, 26);
            this.txt_userID.TabIndex = 22;
            this.txt_userID.Text = "Enter your ID";
            this.txt_userID.Enter += new System.EventHandler(this.txt_userID_Enter);
            this.txt_userID.Leave += new System.EventHandler(this.txt_userID_Leave);
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_Password.Location = new System.Drawing.Point(31, 230);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(234, 26);
            this.txt_Password.TabIndex = 21;
            this.txt_Password.Text = "Password";
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            this.txt_Password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_Password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // bt_IconUser
            // 
            this.bt_IconUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bt_IconUser.FlatAppearance.BorderSize = 0;
            this.bt_IconUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_IconUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.bt_IconUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.bt_IconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_IconUser.IconSize = 28;
            this.bt_IconUser.Location = new System.Drawing.Point(270, 134);
            this.bt_IconUser.Margin = new System.Windows.Forms.Padding(2);
            this.bt_IconUser.Name = "bt_IconUser";
            this.bt_IconUser.Size = new System.Drawing.Size(28, 24);
            this.bt_IconUser.TabIndex = 18;
            this.bt_IconUser.UseVisualStyleBackColor = false;
            // 
            // lb_gachngang
            // 
            this.lb_gachngang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lb_gachngang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lb_gachngang.Location = new System.Drawing.Point(22, 163);
            this.lb_gachngang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_gachngang.Name = "lb_gachngang";
            this.lb_gachngang.Size = new System.Drawing.Size(276, 1);
            this.lb_gachngang.TabIndex = 3;
            this.lb_gachngang.Click += new System.EventHandler(this.lb_gachngang_Click);
            // 
            // bt_iconPass
            // 
            this.bt_iconPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bt_iconPass.FlatAppearance.BorderSize = 0;
            this.bt_iconPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_iconPass.IconChar = FontAwesome.Sharp.IconChar.UnlockKeyhole;
            this.bt_iconPass.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.bt_iconPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_iconPass.IconSize = 28;
            this.bt_iconPass.Location = new System.Drawing.Point(270, 231);
            this.bt_iconPass.Margin = new System.Windows.Forms.Padding(2);
            this.bt_iconPass.Name = "bt_iconPass";
            this.bt_iconPass.Size = new System.Drawing.Size(28, 24);
            this.bt_iconPass.TabIndex = 19;
            this.bt_iconPass.UseVisualStyleBackColor = false;
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.bt_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.ForeColor = System.Drawing.Color.Gainsboro;
            this.bt_login.Location = new System.Drawing.Point(23, 347);
            this.bt_login.Margin = new System.Windows.Forms.Padding(2);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(274, 37);
            this.bt_login.TabIndex = 13;
            this.bt_login.Text = "LOGIN";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // llb_forgotpassword
            // 
            this.llb_forgotpassword.AutoSize = true;
            this.llb_forgotpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_forgotpassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.llb_forgotpassword.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llb_forgotpassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.llb_forgotpassword.Location = new System.Drawing.Point(186, 474);
            this.llb_forgotpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llb_forgotpassword.Name = "llb_forgotpassword";
            this.llb_forgotpassword.Size = new System.Drawing.Size(116, 16);
            this.llb_forgotpassword.TabIndex = 12;
            this.llb_forgotpassword.TabStop = true;
            this.llb_forgotpassword.Text = "Forgot Password?";
            this.llb_forgotpassword.VisitedLinkColor = System.Drawing.Color.Orange;
            this.llb_forgotpassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_forgotpassword_LinkClicked);
            // 
            // lb_gachngang2
            // 
            this.lb_gachngang2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lb_gachngang2.ForeColor = System.Drawing.Color.Gold;
            this.lb_gachngang2.Location = new System.Drawing.Point(22, 259);
            this.lb_gachngang2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_gachngang2.Name = "lb_gachngang2";
            this.lb_gachngang2.Size = new System.Drawing.Size(276, 1);
            this.lb_gachngang2.TabIndex = 7;
            this.lb_gachngang2.Click += new System.EventHandler(this.lb_gachngang2_Click);
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lb_password.Location = new System.Drawing.Point(19, 191);
            this.lb_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(111, 20);
            this.lb_password.TabIndex = 5;
            this.lb_password.Text = "PASSWORD";
            this.lb_password.Click += new System.EventHandler(this.lb_password_Click);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lb_id.Location = new System.Drawing.Point(19, 99);
            this.lb_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(83, 20);
            this.lb_id.TabIndex = 1;
            this.lb_id.Text = "USER ID";
            this.lb_id.Click += new System.EventHandler(this.lb_id_Click);
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lb_login.Location = new System.Drawing.Point(113, 50);
            this.lb_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(104, 31);
            this.lb_login.TabIndex = 0;
            this.lb_login.Text = "LOGIN";
            this.lb_login.Click += new System.EventHandler(this.lb_login_Click);
            // 
            // bt_iconExit
            // 
            this.bt_iconExit.BackColor = System.Drawing.Color.Transparent;
            this.bt_iconExit.FlatAppearance.BorderSize = 0;
            this.bt_iconExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_iconExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.bt_iconExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.bt_iconExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(78)))));
            this.bt_iconExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_iconExit.IconSize = 30;
            this.bt_iconExit.Location = new System.Drawing.Point(300, 5);
            this.bt_iconExit.Margin = new System.Windows.Forms.Padding(2);
            this.bt_iconExit.Name = "bt_iconExit";
            this.bt_iconExit.Size = new System.Drawing.Size(28, 24);
            this.bt_iconExit.TabIndex = 31;
            this.bt_iconExit.UseVisualStyleBackColor = false;
            this.bt_iconExit.Click += new System.EventHandler(this.bt_iconExit_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(666, 498);
            this.Controls.Add(this.pn_right);
            this.Controls.Add(this.pn_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pn_left.ResumeLayout(false);
            this.pn_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            this.pn_right.ResumeLayout(false);
            this.pn_right.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_left;
        private System.Windows.Forms.Panel pn_right;
        private System.Windows.Forms.PictureBox ptb_logo;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_logo;
        private System.Windows.Forms.Label lb_gachngang;
        private System.Windows.Forms.Label lb_gachngang2;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.LinkLabel llb_forgotpassword;
        private System.Windows.Forms.Button bt_login;
        private FontAwesome.Sharp.IconButton bt_IconUser;
        private FontAwesome.Sharp.IconButton bt_iconPass;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_userID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton bt_iconExit;
    }
}

