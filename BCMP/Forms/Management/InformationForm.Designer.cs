namespace BCMP.Forms.Management
{
    partial class InformationForm
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
            this.cbb_role = new System.Windows.Forms.ComboBox();
            this.cbb_department = new System.Windows.Forms.ComboBox();
            this.txt_IdStaff = new System.Windows.Forms.TextBox();
            this.lb_IdStaff = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lb_role = new System.Windows.Forms.Label();
            this.lb_department = new System.Windows.Forms.Label();
            this.lb_phone = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.pn_containerInformation = new System.Windows.Forms.Panel();
            this.bt_exit = new FontAwesome.Sharp.IconButton();
            this.pn_user = new System.Windows.Forms.Panel();
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            this.lb_information = new System.Windows.Forms.Label();
            this.pn_containerInformation.SuspendLayout();
            this.pn_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            this.SuspendLayout();
            // 
            // cbb_role
            // 
            this.cbb_role.FormattingEnabled = true;
            this.cbb_role.Location = new System.Drawing.Point(152, 421);
            this.cbb_role.Name = "cbb_role";
            this.cbb_role.Size = new System.Drawing.Size(194, 21);
            this.cbb_role.TabIndex = 49;
            // 
            // cbb_department
            // 
            this.cbb_department.FormattingEnabled = true;
            this.cbb_department.Location = new System.Drawing.Point(152, 372);
            this.cbb_department.Name = "cbb_department";
            this.cbb_department.Size = new System.Drawing.Size(194, 21);
            this.cbb_department.TabIndex = 48;
            // 
            // txt_IdStaff
            // 
            this.txt_IdStaff.Location = new System.Drawing.Point(152, 161);
            this.txt_IdStaff.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IdStaff.Multiline = true;
            this.txt_IdStaff.Name = "txt_IdStaff";
            this.txt_IdStaff.Size = new System.Drawing.Size(194, 27);
            this.txt_IdStaff.TabIndex = 47;
            // 
            // lb_IdStaff
            // 
            this.lb_IdStaff.AutoSize = true;
            this.lb_IdStaff.BackColor = System.Drawing.Color.Transparent;
            this.lb_IdStaff.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IdStaff.ForeColor = System.Drawing.Color.Black;
            this.lb_IdStaff.Location = new System.Drawing.Point(50, 169);
            this.lb_IdStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_IdStaff.Name = "lb_IdStaff";
            this.lb_IdStaff.Size = new System.Drawing.Size(56, 19);
            this.lb_IdStaff.TabIndex = 46;
            this.lb_IdStaff.Text = "ID Staff";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(152, 325);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(2);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(194, 27);
            this.txt_phone.TabIndex = 45;
            // 
            // lb_role
            // 
            this.lb_role.AutoSize = true;
            this.lb_role.BackColor = System.Drawing.Color.Transparent;
            this.lb_role.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_role.ForeColor = System.Drawing.Color.Black;
            this.lb_role.Location = new System.Drawing.Point(50, 420);
            this.lb_role.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(39, 19);
            this.lb_role.TabIndex = 44;
            this.lb_role.Text = "Role";
            // 
            // lb_department
            // 
            this.lb_department.AutoSize = true;
            this.lb_department.BackColor = System.Drawing.Color.Transparent;
            this.lb_department.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_department.ForeColor = System.Drawing.Color.Black;
            this.lb_department.Location = new System.Drawing.Point(50, 371);
            this.lb_department.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_department.Name = "lb_department";
            this.lb_department.Size = new System.Drawing.Size(93, 19);
            this.lb_department.TabIndex = 43;
            this.lb_department.Text = "Department";
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.BackColor = System.Drawing.Color.Transparent;
            this.lb_phone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.ForeColor = System.Drawing.Color.Black;
            this.lb_phone.Location = new System.Drawing.Point(50, 333);
            this.lb_phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(53, 19);
            this.lb_phone.TabIndex = 42;
            this.lb_phone.Text = "Phone";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(152, 271);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(194, 27);
            this.txt_Email.TabIndex = 40;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(152, 215);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(194, 27);
            this.txt_name.TabIndex = 41;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.BackColor = System.Drawing.Color.Transparent;
            this.lb_Name.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.ForeColor = System.Drawing.Color.Black;
            this.lb_Name.Location = new System.Drawing.Point(50, 223);
            this.lb_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(76, 19);
            this.lb_Name.TabIndex = 38;
            this.lb_Name.Text = "Full name";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.BackColor = System.Drawing.Color.Transparent;
            this.lb_Email.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.ForeColor = System.Drawing.Color.Black;
            this.lb_Email.Location = new System.Drawing.Point(50, 279);
            this.lb_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(46, 19);
            this.lb_Email.TabIndex = 39;
            this.lb_Email.Text = "Email";
            // 
            // pn_containerInformation
            // 
            this.pn_containerInformation.Controls.Add(this.lb_information);
            this.pn_containerInformation.Controls.Add(this.bt_exit);
            this.pn_containerInformation.Controls.Add(this.pn_user);
            this.pn_containerInformation.Controls.Add(this.txt_name);
            this.pn_containerInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_containerInformation.Location = new System.Drawing.Point(0, 0);
            this.pn_containerInformation.Name = "pn_containerInformation";
            this.pn_containerInformation.Size = new System.Drawing.Size(428, 469);
            this.pn_containerInformation.TabIndex = 50;
            this.pn_containerInformation.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_containerInformation_Paint);
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
            this.pn_user.Location = new System.Drawing.Point(118, 37);
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
            // lb_information
            // 
            this.lb_information.AutoSize = true;
            this.lb_information.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_information.Location = new System.Drawing.Point(12, 9);
            this.lb_information.Name = "lb_information";
            this.lb_information.Size = new System.Drawing.Size(128, 25);
            this.lb_information.TabIndex = 53;
            this.lb_information.Text = "Information";
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 469);
            this.Controls.Add(this.cbb_role);
            this.Controls.Add(this.cbb_department);
            this.Controls.Add(this.txt_IdStaff);
            this.Controls.Add(this.lb_IdStaff);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lb_role);
            this.Controls.Add(this.lb_department);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.pn_containerInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformationForm";
            this.Load += new System.EventHandler(this.InformationForm_Load);
            this.pn_containerInformation.ResumeLayout(false);
            this.pn_containerInformation.PerformLayout();
            this.pn_user.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbb_role;
        private System.Windows.Forms.ComboBox cbb_department;
        private System.Windows.Forms.TextBox txt_IdStaff;
        private System.Windows.Forms.Label lb_IdStaff;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lb_role;
        private System.Windows.Forms.Label lb_department;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Panel pn_containerInformation;
        private System.Windows.Forms.Panel pn_user;
        private FontAwesome.Sharp.IconPictureBox iconUser;
        private FontAwesome.Sharp.IconButton bt_exit;
        private System.Windows.Forms.Label lb_information;
    }
}