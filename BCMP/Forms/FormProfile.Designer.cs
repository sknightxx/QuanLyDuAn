namespace BCMP.Forms
{
    partial class FormProfile
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
            this.dgv_employees = new System.Windows.Forms.DataGridView();
            this.lb_employees = new System.Windows.Forms.Label();
            this.bt_addUser = new FontAwesome.Sharp.IconButton();
            this.bt_others = new FontAwesome.Sharp.IconButton();
            this.pn_tittleProfile = new System.Windows.Forms.Panel();
            this.bt_search = new FontAwesome.Sharp.IconButton();
            this.txt_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employees)).BeginInit();
            this.pn_tittleProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_employees
            // 
            this.dgv_employees.BackgroundColor = System.Drawing.Color.White;
            this.dgv_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employees.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_employees.Location = new System.Drawing.Point(0, 78);
            this.dgv_employees.Name = "dgv_employees";
            this.dgv_employees.RowHeadersWidth = 51;
            this.dgv_employees.RowTemplate.Height = 24;
            this.dgv_employees.Size = new System.Drawing.Size(1127, 507);
            this.dgv_employees.TabIndex = 9;
            // 
            // lb_employees
            // 
            this.lb_employees.AutoSize = true;
            this.lb_employees.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_employees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.lb_employees.Location = new System.Drawing.Point(29, 25);
            this.lb_employees.Name = "lb_employees";
            this.lb_employees.Size = new System.Drawing.Size(135, 27);
            this.lb_employees.TabIndex = 5;
            this.lb_employees.Text = "Employees";
            this.lb_employees.TextChanged += new System.EventHandler(this.lb_employees_TextChanged);
            // 
            // bt_addUser
            // 
            this.bt_addUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_addUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.bt_addUser.FlatAppearance.BorderSize = 0;
            this.bt_addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_addUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_addUser.ForeColor = System.Drawing.Color.White;
            this.bt_addUser.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bt_addUser.IconColor = System.Drawing.Color.Gainsboro;
            this.bt_addUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_addUser.IconSize = 32;
            this.bt_addUser.Location = new System.Drawing.Point(866, 25);
            this.bt_addUser.Name = "bt_addUser";
            this.bt_addUser.Size = new System.Drawing.Size(115, 37);
            this.bt_addUser.TabIndex = 10;
            this.bt_addUser.Text = "Create";
            this.bt_addUser.UseVisualStyleBackColor = false;
            this.bt_addUser.Click += new System.EventHandler(this.bt_addUser_Click);
            // 
            // bt_others
            // 
            this.bt_others.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_others.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
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
            this.bt_others.TabIndex = 11;
            this.bt_others.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_others.UseVisualStyleBackColor = false;
            // 
            // pn_tittleProfile
            // 
            this.pn_tittleProfile.BackColor = System.Drawing.Color.White;
            this.pn_tittleProfile.Controls.Add(this.bt_search);
            this.pn_tittleProfile.Controls.Add(this.txt_search);
            this.pn_tittleProfile.Controls.Add(this.lb_employees);
            this.pn_tittleProfile.Controls.Add(this.bt_others);
            this.pn_tittleProfile.Controls.Add(this.bt_addUser);
            this.pn_tittleProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_tittleProfile.Location = new System.Drawing.Point(0, 0);
            this.pn_tittleProfile.Name = "pn_tittleProfile";
            this.pn_tittleProfile.Size = new System.Drawing.Size(1127, 83);
            this.pn_tittleProfile.TabIndex = 12;
            // 
            // bt_search
            // 
            this.bt_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_search.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_search.FlatAppearance.BorderSize = 0;
            this.bt_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.bt_search.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(160)))), ((int)(((byte)(166)))));
            this.bt_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_search.IconSize = 30;
            this.bt_search.Location = new System.Drawing.Point(699, 26);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(45, 35);
            this.bt_search.TabIndex = 13;
            this.bt_search.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(335, 25);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(410, 37);
            this.txt_search.TabIndex = 12;
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1127, 585);
            this.Controls.Add(this.pn_tittleProfile);
            this.Controls.Add(this.dgv_employees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProfile";
            this.Text = "FormProfile";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employees)).EndInit();
            this.pn_tittleProfile.ResumeLayout(false);
            this.pn_tittleProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_employees;
        private System.Windows.Forms.Label lb_employees;
        private FontAwesome.Sharp.IconButton bt_addUser;
        private FontAwesome.Sharp.IconButton bt_others;
        private System.Windows.Forms.Panel pn_tittleProfile;
        private FontAwesome.Sharp.IconButton bt_search;
        private System.Windows.Forms.TextBox txt_search;
    }
}