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
            this.bt_EditMission = new System.Windows.Forms.Button();
            this.pn_container = new System.Windows.Forms.Panel();
            this.txt_comment = new System.Windows.Forms.TextBox();
            this.lb_comment = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_document = new System.Windows.Forms.Label();
            this.txt_management = new System.Windows.Forms.TextBox();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.bt_exit = new FontAwesome.Sharp.IconButton();
            this.txt_tittle = new System.Windows.Forms.TextBox();
            this.txt_IdMission = new System.Windows.Forms.TextBox();
            this.lb_Tittle = new System.Windows.Forms.Label();
            this.lb_IdMission = new System.Windows.Forms.Label();
            this.cbb_status = new System.Windows.Forms.ComboBox();
            this.txt_relateProject = new System.Windows.Forms.TextBox();
            this.lb_relateProject = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.txt_document = new System.Windows.Forms.TextBox();
            this.lb_Management = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lb_description = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_EditMission
            // 
            this.bt_EditMission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_EditMission.BackColor = System.Drawing.Color.Black;
            this.bt_EditMission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_EditMission.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.bt_EditMission.FlatAppearance.BorderSize = 0;
            this.bt_EditMission.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_EditMission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_EditMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_EditMission.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_EditMission.ForeColor = System.Drawing.Color.White;
            this.bt_EditMission.Location = new System.Drawing.Point(788, 423);
            this.bt_EditMission.Margin = new System.Windows.Forms.Padding(2);
            this.bt_EditMission.Name = "bt_EditMission";
            this.bt_EditMission.Size = new System.Drawing.Size(92, 30);
            this.bt_EditMission.TabIndex = 19;
            this.bt_EditMission.Text = "Edit";
            this.bt_EditMission.UseVisualStyleBackColor = false;
            this.bt_EditMission.Click += new System.EventHandler(this.bt_EditMission_Click);
            // 
            // pn_container
            // 
            this.pn_container.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_container.Controls.Add(this.txt_comment);
            this.pn_container.Controls.Add(this.lb_comment);
            this.pn_container.Controls.Add(this.bt_cancel);
            this.pn_container.Controls.Add(this.dtp_From);
            this.pn_container.Controls.Add(this.label2);
            this.pn_container.Controls.Add(this.label3);
            this.pn_container.Controls.Add(this.lb_document);
            this.pn_container.Controls.Add(this.txt_management);
            this.pn_container.Controls.Add(this.dtp_To);
            this.pn_container.Controls.Add(this.bt_exit);
            this.pn_container.Controls.Add(this.txt_tittle);
            this.pn_container.Controls.Add(this.txt_IdMission);
            this.pn_container.Controls.Add(this.bt_EditMission);
            this.pn_container.Controls.Add(this.lb_Tittle);
            this.pn_container.Controls.Add(this.lb_IdMission);
            this.pn_container.Controls.Add(this.cbb_status);
            this.pn_container.Controls.Add(this.txt_relateProject);
            this.pn_container.Controls.Add(this.lb_relateProject);
            this.pn_container.Controls.Add(this.lb_status);
            this.pn_container.Controls.Add(this.txt_document);
            this.pn_container.Controls.Add(this.lb_Management);
            this.pn_container.Controls.Add(this.txt_Description);
            this.pn_container.Controls.Add(this.lb_description);
            this.pn_container.Controls.Add(this.panel1);
            this.pn_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_container.Location = new System.Drawing.Point(0, 0);
            this.pn_container.Name = "pn_container";
            this.pn_container.Size = new System.Drawing.Size(902, 468);
            this.pn_container.TabIndex = 17;
            this.pn_container.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_container_Paint);
            // 
            // txt_comment
            // 
            this.txt_comment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comment.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_comment.Location = new System.Drawing.Point(163, 345);
            this.txt_comment.Margin = new System.Windows.Forms.Padding(2);
            this.txt_comment.Multiline = true;
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.Size = new System.Drawing.Size(680, 59);
            this.txt_comment.TabIndex = 27;
            // 
            // lb_comment
            // 
            this.lb_comment.AutoSize = true;
            this.lb_comment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_comment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_comment.Location = new System.Drawing.Point(34, 345);
            this.lb_comment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_comment.Name = "lb_comment";
            this.lb_comment.Size = new System.Drawing.Size(74, 18);
            this.lb_comment.TabIndex = 26;
            this.lb_comment.Text = "Comment";
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
            this.bt_cancel.Location = new System.Drawing.Point(680, 423);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(90, 34);
            this.bt_cancel.TabIndex = 25;
            this.bt_cancel.Text = "CANCEL";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            this.bt_cancel.MouseEnter += new System.EventHandler(this.bt_cancel_MouseEnter);
            this.bt_cancel.MouseLeave += new System.EventHandler(this.bt_cancel_MouseLeave);
            // 
            // dtp_From
            // 
            this.dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_From.Location = new System.Drawing.Point(492, 163);
            this.dtp_From.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(138, 20);
            this.dtp_From.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label2.Location = new System.Drawing.Point(527, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label3.Location = new System.Drawing.Point(694, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "To";
            // 
            // lb_document
            // 
            this.lb_document.AutoSize = true;
            this.lb_document.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_document.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_document.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_document.Location = new System.Drawing.Point(27, 156);
            this.lb_document.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_document.Name = "lb_document";
            this.lb_document.Size = new System.Drawing.Size(77, 18);
            this.lb_document.TabIndex = 3;
            this.lb_document.Text = "Document";
            // 
            // txt_management
            // 
            this.txt_management.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_management.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_management.Location = new System.Drawing.Point(553, 17);
            this.txt_management.Margin = new System.Windows.Forms.Padding(2);
            this.txt_management.Multiline = true;
            this.txt_management.Name = "txt_management";
            this.txt_management.Size = new System.Drawing.Size(290, 29);
            this.txt_management.TabIndex = 16;
            // 
            // dtp_To
            // 
            this.dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_To.Location = new System.Drawing.Point(667, 163);
            this.dtp_To.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(138, 20);
            this.dtp_To.TabIndex = 8;
            // 
            // bt_exit
            // 
            this.bt_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_exit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bt_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_exit.FlatAppearance.BorderSize = 0;
            this.bt_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_exit.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.bt_exit.IconColor = System.Drawing.Color.Black;
            this.bt_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_exit.IconSize = 30;
            this.bt_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_exit.Location = new System.Drawing.Point(846, 7);
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
            // txt_tittle
            // 
            this.txt_tittle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tittle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_tittle.Location = new System.Drawing.Point(163, 86);
            this.txt_tittle.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tittle.Multiline = true;
            this.txt_tittle.Name = "txt_tittle";
            this.txt_tittle.Size = new System.Drawing.Size(680, 29);
            this.txt_tittle.TabIndex = 12;
            // 
            // txt_IdMission
            // 
            this.txt_IdMission.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdMission.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_IdMission.Location = new System.Drawing.Point(163, 17);
            this.txt_IdMission.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IdMission.Multiline = true;
            this.txt_IdMission.Name = "txt_IdMission";
            this.txt_IdMission.Size = new System.Drawing.Size(218, 29);
            this.txt_IdMission.TabIndex = 14;
            // 
            // lb_Tittle
            // 
            this.lb_Tittle.AutoSize = true;
            this.lb_Tittle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_Tittle.Location = new System.Drawing.Point(27, 88);
            this.lb_Tittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Tittle.Name = "lb_Tittle";
            this.lb_Tittle.Size = new System.Drawing.Size(39, 18);
            this.lb_Tittle.TabIndex = 1;
            this.lb_Tittle.Text = "Tittle";
            // 
            // lb_IdMission
            // 
            this.lb_IdMission.AutoSize = true;
            this.lb_IdMission.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_IdMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IdMission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_IdMission.Location = new System.Drawing.Point(27, 19);
            this.lb_IdMission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_IdMission.Name = "lb_IdMission";
            this.lb_IdMission.Size = new System.Drawing.Size(78, 18);
            this.lb_IdMission.TabIndex = 13;
            this.lb_IdMission.Text = "ID mission";
            // 
            // cbb_status
            // 
            this.cbb_status.FormattingEnabled = true;
            this.cbb_status.Location = new System.Drawing.Point(163, 223);
            this.cbb_status.Name = "cbb_status";
            this.cbb_status.Size = new System.Drawing.Size(218, 21);
            this.cbb_status.TabIndex = 22;
            // 
            // txt_relateProject
            // 
            this.txt_relateProject.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_relateProject.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_relateProject.Location = new System.Drawing.Point(163, 280);
            this.txt_relateProject.Multiline = true;
            this.txt_relateProject.Name = "txt_relateProject";
            this.txt_relateProject.Size = new System.Drawing.Size(218, 29);
            this.txt_relateProject.TabIndex = 21;
            // 
            // lb_relateProject
            // 
            this.lb_relateProject.AutoSize = true;
            this.lb_relateProject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_relateProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_relateProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_relateProject.Location = new System.Drawing.Point(30, 282);
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
            this.lb_status.Location = new System.Drawing.Point(30, 223);
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
            this.txt_document.Location = new System.Drawing.Point(163, 154);
            this.txt_document.Multiline = true;
            this.txt_document.Name = "txt_document";
            this.txt_document.Size = new System.Drawing.Size(218, 29);
            this.txt_document.TabIndex = 16;
            // 
            // lb_Management
            // 
            this.lb_Management.AutoSize = true;
            this.lb_Management.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Management.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Management.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_Management.Location = new System.Drawing.Point(410, 19);
            this.lb_Management.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Management.Name = "lb_Management";
            this.lb_Management.Size = new System.Drawing.Size(130, 18);
            this.lb_Management.TabIndex = 15;
            this.lb_Management.Text = " Management staff";
            // 
            // txt_Description
            // 
            this.txt_Description.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Description.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Description.Location = new System.Drawing.Point(481, 223);
            this.txt_Description.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(362, 86);
            this.txt_Description.TabIndex = 10;
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_description.Location = new System.Drawing.Point(478, 203);
            this.lb_description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(83, 18);
            this.lb_description.TabIndex = 9;
            this.lb_description.Text = "Description";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 468);
            this.panel1.TabIndex = 28;
            // 
            // FormDetailMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 468);
            this.Controls.Add(this.pn_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDetailMission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetailMission";
            this.pn_container.ResumeLayout(false);
            this.pn_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_EditMission;
        private System.Windows.Forms.TextBox txt_management;
        private System.Windows.Forms.TextBox txt_IdMission;
        private System.Windows.Forms.Label lb_IdMission;
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