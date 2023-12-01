namespace BCMP.Forms.Management
{
    partial class FormDepartmentData
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
            this.dgv_DepartmentData = new System.Windows.Forms.DataGridView();
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeFileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.missionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Download = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DepartmentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DepartmentData
            // 
            this.dgv_DepartmentData.AutoGenerateColumns = false;
            this.dgv_DepartmentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DepartmentData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.pathDataGridViewTextBoxColumn,
            this.releaseDateDataGridViewTextBoxColumn,
            this.typeFileDataGridViewTextBoxColumn,
            this.serialNumberDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.missionIdDataGridViewTextBoxColumn,
            this.projectIdDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.departmentIdDataGridViewTextBoxColumn,
            this.Department,
            this.partnerCodeDataGridViewTextBoxColumn,
            this.Download,
            this.Delete});
            this.dgv_DepartmentData.DataSource = this.documentBindingSource;
            this.dgv_DepartmentData.Location = new System.Drawing.Point(13, 26);
            this.dgv_DepartmentData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_DepartmentData.Name = "dgv_DepartmentData";
            this.dgv_DepartmentData.RowHeadersWidth = 51;
            this.dgv_DepartmentData.Size = new System.Drawing.Size(946, 330);
            this.dgv_DepartmentData.TabIndex = 0;
            this.dgv_DepartmentData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DepartmentData_CellContentClick);
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataSource = typeof(BCMP.DTO.Document);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            this.pathDataGridViewTextBoxColumn.Visible = false;
            this.pathDataGridViewTextBoxColumn.Width = 125;
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            this.releaseDateDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.HeaderText = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            this.releaseDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeFileDataGridViewTextBoxColumn
            // 
            this.typeFileDataGridViewTextBoxColumn.DataPropertyName = "TypeFile";
            this.typeFileDataGridViewTextBoxColumn.HeaderText = "TypeFile";
            this.typeFileDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeFileDataGridViewTextBoxColumn.Name = "typeFileDataGridViewTextBoxColumn";
            this.typeFileDataGridViewTextBoxColumn.Width = 125;
            // 
            // serialNumberDataGridViewTextBoxColumn
            // 
            this.serialNumberDataGridViewTextBoxColumn.DataPropertyName = "SerialNumber";
            this.serialNumberDataGridViewTextBoxColumn.HeaderText = "SerialNumber";
            this.serialNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serialNumberDataGridViewTextBoxColumn.Name = "serialNumberDataGridViewTextBoxColumn";
            this.serialNumberDataGridViewTextBoxColumn.Visible = false;
            this.serialNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Visible = false;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // missionIdDataGridViewTextBoxColumn
            // 
            this.missionIdDataGridViewTextBoxColumn.DataPropertyName = "MissionId";
            this.missionIdDataGridViewTextBoxColumn.HeaderText = "MissionId";
            this.missionIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.missionIdDataGridViewTextBoxColumn.Name = "missionIdDataGridViewTextBoxColumn";
            this.missionIdDataGridViewTextBoxColumn.Visible = false;
            this.missionIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // projectIdDataGridViewTextBoxColumn
            // 
            this.projectIdDataGridViewTextBoxColumn.DataPropertyName = "ProjectId";
            this.projectIdDataGridViewTextBoxColumn.HeaderText = "ProjectId";
            this.projectIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectIdDataGridViewTextBoxColumn.Name = "projectIdDataGridViewTextBoxColumn";
            this.projectIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Visible = false;
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentIdDataGridViewTextBoxColumn
            // 
            this.departmentIdDataGridViewTextBoxColumn.DataPropertyName = "DepartmentId";
            this.departmentIdDataGridViewTextBoxColumn.HeaderText = "DepartmentId";
            this.departmentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentIdDataGridViewTextBoxColumn.Name = "departmentIdDataGridViewTextBoxColumn";
            this.departmentIdDataGridViewTextBoxColumn.Visible = false;
            this.departmentIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "Department";
            this.Department.MinimumWidth = 6;
            this.Department.Name = "Department";
            this.Department.ToolTipText = "Department";
            this.Department.Visible = false;
            this.Department.Width = 125;
            // 
            // partnerCodeDataGridViewTextBoxColumn
            // 
            this.partnerCodeDataGridViewTextBoxColumn.DataPropertyName = "PartnerCode";
            this.partnerCodeDataGridViewTextBoxColumn.HeaderText = "PartnerCode";
            this.partnerCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partnerCodeDataGridViewTextBoxColumn.Name = "partnerCodeDataGridViewTextBoxColumn";
            this.partnerCodeDataGridViewTextBoxColumn.Visible = false;
            this.partnerCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // Download
            // 
            this.Download.DataPropertyName = "Download";
            this.Download.HeaderText = "Download";
            this.Download.MinimumWidth = 6;
            this.Download.Name = "Download";
            this.Download.Text = "Download";
            this.Download.ToolTipText = "Download";
            this.Download.Width = 125;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.Width = 125;
            // 
            // FormDepartmentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 437);
            this.Controls.Add(this.dgv_DepartmentData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDepartmentData";
            this.Text = "FormDepartmentData";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DepartmentData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DepartmentData;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeFileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn missionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Download;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}