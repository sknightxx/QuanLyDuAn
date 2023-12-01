namespace BCMP.Forms.Management
{
    partial class FormDetailProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetailProject));
            this.lb_member = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Open = new System.Windows.Forms.Button();
            this.bt_exit = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_description = new System.Windows.Forms.Label();
            this.dtpkPlannedEnd = new System.Windows.Forms.DateTimePicker();
            this.txt_IdProject = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgvMissionList = new System.Windows.Forms.DataGridView();
            this.MissionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bt_default = new System.Windows.Forms.Button();
            this.cb_Department = new System.Windows.Forms.ComboBox();
            this.dtgv_listEmp = new System.Windows.Forms.DataGridView();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dtgv_ListDocument = new System.Windows.Forms.DataGridView();
            this.Download = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lb_department = new System.Windows.Forms.Label();
            this.dtpkPlannedStart = new System.Windows.Forms.DateTimePicker();
            this.bt_CreateEmployee = new System.Windows.Forms.Button();
            this.cbb_department = new System.Windows.Forms.ComboBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.bt_CreateMission = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.txt_nameProject = new System.Windows.Forms.TextBox();
            this.lb_IdProject = new System.Windows.Forms.Label();
            this.lb_NameProject = new System.Windows.Forms.Label();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.missionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeEmployeeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.departmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeFileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.missionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMissionList)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_listEmp)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_member
            // 
            resources.ApplyResources(this.lb_member, "lb_member");
            this.lb_member.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_member.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_member.Name = "lb_member";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.btn_Open);
            this.panel2.Controls.Add(this.bt_exit);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lb_description);
            this.panel2.Controls.Add(this.dtpkPlannedEnd);
            this.panel2.Controls.Add(this.txt_IdProject);
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.lb_department);
            this.panel2.Controls.Add(this.dtpkPlannedStart);
            this.panel2.Controls.Add(this.bt_CreateEmployee);
            this.panel2.Controls.Add(this.cbb_department);
            this.panel2.Controls.Add(this.txt_Description);
            this.panel2.Controls.Add(this.bt_CreateMission);
            this.panel2.Controls.Add(this.bt_save);
            this.panel2.Controls.Add(this.bt_cancel);
            this.panel2.Controls.Add(this.txt_nameProject);
            this.panel2.Controls.Add(this.lb_IdProject);
            this.panel2.Controls.Add(this.lb_NameProject);
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_Open
            // 
            resources.ApplyResources(this.btn_Open, "btn_Open");
            this.btn_Open.BackColor = System.Drawing.Color.Black;
            this.btn_Open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Open.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.btn_Open.FlatAppearance.BorderSize = 0;
            this.btn_Open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Open.ForeColor = System.Drawing.Color.White;
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.UseVisualStyleBackColor = false;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
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
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label2.Name = "label2";
            // 
            // lb_description
            // 
            resources.ApplyResources(this.lb_description, "lb_description");
            this.lb_description.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_description.Name = "lb_description";
            // 
            // dtpkPlannedEnd
            // 
            resources.ApplyResources(this.dtpkPlannedEnd, "dtpkPlannedEnd");
            this.dtpkPlannedEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkPlannedEnd.Name = "dtpkPlannedEnd";
            // 
            // txt_IdProject
            // 
            resources.ApplyResources(this.txt_IdProject, "txt_IdProject");
            this.txt_IdProject.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_IdProject.Name = "txt_IdProject";
            this.txt_IdProject.ReadOnly = true;
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.dtgvMissionList);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgvMissionList
            // 
            resources.ApplyResources(this.dtgvMissionList, "dtgvMissionList");
            this.dtgvMissionList.AllowDrop = true;
            this.dtgvMissionList.AutoGenerateColumns = false;
            this.dtgvMissionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMissionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.MissionId,
            this.progressDataGridViewTextBoxColumn,
            this.plannedStartDateDataGridViewTextBoxColumn,
            this.plannedEndDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.Detail});
            this.dtgvMissionList.DataSource = this.missionBindingSource;
            this.dtgvMissionList.Name = "dtgvMissionList";
            this.dtgvMissionList.RowTemplate.Height = 24;
            this.dtgvMissionList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMissionList_CellContentClick);
            // 
            // MissionId
            // 
            this.MissionId.DataPropertyName = "MissionId";
            resources.ApplyResources(this.MissionId, "MissionId");
            this.MissionId.Name = "MissionId";
            // 
            // Detail
            // 
            this.Detail.DataPropertyName = "Detail";
            resources.ApplyResources(this.Detail, "Detail");
            this.Detail.Name = "Detail";
            this.Detail.Text = "Detail";
            this.Detail.UseColumnTextForButtonValue = true;
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.bt_default);
            this.tabPage2.Controls.Add(this.cb_Department);
            this.tabPage2.Controls.Add(this.dtgv_listEmp);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bt_default
            // 
            resources.ApplyResources(this.bt_default, "bt_default");
            this.bt_default.Name = "bt_default";
            this.bt_default.UseVisualStyleBackColor = true;
            this.bt_default.Click += new System.EventHandler(this.bt_default_Click);
            // 
            // cb_Department
            // 
            resources.ApplyResources(this.cb_Department, "cb_Department");
            this.cb_Department.FormattingEnabled = true;
            this.cb_Department.Name = "cb_Department";
            this.cb_Department.SelectedIndexChanged += new System.EventHandler(this.cb_Department_SelectedIndexChanged);
            // 
            // dtgv_listEmp
            // 
            resources.ApplyResources(this.dtgv_listEmp, "dtgv_listEmp");
            this.dtgv_listEmp.AutoGenerateColumns = false;
            this.dtgv_listEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_listEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn1,
            this.fullNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
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
            this.Role.ReadOnly = true;
            // 
            // Type
            // 
            resources.ApplyResources(this.Type, "Type");
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Department
            // 
            resources.ApplyResources(this.Department, "Department");
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // tabPage3
            // 
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Controls.Add(this.dtgv_ListDocument);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dtgv_ListDocument
            // 
            resources.ApplyResources(this.dtgv_ListDocument, "dtgv_ListDocument");
            this.dtgv_ListDocument.AutoGenerateColumns = false;
            this.dtgv_ListDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ListDocument.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.pathDataGridViewTextBoxColumn,
            this.releaseDateDataGridViewTextBoxColumn,
            this.typeFileDataGridViewTextBoxColumn,
            this.serialNumberDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn1,
            this.missionIdDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn2,
            this.projectIdDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.departmentIdDataGridViewTextBoxColumn1,
            this.partnerCodeDataGridViewTextBoxColumn,
            this.Download});
            this.dtgv_ListDocument.DataSource = this.documentBindingSource;
            this.dtgv_ListDocument.Name = "dtgv_ListDocument";
            this.dtgv_ListDocument.RowTemplate.Height = 24;
            this.dtgv_ListDocument.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ListDocument_CellContentClick);
            // 
            // Download
            // 
            this.Download.DataPropertyName = "Download";
            resources.ApplyResources(this.Download, "Download");
            this.Download.Name = "Download";
            this.Download.Text = "Download";
            this.Download.UseColumnTextForButtonValue = true;
            // 
            // lb_department
            // 
            resources.ApplyResources(this.lb_department, "lb_department");
            this.lb_department.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_department.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_department.Name = "lb_department";
            // 
            // dtpkPlannedStart
            // 
            resources.ApplyResources(this.dtpkPlannedStart, "dtpkPlannedStart");
            this.dtpkPlannedStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkPlannedStart.Name = "dtpkPlannedStart";
            // 
            // bt_CreateEmployee
            // 
            resources.ApplyResources(this.bt_CreateEmployee, "bt_CreateEmployee");
            this.bt_CreateEmployee.BackColor = System.Drawing.Color.Black;
            this.bt_CreateEmployee.ForeColor = System.Drawing.Color.White;
            this.bt_CreateEmployee.Name = "bt_CreateEmployee";
            this.bt_CreateEmployee.UseVisualStyleBackColor = false;
            this.bt_CreateEmployee.Click += new System.EventHandler(this.bt_CreateEmployee_Click);
            // 
            // cbb_department
            // 
            resources.ApplyResources(this.cbb_department, "cbb_department");
            this.cbb_department.FormattingEnabled = true;
            this.cbb_department.Name = "cbb_department";
            // 
            // txt_Description
            // 
            resources.ApplyResources(this.txt_Description, "txt_Description");
            this.txt_Description.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.ReadOnly = true;
            // 
            // bt_CreateMission
            // 
            resources.ApplyResources(this.bt_CreateMission, "bt_CreateMission");
            this.bt_CreateMission.BackColor = System.Drawing.Color.Black;
            this.bt_CreateMission.ForeColor = System.Drawing.Color.White;
            this.bt_CreateMission.Name = "bt_CreateMission";
            this.bt_CreateMission.UseVisualStyleBackColor = false;
            this.bt_CreateMission.Click += new System.EventHandler(this.bt_CreateMission_Click);
            // 
            // bt_save
            // 
            resources.ApplyResources(this.bt_save, "bt_save");
            this.bt_save.BackColor = System.Drawing.Color.Black;
            this.bt_save.ForeColor = System.Drawing.Color.White;
            this.bt_save.Name = "bt_save";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
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
            // txt_nameProject
            // 
            resources.ApplyResources(this.txt_nameProject, "txt_nameProject");
            this.txt_nameProject.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_nameProject.Name = "txt_nameProject";
            this.txt_nameProject.ReadOnly = true;
            // 
            // lb_IdProject
            // 
            resources.ApplyResources(this.lb_IdProject, "lb_IdProject");
            this.lb_IdProject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_IdProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_IdProject.Name = "lb_IdProject";
            // 
            // lb_NameProject
            // 
            resources.ApplyResources(this.lb_NameProject, "lb_NameProject");
            this.lb_NameProject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_NameProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_NameProject.Name = "lb_NameProject";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            resources.ApplyResources(this.titleDataGridViewTextBoxColumn, "titleDataGridViewTextBoxColumn");
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // progressDataGridViewTextBoxColumn
            // 
            this.progressDataGridViewTextBoxColumn.DataPropertyName = "Progress";
            resources.ApplyResources(this.progressDataGridViewTextBoxColumn, "progressDataGridViewTextBoxColumn");
            this.progressDataGridViewTextBoxColumn.Name = "progressDataGridViewTextBoxColumn";
            this.progressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plannedStartDateDataGridViewTextBoxColumn
            // 
            this.plannedStartDateDataGridViewTextBoxColumn.DataPropertyName = "PlannedStartDate";
            resources.ApplyResources(this.plannedStartDateDataGridViewTextBoxColumn, "plannedStartDateDataGridViewTextBoxColumn");
            this.plannedStartDateDataGridViewTextBoxColumn.Name = "plannedStartDateDataGridViewTextBoxColumn";
            this.plannedStartDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plannedEndDateDataGridViewTextBoxColumn
            // 
            this.plannedEndDateDataGridViewTextBoxColumn.DataPropertyName = "PlannedEndDate";
            resources.ApplyResources(this.plannedEndDateDataGridViewTextBoxColumn, "plannedEndDateDataGridViewTextBoxColumn");
            this.plannedEndDateDataGridViewTextBoxColumn.Name = "plannedEndDateDataGridViewTextBoxColumn";
            this.plannedEndDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            resources.ApplyResources(this.statusDataGridViewTextBoxColumn, "statusDataGridViewTextBoxColumn");
            this.statusDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "TO DO",
            "IN PROGRESS",
            "DONE"});
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            resources.ApplyResources(this.userIdDataGridViewTextBoxColumn, "userIdDataGridViewTextBoxColumn");
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // missionBindingSource
            // 
            this.missionBindingSource.DataSource = typeof(BCMP.DTO.Mission);
            // 
            // userIdDataGridViewTextBoxColumn1
            // 
            this.userIdDataGridViewTextBoxColumn1.DataPropertyName = "UserId";
            resources.ApplyResources(this.userIdDataGridViewTextBoxColumn1, "userIdDataGridViewTextBoxColumn1");
            this.userIdDataGridViewTextBoxColumn1.Name = "userIdDataGridViewTextBoxColumn1";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            resources.ApplyResources(this.fullNameDataGridViewTextBoxColumn, "fullNameDataGridViewTextBoxColumn");
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            resources.ApplyResources(this.emailDataGridViewTextBoxColumn, "emailDataGridViewTextBoxColumn");
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            resources.ApplyResources(this.phoneNumberDataGridViewTextBoxColumn, "phoneNumberDataGridViewTextBoxColumn");
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.typeFileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serialNumberDataGridViewTextBoxColumn
            // 
            this.serialNumberDataGridViewTextBoxColumn.DataPropertyName = "SerialNumber";
            resources.ApplyResources(this.serialNumberDataGridViewTextBoxColumn, "serialNumberDataGridViewTextBoxColumn");
            this.serialNumberDataGridViewTextBoxColumn.Name = "serialNumberDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            resources.ApplyResources(this.statusDataGridViewTextBoxColumn1, "statusDataGridViewTextBoxColumn1");
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            // 
            // missionIdDataGridViewTextBoxColumn
            // 
            this.missionIdDataGridViewTextBoxColumn.DataPropertyName = "MissionId";
            resources.ApplyResources(this.missionIdDataGridViewTextBoxColumn, "missionIdDataGridViewTextBoxColumn");
            this.missionIdDataGridViewTextBoxColumn.Name = "missionIdDataGridViewTextBoxColumn";
            // 
            // userIdDataGridViewTextBoxColumn2
            // 
            this.userIdDataGridViewTextBoxColumn2.DataPropertyName = "UserId";
            resources.ApplyResources(this.userIdDataGridViewTextBoxColumn2, "userIdDataGridViewTextBoxColumn2");
            this.userIdDataGridViewTextBoxColumn2.Name = "userIdDataGridViewTextBoxColumn2";
            this.userIdDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // projectIdDataGridViewTextBoxColumn
            // 
            this.projectIdDataGridViewTextBoxColumn.DataPropertyName = "ProjectId";
            resources.ApplyResources(this.projectIdDataGridViewTextBoxColumn, "projectIdDataGridViewTextBoxColumn");
            this.projectIdDataGridViewTextBoxColumn.Name = "projectIdDataGridViewTextBoxColumn";
            this.projectIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            resources.ApplyResources(this.typeDataGridViewTextBoxColumn, "typeDataGridViewTextBoxColumn");
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // departmentIdDataGridViewTextBoxColumn1
            // 
            this.departmentIdDataGridViewTextBoxColumn1.DataPropertyName = "DepartmentId";
            resources.ApplyResources(this.departmentIdDataGridViewTextBoxColumn1, "departmentIdDataGridViewTextBoxColumn1");
            this.departmentIdDataGridViewTextBoxColumn1.Name = "departmentIdDataGridViewTextBoxColumn1";
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
            // FormDetailProject
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lb_member);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDetailProject";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMissionList)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_listEmp)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_member;
        private System.Windows.Forms.BindingSource missionBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton bt_exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.DateTimePicker dtpkPlannedEnd;
        private System.Windows.Forms.TextBox txt_IdProject;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgvMissionList;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bt_default;
        private System.Windows.Forms.ComboBox cb_Department;
        private System.Windows.Forms.DataGridView dtgv_listEmp;
        private System.Windows.Forms.Label lb_department;
        private System.Windows.Forms.DateTimePicker dtpkPlannedStart;
        private System.Windows.Forms.Button bt_CreateEmployee;
        private System.Windows.Forms.ComboBox cbb_department;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Button bt_CreateMission;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.TextBox txt_nameProject;
        private System.Windows.Forms.Label lb_IdProject;
        private System.Windows.Forms.Label lb_NameProject;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typeEmployeeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MissionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn progressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannedStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannedEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
        private System.Windows.Forms.DataGridView dtgv_ListDocument;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeFileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn missionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Download;
    }
}