namespace BCMP.Forms
{
    partial class FormProject
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
            this.pn_tittle = new System.Windows.Forms.Panel();
            this.pn_search = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.bt_search = new FontAwesome.Sharp.IconButton();
            this.bt_others = new FontAwesome.Sharp.IconButton();
            this.bt_CreateProject = new System.Windows.Forms.Button();
            this.lb_MyWork = new System.Windows.Forms.Label();
            this.pn_background = new System.Windows.Forms.Panel();
            this.pn_container = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgv_Project = new System.Windows.Forms.DataGridView();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.projectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pn_tittle.SuspendLayout();
            this.pn_search.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pn_background.SuspendLayout();
            this.pn_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Project)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_tittle
            // 
            this.pn_tittle.BackColor = System.Drawing.Color.White;
            this.pn_tittle.Controls.Add(this.pn_search);
            this.pn_tittle.Controls.Add(this.bt_others);
            this.pn_tittle.Controls.Add(this.bt_CreateProject);
            this.pn_tittle.Controls.Add(this.lb_MyWork);
            this.pn_tittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_tittle.Location = new System.Drawing.Point(0, 0);
            this.pn_tittle.Margin = new System.Windows.Forms.Padding(2);
            this.pn_tittle.Name = "pn_tittle";
            this.pn_tittle.Size = new System.Drawing.Size(1128, 72);
            this.pn_tittle.TabIndex = 3;
            // 
            // pn_search
            // 
            this.pn_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pn_search.Controls.Add(this.panel2);
            this.pn_search.Controls.Add(this.bt_search);
            this.pn_search.Location = new System.Drawing.Point(279, 25);
            this.pn_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pn_search.Name = "pn_search";
            this.pn_search.Size = new System.Drawing.Size(496, 38);
            this.pn_search.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_search);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(45, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 38);
            this.panel2.TabIndex = 15;
            // 
            // txt_search
            // 
            this.txt_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_search.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_search.Location = new System.Drawing.Point(0, 0);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(451, 38);
            this.txt_search.TabIndex = 0;
            this.txt_search.Text = "Search for project";
            this.txt_search.Enter += new System.EventHandler(this.txt_search_Enter);
            this.txt_search.Leave += new System.EventHandler(this.txt_search_Leave);
            this.txt_search.Move += new System.EventHandler(this.txt_search_Move);
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.White;
            this.bt_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_search.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.bt_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.bt_search.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(160)))), ((int)(((byte)(166)))));
            this.bt_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_search.IconSize = 30;
            this.bt_search.Location = new System.Drawing.Point(0, 0);
            this.bt_search.Margin = new System.Windows.Forms.Padding(2);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(45, 38);
            this.bt_search.TabIndex = 14;
            this.bt_search.UseVisualStyleBackColor = false;
            // 
            // bt_others
            // 
            this.bt_others.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_others.BackColor = System.Drawing.Color.Black;
            this.bt_others.FlatAppearance.BorderSize = 0;
            this.bt_others.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_others.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_others.ForeColor = System.Drawing.Color.White;
            this.bt_others.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.bt_others.IconColor = System.Drawing.Color.White;
            this.bt_others.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_others.IconSize = 32;
            this.bt_others.Location = new System.Drawing.Point(1006, 25);
            this.bt_others.Margin = new System.Windows.Forms.Padding(2);
            this.bt_others.Name = "bt_others";
            this.bt_others.Size = new System.Drawing.Size(55, 38);
            this.bt_others.TabIndex = 20;
            this.bt_others.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_others.UseVisualStyleBackColor = false;
            // 
            // bt_CreateProject
            // 
            this.bt_CreateProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_CreateProject.BackColor = System.Drawing.Color.Black;
            this.bt_CreateProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_CreateProject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.bt_CreateProject.FlatAppearance.BorderSize = 0;
            this.bt_CreateProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_CreateProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_CreateProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_CreateProject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CreateProject.ForeColor = System.Drawing.Color.White;
            this.bt_CreateProject.Location = new System.Drawing.Point(866, 25);
            this.bt_CreateProject.Margin = new System.Windows.Forms.Padding(2);
            this.bt_CreateProject.Name = "bt_CreateProject";
            this.bt_CreateProject.Size = new System.Drawing.Size(115, 38);
            this.bt_CreateProject.TabIndex = 19;
            this.bt_CreateProject.Text = "Create";
            this.bt_CreateProject.UseVisualStyleBackColor = false;
            this.bt_CreateProject.Click += new System.EventHandler(this.bt_CreateProject_Click);
            // 
            // lb_MyWork
            // 
            this.lb_MyWork.AutoSize = true;
            this.lb_MyWork.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MyWork.ForeColor = System.Drawing.Color.Black;
            this.lb_MyWork.Location = new System.Drawing.Point(29, 25);
            this.lb_MyWork.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_MyWork.Name = "lb_MyWork";
            this.lb_MyWork.Size = new System.Drawing.Size(105, 27);
            this.lb_MyWork.TabIndex = 2;
            this.lb_MyWork.Text = "My work";
            // 
            // pn_background
            // 
            this.pn_background.BackColor = System.Drawing.Color.White;
            this.pn_background.Controls.Add(this.pn_container);
            this.pn_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_background.Location = new System.Drawing.Point(0, 72);
            this.pn_background.Margin = new System.Windows.Forms.Padding(2);
            this.pn_background.Name = "pn_background";
            this.pn_background.Size = new System.Drawing.Size(1128, 513);
            this.pn_background.TabIndex = 2;
            // 
            // pn_container
            // 
            this.pn_container.AutoScroll = true;
            this.pn_container.Controls.Add(this.dtgv_Project);
            this.pn_container.Controls.Add(this.button1);
            this.pn_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_container.Location = new System.Drawing.Point(0, 0);
            this.pn_container.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pn_container.Name = "pn_container";
            this.pn_container.Size = new System.Drawing.Size(1128, 513);
            this.pn_container.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(866, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "detail";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgv_Project
            // 
            this.dtgv_Project.AutoGenerateColumns = false;
            this.dtgv_Project.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Project.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.plannedStartDateDataGridViewTextBoxColumn,
            this.plannedEndDateDataGridViewTextBoxColumn,
            this.Detail});
            this.dtgv_Project.DataSource = this.projectBindingSource;
            this.dtgv_Project.Location = new System.Drawing.Point(12, 5);
            this.dtgv_Project.Name = "dtgv_Project";
            this.dtgv_Project.RowHeadersWidth = 51;
            this.dtgv_Project.RowTemplate.Height = 24;
            this.dtgv_Project.Size = new System.Drawing.Size(847, 481);
            this.dtgv_Project.TabIndex = 1;
            this.dtgv_Project.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Project_CellContentClick);
            // 
            // Detail
            // 
            this.Detail.HeaderText = "Detail";
            this.Detail.MinimumWidth = 6;
            this.Detail.Name = "Detail";
            this.Detail.Text = "Detail";
            this.Detail.UseColumnTextForButtonValue = true;
            this.Detail.Width = 125;
            // 
            // projectIdDataGridViewTextBoxColumn
            // 
            this.projectIdDataGridViewTextBoxColumn.DataPropertyName = "ProjectId";
            this.projectIdDataGridViewTextBoxColumn.HeaderText = "ProjectId";
            this.projectIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectIdDataGridViewTextBoxColumn.Name = "projectIdDataGridViewTextBoxColumn";
            this.projectIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // plannedStartDateDataGridViewTextBoxColumn
            // 
            this.plannedStartDateDataGridViewTextBoxColumn.DataPropertyName = "PlannedStartDate";
            this.plannedStartDateDataGridViewTextBoxColumn.HeaderText = "PlannedStartDate";
            this.plannedStartDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.plannedStartDateDataGridViewTextBoxColumn.Name = "plannedStartDateDataGridViewTextBoxColumn";
            this.plannedStartDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // plannedEndDateDataGridViewTextBoxColumn
            // 
            this.plannedEndDateDataGridViewTextBoxColumn.DataPropertyName = "PlannedEndDate";
            this.plannedEndDateDataGridViewTextBoxColumn.HeaderText = "PlannedEndDate";
            this.plannedEndDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.plannedEndDateDataGridViewTextBoxColumn.Name = "plannedEndDateDataGridViewTextBoxColumn";
            this.plannedEndDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(BCMP.DTO.Project);
            // 
            // FormProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1128, 585);
            this.Controls.Add(this.pn_background);
            this.Controls.Add(this.pn_tittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormProject";
            this.Text = "FormProject";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormProject_Paint);
            this.pn_tittle.ResumeLayout(false);
            this.pn_tittle.PerformLayout();
            this.pn_search.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pn_background.ResumeLayout(false);
            this.pn_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Project)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_tittle;
        private System.Windows.Forms.Label lb_MyWork;
        private System.Windows.Forms.Panel pn_background;
        private System.Windows.Forms.Button bt_CreateProject;
        private FontAwesome.Sharp.IconButton bt_others;
        private System.Windows.Forms.Panel pn_search;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton bt_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pn_container;
        private System.Windows.Forms.DataGridView dtgv_Project;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannedStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannedEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
    }
}