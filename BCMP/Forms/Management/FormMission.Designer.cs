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
            this.pn_tittle = new System.Windows.Forms.Panel();
            this.pn_search = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.bt_CreateProject = new System.Windows.Forms.Button();
            this.lb_MyWork = new System.Windows.Forms.Label();
            this.pn_container = new System.Windows.Forms.Panel();
            this.bt_search = new FontAwesome.Sharp.IconButton();
            this.bt_others = new FontAwesome.Sharp.IconButton();
            this.pn_tittle.SuspendLayout();
            this.pn_search.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_tittle
            // 
            this.pn_tittle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_tittle.BackColor = System.Drawing.Color.White;
            this.pn_tittle.Controls.Add(this.pn_search);
            this.pn_tittle.Controls.Add(this.bt_others);
            this.pn_tittle.Controls.Add(this.bt_CreateProject);
            this.pn_tittle.Controls.Add(this.lb_MyWork);
            this.pn_tittle.Location = new System.Drawing.Point(0, 0);
            this.pn_tittle.Margin = new System.Windows.Forms.Padding(2);
            this.pn_tittle.Name = "pn_tittle";
            this.pn_tittle.Size = new System.Drawing.Size(902, 58);
            this.pn_tittle.TabIndex = 5;
            // 
            // pn_search
            // 
            this.pn_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pn_search.Controls.Add(this.panel2);
            this.pn_search.Controls.Add(this.bt_search);
            this.pn_search.Location = new System.Drawing.Point(223, 20);
            this.pn_search.Name = "pn_search";
            this.pn_search.Size = new System.Drawing.Size(397, 30);
            this.pn_search.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_search);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(36, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 30);
            this.panel2.TabIndex = 15;
            // 
            // txt_search
            // 
            this.txt_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_search.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_search.Location = new System.Drawing.Point(0, 0);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(361, 30);
            this.txt_search.TabIndex = 0;
            this.txt_search.Text = "Search mission by ID";
            this.txt_search.Enter += new System.EventHandler(this.txt_search_Enter);
            this.txt_search.Leave += new System.EventHandler(this.txt_search_Leave);
            // 
            // bt_CreateProject
            // 
            this.bt_CreateProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_CreateProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.bt_CreateProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_CreateProject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.bt_CreateProject.FlatAppearance.BorderSize = 0;
            this.bt_CreateProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_CreateProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_CreateProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_CreateProject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CreateProject.ForeColor = System.Drawing.Color.White;
            this.bt_CreateProject.Location = new System.Drawing.Point(693, 20);
            this.bt_CreateProject.Margin = new System.Windows.Forms.Padding(2);
            this.bt_CreateProject.Name = "bt_CreateProject";
            this.bt_CreateProject.Size = new System.Drawing.Size(92, 30);
            this.bt_CreateProject.TabIndex = 19;
            this.bt_CreateProject.Text = "Create";
            this.bt_CreateProject.UseVisualStyleBackColor = false;
            this.bt_CreateProject.Click += new System.EventHandler(this.bt_CreateProject_Click);
            // 
            // lb_MyWork
            // 
            this.lb_MyWork.AutoSize = true;
            this.lb_MyWork.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MyWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.lb_MyWork.Location = new System.Drawing.Point(23, 20);
            this.lb_MyWork.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_MyWork.Name = "lb_MyWork";
            this.lb_MyWork.Size = new System.Drawing.Size(81, 23);
            this.lb_MyWork.TabIndex = 2;
            this.lb_MyWork.Text = "My task";
            // 
            // pn_container
            // 
            this.pn_container.BackColor = System.Drawing.Color.White;
            this.pn_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_container.Location = new System.Drawing.Point(0, 0);
            this.pn_container.Margin = new System.Windows.Forms.Padding(2);
            this.pn_container.Name = "pn_container";
            this.pn_container.Size = new System.Drawing.Size(902, 468);
            this.pn_container.TabIndex = 4;
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
            this.bt_search.Size = new System.Drawing.Size(36, 30);
            this.bt_search.TabIndex = 14;
            this.bt_search.UseVisualStyleBackColor = false;
            // 
            // bt_others
            // 
            this.bt_others.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_others.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.bt_others.FlatAppearance.BorderSize = 0;
            this.bt_others.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_others.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_others.ForeColor = System.Drawing.Color.White;
            this.bt_others.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.bt_others.IconColor = System.Drawing.Color.White;
            this.bt_others.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_others.IconSize = 32;
            this.bt_others.Location = new System.Drawing.Point(805, 20);
            this.bt_others.Margin = new System.Windows.Forms.Padding(2);
            this.bt_others.Name = "bt_others";
            this.bt_others.Size = new System.Drawing.Size(44, 30);
            this.bt_others.TabIndex = 20;
            this.bt_others.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_others.UseVisualStyleBackColor = false;
            // 
            // FormMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(902, 468);
            this.Controls.Add(this.pn_tittle);
            this.Controls.Add(this.pn_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMission";
            this.Text = "FormMission";
            this.pn_tittle.ResumeLayout(false);
            this.pn_tittle.PerformLayout();
            this.pn_search.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}