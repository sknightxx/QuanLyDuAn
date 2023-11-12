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
            this.txt_IdStaff = new System.Windows.Forms.TextBox();
            this.lb_IdStaff = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lb_phone = new System.Windows.Forms.Label();
            this.pn_containerChangePass = new System.Windows.Forms.Panel();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.bt_exit = new FontAwesome.Sharp.IconButton();
            this.pn_user = new System.Windows.Forms.Panel();
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            this.pn_containerChangePass.SuspendLayout();
            this.pn_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_IdStaff
            // 
            this.txt_IdStaff.Location = new System.Drawing.Point(167, 188);
            this.txt_IdStaff.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IdStaff.Multiline = true;
            this.txt_IdStaff.Name = "txt_IdStaff";
            this.txt_IdStaff.Size = new System.Drawing.Size(194, 27);
            this.txt_IdStaff.TabIndex = 59;
            // 
            // lb_IdStaff
            // 
            this.lb_IdStaff.AutoSize = true;
            this.lb_IdStaff.BackColor = System.Drawing.Color.Transparent;
            this.lb_IdStaff.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IdStaff.ForeColor = System.Drawing.Color.Black;
            this.lb_IdStaff.Location = new System.Drawing.Point(19, 196);
            this.lb_IdStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_IdStaff.Name = "lb_IdStaff";
            this.lb_IdStaff.Size = new System.Drawing.Size(56, 19);
            this.lb_IdStaff.TabIndex = 58;
            this.lb_IdStaff.Text = "ID Staff";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(167, 313);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(2);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(194, 27);
            this.txt_phone.TabIndex = 57;
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.BackColor = System.Drawing.Color.Transparent;
            this.lb_phone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.ForeColor = System.Drawing.Color.Black;
            this.lb_phone.Location = new System.Drawing.Point(19, 321);
            this.lb_phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(129, 19);
            this.lb_phone.TabIndex = 54;
            this.lb_phone.Text = "Confirm Password";
            // 
            // pn_containerChangePass
            // 
            this.pn_containerChangePass.Controls.Add(this.bt_cancel);
            this.pn_containerChangePass.Controls.Add(this.bt_save);
            this.pn_containerChangePass.Controls.Add(this.txt_phone);
            this.pn_containerChangePass.Controls.Add(this.txt_IdStaff);
            this.pn_containerChangePass.Controls.Add(this.lb_phone);
            this.pn_containerChangePass.Controls.Add(this.lb_IdStaff);
            this.pn_containerChangePass.Controls.Add(this.txt_Email);
            this.pn_containerChangePass.Controls.Add(this.lb_Email);
            this.pn_containerChangePass.Controls.Add(this.bt_exit);
            this.pn_containerChangePass.Controls.Add(this.pn_user);
            this.pn_containerChangePass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_containerChangePass.Location = new System.Drawing.Point(0, 0);
            this.pn_containerChangePass.Name = "pn_containerChangePass";
            this.pn_containerChangePass.Size = new System.Drawing.Size(428, 469);
            this.pn_containerChangePass.TabIndex = 62;
            this.pn_containerChangePass.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_containerChangePass_Paint);
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
            this.bt_cancel.Location = new System.Drawing.Point(208, 413);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(90, 34);
            this.bt_cancel.TabIndex = 61;
            this.bt_cancel.Text = "CANCEL";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.Black;
            this.bt_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_save.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.ForeColor = System.Drawing.Color.White;
            this.bt_save.Location = new System.Drawing.Point(311, 413);
            this.bt_save.Margin = new System.Windows.Forms.Padding(2);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(90, 34);
            this.bt_save.TabIndex = 60;
            this.bt_save.Text = "SAVE";
            this.bt_save.UseVisualStyleBackColor = false;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(167, 250);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(194, 27);
            this.txt_Email.TabIndex = 53;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.BackColor = System.Drawing.Color.Transparent;
            this.lb_Email.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.ForeColor = System.Drawing.Color.Black;
            this.lb_Email.Location = new System.Drawing.Point(19, 258);
            this.lb_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(72, 19);
            this.lb_Email.TabIndex = 52;
            this.lb_Email.Text = "Password";
            this.lb_Email.Click += new System.EventHandler(this.lb_Email_Click);
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
            this.bt_exit.Location = new System.Drawing.Point(376, 11);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(2);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Padding = new System.Windows.Forms.Padding(9, 0, 16, 0);
            this.bt_exit.Size = new System.Drawing.Size(41, 18);
            this.bt_exit.TabIndex = 17;
            this.bt_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // pn_user
            // 
            this.pn_user.Controls.Add(this.iconUser);
            this.pn_user.Location = new System.Drawing.Point(114, 32);
            this.pn_user.Name = "pn_user";
            this.pn_user.Size = new System.Drawing.Size(178, 97);
            this.pn_user.TabIndex = 0;
            // 
            // iconUser
            // 
            this.iconUser.BackColor = System.Drawing.SystemColors.Control;
            this.iconUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.iconUser.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUser.IconSize = 97;
            this.iconUser.Location = new System.Drawing.Point(0, 0);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(178, 97);
            this.iconUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconUser.TabIndex = 1;
            this.iconUser.TabStop = false;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 469);
            this.Controls.Add(this.pn_containerChangePass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePasswordForm";
            this.pn_containerChangePass.ResumeLayout(false);
            this.pn_containerChangePass.PerformLayout();
            this.pn_user.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_IdStaff;
        private System.Windows.Forms.Label lb_IdStaff;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Panel pn_containerChangePass;
        private FontAwesome.Sharp.IconButton bt_exit;
        private System.Windows.Forms.Panel pn_user;
        private FontAwesome.Sharp.IconPictureBox iconUser;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_save;
    }
}