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
            this.pn_tittleFormAddUser = new System.Windows.Forms.Panel();
            this.bt_CreateProject = new System.Windows.Forms.Button();
            this.lb_MyWork = new System.Windows.Forms.Label();
            this.pn_containerFormAddUser = new System.Windows.Forms.Panel();
            this.lb_Name = new System.Windows.Forms.Label();
            this.bt_others = new FontAwesome.Sharp.IconButton();
            this.pn_tittleFormAddUser.SuspendLayout();
            this.pn_containerFormAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_tittleFormAddUser
            // 
            this.pn_tittleFormAddUser.BackColor = System.Drawing.Color.White;
            this.pn_tittleFormAddUser.Controls.Add(this.bt_others);
            this.pn_tittleFormAddUser.Controls.Add(this.bt_CreateProject);
            this.pn_tittleFormAddUser.Controls.Add(this.lb_MyWork);
            this.pn_tittleFormAddUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_tittleFormAddUser.Location = new System.Drawing.Point(0, 0);
            this.pn_tittleFormAddUser.Name = "pn_tittleFormAddUser";
            this.pn_tittleFormAddUser.Size = new System.Drawing.Size(1127, 73);
            this.pn_tittleFormAddUser.TabIndex = 3;
            // 
            // bt_CreateProject
            // 
            this.bt_CreateProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(144)))));
            this.bt_CreateProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_CreateProject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.bt_CreateProject.FlatAppearance.BorderSize = 0;
            this.bt_CreateProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_CreateProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_CreateProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_CreateProject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CreateProject.ForeColor = System.Drawing.Color.White;
            this.bt_CreateProject.Location = new System.Drawing.Point(866, 25);
            this.bt_CreateProject.Name = "bt_CreateProject";
            this.bt_CreateProject.Size = new System.Drawing.Size(115, 37);
            this.bt_CreateProject.TabIndex = 19;
            this.bt_CreateProject.Text = "Create";
            this.bt_CreateProject.UseVisualStyleBackColor = false;
            this.bt_CreateProject.Click += new System.EventHandler(this.bt_CreateProject_Click);
            // 
            // lb_MyWork
            // 
            this.lb_MyWork.AutoSize = true;
            this.lb_MyWork.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MyWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(144)))));
            this.lb_MyWork.Location = new System.Drawing.Point(29, 25);
            this.lb_MyWork.Name = "lb_MyWork";
            this.lb_MyWork.Size = new System.Drawing.Size(105, 27);
            this.lb_MyWork.TabIndex = 2;
            this.lb_MyWork.Text = "My work";
            // 
            // pn_containerFormAddUser
            // 
            this.pn_containerFormAddUser.BackColor = System.Drawing.Color.White;
            this.pn_containerFormAddUser.Controls.Add(this.lb_Name);
            this.pn_containerFormAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_containerFormAddUser.Location = new System.Drawing.Point(0, 0);
            this.pn_containerFormAddUser.Name = "pn_containerFormAddUser";
            this.pn_containerFormAddUser.Size = new System.Drawing.Size(1127, 585);
            this.pn_containerFormAddUser.TabIndex = 2;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.BackColor = System.Drawing.Color.Transparent;
            this.lb_Name.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.ForeColor = System.Drawing.Color.Black;
            this.lb_Name.Location = new System.Drawing.Point(46, 194);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(0, 21);
            this.lb_Name.TabIndex = 18;
            // 
            // bt_others
            // 
            this.bt_others.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_others.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(144)))));
            this.bt_others.FlatAppearance.BorderSize = 0;
            this.bt_others.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_others.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_others.ForeColor = System.Drawing.Color.White;
            this.bt_others.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.bt_others.IconColor = System.Drawing.Color.White;
            this.bt_others.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_others.IconSize = 32;
            this.bt_others.Location = new System.Drawing.Point(1006, 25);
            this.bt_others.Name = "bt_others";
            this.bt_others.Size = new System.Drawing.Size(55, 37);
            this.bt_others.TabIndex = 20;
            this.bt_others.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_others.UseVisualStyleBackColor = false;
            // 
            // FormProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1127, 585);
            this.Controls.Add(this.pn_tittleFormAddUser);
            this.Controls.Add(this.pn_containerFormAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProject";
            this.Text = "FormProject";
            this.pn_tittleFormAddUser.ResumeLayout(false);
            this.pn_tittleFormAddUser.PerformLayout();
            this.pn_containerFormAddUser.ResumeLayout(false);
            this.pn_containerFormAddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_tittleFormAddUser;
        private System.Windows.Forms.Label lb_MyWork;
        private System.Windows.Forms.Panel pn_containerFormAddUser;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Button bt_CreateProject;
        private FontAwesome.Sharp.IconButton bt_others;
    }
}