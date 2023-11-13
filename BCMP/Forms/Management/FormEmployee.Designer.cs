namespace BCMP.Forms
{
    partial class FormEmployee
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
            this.pn_tittleForm = new System.Windows.Forms.Panel();
            this.pn_search = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.bt_search = new FontAwesome.Sharp.IconButton();
            this.bt_others = new FontAwesome.Sharp.IconButton();
            this.bt_Create = new System.Windows.Forms.Button();
            this.lb_employee = new System.Windows.Forms.Label();
            this.pn_container = new System.Windows.Forms.Panel();
            this.lb_Name = new System.Windows.Forms.Label();
            this.pn_tittleForm.SuspendLayout();
            this.pn_search.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pn_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_tittleForm
            // 
            this.pn_tittleForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_tittleForm.BackColor = System.Drawing.Color.White;
            this.pn_tittleForm.Controls.Add(this.pn_search);
            this.pn_tittleForm.Controls.Add(this.bt_others);
            this.pn_tittleForm.Controls.Add(this.bt_Create);
            this.pn_tittleForm.Controls.Add(this.lb_employee);
            this.pn_tittleForm.Location = new System.Drawing.Point(0, 0);
            this.pn_tittleForm.Margin = new System.Windows.Forms.Padding(2);
            this.pn_tittleForm.Name = "pn_tittleForm";
            this.pn_tittleForm.Size = new System.Drawing.Size(902, 58);
            this.pn_tittleForm.TabIndex = 5;
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
            this.txt_search.Text = "Search for employees";
            this.txt_search.Enter += new System.EventHandler(this.txt_search_Enter);
            this.txt_search.Leave += new System.EventHandler(this.txt_search_Leave);
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
            this.bt_others.BackColor = System.Drawing.Color.Black;
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
            // bt_Create
            // 
            this.bt_Create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Create.BackColor = System.Drawing.Color.Black;
            this.bt_Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Create.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.bt_Create.FlatAppearance.BorderSize = 0;
            this.bt_Create.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_Create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Create.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Create.ForeColor = System.Drawing.Color.White;
            this.bt_Create.Location = new System.Drawing.Point(693, 20);
            this.bt_Create.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Create.Name = "bt_Create";
            this.bt_Create.Size = new System.Drawing.Size(92, 30);
            this.bt_Create.TabIndex = 19;
            this.bt_Create.Text = "Create";
            this.bt_Create.UseVisualStyleBackColor = false;
            this.bt_Create.Click += new System.EventHandler(this.bt_Create_Click);
            // 
            // lb_employee
            // 
            this.lb_employee.AutoSize = true;
            this.lb_employee.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_employee.ForeColor = System.Drawing.Color.Black;
            this.lb_employee.Location = new System.Drawing.Point(23, 20);
            this.lb_employee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_employee.Name = "lb_employee";
            this.lb_employee.Size = new System.Drawing.Size(103, 23);
            this.lb_employee.TabIndex = 2;
            this.lb_employee.Text = "Employee";
            // 
            // pn_container
            // 
            this.pn_container.BackColor = System.Drawing.Color.White;
            this.pn_container.Controls.Add(this.lb_Name);
            this.pn_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_container.Location = new System.Drawing.Point(0, 0);
            this.pn_container.Margin = new System.Windows.Forms.Padding(2);
            this.pn_container.Name = "pn_container";
            this.pn_container.Size = new System.Drawing.Size(902, 468);
            this.pn_container.TabIndex = 4;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.BackColor = System.Drawing.Color.Transparent;
            this.lb_Name.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.ForeColor = System.Drawing.Color.Black;
            this.lb_Name.Location = new System.Drawing.Point(37, 155);
            this.lb_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(0, 19);
            this.lb_Name.TabIndex = 18;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(902, 468);
            this.Controls.Add(this.pn_tittleForm);
            this.Controls.Add(this.pn_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEmployee";
            this.Text = "FormProfile";
            this.pn_tittleForm.ResumeLayout(false);
            this.pn_tittleForm.PerformLayout();
            this.pn_search.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pn_container.ResumeLayout(false);
            this.pn_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_tittleForm;
        private System.Windows.Forms.Panel pn_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_search;
        private FontAwesome.Sharp.IconButton bt_search;
        private FontAwesome.Sharp.IconButton bt_others;
        private System.Windows.Forms.Button bt_Create;
        private System.Windows.Forms.Label lb_employee;
        private System.Windows.Forms.Panel pn_container;
        private System.Windows.Forms.Label lb_Name;
    }
}