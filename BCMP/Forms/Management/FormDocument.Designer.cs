﻿namespace BCMP.Forms.Management
{
    partial class FormDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocument));
            this.pn_containerDocument = new System.Windows.Forms.Panel();
            this.bt_download = new FontAwesome.Sharp.IconButton();
            this.bt_upload = new FontAwesome.Sharp.IconButton();
            this.pn_tittle = new System.Windows.Forms.Panel();
            this.bt_delete = new FontAwesome.Sharp.IconButton();
            this.bt_print = new FontAwesome.Sharp.IconButton();
            this.lb_file = new System.Windows.Forms.Label();
            this.bt_departmentData = new System.Windows.Forms.Button();
            this.bt_publicData = new System.Windows.Forms.Button();
            this.pn_search = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.bt_search = new FontAwesome.Sharp.IconButton();
            this.pn_background = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_tittle.SuspendLayout();
            this.pn_search.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pn_background.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_containerDocument
            // 
            resources.ApplyResources(this.pn_containerDocument, "pn_containerDocument");
            this.pn_containerDocument.BackColor = System.Drawing.Color.Transparent;
            this.pn_containerDocument.Name = "pn_containerDocument";
            // 
            // bt_download
            // 
            resources.ApplyResources(this.bt_download, "bt_download");
            this.bt_download.BackColor = System.Drawing.Color.White;
            this.bt_download.FlatAppearance.BorderSize = 0;
            this.bt_download.ForeColor = System.Drawing.Color.White;
            this.bt_download.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.bt_download.IconColor = System.Drawing.Color.Black;
            this.bt_download.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_download.IconSize = 32;
            this.bt_download.Name = "bt_download";
            this.bt_download.UseVisualStyleBackColor = false;
            // 
            // bt_upload
            // 
            resources.ApplyResources(this.bt_upload, "bt_upload");
            this.bt_upload.BackColor = System.Drawing.Color.White;
            this.bt_upload.FlatAppearance.BorderSize = 0;
            this.bt_upload.ForeColor = System.Drawing.Color.White;
            this.bt_upload.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.bt_upload.IconColor = System.Drawing.Color.Black;
            this.bt_upload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_upload.IconSize = 32;
            this.bt_upload.Name = "bt_upload";
            this.bt_upload.UseVisualStyleBackColor = false;
            // 
            // pn_tittle
            // 
            resources.ApplyResources(this.pn_tittle, "pn_tittle");
            this.pn_tittle.BackColor = System.Drawing.Color.White;
            this.pn_tittle.Controls.Add(this.bt_delete);
            this.pn_tittle.Controls.Add(this.bt_download);
            this.pn_tittle.Controls.Add(this.bt_print);
            this.pn_tittle.Controls.Add(this.lb_file);
            this.pn_tittle.Controls.Add(this.bt_upload);
            this.pn_tittle.Controls.Add(this.bt_departmentData);
            this.pn_tittle.Controls.Add(this.bt_publicData);
            this.pn_tittle.Controls.Add(this.pn_search);
            this.pn_tittle.Name = "pn_tittle";
            // 
            // bt_delete
            // 
            resources.ApplyResources(this.bt_delete, "bt_delete");
            this.bt_delete.BackColor = System.Drawing.Color.White;
            this.bt_delete.FlatAppearance.BorderSize = 0;
            this.bt_delete.ForeColor = System.Drawing.Color.White;
            this.bt_delete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.bt_delete.IconColor = System.Drawing.Color.Black;
            this.bt_delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_delete.IconSize = 32;
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.UseVisualStyleBackColor = false;
            // 
            // bt_print
            // 
            resources.ApplyResources(this.bt_print, "bt_print");
            this.bt_print.BackColor = System.Drawing.Color.White;
            this.bt_print.FlatAppearance.BorderSize = 0;
            this.bt_print.ForeColor = System.Drawing.Color.White;
            this.bt_print.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.bt_print.IconColor = System.Drawing.Color.Black;
            this.bt_print.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_print.IconSize = 32;
            this.bt_print.Name = "bt_print";
            this.bt_print.UseVisualStyleBackColor = false;
            // 
            // lb_file
            // 
            resources.ApplyResources(this.lb_file, "lb_file");
            this.lb_file.Name = "lb_file";
            this.lb_file.Click += new System.EventHandler(this.lb_file_Click);
            // 
            // bt_departmentData
            // 
            resources.ApplyResources(this.bt_departmentData, "bt_departmentData");
            this.bt_departmentData.Name = "bt_departmentData";
            this.bt_departmentData.UseVisualStyleBackColor = true;
            this.bt_departmentData.Click += new System.EventHandler(this.bt_departmentData_Click);
            // 
            // bt_publicData
            // 
            resources.ApplyResources(this.bt_publicData, "bt_publicData");
            this.bt_publicData.Name = "bt_publicData";
            this.bt_publicData.UseVisualStyleBackColor = true;
            this.bt_publicData.Click += new System.EventHandler(this.bt_publicData_Click);
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
            // pn_background
            // 
            resources.ApplyResources(this.pn_background, "pn_background");
            this.pn_background.BackColor = System.Drawing.Color.White;
            this.pn_background.Controls.Add(this.panel1);
            this.pn_background.Name = "pn_background";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.pn_containerDocument);
            this.panel1.Name = "panel1";
            // 
            // FormDocument
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_background);
            this.Controls.Add(this.pn_tittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDocument";
            this.pn_tittle.ResumeLayout(false);
            this.pn_tittle.PerformLayout();
            this.pn_search.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pn_background.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_containerDocument;
        private System.Windows.Forms.Panel pn_tittle;
        private System.Windows.Forms.Panel pn_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_search;
        private FontAwesome.Sharp.IconButton bt_search;
        private FontAwesome.Sharp.IconButton bt_delete;
        private System.Windows.Forms.Panel pn_background;
        private System.Windows.Forms.Label lb_file;
        private System.Windows.Forms.Button bt_departmentData;
        private System.Windows.Forms.Button bt_publicData;
        private FontAwesome.Sharp.IconButton bt_print;
        private FontAwesome.Sharp.IconButton bt_download;
        private FontAwesome.Sharp.IconButton bt_upload;
        private System.Windows.Forms.Panel panel1;
    }
}