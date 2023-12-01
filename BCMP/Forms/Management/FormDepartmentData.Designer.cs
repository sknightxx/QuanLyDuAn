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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepartmentData));
            this.dgv_DepartmentData = new System.Windows.Forms.DataGridView();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Download = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.partnerCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.Download});
            this.dgv_DepartmentData.DataSource = this.documentBindingSource;
            resources.ApplyResources(this.dgv_DepartmentData, "dgv_DepartmentData");
            this.dgv_DepartmentData.Name = "dgv_DepartmentData";
            this.dgv_DepartmentData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DepartmentData_CellContentClick);
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            resources.ApplyResources(this.Department, "Department");
            this.Department.Name = "Department";
            // 
            // Download
            // 
            this.Download.DataPropertyName = "Download";
            resources.ApplyResources(this.Download, "Download");
            this.Download.Name = "Download";
            this.Download.Text = "Download";
            this.Download.UseColumnTextForButtonValue = true;
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
            // projectIdDataGridViewTextBoxColumn
            // 
            this.projectIdDataGridViewTextBoxColumn.DataPropertyName = "ProjectId";
            resources.ApplyResources(this.projectIdDataGridViewTextBoxColumn, "projectIdDataGridViewTextBoxColumn");
            this.projectIdDataGridViewTextBoxColumn.Name = "projectIdDataGridViewTextBoxColumn";
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            resources.ApplyResources(this.userIdDataGridViewTextBoxColumn, "userIdDataGridViewTextBoxColumn");
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            resources.ApplyResources(this.typeDataGridViewTextBoxColumn, "typeDataGridViewTextBoxColumn");
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // departmentIdDataGridViewTextBoxColumn
            // 
            this.departmentIdDataGridViewTextBoxColumn.DataPropertyName = "DepartmentId";
            resources.ApplyResources(this.departmentIdDataGridViewTextBoxColumn, "departmentIdDataGridViewTextBoxColumn");
            this.departmentIdDataGridViewTextBoxColumn.Name = "departmentIdDataGridViewTextBoxColumn";
            // 
            // partnerCodeDataGridViewTextBoxColumn
            // 
            this.partnerCodeDataGridViewTextBoxColumn.DataPropertyName = "PartnerCode";
            resources.ApplyResources(this.partnerCodeDataGridViewTextBoxColumn, "partnerCodeDataGridViewTextBoxColumn");
            this.partnerCodeDataGridViewTextBoxColumn.Name = "partnerCodeDataGridViewTextBoxColumn";
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataSource = typeof(BCMP.DTO.Document);
            // 
            // FormDepartmentData
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_DepartmentData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDepartmentData";
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
    }
}