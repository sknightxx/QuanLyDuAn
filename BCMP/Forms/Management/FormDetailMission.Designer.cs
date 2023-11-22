namespace BCMP.Forms.Management
{
    partial class FormDetailMission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetailMission));
            this.bt_EditMission = new System.Windows.Forms.Button();
            this.pn_container = new System.Windows.Forms.Panel();
            this.txt_comment = new System.Windows.Forms.TextBox();
            this.lb_comment = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_document = new System.Windows.Forms.Label();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.bt_exit = new FontAwesome.Sharp.IconButton();
            this.txt_tittle = new System.Windows.Forms.TextBox();
            this.lb_Tittle = new System.Windows.Forms.Label();
            this.cbb_status = new System.Windows.Forms.ComboBox();
            this.txt_relateProject = new System.Windows.Forms.TextBox();
            this.lb_relateProject = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.txt_document = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lb_description = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Management = new System.Windows.Forms.Label();
            this.txt_management = new System.Windows.Forms.TextBox();
            this.pn_container.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_EditMission
            // 
            resources.ApplyResources(this.bt_EditMission, "bt_EditMission");
            this.bt_EditMission.BackColor = System.Drawing.Color.Black;
            this.bt_EditMission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_EditMission.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.bt_EditMission.FlatAppearance.BorderSize = 0;
            this.bt_EditMission.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_EditMission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_EditMission.ForeColor = System.Drawing.Color.White;
            this.bt_EditMission.Name = "bt_EditMission";
            this.bt_EditMission.UseVisualStyleBackColor = false;
            this.bt_EditMission.Click += new System.EventHandler(this.bt_EditMission_Click);
            // 
            // pn_container
            // 
            resources.ApplyResources(this.pn_container, "pn_container");
            this.pn_container.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_container.Controls.Add(this.txt_comment);
            this.pn_container.Controls.Add(this.lb_comment);
            this.pn_container.Controls.Add(this.bt_cancel);
            this.pn_container.Controls.Add(this.dtp_From);
            this.pn_container.Controls.Add(this.label2);
            this.pn_container.Controls.Add(this.label3);
            this.pn_container.Controls.Add(this.lb_document);
            this.pn_container.Controls.Add(this.dtp_To);
            this.pn_container.Controls.Add(this.bt_exit);
            this.pn_container.Controls.Add(this.txt_tittle);
            this.pn_container.Controls.Add(this.bt_EditMission);
            this.pn_container.Controls.Add(this.lb_Tittle);
            this.pn_container.Controls.Add(this.cbb_status);
            this.pn_container.Controls.Add(this.txt_relateProject);
            this.pn_container.Controls.Add(this.lb_relateProject);
            this.pn_container.Controls.Add(this.lb_status);
            this.pn_container.Controls.Add(this.txt_document);
            this.pn_container.Controls.Add(this.txt_Description);
            this.pn_container.Controls.Add(this.lb_description);
            this.pn_container.Controls.Add(this.panel1);
            this.pn_container.Name = "pn_container";
            this.pn_container.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_container_Paint);
            // 
            // txt_comment
            // 
            resources.ApplyResources(this.txt_comment, "txt_comment");
            this.txt_comment.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_comment.Name = "txt_comment";
            // 
            // lb_comment
            // 
            resources.ApplyResources(this.lb_comment, "lb_comment");
            this.lb_comment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_comment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_comment.Name = "lb_comment";
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
            this.bt_cancel.MouseEnter += new System.EventHandler(this.bt_cancel_MouseEnter);
            this.bt_cancel.MouseLeave += new System.EventHandler(this.bt_cancel_MouseLeave);
            // 
            // dtp_From
            // 
            resources.ApplyResources(this.dtp_From, "dtp_From");
            this.dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_From.Name = "dtp_From";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label3.Name = "label3";
            // 
            // lb_document
            // 
            resources.ApplyResources(this.lb_document, "lb_document");
            this.lb_document.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_document.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_document.Name = "lb_document";
            // 
            // dtp_To
            // 
            resources.ApplyResources(this.dtp_To, "dtp_To");
            this.dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_To.Name = "dtp_To";
            // 
            // bt_exit
            // 
            resources.ApplyResources(this.bt_exit, "bt_exit");
            this.bt_exit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bt_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_exit.FlatAppearance.BorderSize = 0;
            this.bt_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.bt_exit.IconColor = System.Drawing.Color.Black;
            this.bt_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_exit.IconSize = 30;
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // txt_tittle
            // 
            resources.ApplyResources(this.txt_tittle, "txt_tittle");
            this.txt_tittle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_tittle.Name = "txt_tittle";
            this.txt_tittle.ReadOnly = true;
            // 
            // lb_Tittle
            // 
            resources.ApplyResources(this.lb_Tittle, "lb_Tittle");
            this.lb_Tittle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Tittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_Tittle.Name = "lb_Tittle";
            // 
            // cbb_status
            // 
            resources.ApplyResources(this.cbb_status, "cbb_status");
            this.cbb_status.FormattingEnabled = true;
            this.cbb_status.Items.AddRange(new object[] {
            resources.GetString("cbb_status.Items"),
            resources.GetString("cbb_status.Items1"),
            resources.GetString("cbb_status.Items2")});
            this.cbb_status.Name = "cbb_status";
            // 
            // txt_relateProject
            // 
            resources.ApplyResources(this.txt_relateProject, "txt_relateProject");
            this.txt_relateProject.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_relateProject.Name = "txt_relateProject";
            this.txt_relateProject.ReadOnly = true;
            // 
            // lb_relateProject
            // 
            resources.ApplyResources(this.lb_relateProject, "lb_relateProject");
            this.lb_relateProject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_relateProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_relateProject.Name = "lb_relateProject";
            // 
            // lb_status
            // 
            resources.ApplyResources(this.lb_status, "lb_status");
            this.lb_status.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_status.Name = "lb_status";
            // 
            // txt_document
            // 
            resources.ApplyResources(this.txt_document, "txt_document");
            this.txt_document.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_document.Name = "txt_document";
            // 
            // txt_Description
            // 
            resources.ApplyResources(this.txt_Description, "txt_Description");
            this.txt_Description.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Description.Name = "txt_Description";
            // 
            // lb_description
            // 
            resources.ApplyResources(this.lb_description, "lb_description");
            this.lb_description.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_description.Name = "lb_description";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.lb_Management);
            this.panel1.Controls.Add(this.txt_management);
            this.panel1.Name = "panel1";
            // 
            // lb_Management
            // 
            resources.ApplyResources(this.lb_Management, "lb_Management");
            this.lb_Management.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Management.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_Management.Name = "lb_Management";
            // 
            // txt_management
            // 
            resources.ApplyResources(this.txt_management, "txt_management");
            this.txt_management.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_management.Name = "txt_management";
            this.txt_management.ReadOnly = true;
            // 
            // FormDetailMission
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDetailMission";
            this.pn_container.ResumeLayout(false);
            this.pn_container.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_EditMission;
        private System.Windows.Forms.TextBox txt_management;
        private System.Windows.Forms.Label lb_document;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tittle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Tittle;
        private System.Windows.Forms.DateTimePicker dtp_To;
        private System.Windows.Forms.Panel pn_container;
        private System.Windows.Forms.ComboBox cbb_status;
        private System.Windows.Forms.TextBox txt_relateProject;
        private System.Windows.Forms.Label lb_relateProject;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.TextBox txt_document;
        private System.Windows.Forms.Label lb_Management;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.Button bt_cancel;
        private FontAwesome.Sharp.IconButton bt_exit;
        private System.Windows.Forms.DateTimePicker dtp_From;
        private System.Windows.Forms.TextBox txt_comment;
        private System.Windows.Forms.Label lb_comment;
        private System.Windows.Forms.Panel panel1;
    }
}