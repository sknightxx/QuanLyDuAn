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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationForm));
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
            this.lb_information = new System.Windows.Forms.Label();
            this.pn_user = new System.Windows.Forms.Panel();
            this.bt_exit = new FontAwesome.Sharp.IconButton();
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            this.pn_containerInformation.SuspendLayout();
            this.pn_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            this.SuspendLayout();
            // 
            // cbb_role
            // 
            resources.ApplyResources(this.cbb_role, "cbb_role");
            this.cbb_role.FormattingEnabled = true;
            this.cbb_role.Name = "cbb_role";
            // 
            // cbb_department
            // 
            resources.ApplyResources(this.cbb_department, "cbb_department");
            this.cbb_department.FormattingEnabled = true;
            this.cbb_department.Name = "cbb_department";
            // 
            // txt_IdStaff
            // 
            resources.ApplyResources(this.txt_IdStaff, "txt_IdStaff");
            this.txt_IdStaff.Name = "txt_IdStaff";
            // 
            // lb_IdStaff
            // 
            resources.ApplyResources(this.lb_IdStaff, "lb_IdStaff");
            this.lb_IdStaff.BackColor = System.Drawing.Color.Transparent;
            this.lb_IdStaff.ForeColor = System.Drawing.Color.Black;
            this.lb_IdStaff.Name = "lb_IdStaff";
            // 
            // txt_phone
            // 
            resources.ApplyResources(this.txt_phone, "txt_phone");
            this.txt_phone.Name = "txt_phone";
            // 
            // lb_role
            // 
            resources.ApplyResources(this.lb_role, "lb_role");
            this.lb_role.BackColor = System.Drawing.Color.Transparent;
            this.lb_role.ForeColor = System.Drawing.Color.Black;
            this.lb_role.Name = "lb_role";
            // 
            // lb_department
            // 
            resources.ApplyResources(this.lb_department, "lb_department");
            this.lb_department.BackColor = System.Drawing.Color.Transparent;
            this.lb_department.ForeColor = System.Drawing.Color.Black;
            this.lb_department.Name = "lb_department";
            // 
            // lb_phone
            // 
            resources.ApplyResources(this.lb_phone, "lb_phone");
            this.lb_phone.BackColor = System.Drawing.Color.Transparent;
            this.lb_phone.ForeColor = System.Drawing.Color.Black;
            this.lb_phone.Name = "lb_phone";
            // 
            // txt_Email
            // 
            resources.ApplyResources(this.txt_Email, "txt_Email");
            this.txt_Email.Name = "txt_Email";
            // 
            // txt_name
            // 
            resources.ApplyResources(this.txt_name, "txt_name");
            this.txt_name.Name = "txt_name";
            // 
            // lb_Name
            // 
            resources.ApplyResources(this.lb_Name, "lb_Name");
            this.lb_Name.BackColor = System.Drawing.Color.Transparent;
            this.lb_Name.ForeColor = System.Drawing.Color.Black;
            this.lb_Name.Name = "lb_Name";
            // 
            // lb_Email
            // 
            resources.ApplyResources(this.lb_Email, "lb_Email");
            this.lb_Email.BackColor = System.Drawing.Color.Transparent;
            this.lb_Email.ForeColor = System.Drawing.Color.Black;
            this.lb_Email.Name = "lb_Email";
            // 
            // pn_containerInformation
            // 
            resources.ApplyResources(this.pn_containerInformation, "pn_containerInformation");
            this.pn_containerInformation.Controls.Add(this.lb_information);
            this.pn_containerInformation.Controls.Add(this.bt_exit);
            this.pn_containerInformation.Controls.Add(this.pn_user);
            this.pn_containerInformation.Controls.Add(this.txt_name);
            this.pn_containerInformation.Name = "pn_containerInformation";
            this.pn_containerInformation.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_containerInformation_Paint);
            this.pn_containerInformation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_containerInformation_MouseDown);
            this.pn_containerInformation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pn_containerInformation_MouseMove);
            this.pn_containerInformation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pn_containerInformation_MouseUp);
            // 
            // lb_information
            // 
            resources.ApplyResources(this.lb_information, "lb_information");
            this.lb_information.Name = "lb_information";
            // 
            // pn_user
            // 
            resources.ApplyResources(this.pn_user, "pn_user");
            this.pn_user.Controls.Add(this.iconUser);
            this.pn_user.Name = "pn_user";
            // 
            // lb_information
            // 
            resources.ApplyResources(this.lb_information, "lb_information");
            this.lb_information.Name = "lb_information";
            // 
            // pn_user
            // 
            resources.ApplyResources(this.pn_user, "pn_user");
            this.pn_user.Controls.Add(this.iconUser);
            this.pn_user.Name = "pn_user";
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
            // 
            // InformationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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