namespace BCMP.Forms
{
    partial class FormAddProject
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
            this.lb_newProject = new System.Windows.Forms.Label();
            this.lb_NameProject = new System.Windows.Forms.Label();
            this.dsTextbox1 = new BCMP.DesignControls.DsTextbox();
            this.SuspendLayout();
            // 
            // lb_newProject
            // 
            this.lb_newProject.AutoSize = true;
            this.lb_newProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_newProject.ForeColor = System.Drawing.Color.Black;
            this.lb_newProject.Location = new System.Drawing.Point(20, 17);
            this.lb_newProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_newProject.Name = "lb_newProject";
            this.lb_newProject.Size = new System.Drawing.Size(122, 24);
            this.lb_newProject.TabIndex = 0;
            this.lb_newProject.Text = "New project";
            // 
            // lb_NameProject
            // 
            this.lb_NameProject.AutoSize = true;
            this.lb_NameProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NameProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_NameProject.Location = new System.Drawing.Point(21, 67);
            this.lb_NameProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NameProject.Name = "lb_NameProject";
            this.lb_NameProject.Size = new System.Drawing.Size(114, 18);
            this.lb_NameProject.TabIndex = 1;
            this.lb_NameProject.Text = "Name of project";
            // 
            // dsTextbox1
            // 
            this.dsTextbox1.AutoSize = true;
            this.dsTextbox1.BorderColor = System.Drawing.Color.DarkGray;
            this.dsTextbox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.dsTextbox1.BorderRadius = 10;
            this.dsTextbox1.BorderSize = 1;
            this.dsTextbox1.Location = new System.Drawing.Point(24, 99);
            this.dsTextbox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dsTextbox1.Multiline = false;
            this.dsTextbox1.Name = "dsTextbox1";
            this.dsTextbox1.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.dsTextbox1.PasswordChar = false;
            this.dsTextbox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.dsTextbox1.PlaceholderText = "";
            this.dsTextbox1.Size = new System.Drawing.Size(579, 26);
            this.dsTextbox1.TabIndex = 2;
            this.dsTextbox1.Texts = "";
            this.dsTextbox1.UnderlinedStyle = false;
            // 
            // FormAddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 512);
            this.Controls.Add(this.dsTextbox1);
            this.Controls.Add(this.lb_NameProject);
            this.Controls.Add(this.lb_newProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAddProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_newProject;
        private System.Windows.Forms.Label lb_NameProject;
        private DesignControls.DsTextbox dsTextbox1;
    }
}