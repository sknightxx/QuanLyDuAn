namespace BCMP
{
    partial class FormFotgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFotgotPassword));
            this.lb_logo = new System.Windows.Forms.Label();
            this.pn_left = new System.Windows.Forms.Panel();
            this.lb_fotgotpassword = new System.Windows.Forms.Label();
            this.lb_userIdFotgotPass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pn_right = new System.Windows.Forms.Panel();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_idPass = new System.Windows.Forms.TextBox();
            this.bt_sendmail = new System.Windows.Forms.Button();
            this.bt_iconExit = new FontAwesome.Sharp.IconButton();
            this.bt_iconMail = new FontAwesome.Sharp.IconButton();
            this.bt_IconUserForgotPass = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_iconBackLogin = new FontAwesome.Sharp.IconButton();
            this.ptb_logo = new System.Windows.Forms.PictureBox();
            this.pn_left.SuspendLayout();
            this.pn_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_logo
            // 
            resources.ApplyResources(this.lb_logo, "lb_logo");
            this.lb_logo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_logo.Name = "lb_logo";
            // 
            // pn_left
            // 
            resources.ApplyResources(this.pn_left, "pn_left");
            this.pn_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pn_left.Controls.Add(this.pictureBox1);
            this.pn_left.Controls.Add(this.bt_iconBackLogin);
            this.pn_left.Controls.Add(this.lb_logo);
            this.pn_left.Controls.Add(this.ptb_logo);
            this.pn_left.Name = "pn_left";
            // 
            // lb_fotgotpassword
            // 
            resources.ApplyResources(this.lb_fotgotpassword, "lb_fotgotpassword");
            this.lb_fotgotpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lb_fotgotpassword.Name = "lb_fotgotpassword";
            // 
            // lb_userIdFotgotPass
            // 
            resources.ApplyResources(this.lb_userIdFotgotPass, "lb_userIdFotgotPass");
            this.lb_userIdFotgotPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lb_userIdFotgotPass.Name = "lb_userIdFotgotPass";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(78)))));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Name = "label2";
            // 
            // lb_email
            // 
            resources.ApplyResources(this.lb_email, "lb_email");
            this.lb_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lb_email.Name = "lb_email";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(78)))));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Name = "label4";
            // 
            // pn_right
            // 
            resources.ApplyResources(this.pn_right, "pn_right");
            this.pn_right.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_right.Controls.Add(this.bt_iconExit);
            this.pn_right.Controls.Add(this.bt_iconMail);
            this.pn_right.Controls.Add(this.bt_IconUserForgotPass);
            this.pn_right.Controls.Add(this.txt_email);
            this.pn_right.Controls.Add(this.txt_idPass);
            this.pn_right.Controls.Add(this.bt_sendmail);
            this.pn_right.Controls.Add(this.label4);
            this.pn_right.Controls.Add(this.lb_email);
            this.pn_right.Controls.Add(this.label2);
            this.pn_right.Controls.Add(this.lb_userIdFotgotPass);
            this.pn_right.Controls.Add(this.lb_fotgotpassword);
            this.pn_right.Name = "pn_right";
            // 
            // txt_email
            // 
            resources.ApplyResources(this.txt_email, "txt_email");
            this.txt_email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_email.Name = "txt_email";
            this.txt_email.UseSystemPasswordChar = true;
            this.txt_email.Enter += new System.EventHandler(this.txt_email_Enter);
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // txt_idPass
            // 
            resources.ApplyResources(this.txt_idPass, "txt_idPass");
            this.txt_idPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_idPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_idPass.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_idPass.Name = "txt_idPass";
            this.txt_idPass.Enter += new System.EventHandler(this.txt_idPass_Enter);
            this.txt_idPass.Leave += new System.EventHandler(this.txt_idPass_Leave);
            // 
            // bt_sendmail
            // 
            resources.ApplyResources(this.bt_sendmail, "bt_sendmail");
            this.bt_sendmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.bt_sendmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.bt_sendmail.Name = "bt_sendmail";
            this.bt_sendmail.UseVisualStyleBackColor = false;
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
            // bt_iconMail
            // 
            resources.ApplyResources(this.bt_iconMail, "bt_iconMail");
            this.bt_iconMail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bt_iconMail.FlatAppearance.BorderSize = 0;
            this.bt_iconMail.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.bt_iconMail.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.bt_iconMail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_iconMail.IconSize = 28;
            this.bt_iconMail.Name = "bt_iconMail";
            this.bt_iconMail.UseVisualStyleBackColor = false;
            // 
            // bt_IconUserForgotPass
            // 
            resources.ApplyResources(this.bt_IconUserForgotPass, "bt_IconUserForgotPass");
            this.bt_IconUserForgotPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bt_IconUserForgotPass.FlatAppearance.BorderSize = 0;
            this.bt_IconUserForgotPass.IconChar = FontAwesome.Sharp.IconChar.User;
            this.bt_IconUserForgotPass.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.bt_IconUserForgotPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_IconUserForgotPass.IconSize = 28;
            this.bt_IconUserForgotPass.Name = "bt_IconUserForgotPass";
            this.bt_IconUserForgotPass.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::BCMP.Properties.Resources.z4821246153762_f7cf5b667b259876816633f716183abb;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // bt_iconBackLogin
            // 
            resources.ApplyResources(this.bt_iconBackLogin, "bt_iconBackLogin");
            this.bt_iconBackLogin.BackColor = System.Drawing.Color.Transparent;
            this.bt_iconBackLogin.FlatAppearance.BorderSize = 0;
            this.bt_iconBackLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.bt_iconBackLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.bt_iconBackLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(78)))));
            this.bt_iconBackLogin.IconChar = FontAwesome.Sharp.IconChar.LeftLong;
            this.bt_iconBackLogin.IconColor = System.Drawing.Color.Gainsboro;
            this.bt_iconBackLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_iconBackLogin.IconSize = 30;
            this.bt_iconBackLogin.Name = "bt_iconBackLogin";
            this.bt_iconBackLogin.UseVisualStyleBackColor = false;
            this.bt_iconBackLogin.Click += new System.EventHandler(this.bt_iconBackLogin_Click);
            // 
            // ptb_logo
            // 
            resources.ApplyResources(this.ptb_logo, "ptb_logo");
            this.ptb_logo.Image = global::BCMP.Properties.Resources._629235f0ad752419f8ecfe84;
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.TabStop = false;
            // 
            // FormFotgotPassword
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.pn_right);
            this.Controls.Add(this.pn_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFotgotPassword";
            this.pn_left.ResumeLayout(false);
            this.pn_left.PerformLayout();
            this.pn_right.ResumeLayout(false);
            this.pn_right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_logo;

        private System.Windows.Forms.Panel pn_left;
        private System.Windows.Forms.Label lb_logo;
        private System.Windows.Forms.Panel pn_right;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_userIdFotgotPass;
        private System.Windows.Forms.Label lb_fotgotpassword;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_idPass;
        private System.Windows.Forms.Button bt_sendmail;
        private FontAwesome.Sharp.IconButton bt_iconMail;
        private FontAwesome.Sharp.IconButton bt_IconUserForgotPass;
        private FontAwesome.Sharp.IconButton bt_iconBackLogin;
        private FontAwesome.Sharp.IconButton bt_iconExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}