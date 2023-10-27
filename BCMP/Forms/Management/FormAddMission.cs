using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace BCMP.Forms.Management
{
    public partial class FormAddMission : Form
    {
        private TextBox txt_management;
        private Label lb_Management;
        private TextBox txt_IdProject;
        private Panel panel1;
        private Panel pn_tittleAddProject;
        private Label lb_newMission;
        private FontAwesome.Sharp.IconButton bt_exit;
        private Button bt_cancel;
        private Button bt_save;
        private Label lb_IdProject;
        private TextBox txt_name;
        private Label lb_member;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label lb_description;
        private DateTimePicker dateTimePicker2;
        private Panel pn_container;
        private TextBox txt_Description;
        private Label lb_document;
        private Label label2;
        private TextBox txt_document;
        private TextBox txt_relateProject;
        private Label lb_relateProject;
        private Label lb_status;
        private ComboBox cbb_status;
        private Label lb_Tittle;

        public FormAddMission()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txt_management = new System.Windows.Forms.TextBox();
            this.lb_Management = new System.Windows.Forms.Label();
            this.txt_IdProject = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbb_status = new System.Windows.Forms.ComboBox();
            this.txt_relateProject = new System.Windows.Forms.TextBox();
            this.lb_relateProject = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.txt_document = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lb_description = new System.Windows.Forms.Label();
            this.pn_tittleAddProject = new System.Windows.Forms.Panel();
            this.lb_newMission = new System.Windows.Forms.Label();
            this.bt_exit = new FontAwesome.Sharp.IconButton();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.lb_IdProject = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lb_member = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.pn_container = new System.Windows.Forms.Panel();
            this.lb_document = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Tittle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pn_tittleAddProject.SuspendLayout();
            this.pn_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_management
            // 
            this.txt_management.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_management.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_management.Location = new System.Drawing.Point(353, 96);
            this.txt_management.Margin = new System.Windows.Forms.Padding(2);
            this.txt_management.Multiline = true;
            this.txt_management.Name = "txt_management";
            this.txt_management.Size = new System.Drawing.Size(290, 29);
            this.txt_management.TabIndex = 16;
            this.txt_management.Text = "Enter management staff";
            this.txt_management.Enter += new System.EventHandler(this.txt_management_Enter);
            this.txt_management.Leave += new System.EventHandler(this.txt_management_Leave);
            // 
            // lb_Management
            // 
            this.lb_Management.AutoSize = true;
            this.lb_Management.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Management.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Management.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_Management.Location = new System.Drawing.Point(350, 68);
            this.lb_Management.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Management.Name = "lb_Management";
            this.lb_Management.Size = new System.Drawing.Size(130, 18);
            this.lb_Management.TabIndex = 15;
            this.lb_Management.Text = " Management staff";
            // 
            // txt_IdProject
            // 
            this.txt_IdProject.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdProject.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_IdProject.Location = new System.Drawing.Point(26, 96);
            this.txt_IdProject.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IdProject.Multiline = true;
            this.txt_IdProject.Name = "txt_IdProject";
            this.txt_IdProject.Size = new System.Drawing.Size(210, 29);
            this.txt_IdProject.TabIndex = 14;
            this.txt_IdProject.Text = "Enter ID mission";
            this.txt_IdProject.Enter += new System.EventHandler(this.txt_IdProject_Enter);
            this.txt_IdProject.Leave += new System.EventHandler(this.txt_IdProject_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbb_status);
            this.panel1.Controls.Add(this.txt_relateProject);
            this.panel1.Controls.Add(this.lb_relateProject);
            this.panel1.Controls.Add(this.lb_status);
            this.panel1.Controls.Add(this.txt_document);
            this.panel1.Controls.Add(this.lb_Management);
            this.panel1.Controls.Add(this.txt_Description);
            this.panel1.Controls.Add(this.lb_description);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 550);
            this.panel1.TabIndex = 17;
            // 
            // cbb_status
            // 
            this.cbb_status.FormattingEnabled = true;
            this.cbb_status.Location = new System.Drawing.Point(26, 325);
            this.cbb_status.Name = "cbb_status";
            this.cbb_status.Size = new System.Drawing.Size(244, 21);
            this.cbb_status.TabIndex = 22;
            // 
            // txt_relateProject
            // 
            this.txt_relateProject.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_relateProject.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_relateProject.Location = new System.Drawing.Point(353, 323);
            this.txt_relateProject.Multiline = true;
            this.txt_relateProject.Name = "txt_relateProject";
            this.txt_relateProject.Size = new System.Drawing.Size(244, 29);
            this.txt_relateProject.TabIndex = 21;
            this.txt_relateProject.Text = "Enter related project";
            this.txt_relateProject.Enter += new System.EventHandler(this.txt_relateProject_Enter);
            this.txt_relateProject.Leave += new System.EventHandler(this.txt_relateProject_Leave);
            // 
            // lb_relateProject
            // 
            this.lb_relateProject.AutoSize = true;
            this.lb_relateProject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_relateProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_relateProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_relateProject.Location = new System.Drawing.Point(349, 293);
            this.lb_relateProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_relateProject.Name = "lb_relateProject";
            this.lb_relateProject.Size = new System.Drawing.Size(107, 18);
            this.lb_relateProject.TabIndex = 20;
            this.lb_relateProject.Text = "Related project";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_status.Location = new System.Drawing.Point(22, 293);
            this.lb_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(50, 18);
            this.lb_status.TabIndex = 18;
            this.lb_status.Text = "Status";
            // 
            // txt_document
            // 
            this.txt_document.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_document.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_document.Location = new System.Drawing.Point(26, 245);
            this.txt_document.Multiline = true;
            this.txt_document.Name = "txt_document";
            this.txt_document.Size = new System.Drawing.Size(244, 29);
            this.txt_document.TabIndex = 16;
            this.txt_document.Text = "Attachments";
            this.txt_document.Enter += new System.EventHandler(this.txt_document_Enter);
            this.txt_document.Leave += new System.EventHandler(this.txt_document_Leave);
            // 
            // txt_Description
            // 
            this.txt_Description.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Description.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Description.Location = new System.Drawing.Point(26, 398);
            this.txt_Description.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(618, 69);
            this.txt_Description.TabIndex = 10;
            this.txt_Description.Text = "Enter desciption about mission";
            this.txt_Description.Enter += new System.EventHandler(this.txt_Description_Enter);
            this.txt_Description.Leave += new System.EventHandler(this.txt_Description_Leave);
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_description.Location = new System.Drawing.Point(22, 366);
            this.lb_description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(83, 18);
            this.lb_description.TabIndex = 9;
            this.lb_description.Text = "Description";
            // 
            // pn_tittleAddProject
            // 
            this.pn_tittleAddProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pn_tittleAddProject.Controls.Add(this.lb_newMission);
            this.pn_tittleAddProject.Controls.Add(this.bt_exit);
            this.pn_tittleAddProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_tittleAddProject.Location = new System.Drawing.Point(0, 0);
            this.pn_tittleAddProject.Margin = new System.Windows.Forms.Padding(2);
            this.pn_tittleAddProject.Name = "pn_tittleAddProject";
            this.pn_tittleAddProject.Size = new System.Drawing.Size(674, 58);
            this.pn_tittleAddProject.TabIndex = 21;
            // 
            // lb_newMission
            // 
            this.lb_newMission.AutoSize = true;
            this.lb_newMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_newMission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.lb_newMission.Location = new System.Drawing.Point(10, 9);
            this.lb_newMission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_newMission.Name = "lb_newMission";
            this.lb_newMission.Size = new System.Drawing.Size(129, 24);
            this.lb_newMission.TabIndex = 0;
            this.lb_newMission.Text = "New mission";
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
            this.bt_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(144)))));
            this.bt_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.bt_exit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.bt_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_exit.IconSize = 30;
            this.bt_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_exit.Location = new System.Drawing.Point(618, 9);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(2);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Padding = new System.Windows.Forms.Padding(9, 0, 16, 0);
            this.bt_exit.Size = new System.Drawing.Size(45, 24);
            this.bt_exit.TabIndex = 15;
            this.bt_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.White;
            this.bt_cancel.FlatAppearance.BorderSize = 0;
            this.bt_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.bt_cancel.Location = new System.Drawing.Point(450, 489);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(90, 34);
            this.bt_cancel.TabIndex = 20;
            this.bt_cancel.Text = "CANCEL";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            this.bt_cancel.MouseEnter += new System.EventHandler(this.bt_cancel_MouseEnter);
            this.bt_cancel.MouseLeave += new System.EventHandler(this.bt_cancel_MouseLeave);
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.bt_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_save.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.ForeColor = System.Drawing.Color.White;
            this.bt_save.Location = new System.Drawing.Point(553, 489);
            this.bt_save.Margin = new System.Windows.Forms.Padding(2);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(90, 34);
            this.bt_save.TabIndex = 19;
            this.bt_save.Text = "SAVE";
            this.bt_save.UseVisualStyleBackColor = false;
            // 
            // lb_IdProject
            // 
            this.lb_IdProject.AutoSize = true;
            this.lb_IdProject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_IdProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IdProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_IdProject.Location = new System.Drawing.Point(22, 68);
            this.lb_IdProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_IdProject.Name = "lb_IdProject";
            this.lb_IdProject.Size = new System.Drawing.Size(78, 18);
            this.lb_IdProject.TabIndex = 13;
            this.lb_IdProject.Text = "ID mission";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_name.Location = new System.Drawing.Point(25, 166);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(618, 29);
            this.txt_name.TabIndex = 12;
            this.txt_name.Text = "Enter tittle of mission";
            this.txt_name.Enter += new System.EventHandler(this.txt_name_Enter);
            this.txt_name.Leave += new System.EventHandler(this.txt_name_Leave);
            // 
            // lb_member
            // 
            this.lb_member.AutoSize = true;
            this.lb_member.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_member.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_member.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_member.Location = new System.Drawing.Point(30, 372);
            this.lb_member.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_member.Name = "lb_member";
            this.lb_member.Size = new System.Drawing.Size(0, 18);
            this.lb_member.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label3.Location = new System.Drawing.Point(522, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "To";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(353, 245);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(506, 247);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // pn_container
            // 
            this.pn_container.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_container.Controls.Add(this.txt_management);
            this.pn_container.Controls.Add(this.txt_IdProject);
            this.pn_container.Controls.Add(this.lb_IdProject);
            this.pn_container.Controls.Add(this.lb_document);
            this.pn_container.Controls.Add(this.label2);
            this.pn_container.Controls.Add(this.txt_name);
            this.pn_container.Controls.Add(this.label3);
            this.pn_container.Controls.Add(this.lb_Tittle);
            this.pn_container.Controls.Add(this.dateTimePicker1);
            this.pn_container.Controls.Add(this.dateTimePicker2);
            this.pn_container.Controls.Add(this.panel1);
            this.pn_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_container.Location = new System.Drawing.Point(0, 0);
            this.pn_container.Margin = new System.Windows.Forms.Padding(2);
            this.pn_container.Name = "pn_container";
            this.pn_container.Size = new System.Drawing.Size(674, 550);
            this.pn_container.TabIndex = 22;
            this.pn_container.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_container_Paint);
            // 
            // lb_document
            // 
            this.lb_document.AutoSize = true;
            this.lb_document.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_document.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_document.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_document.Location = new System.Drawing.Point(22, 215);
            this.lb_document.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_document.Name = "lb_document";
            this.lb_document.Size = new System.Drawing.Size(77, 18);
            this.lb_document.TabIndex = 3;
            this.lb_document.Text = "Document";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label2.Location = new System.Drawing.Point(366, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "From";
            // 
            // lb_Tittle
            // 
            this.lb_Tittle.AutoSize = true;
            this.lb_Tittle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_Tittle.Location = new System.Drawing.Point(21, 138);
            this.lb_Tittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Tittle.Name = "lb_Tittle";
            this.lb_Tittle.Size = new System.Drawing.Size(39, 18);
            this.lb_Tittle.TabIndex = 1;
            this.lb_Tittle.Text = "Tittle";
            // 
            // FormAddMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(674, 550);
            this.Controls.Add(this.pn_tittleAddProject);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.lb_member);
            this.Controls.Add(this.pn_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddMission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_tittleAddProject.ResumeLayout(false);
            this.pn_tittleAddProject.PerformLayout();
            this.pn_container.ResumeLayout(false);
            this.pn_container.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_cancel_MouseEnter(object sender, EventArgs e)
        {
            bt_cancel.Font = new Font(bt_cancel.Font, System.Drawing.FontStyle.Underline);

        }

        private void bt_cancel_MouseLeave(object sender, EventArgs e)
        {
            bt_cancel.Font = new Font(bt_cancel.Font, System.Drawing.FontStyle.Regular);

        }

        private void pn_container_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 10; // Độ cong của góc (có thể điều chỉnh)
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
            GraphicsPath path = new GraphicsPath();

            // Vẽ góc bo tròn
            path.AddArc(bounds.Left, bounds.Top, borderRadius * 2, borderRadius * 2, 180, 90);
            path.AddArc(bounds.Right - borderRadius * 2, bounds.Top, borderRadius * 2, borderRadius * 2, 270, 90);
            path.AddArc(bounds.Right - borderRadius * 2, bounds.Bottom - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);
            base.OnPaintBackground(e);
        }

        private void txt_management_Leave(object sender, EventArgs e)
        {
            if (txt_management.Text == "")
            {
                txt_management.Text = "Enter management staff";
                txt_management.ForeColor = Color.Black;
            }
        }

        private void txt_management_Enter(object sender, EventArgs e)
        {
            if(txt_management.Text == "Enter management staff")
            {
                txt_management.Text = "";
                txt_management.ForeColor = Color.Gray;
            }
        }

        

        private void txt_name_Leave(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                txt_name.Text = "Enter tittle of mission";
                txt_name.ForeColor = Color.Black;
            }
        }

        private void txt_name_Enter(object sender, EventArgs e)
        {
            if (txt_name.Text == "Enter tittle of mission")
            {
                txt_name.Text = "";
                txt_name.ForeColor = Color.Gray;
            }
        }

        private void txt_document_Leave(object sender, EventArgs e)
        {
            if (txt_document.Text == "")
            {
                txt_document.Text = "Attachments";
                txt_document.ForeColor = Color.Black;
            }
        }

        private void txt_document_Enter(object sender, EventArgs e)
        {
            if (txt_document.Text == "Attachments")
            {
                txt_document.Text = "";
                txt_document.ForeColor = Color.Gray;
            }
        }

        private void txt_relateProject_Leave(object sender, EventArgs e)
        {
            if (txt_relateProject.Text == "")
            {
                txt_relateProject.Text = "Enter related project";
                txt_relateProject.ForeColor = Color.Black;
            }
        }

        private void txt_relateProject_Enter(object sender, EventArgs e)
        {
            if (txt_relateProject.Text == "Enter related project")
            {
                txt_relateProject.Text = "";
                txt_relateProject.ForeColor = Color.Gray;
            }
        }

        private void txt_Description_Leave(object sender, EventArgs e)
        {
            if (txt_Description.Text == "")
            {
                txt_Description.Text = "Enter desciption about mission";
                txt_Description.ForeColor = Color.Black;
            }
        }

        private void txt_Description_Enter(object sender, EventArgs e)
        {
            if (txt_Description.Text == "Enter desciption about mission")
            {
                txt_Description.Text = "";
                txt_Description.ForeColor = Color.Gray;
            }

        }

        private void txt_IdProject_Leave(object sender, EventArgs e)
        {
            if (txt_IdProject.Text == "")
            {
                txt_IdProject.Text = "Enter ID mission";
                txt_IdProject.ForeColor = Color.Black;
            }
        }

        private void txt_IdProject_Enter(object sender, EventArgs e)
        {
            if (txt_IdProject.Text == "Enter ID mission")
            {
                txt_IdProject.Text = "";
                txt_IdProject.ForeColor = Color.Gray;
            }
        }
    }
}
