namespace BCMP.Forms
{
    partial class FormMission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMission));
            this.pn_tittle = new System.Windows.Forms.Panel();
            this.pn_search = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.bt_CreateProject = new System.Windows.Forms.Button();
            this.lb_MyWork = new System.Windows.Forms.Label();
            this.pn_container = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgvMyMission = new System.Windows.Forms.DataGridView();
            this.bt_search = new FontAwesome.Sharp.IconButton();
            this.bt_others = new FontAwesome.Sharp.IconButton();
            this.missionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.missionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MissionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.projectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pn_tittle.SuspendLayout();
            this.pn_search.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pn_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMyMission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_tittle
            // 
            resources.ApplyResources(this.pn_tittle, "pn_tittle");
            this.pn_tittle.BackColor = System.Drawing.Color.White;
            this.pn_tittle.Controls.Add(this.pn_search);
            this.pn_tittle.Controls.Add(this.bt_others);
            this.pn_tittle.Controls.Add(this.bt_CreateProject);
            this.pn_tittle.Controls.Add(this.lb_MyWork);
            this.pn_tittle.Name = "pn_tittle";
            // 
            // pn_search
            // 
            resources.ApplyResources(this.pn_search, "pn_search");
            this.pn_search.Controls.Add(this.panel2);
            this.pn_search.Controls.Add(this.bt_search);
            this.pn_search.Name = "pn_search";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_search);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // txt_search
            // 
            resources.ApplyResources(this.txt_search, "txt_search");
            this.txt_search.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_search.Name = "txt_search";
            this.txt_search.Enter += new System.EventHandler(this.txt_search_Enter);
            this.txt_search.Leave += new System.EventHandler(this.txt_search_Leave);
            // 
            // bt_CreateProject
            // 
            resources.ApplyResources(this.bt_CreateProject, "bt_CreateProject");
            this.bt_CreateProject.BackColor = System.Drawing.Color.Black;
            this.bt_CreateProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_CreateProject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.bt_CreateProject.FlatAppearance.BorderSize = 0;
            this.bt_CreateProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_CreateProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_CreateProject.ForeColor = System.Drawing.Color.White;
            this.bt_CreateProject.Name = "bt_CreateProject";
            this.bt_CreateProject.UseVisualStyleBackColor = false;
            this.bt_CreateProject.Click += new System.EventHandler(this.bt_CreateProject_Click);
            // 
            // lb_MyWork
            // 
            resources.ApplyResources(this.lb_MyWork, "lb_MyWork");
            this.lb_MyWork.ForeColor = System.Drawing.Color.Black;
            this.lb_MyWork.Name = "lb_MyWork";
            // 
            // pn_container
            // 
            this.pn_container.BackColor = System.Drawing.Color.White;
            this.pn_container.Controls.Add(this.dtgvMyMission);
            this.pn_container.Controls.Add(this.button1);
            resources.ApplyResources(this.pn_container, "pn_container");
            this.pn_container.Name = "pn_container";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgvMyMission
            // 
            this.dtgvMyMission.AutoGenerateColumns = false;
            this.dtgvMyMission.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvMyMission.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvMyMission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMyMission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.MissionId,
            this.progressDataGridViewTextBoxColumn,
            this.plannedStartDateDataGridViewTextBoxColumn,
            this.plannedEndDateDataGridViewTextBoxColumn,
            this.Status,
            this.projectIdDataGridViewTextBoxColumn,
            this.Detail});
            this.dtgvMyMission.DataSource = this.missionBindingSource1;
            resources.ApplyResources(this.dtgvMyMission, "dtgvMyMission");
            this.dtgvMyMission.Name = "dtgvMyMission";
            this.dtgvMyMission.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvMyMission.RowTemplate.Height = 24;
            this.dtgvMyMission.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMyMission_CellContentClick);
            this.dtgvMyMission.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMyMission_CellEndEdit);
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.White;
            this.bt_search.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.bt_search, "bt_search");
            this.bt_search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.bt_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.bt_search.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(160)))), ((int)(((byte)(166)))));
            this.bt_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_search.IconSize = 30;
            this.bt_search.Name = "bt_search";
            this.bt_search.UseVisualStyleBackColor = false;
            // 
            // bt_others
            // 
            resources.ApplyResources(this.bt_others, "bt_others");
            this.bt_others.BackColor = System.Drawing.Color.Black;
            this.bt_others.FlatAppearance.BorderSize = 0;
            this.bt_others.ForeColor = System.Drawing.Color.White;
            this.bt_others.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.bt_others.IconColor = System.Drawing.Color.White;
            this.bt_others.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_others.IconSize = 32;
            this.bt_others.Name = "bt_others";
            this.bt_others.UseVisualStyleBackColor = false;
            // 
            // missionBindingSource1
            // 
            this.missionBindingSource1.DataSource = typeof(BCMP.DTO.Mission);
            // 
            // missionBindingSource
            // 
            this.missionBindingSource.DataSource = typeof(BCMP.DTO.Mission);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            resources.ApplyResources(this.titleDataGridViewTextBoxColumn, "titleDataGridViewTextBoxColumn");
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // MissionId
            // 
            this.MissionId.DataPropertyName = "MissionId";
            resources.ApplyResources(this.MissionId, "MissionId");
            this.MissionId.Name = "MissionId";
            // 
            // progressDataGridViewTextBoxColumn
            // 
            this.progressDataGridViewTextBoxColumn.DataPropertyName = "Progress";
            resources.ApplyResources(this.progressDataGridViewTextBoxColumn, "progressDataGridViewTextBoxColumn");
            this.progressDataGridViewTextBoxColumn.Name = "progressDataGridViewTextBoxColumn";
            // 
            // plannedStartDateDataGridViewTextBoxColumn
            // 
            this.plannedStartDateDataGridViewTextBoxColumn.DataPropertyName = "PlannedStartDate";
            resources.ApplyResources(this.plannedStartDateDataGridViewTextBoxColumn, "plannedStartDateDataGridViewTextBoxColumn");
            this.plannedStartDateDataGridViewTextBoxColumn.Name = "plannedStartDateDataGridViewTextBoxColumn";
            // 
            // plannedEndDateDataGridViewTextBoxColumn
            // 
            this.plannedEndDateDataGridViewTextBoxColumn.DataPropertyName = "PlannedEndDate";
            resources.ApplyResources(this.plannedEndDateDataGridViewTextBoxColumn, "plannedEndDateDataGridViewTextBoxColumn");
            this.plannedEndDateDataGridViewTextBoxColumn.Name = "plannedEndDateDataGridViewTextBoxColumn";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            resources.ApplyResources(this.Status, "Status");
            this.Status.Items.AddRange(new object[] {
            "TO DO",
            "IN PROGRESS",
            "DONE"});
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // projectIdDataGridViewTextBoxColumn
            // 
            this.projectIdDataGridViewTextBoxColumn.DataPropertyName = "ProjectId";
            resources.ApplyResources(this.projectIdDataGridViewTextBoxColumn, "projectIdDataGridViewTextBoxColumn");
            this.projectIdDataGridViewTextBoxColumn.Name = "projectIdDataGridViewTextBoxColumn";
            // 
            // Detail
            // 
            this.Detail.DataPropertyName = "Detail";
            resources.ApplyResources(this.Detail, "Detail");
            this.Detail.Name = "Detail";
            this.Detail.Text = "Detail";
            // 
            // FormMission
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.pn_tittle);
            this.Controls.Add(this.pn_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMission";
            this.pn_tittle.ResumeLayout(false);
            this.pn_tittle.PerformLayout();
            this.pn_search.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pn_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMyMission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_tittle;
        private System.Windows.Forms.Panel pn_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_search;
        private FontAwesome.Sharp.IconButton bt_search;
        private FontAwesome.Sharp.IconButton bt_others;
        private System.Windows.Forms.Button bt_CreateProject;
        private System.Windows.Forms.Label lb_MyWork;
        private System.Windows.Forms.Panel pn_container;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource missionBindingSource;
        private System.Windows.Forms.DataGridView dtgvMyMission;
        private System.Windows.Forms.BindingSource missionBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MissionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn progressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannedStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannedEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
    }
}