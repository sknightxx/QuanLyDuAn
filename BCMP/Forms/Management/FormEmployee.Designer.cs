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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            this.pn_tittleForm = new System.Windows.Forms.Panel();
            this.pn_search = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.bt_Create = new System.Windows.Forms.Button();
            this.lb_employee = new System.Windows.Forms.Label();
            this.pn_container = new System.Windows.Forms.Panel();
            this.lb_Name = new System.Windows.Forms.Label();
            this.bt_search = new FontAwesome.Sharp.IconButton();
            this.bt_others = new FontAwesome.Sharp.IconButton();
            this.pn_tittleForm.SuspendLayout();
            this.pn_search.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pn_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_tittleForm
            // 
            resources.ApplyResources(this.pn_tittleForm, "pn_tittleForm");
            this.pn_tittleForm.BackColor = System.Drawing.Color.White;
            this.pn_tittleForm.Controls.Add(this.pn_search);
            this.pn_tittleForm.Controls.Add(this.bt_others);
            this.pn_tittleForm.Controls.Add(this.bt_Create);
            this.pn_tittleForm.Controls.Add(this.lb_employee);
            this.pn_tittleForm.Name = "pn_tittleForm";
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
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.txt_search);
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
            // bt_Create
            // 
            resources.ApplyResources(this.bt_Create, "bt_Create");
            this.bt_Create.BackColor = System.Drawing.Color.Black;
            this.bt_Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Create.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.bt_Create.FlatAppearance.BorderSize = 0;
            this.bt_Create.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_Create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_Create.ForeColor = System.Drawing.Color.White;
            this.bt_Create.Name = "bt_Create";
            this.bt_Create.UseVisualStyleBackColor = false;
            this.bt_Create.Click += new System.EventHandler(this.bt_Create_Click);
            // 
            // lb_employee
            // 
            resources.ApplyResources(this.lb_employee, "lb_employee");
            this.lb_employee.ForeColor = System.Drawing.Color.Black;
            this.lb_employee.Name = "lb_employee";
            // 
            // pn_container
            // 
            resources.ApplyResources(this.pn_container, "pn_container");
            this.pn_container.BackColor = System.Drawing.Color.White;
            this.pn_container.Controls.Add(this.lb_Name);
            this.pn_container.Name = "pn_container";
            // 
            // lb_Name
            // 
            resources.ApplyResources(this.lb_Name, "lb_Name");
            this.lb_Name.BackColor = System.Drawing.Color.Transparent;
            this.lb_Name.ForeColor = System.Drawing.Color.Black;
            this.lb_Name.Name = "lb_Name";
            // 
            // bt_search
            // 
            resources.ApplyResources(this.bt_search, "bt_search");
            this.bt_search.BackColor = System.Drawing.Color.White;
            this.bt_search.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // FormEmployee
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.pn_tittleForm);
            this.Controls.Add(this.pn_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmployee";
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