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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pn_left = new System.Windows.Forms.Panel();
            this.lb_logo = new System.Windows.Forms.Label();
            this.pn_right = new System.Windows.Forms.Panel();
            this.bt_iconExit = new FontAwesome.Sharp.IconButton();
            this.txt_userID = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lb_gachngang = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.llb_forgotpassword = new System.Windows.Forms.LinkLabel();
            this.lb_gachngang2 = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.Label();
            this.pn_left.SuspendLayout();
            this.pn_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_left
            // 
            resources.ApplyResources(this.pn_left, "pn_left");
            this.pn_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pn_left.Controls.Add(this.pictureBox1);
            this.pn_left.Controls.Add(this.lb_logo);
            this.pn_left.Controls.Add(this.ptb_logo);
            this.pn_left.Name = "pn_left";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::BCMP.Properties.Resources.logo_color;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lb_logo
            // 
            resources.ApplyResources(this.lb_logo, "lb_logo");
            this.lb_logo.BackColor = System.Drawing.Color.Transparent;
            this.lb_logo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_logo.Name = "lb_logo";
            this.lb_logo.Click += new System.EventHandler(this.lb_logo_Click);
            // 
            // ptb_logo
            // 
            resources.ApplyResources(this.ptb_logo, "ptb_logo");
            this.ptb_logo.Image = global::BCMP.Properties.Resources._629235f0ad752419f8ecfe84;
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.TabStop = false;
            // 
            // pn_right
            // 
            resources.ApplyResources(this.pn_right, "pn_right");
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
            this.pn_right.Name = "pn_right";
            // 
            // bt_iconExit
            // 
            resources.ApplyResources(this.bt_iconExit, "bt_iconExit");
            this.bt_iconExit.BackColor = System.Drawing.Color.Transparent;
            this.bt_iconExit.FlatAppearance.BorderSize = 0;
            this.bt_iconExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.bt_iconExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.bt_iconExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(78)))));
            this.bt_iconExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_iconExit.IconSize = 30;
            this.bt_iconExit.Name = "bt_iconExit";
            this.bt_iconExit.UseVisualStyleBackColor = false;
            this.bt_iconExit.Click += new System.EventHandler(this.bt_iconExit_Click);
            // 
            // txt_userID
            // 
            resources.ApplyResources(this.txt_userID, "txt_userID");
            this.txt_userID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_userID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_userID.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.Enter += new System.EventHandler(this.txt_userID_Enter);
            this.txt_userID.Leave += new System.EventHandler(this.txt_userID_Leave);
            // 
            // txt_Password
            // 
            resources.ApplyResources(this.txt_Password, "txt_Password");
            this.txt_Password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            this.txt_Password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_Password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // bt_IconUser
            // 
            resources.ApplyResources(this.bt_IconUser, "bt_IconUser");
            this.bt_IconUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bt_IconUser.FlatAppearance.BorderSize = 0;
            this.bt_IconUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.bt_IconUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.bt_IconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_IconUser.IconSize = 28;
            this.bt_IconUser.Name = "bt_IconUser";
            this.bt_IconUser.UseVisualStyleBackColor = false;
            // 
            // lb_gachngang
            // 
            resources.ApplyResources(this.lb_gachngang, "lb_gachngang");
            this.lb_gachngang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lb_gachngang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lb_gachngang.Name = "lb_gachngang";
            this.lb_gachngang.Click += new System.EventHandler(this.lb_gachngang_Click);
            // 
            // bt_iconPass
            // 
            resources.ApplyResources(this.bt_iconPass, "bt_iconPass");
            this.bt_iconPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bt_iconPass.FlatAppearance.BorderSize = 0;
            this.bt_iconPass.IconChar = FontAwesome.Sharp.IconChar.UnlockKeyhole;
            this.bt_iconPass.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.bt_iconPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_iconPass.IconSize = 28;
            this.bt_iconPass.Name = "bt_iconPass";
            this.bt_iconPass.UseVisualStyleBackColor = false;
            // 
            // bt_login
            // 
            resources.ApplyResources(this.bt_login, "bt_login");
            this.bt_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.bt_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_login.ForeColor = System.Drawing.Color.Gainsboro;
            this.bt_login.Name = "bt_login";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // llb_forgotpassword
            // 
            resources.ApplyResources(this.llb_forgotpassword, "llb_forgotpassword");
            this.llb_forgotpassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.llb_forgotpassword.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llb_forgotpassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.llb_forgotpassword.Name = "llb_forgotpassword";
            this.llb_forgotpassword.TabStop = true;
            this.llb_forgotpassword.VisitedLinkColor = System.Drawing.Color.Orange;
            this.llb_forgotpassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_forgotpassword_LinkClicked);
            // 
            // lb_gachngang2
            // 
            resources.ApplyResources(this.lb_gachngang2, "lb_gachngang2");
            this.lb_gachngang2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lb_gachngang2.ForeColor = System.Drawing.Color.Gold;
            this.lb_gachngang2.Name = "lb_gachngang2";
            this.lb_gachngang2.Click += new System.EventHandler(this.lb_gachngang2_Click);
            // 
            // lb_password
            // 
            resources.ApplyResources(this.lb_password, "lb_password");
            this.lb_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lb_password.Name = "lb_password";
            this.lb_password.Click += new System.EventHandler(this.lb_password_Click);
            // 
            // lb_id
            // 
            resources.ApplyResources(this.lb_id, "lb_id");
            this.lb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lb_id.Name = "lb_id";
            this.lb_id.Click += new System.EventHandler(this.lb_id_Click);
            // 
            // lb_login
            // 
            resources.ApplyResources(this.lb_login, "lb_login");
            this.lb_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lb_login.Name = "lb_login";
            this.lb_login.Click += new System.EventHandler(this.lb_login_Click);
            // 
            // FormLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.pn_right);
            this.Controls.Add(this.pn_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.pn_left.ResumeLayout(false);
            this.pn_left.PerformLayout();
            this.pn_right.ResumeLayout(false);
            this.pn_right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
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

