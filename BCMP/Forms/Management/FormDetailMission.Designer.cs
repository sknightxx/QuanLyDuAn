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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetailMission));
            this.bt_EditMission = new System.Windows.Forms.Button();
            this.pn_container = new System.Windows.Forms.Panel();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgv_ListDocument = new System.Windows.Forms.DataGridView();
            this.btn_Open = new System.Windows.Forms.Button();
            this.lb_Management = new System.Windows.Forms.Label();
            this.txt_management = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lb_description = new System.Windows.Forms.Label();
            this.Download = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeFileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.missionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pn_container.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
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
            this.pn_container.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.pn_container.Controls.Add(this.lb_relateProject);
            this.pn_container.Controls.Add(this.lb_status);
            this.pn_container.Controls.Add(this.panel1);
            resources.ApplyResources(this.pn_container, "pn_container");
            this.pn_container.Name = "pn_container";
            this.pn_container.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_container_Paint);
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.White;
            this.bt_cancel.FlatAppearance.BorderSize = 0;
            this.bt_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.bt_cancel, "bt_cancel");
            this.bt_cancel.ForeColor = System.Drawing.Color.Black;
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            this.bt_cancel.MouseEnter += new System.EventHandler(this.bt_cancel_MouseEnter);
            this.bt_cancel.MouseLeave += new System.EventHandler(this.bt_cancel_MouseLeave);
            // 
            // dtp_From
            // 
            this.dtp_From.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtp_From, "dtp_From");
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
            this.dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtp_To, "dtp_To");
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
            this.cbb_status.FormattingEnabled = true;
            this.cbb_status.Items.AddRange(new object[] {
            resources.GetString("cbb_status.Items"),
            resources.GetString("cbb_status.Items1"),
            resources.GetString("cbb_status.Items2")});
            resources.ApplyResources(this.cbb_status, "cbb_status");
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
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgv_ListDocument);
            this.panel1.Controls.Add(this.btn_Open);
            this.panel1.Controls.Add(this.lb_Management);
            this.panel1.Controls.Add(this.txt_management);
            this.panel1.Controls.Add(this.txt_Description);
            this.panel1.Controls.Add(this.lb_description);
            this.panel1.Controls.Add(this.txt_relateProject);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // dtgv_ListDocument
            // 
            this.dtgv_ListDocument.AutoGenerateColumns = false;
            this.dtgv_ListDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ListDocument.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.pathDataGridViewTextBoxColumn,
            this.releaseDateDataGridViewTextBoxColumn,
            this.typeFileDataGridViewTextBoxColumn,
            this.serialNumberDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.missionIdDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.projectIdDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.partnerCodeDataGridViewTextBoxColumn,
            this.departmentIdDataGridViewTextBoxColumn,
            this.Download});
            this.dtgv_ListDocument.DataSource = this.documentBindingSource;
            resources.ApplyResources(this.dtgv_ListDocument, "dtgv_ListDocument");
            this.dtgv_ListDocument.Name = "dtgv_ListDocument";
            this.dtgv_ListDocument.RowTemplate.Height = 24;
            this.dtgv_ListDocument.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ListDocument_CellContentClick);
            // 
            // btn_Open
            // 
            this.btn_Open.BackColor = System.Drawing.Color.Black;
            this.btn_Open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Open.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.btn_Open.FlatAppearance.BorderSize = 0;
            this.btn_Open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Open.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btn_Open, "btn_Open");
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.UseVisualStyleBackColor = false;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
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
            // Download
            // 
            this.Download.DataPropertyName = "Download";
            resources.ApplyResources(this.Download, "Download");
            this.Download.Name = "Download";
            this.Download.Text = "Download";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            resources.ApplyResources(this.pathDataGridViewTextBoxColumn, "pathDataGridViewTextBoxColumn");
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            this.releaseDateDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDate";
            resources.ApplyResources(this.releaseDateDataGridViewTextBoxColumn, "releaseDateDataGridViewTextBoxColumn");
            this.releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            // 
            // typeFileDataGridViewTextBoxColumn
            // 
            this.typeFileDataGridViewTextBoxColumn.DataPropertyName = "TypeFile";
            resources.ApplyResources(this.typeFileDataGridViewTextBoxColumn, "typeFileDataGridViewTextBoxColumn");
            this.typeFileDataGridViewTextBoxColumn.Name = "typeFileDataGridViewTextBoxColumn";
            // 
            // serialNumberDataGridViewTextBoxColumn
            // 
            this.serialNumberDataGridViewTextBoxColumn.DataPropertyName = "SerialNumber";
            resources.ApplyResources(this.serialNumberDataGridViewTextBoxColumn, "serialNumberDataGridViewTextBoxColumn");
            this.serialNumberDataGridViewTextBoxColumn.Name = "serialNumberDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            resources.ApplyResources(this.statusDataGridViewTextBoxColumn, "statusDataGridViewTextBoxColumn");
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // missionIdDataGridViewTextBoxColumn
            // 
            this.missionIdDataGridViewTextBoxColumn.DataPropertyName = "MissionId";
            resources.ApplyResources(this.missionIdDataGridViewTextBoxColumn, "missionIdDataGridViewTextBoxColumn");
            this.missionIdDataGridViewTextBoxColumn.Name = "missionIdDataGridViewTextBoxColumn";
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            resources.ApplyResources(this.userIdDataGridViewTextBoxColumn, "userIdDataGridViewTextBoxColumn");
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // projectIdDataGridViewTextBoxColumn
            // 
            this.projectIdDataGridViewTextBoxColumn.DataPropertyName = "ProjectId";
            resources.ApplyResources(this.projectIdDataGridViewTextBoxColumn, "projectIdDataGridViewTextBoxColumn");
            this.projectIdDataGridViewTextBoxColumn.Name = "projectIdDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            resources.ApplyResources(this.typeDataGridViewTextBoxColumn, "typeDataGridViewTextBoxColumn");
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // partnerCodeDataGridViewTextBoxColumn
            // 
            this.partnerCodeDataGridViewTextBoxColumn.DataPropertyName = "PartnerCode";
            resources.ApplyResources(this.partnerCodeDataGridViewTextBoxColumn, "partnerCodeDataGridViewTextBoxColumn");
            this.partnerCodeDataGridViewTextBoxColumn.Name = "partnerCodeDataGridViewTextBoxColumn";
            // 
            // departmentIdDataGridViewTextBoxColumn
            // 
            this.departmentIdDataGridViewTextBoxColumn.DataPropertyName = "DepartmentId";
            resources.ApplyResources(this.departmentIdDataGridViewTextBoxColumn, "departmentIdDataGridViewTextBoxColumn");
            this.departmentIdDataGridViewTextBoxColumn.Name = "departmentIdDataGridViewTextBoxColumn";
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataSource = typeof(BCMP.DTO.Document);
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
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
        private System.Windows.Forms.Label lb_Management;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.Button bt_cancel;
        private FontAwesome.Sharp.IconButton bt_exit;
        private System.Windows.Forms.DateTimePicker dtp_From;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.DataGridView dtgv_ListDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeFileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn missionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Download;
        private System.Windows.Forms.BindingSource documentBindingSource;
    }
}