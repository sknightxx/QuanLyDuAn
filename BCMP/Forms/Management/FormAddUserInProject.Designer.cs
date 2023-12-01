namespace BCMP.Forms.Management
{
    partial class FormAddUserInProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUserInProject));
            this.bt_cancel = new System.Windows.Forms.Button();
            this.dtgv_listEmp = new System.Windows.Forms.DataGridView();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_addInProject = new System.Windows.Forms.Button();
            this.cb_Department = new System.Windows.Forms.ComboBox();
            this.bt_Default = new System.Windows.Forms.Button();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeEmployeeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.departmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_listEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_cancel
            // 
            resources.ApplyResources(this.bt_cancel, "bt_cancel");
            this.bt_cancel.BackColor = System.Drawing.Color.Black;
            this.bt_cancel.ForeColor = System.Drawing.Color.White;
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.UseVisualStyleBackColor = false;
            // 
            // dtgv_listEmp
            // 
            resources.ApplyResources(this.dtgv_listEmp, "dtgv_listEmp");
            this.dtgv_listEmp.AutoGenerateColumns = false;
            this.dtgv_listEmp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgv_listEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_listEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.roleIdDataGridViewTextBoxColumn,
            this.Role,
            this.typeEmployeeDataGridViewCheckBoxColumn,
            this.Type,
            this.departmentIdDataGridViewTextBoxColumn,
            this.Department});
            this.dtgv_listEmp.DataSource = this.employeeBindingSource;
            this.dtgv_listEmp.Name = "dtgv_listEmp";
            this.dtgv_listEmp.RowTemplate.Height = 24;
            this.dtgv_listEmp.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgv_listEmp_DataBindingComplete);
            // 
            // Role
            // 
            resources.ApplyResources(this.Role, "Role");
            this.Role.Name = "Role";
            // 
            // Type
            // 
            resources.ApplyResources(this.Type, "Type");
            this.Type.Name = "Type";
            // 
            // Department
            // 
            resources.ApplyResources(this.Department, "Department");
            this.Department.Name = "Department";
            // 
            // bt_addInProject
            // 
            resources.ApplyResources(this.bt_addInProject, "bt_addInProject");
            this.bt_addInProject.BackColor = System.Drawing.Color.Black;
            this.bt_addInProject.ForeColor = System.Drawing.Color.White;
            this.bt_addInProject.Name = "bt_addInProject";
            this.bt_addInProject.UseVisualStyleBackColor = false;
            this.bt_addInProject.Click += new System.EventHandler(this.bt_addInProject_Click);
            // 
            // cb_Department
            // 
            resources.ApplyResources(this.cb_Department, "cb_Department");
            this.cb_Department.FormattingEnabled = true;
            this.cb_Department.Name = "cb_Department";
            this.cb_Department.SelectedIndexChanged += new System.EventHandler(this.cb_Department_SelectedIndexChanged);
            // 
            // bt_Default
            // 
            resources.ApplyResources(this.bt_Default, "bt_Default");
            this.bt_Default.Name = "bt_Default";
            this.bt_Default.UseVisualStyleBackColor = true;
            this.bt_Default.Click += new System.EventHandler(this.bt_Default_Click);
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            resources.ApplyResources(this.userIdDataGridViewTextBoxColumn, "userIdDataGridViewTextBoxColumn");
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            resources.ApplyResources(this.fullNameDataGridViewTextBoxColumn, "fullNameDataGridViewTextBoxColumn");
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            resources.ApplyResources(this.emailDataGridViewTextBoxColumn, "emailDataGridViewTextBoxColumn");
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // roleIdDataGridViewTextBoxColumn
            // 
            this.roleIdDataGridViewTextBoxColumn.DataPropertyName = "RoleId";
            resources.ApplyResources(this.roleIdDataGridViewTextBoxColumn, "roleIdDataGridViewTextBoxColumn");
            this.roleIdDataGridViewTextBoxColumn.Name = "roleIdDataGridViewTextBoxColumn";
            // 
            // typeEmployeeDataGridViewCheckBoxColumn
            // 
            this.typeEmployeeDataGridViewCheckBoxColumn.DataPropertyName = "TypeEmployee";
            resources.ApplyResources(this.typeEmployeeDataGridViewCheckBoxColumn, "typeEmployeeDataGridViewCheckBoxColumn");
            this.typeEmployeeDataGridViewCheckBoxColumn.Name = "typeEmployeeDataGridViewCheckBoxColumn";
            // 
            // departmentIdDataGridViewTextBoxColumn
            // 
            this.departmentIdDataGridViewTextBoxColumn.DataPropertyName = "DepartmentId";
            resources.ApplyResources(this.departmentIdDataGridViewTextBoxColumn, "departmentIdDataGridViewTextBoxColumn");
            this.departmentIdDataGridViewTextBoxColumn.Name = "departmentIdDataGridViewTextBoxColumn";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(BCMP.DTO.Employee);
            // 
            // FormAddUserInProject
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_Default);
            this.Controls.Add(this.cb_Department);
            this.Controls.Add(this.bt_addInProject);
            this.Controls.Add(this.dtgv_listEmp);
            this.Controls.Add(this.bt_cancel);
            this.Name = "FormAddUserInProject";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_listEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.DataGridView dtgv_listEmp;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.Button bt_addInProject;
        private System.Windows.Forms.ComboBox cb_Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typeEmployeeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.Button bt_Default;
    }
}