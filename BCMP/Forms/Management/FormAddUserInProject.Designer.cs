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
            this.bt_cancel = new System.Windows.Forms.Button();
            this.dtgv_listEmp = new System.Windows.Forms.DataGridView();
            this.bt_addInProject = new System.Windows.Forms.Button();
            this.cb_Department = new System.Windows.Forms.ComboBox();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeEmployeeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.departmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bt_Default = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_listEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.Black;
            this.bt_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_cancel.ForeColor = System.Drawing.Color.White;
            this.bt_cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_cancel.Location = new System.Drawing.Point(711, 494);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(112, 42);
            this.bt_cancel.TabIndex = 20;
            this.bt_cancel.Text = "CANCEL";
            this.bt_cancel.UseVisualStyleBackColor = false;
            // 
            // dtgv_listEmp
            // 
            this.dtgv_listEmp.AutoGenerateColumns = false;
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
            this.dtgv_listEmp.Location = new System.Drawing.Point(223, 12);
            this.dtgv_listEmp.Name = "dtgv_listEmp";
            this.dtgv_listEmp.RowHeadersWidth = 51;
            this.dtgv_listEmp.RowTemplate.Height = 24;
            this.dtgv_listEmp.Size = new System.Drawing.Size(688, 477);
            this.dtgv_listEmp.TabIndex = 21;
            this.dtgv_listEmp.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgv_listEmp_DataBindingComplete);
            // 
            // bt_addInProject
            // 
            this.bt_addInProject.BackColor = System.Drawing.Color.Black;
            this.bt_addInProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_addInProject.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_addInProject.ForeColor = System.Drawing.Color.White;
            this.bt_addInProject.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_addInProject.Location = new System.Drawing.Point(878, 494);
            this.bt_addInProject.Margin = new System.Windows.Forms.Padding(2);
            this.bt_addInProject.Name = "bt_addInProject";
            this.bt_addInProject.Size = new System.Drawing.Size(112, 42);
            this.bt_addInProject.TabIndex = 22;
            this.bt_addInProject.Text = "Add";
            this.bt_addInProject.UseVisualStyleBackColor = false;
            this.bt_addInProject.Click += new System.EventHandler(this.bt_addInProject_Click);
            // 
            // cb_Department
            // 
            this.cb_Department.FormattingEnabled = true;
            this.cb_Department.Location = new System.Drawing.Point(13, 13);
            this.cb_Department.Name = "cb_Department";
            this.cb_Department.Size = new System.Drawing.Size(184, 24);
            this.cb_Department.TabIndex = 23;
            this.cb_Department.SelectedIndexChanged += new System.EventHandler(this.cb_Department_SelectedIndexChanged);
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.Width = 125;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.Width = 125;
            // 
            // Department
            // 
            this.Department.HeaderText = "Department";
            this.Department.MinimumWidth = 6;
            this.Department.Name = "Department";
            this.Department.Width = 125;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Visible = false;
            this.userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // roleIdDataGridViewTextBoxColumn
            // 
            this.roleIdDataGridViewTextBoxColumn.DataPropertyName = "RoleId";
            this.roleIdDataGridViewTextBoxColumn.HeaderText = "RoleId";
            this.roleIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleIdDataGridViewTextBoxColumn.Name = "roleIdDataGridViewTextBoxColumn";
            this.roleIdDataGridViewTextBoxColumn.Visible = false;
            this.roleIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeEmployeeDataGridViewCheckBoxColumn
            // 
            this.typeEmployeeDataGridViewCheckBoxColumn.DataPropertyName = "TypeEmployee";
            this.typeEmployeeDataGridViewCheckBoxColumn.HeaderText = "TypeEmployee";
            this.typeEmployeeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.typeEmployeeDataGridViewCheckBoxColumn.Name = "typeEmployeeDataGridViewCheckBoxColumn";
            this.typeEmployeeDataGridViewCheckBoxColumn.Visible = false;
            this.typeEmployeeDataGridViewCheckBoxColumn.Width = 125;
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
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(BCMP.DTO.Employee);
            // 
            // bt_Default
            // 
            this.bt_Default.Location = new System.Drawing.Point(13, 54);
            this.bt_Default.Name = "bt_Default";
            this.bt_Default.Size = new System.Drawing.Size(184, 23);
            this.bt_Default.TabIndex = 24;
            this.bt_Default.Text = "Show All";
            this.bt_Default.UseVisualStyleBackColor = true;
            this.bt_Default.Click += new System.EventHandler(this.bt_Default_Click);
            // 
            // FormAddUserInProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 547);
            this.Controls.Add(this.bt_Default);
            this.Controls.Add(this.cb_Department);
            this.Controls.Add(this.bt_addInProject);
            this.Controls.Add(this.dtgv_listEmp);
            this.Controls.Add(this.bt_cancel);
            this.Name = "FormAddUserInProject";
            this.Text = "FormAddUserInProject";
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