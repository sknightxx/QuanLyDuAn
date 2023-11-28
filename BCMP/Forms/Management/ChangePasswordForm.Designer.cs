namespace BCMP.Forms.Management
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.lb_phone = new System.Windows.Forms.Label();
            this.pn_containerChangePass = new System.Windows.Forms.Panel();
            this.lb_ChangePass = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.bt_exit = new FontAwesome.Sharp.IconButton();
            this.pn_user = new System.Windows.Forms.Panel();
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            this.pn_containerChangePass.SuspendLayout();
            this.pn_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ConfirmPassword
            // 
            resources.ApplyResources(this.txt_ConfirmPassword, "txt_ConfirmPassword");
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lb_phone
            // 
            resources.ApplyResources(this.lb_phone, "lb_phone");
            this.lb_phone.BackColor = System.Drawing.Color.Transparent;
            this.lb_phone.ForeColor = System.Drawing.Color.Black;
            this.lb_phone.Name = "lb_phone";
            // 
            // pn_containerChangePass
            // 
            resources.ApplyResources(this.pn_containerChangePass, "pn_containerChangePass");
            this.pn_containerChangePass.Controls.Add(this.lb_ChangePass);
            this.pn_containerChangePass.Controls.Add(this.bt_cancel);
            this.pn_containerChangePass.Controls.Add(this.bt_save);
            this.pn_containerChangePass.Controls.Add(this.txt_ConfirmPassword);
            this.pn_containerChangePass.Controls.Add(this.lb_phone);
            this.pn_containerChangePass.Controls.Add(this.txt_Password);
            this.pn_containerChangePass.Controls.Add(this.lb_Email);
            this.pn_containerChangePass.Controls.Add(this.bt_exit);
            this.pn_containerChangePass.Controls.Add(this.pn_user);
            this.pn_containerChangePass.Name = "pn_containerChangePass";
            this.pn_containerChangePass.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_containerChangePass_Paint);
            this.pn_containerChangePass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_containerChangePass_MouseDown);
            this.pn_containerChangePass.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pn_containerChangePass_MouseMove);
            this.pn_containerChangePass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pn_containerChangePass_MouseUp);
            // 
            // lb_ChangePass
            // 
            resources.ApplyResources(this.lb_ChangePass, "lb_ChangePass");
            this.lb_ChangePass.Name = "lb_ChangePass";
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
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
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
            // txt_Password
            // 
            resources.ApplyResources(this.txt_Password, "txt_Password");
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // lb_Email
            // 
            resources.ApplyResources(this.lb_Email, "lb_Email");
            this.lb_Email.BackColor = System.Drawing.Color.Transparent;
            this.lb_Email.ForeColor = System.Drawing.Color.Black;
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Click += new System.EventHandler(this.lb_Email_Click);
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
            // pn_user
            // 
            resources.ApplyResources(this.pn_user, "pn_user");
            this.pn_user.Controls.Add(this.iconUser);
            this.pn_user.Name = "pn_user";
            // 
            // iconUser
            // 
            resources.ApplyResources(this.iconUser, "iconUser");
            this.iconUser.BackColor = System.Drawing.SystemColors.Control;
            this.iconUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.iconUser.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUser.IconSize = 97;
            this.iconUser.Name = "iconUser";
            this.iconUser.TabStop = false;
            this.iconUser.Click += new System.EventHandler(this.iconUser_Click);
            // 
            // ChangePasswordForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_containerChangePass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePasswordForm";
            this.pn_containerChangePass.ResumeLayout(false);
            this.pn_containerChangePass.PerformLayout();
            this.pn_user.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_ConfirmPassword;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Panel pn_containerChangePass;
        private FontAwesome.Sharp.IconButton bt_exit;
        private System.Windows.Forms.Panel pn_user;
        private FontAwesome.Sharp.IconPictureBox iconUser;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Label lb_ChangePass;
    }
}