namespace BCMP
{
    partial class dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.pn_leftDashBoard = new System.Windows.Forms.Panel();
            this.bt_report = new FontAwesome.Sharp.IconButton();
            this.bt_document = new FontAwesome.Sharp.IconButton();
            this.bt_project = new FontAwesome.Sharp.IconButton();
            this.bt_mission = new FontAwesome.Sharp.IconButton();
            this.bt_profile = new FontAwesome.Sharp.IconButton();
            this.bt_home = new FontAwesome.Sharp.IconButton();
            this.pn_logo = new System.Windows.Forms.Panel();
            this.ptb_logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pn_tittleBar = new System.Windows.Forms.Panel();
            this.bt_user = new FontAwesome.Sharp.IconButton();
            this.bt_remind = new FontAwesome.Sharp.IconButton();
            this.bt_mail = new FontAwesome.Sharp.IconButton();
            this.bt_notifications = new FontAwesome.Sharp.IconButton();
            this.lb_tittleChildform = new System.Windows.Forms.Label();
            this.iconCurrentChildform = new FontAwesome.Sharp.IconPictureBox();
            this.bt_minimize = new FontAwesome.Sharp.IconButton();
            this.bt_maximize = new FontAwesome.Sharp.IconButton();
            this.bt_exit = new FontAwesome.Sharp.IconButton();
            this.pn_container = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_shawdow = new System.Windows.Forms.Panel();
            this.dropdownMenu1 = new BCMP.Forms.Management.DropdownMenu(this.components);
            this.bt_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_changePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_language = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_vietnamese = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_english = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_logOut = new System.Windows.Forms.ToolStripMenuItem();
            this.pn_leftDashBoard.SuspendLayout();
            this.pn_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pn_tittleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildform)).BeginInit();
            this.pn_container.SuspendLayout();
            this.dropdownMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_leftDashBoard
            // 
            resources.ApplyResources(this.pn_leftDashBoard, "pn_leftDashBoard");
            this.pn_leftDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pn_leftDashBoard.Controls.Add(this.bt_report);
            this.pn_leftDashBoard.Controls.Add(this.bt_document);
            this.pn_leftDashBoard.Controls.Add(this.bt_project);
            this.pn_leftDashBoard.Controls.Add(this.bt_mission);
            this.pn_leftDashBoard.Controls.Add(this.bt_profile);
            this.pn_leftDashBoard.Controls.Add(this.bt_home);
            this.pn_leftDashBoard.Controls.Add(this.pn_logo);
            this.pn_leftDashBoard.Controls.Add(this.panel2);
            this.pn_leftDashBoard.Name = "pn_leftDashBoard";
            // 
            // bt_report
            // 
            resources.ApplyResources(this.bt_report, "bt_report");
            this.bt_report.BackColor = System.Drawing.Color.Transparent;
            this.bt_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_report.FlatAppearance.BorderSize = 0;
            this.bt_report.ForeColor = System.Drawing.Color.Snow;
            this.bt_report.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.bt_report.IconColor = System.Drawing.Color.Snow;
            this.bt_report.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_report.IconSize = 40;
            this.bt_report.Name = "bt_report";
            this.bt_report.UseVisualStyleBackColor = false;
            this.bt_report.Click += new System.EventHandler(this.bt_report_Click);
            // 
            // bt_document
            // 
            resources.ApplyResources(this.bt_document, "bt_document");
            this.bt_document.BackColor = System.Drawing.Color.Transparent;
            this.bt_document.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_document.FlatAppearance.BorderSize = 0;
            this.bt_document.ForeColor = System.Drawing.Color.Snow;
            this.bt_document.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.bt_document.IconColor = System.Drawing.Color.Snow;
            this.bt_document.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_document.IconSize = 40;
            this.bt_document.Name = "bt_document";
            this.bt_document.UseVisualStyleBackColor = false;
            this.bt_document.Click += new System.EventHandler(this.bt_document_Click);
            // 
            // bt_project
            // 
            resources.ApplyResources(this.bt_project, "bt_project");
            this.bt_project.BackColor = System.Drawing.Color.Transparent;
            this.bt_project.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_project.FlatAppearance.BorderSize = 0;
            this.bt_project.ForeColor = System.Drawing.Color.Snow;
            this.bt_project.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.bt_project.IconColor = System.Drawing.Color.Snow;
            this.bt_project.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_project.IconSize = 40;
            this.bt_project.Name = "bt_project";
            this.bt_project.UseVisualStyleBackColor = false;
            this.bt_project.Click += new System.EventHandler(this.bt_project_Click);
            // 
            // bt_mission
            // 
            resources.ApplyResources(this.bt_mission, "bt_mission");
            this.bt_mission.BackColor = System.Drawing.Color.Transparent;
            this.bt_mission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_mission.FlatAppearance.BorderSize = 0;
            this.bt_mission.ForeColor = System.Drawing.Color.Snow;
            this.bt_mission.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.bt_mission.IconColor = System.Drawing.Color.Snow;
            this.bt_mission.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_mission.IconSize = 40;
            this.bt_mission.Name = "bt_mission";
            this.bt_mission.UseVisualStyleBackColor = false;
            this.bt_mission.Click += new System.EventHandler(this.bt_mission_Click);
            // 
            // bt_profile
            // 
            resources.ApplyResources(this.bt_profile, "bt_profile");
            this.bt_profile.BackColor = System.Drawing.Color.Transparent;
            this.bt_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_profile.FlatAppearance.BorderSize = 0;
            this.bt_profile.ForeColor = System.Drawing.Color.Snow;
            this.bt_profile.IconChar = FontAwesome.Sharp.IconChar.User;
            this.bt_profile.IconColor = System.Drawing.Color.Snow;
            this.bt_profile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_profile.IconSize = 40;
            this.bt_profile.Name = "bt_profile";
            this.bt_profile.UseVisualStyleBackColor = false;
            this.bt_profile.Click += new System.EventHandler(this.bt_employee_Click);
            // 
            // bt_home
            // 
            resources.ApplyResources(this.bt_home, "bt_home");
            this.bt_home.BackColor = System.Drawing.Color.Transparent;
            this.bt_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_home.FlatAppearance.BorderSize = 0;
            this.bt_home.ForeColor = System.Drawing.Color.Snow;
            this.bt_home.IconChar = FontAwesome.Sharp.IconChar.House;
            this.bt_home.IconColor = System.Drawing.Color.Snow;
            this.bt_home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_home.IconSize = 40;
            this.bt_home.Name = "bt_home";
            this.bt_home.UseVisualStyleBackColor = false;
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click);
            // 
            // pn_logo
            // 
            resources.ApplyResources(this.pn_logo, "pn_logo");
            this.pn_logo.Controls.Add(this.ptb_logo);
            this.pn_logo.Name = "pn_logo";
            // 
            // ptb_logo
            // 
            resources.ApplyResources(this.ptb_logo, "ptb_logo");
            this.ptb_logo.BackColor = System.Drawing.Color.Transparent;
            this.ptb_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_logo.Image = global::BCMP.Properties.Resources._629235f0ad752419f8ecfe84;
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.TabStop = false;
            this.ptb_logo.Click += new System.EventHandler(this.ptb_logo_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Name = "panel2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::BCMP.Properties.Resources.logo_color;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pn_tittleBar
            // 
            resources.ApplyResources(this.pn_tittleBar, "pn_tittleBar");
            this.pn_tittleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pn_tittleBar.Controls.Add(this.bt_user);
            this.pn_tittleBar.Controls.Add(this.bt_remind);
            this.pn_tittleBar.Controls.Add(this.bt_mail);
            this.pn_tittleBar.Controls.Add(this.bt_notifications);
            this.pn_tittleBar.Controls.Add(this.lb_tittleChildform);
            this.pn_tittleBar.Controls.Add(this.iconCurrentChildform);
            this.pn_tittleBar.Controls.Add(this.bt_minimize);
            this.pn_tittleBar.Controls.Add(this.bt_maximize);
            this.pn_tittleBar.Controls.Add(this.bt_exit);
            this.pn_tittleBar.Name = "pn_tittleBar";
            this.pn_tittleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_tittleBar_MouseDown);
            // 
            // bt_user
            // 
            resources.ApplyResources(this.bt_user, "bt_user");
            this.bt_user.BackColor = System.Drawing.Color.Transparent;
            this.bt_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_user.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.bt_user.FlatAppearance.BorderSize = 0;
            this.bt_user.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.bt_user.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.bt_user.ForeColor = System.Drawing.Color.Snow;
            this.bt_user.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.bt_user.IconColor = System.Drawing.Color.Snow;
            this.bt_user.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_user.IconSize = 30;
            this.bt_user.Name = "bt_user";
            this.bt_user.UseVisualStyleBackColor = false;
            this.bt_user.Click += new System.EventHandler(this.bt_user_Click);
            // 
            // bt_remind
            // 
            resources.ApplyResources(this.bt_remind, "bt_remind");
            this.bt_remind.BackColor = System.Drawing.Color.Transparent;
            this.bt_remind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_remind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.bt_remind.FlatAppearance.BorderSize = 0;
            this.bt_remind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.bt_remind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.bt_remind.ForeColor = System.Drawing.Color.Transparent;
            this.bt_remind.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.bt_remind.IconColor = System.Drawing.Color.Snow;
            this.bt_remind.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_remind.IconSize = 30;
            this.bt_remind.Name = "bt_remind";
            this.bt_remind.UseVisualStyleBackColor = false;
            this.bt_remind.Click += new System.EventHandler(this.bt_remind_Click);
            // 
            // bt_mail
            // 
            resources.ApplyResources(this.bt_mail, "bt_mail");
            this.bt_mail.BackColor = System.Drawing.Color.Transparent;
            this.bt_mail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_mail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.bt_mail.FlatAppearance.BorderSize = 0;
            this.bt_mail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.bt_mail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.bt_mail.ForeColor = System.Drawing.Color.Transparent;
            this.bt_mail.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.bt_mail.IconColor = System.Drawing.Color.Snow;
            this.bt_mail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_mail.IconSize = 30;
            this.bt_mail.Name = "bt_mail";
            this.bt_mail.UseVisualStyleBackColor = false;
            this.bt_mail.Click += new System.EventHandler(this.bt_mail_Click);
            // 
            // bt_notifications
            // 
            resources.ApplyResources(this.bt_notifications, "bt_notifications");
            this.bt_notifications.BackColor = System.Drawing.Color.Transparent;
            this.bt_notifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_notifications.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.bt_notifications.FlatAppearance.BorderSize = 0;
            this.bt_notifications.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.bt_notifications.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.bt_notifications.ForeColor = System.Drawing.Color.Transparent;
            this.bt_notifications.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.bt_notifications.IconColor = System.Drawing.Color.Snow;
            this.bt_notifications.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_notifications.IconSize = 30;
            this.bt_notifications.Name = "bt_notifications";
            this.bt_notifications.UseVisualStyleBackColor = false;
            this.bt_notifications.Click += new System.EventHandler(this.bt_notifications_Click);
            // 
            // lb_tittleChildform
            // 
            resources.ApplyResources(this.lb_tittleChildform, "lb_tittleChildform");
            this.lb_tittleChildform.ForeColor = System.Drawing.Color.Snow;
            this.lb_tittleChildform.Name = "lb_tittleChildform";
            // 
            // iconCurrentChildform
            // 
            resources.ApplyResources(this.iconCurrentChildform, "iconCurrentChildform");
            this.iconCurrentChildform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.iconCurrentChildform.ForeColor = System.Drawing.Color.Snow;
            this.iconCurrentChildform.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildform.IconColor = System.Drawing.Color.Snow;
            this.iconCurrentChildform.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildform.IconSize = 39;
            this.iconCurrentChildform.Name = "iconCurrentChildform";
            this.iconCurrentChildform.TabStop = false;
            // 
            // bt_minimize
            // 
            resources.ApplyResources(this.bt_minimize, "bt_minimize");
            this.bt_minimize.BackColor = System.Drawing.Color.Transparent;
            this.bt_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_minimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.bt_minimize.FlatAppearance.BorderSize = 0;
            this.bt_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.bt_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.bt_minimize.ForeColor = System.Drawing.Color.Transparent;
            this.bt_minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.bt_minimize.IconColor = System.Drawing.Color.Snow;
            this.bt_minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_minimize.IconSize = 20;
            this.bt_minimize.Name = "bt_minimize";
            this.bt_minimize.UseVisualStyleBackColor = false;
            this.bt_minimize.Click += new System.EventHandler(this.bt_minimize_Click);
            // 
            // bt_maximize
            // 
            resources.ApplyResources(this.bt_maximize, "bt_maximize");
            this.bt_maximize.BackColor = System.Drawing.Color.Transparent;
            this.bt_maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_maximize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.bt_maximize.FlatAppearance.BorderSize = 0;
            this.bt_maximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.bt_maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.bt_maximize.ForeColor = System.Drawing.Color.Transparent;
            this.bt_maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.bt_maximize.IconColor = System.Drawing.Color.Snow;
            this.bt_maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_maximize.IconSize = 20;
            this.bt_maximize.Name = "bt_maximize";
            this.bt_maximize.UseVisualStyleBackColor = false;
            this.bt_maximize.Click += new System.EventHandler(this.bt_maximize_Click);
            // 
            // bt_exit
            // 
            resources.ApplyResources(this.bt_exit, "bt_exit");
            this.bt_exit.BackColor = System.Drawing.Color.Transparent;
            this.bt_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.bt_exit.FlatAppearance.BorderSize = 0;
            this.bt_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.bt_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.bt_exit.ForeColor = System.Drawing.Color.Transparent;
            this.bt_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.bt_exit.IconColor = System.Drawing.Color.Snow;
            this.bt_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_exit.IconSize = 20;
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // pn_container
            // 
            resources.ApplyResources(this.pn_container, "pn_container");
            this.pn_container.Controls.Add(this.vScrollBar1);
            this.pn_container.Name = "pn_container";
            // 
            // vScrollBar1
            // 
            resources.ApplyResources(this.vScrollBar1, "vScrollBar1");
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panel1.Name = "panel1";
            // 
            // pn_shawdow
            // 
            resources.ApplyResources(this.pn_shawdow, "pn_shawdow");
            this.pn_shawdow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.pn_shawdow.Name = "pn_shawdow";
            // 
            // dropdownMenu1
            // 
            resources.ApplyResources(this.dropdownMenu1, "dropdownMenu1");
            this.dropdownMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dropdownMenu1.IsMainMenu = false;
            this.dropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_Info,
            this.bt_changePassword,
            this.bt_language,
            this.bt_logOut});
            this.dropdownMenu1.MenuItemHeight = 25;
            this.dropdownMenu1.MenuItemTextColor = System.Drawing.Color.Snow;
            this.dropdownMenu1.Name = "dropdownMenu1";
            this.dropdownMenu1.PrimaryColor = System.Drawing.Color.Black;
            // 
            // bt_Info
            // 
            resources.ApplyResources(this.bt_Info, "bt_Info");
            this.bt_Info.Name = "bt_Info";
            this.bt_Info.Click += new System.EventHandler(this.bt_Info_Click);
            // 
            // bt_changePassword
            // 
            resources.ApplyResources(this.bt_changePassword, "bt_changePassword");
            this.bt_changePassword.Name = "bt_changePassword";
            this.bt_changePassword.Click += new System.EventHandler(this.bt_changePassword_Click);
            // 
            // bt_language
            // 
            resources.ApplyResources(this.bt_language, "bt_language");
            this.bt_language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_vietnamese,
            this.bt_english});
            this.bt_language.Name = "bt_language";
            // 
            // bt_vietnamese
            // 
            resources.ApplyResources(this.bt_vietnamese, "bt_vietnamese");
            this.bt_vietnamese.Name = "bt_vietnamese";
            this.bt_vietnamese.Click += new System.EventHandler(this.bt_vietnamese_Click);
            // 
            // bt_english
            // 
            resources.ApplyResources(this.bt_english, "bt_english");
            this.bt_english.Name = "bt_english";
            this.bt_english.Click += new System.EventHandler(this.bt_english_Click);
            // 
            // bt_logOut
            // 
            resources.ApplyResources(this.bt_logOut, "bt_logOut");
            this.bt_logOut.Name = "bt_logOut";
            this.bt_logOut.Click += new System.EventHandler(this.bt_logOut_Click);
            // 
            // dashboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn_container);
            this.Controls.Add(this.pn_shawdow);
            this.Controls.Add(this.pn_tittleBar);
            this.Controls.Add(this.pn_leftDashBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.pn_leftDashBoard.ResumeLayout(false);
            this.pn_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pn_tittleBar.ResumeLayout(false);
            this.pn_tittleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildform)).EndInit();
            this.pn_container.ResumeLayout(false);
            this.dropdownMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_leftDashBoard;
        private System.Windows.Forms.Panel pn_logo;
        private FontAwesome.Sharp.IconButton bt_document;
        private FontAwesome.Sharp.IconButton bt_project;
        private FontAwesome.Sharp.IconButton bt_home;
        private FontAwesome.Sharp.IconButton bt_profile;
        private System.Windows.Forms.PictureBox ptb_logo;
        private System.Windows.Forms.Panel pn_tittleBar;
        private FontAwesome.Sharp.IconButton bt_exit;
        private FontAwesome.Sharp.IconButton bt_minimize;
        private FontAwesome.Sharp.IconButton bt_maximize;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildform;
        private System.Windows.Forms.Label lb_tittleChildform;
        private System.Windows.Forms.Panel pn_container;
        private FontAwesome.Sharp.IconButton bt_remind;
        private FontAwesome.Sharp.IconButton bt_mail;
        private FontAwesome.Sharp.IconButton bt_notifications;
        private FontAwesome.Sharp.IconButton bt_user;
        private FontAwesome.Sharp.IconButton bt_report;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pn_shawdow;
        private FontAwesome.Sharp.IconButton bt_mission;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private Forms.Management.DropdownMenu dropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem bt_Info;
        private System.Windows.Forms.ToolStripMenuItem bt_changePassword;
        private System.Windows.Forms.ToolStripMenuItem bt_logOut;
        private System.Windows.Forms.ToolStripMenuItem bt_language;
        private System.Windows.Forms.ToolStripMenuItem bt_vietnamese;
        private System.Windows.Forms.ToolStripMenuItem bt_english;
    }
}