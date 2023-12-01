namespace BCMP.Forms.Management
{
    partial class FormAddDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddDocument));
            this.cb_TypeDocument = new System.Windows.Forms.ComboBox();
            this.cb_PartnerCode = new System.Windows.Forms.ComboBox();
            this.txt_SerialNumber = new System.Windows.Forms.TextBox();
            this.txt_WBS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Department = new System.Windows.Forms.ComboBox();
            this.lb_department = new System.Windows.Forms.Label();
            this.bt_upload = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // cb_TypeDocument
            // 
            resources.ApplyResources(this.cb_TypeDocument, "cb_TypeDocument");
            this.cb_TypeDocument.FormattingEnabled = true;
            this.cb_TypeDocument.Name = "cb_TypeDocument";
            // 
            // cb_PartnerCode
            // 
            resources.ApplyResources(this.cb_PartnerCode, "cb_PartnerCode");
            this.cb_PartnerCode.FormattingEnabled = true;
            this.cb_PartnerCode.Name = "cb_PartnerCode";
            // 
            // txt_SerialNumber
            // 
            resources.ApplyResources(this.txt_SerialNumber, "txt_SerialNumber");
            this.txt_SerialNumber.Name = "txt_SerialNumber";
            // 
            // txt_WBS
            // 
            resources.ApplyResources(this.txt_WBS, "txt_WBS");
            this.txt_WBS.Name = "txt_WBS";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // cb_Department
            // 
            resources.ApplyResources(this.cb_Department, "cb_Department");
            this.cb_Department.FormattingEnabled = true;
            this.cb_Department.Items.AddRange(new object[] {
            resources.GetString("cb_Department.Items"),
            resources.GetString("cb_Department.Items1")});
            this.cb_Department.Name = "cb_Department";
            // 
            // lb_department
            // 
            resources.ApplyResources(this.lb_department, "lb_department");
            this.lb_department.Name = "lb_department";
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
            this.bt_upload.Click += new System.EventHandler(this.bt_upload_Click);
            // 
            // FormAddDocument
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_department);
            this.Controls.Add(this.cb_Department);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_upload);
            this.Controls.Add(this.txt_WBS);
            this.Controls.Add(this.txt_SerialNumber);
            this.Controls.Add(this.cb_PartnerCode);
            this.Controls.Add(this.cb_TypeDocument);
            this.Name = "FormAddDocument";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_TypeDocument;
        private System.Windows.Forms.ComboBox cb_PartnerCode;
        private System.Windows.Forms.TextBox txt_SerialNumber;
        private System.Windows.Forms.TextBox txt_WBS;
        private FontAwesome.Sharp.IconButton bt_upload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Department;
        private System.Windows.Forms.Label lb_department;
    }
}