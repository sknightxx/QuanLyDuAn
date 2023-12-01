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
            this.cb_TypeDocument = new System.Windows.Forms.ComboBox();
            this.cb_PartnerCode = new System.Windows.Forms.ComboBox();
            this.txt_SerialNumber = new System.Windows.Forms.TextBox();
            this.txt_WBS = new System.Windows.Forms.TextBox();
            this.bt_upload = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Department = new System.Windows.Forms.ComboBox();
            this.lb_department = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_TypeDocument
            // 
            this.cb_TypeDocument.FormattingEnabled = true;
            this.cb_TypeDocument.Location = new System.Drawing.Point(181, 136);
            this.cb_TypeDocument.Name = "cb_TypeDocument";
            this.cb_TypeDocument.Size = new System.Drawing.Size(121, 24);
            this.cb_TypeDocument.TabIndex = 0;
            // 
            // cb_PartnerCode
            // 
            this.cb_PartnerCode.FormattingEnabled = true;
            this.cb_PartnerCode.Location = new System.Drawing.Point(26, 138);
            this.cb_PartnerCode.Name = "cb_PartnerCode";
            this.cb_PartnerCode.Size = new System.Drawing.Size(121, 24);
            this.cb_PartnerCode.TabIndex = 1;
            // 
            // txt_SerialNumber
            // 
            this.txt_SerialNumber.Location = new System.Drawing.Point(354, 138);
            this.txt_SerialNumber.Name = "txt_SerialNumber";
            this.txt_SerialNumber.Size = new System.Drawing.Size(100, 22);
            this.txt_SerialNumber.TabIndex = 2;
            // 
            // txt_WBS
            // 
            this.txt_WBS.Location = new System.Drawing.Point(519, 140);
            this.txt_WBS.Name = "txt_WBS";
            this.txt_WBS.Size = new System.Drawing.Size(100, 22);
            this.txt_WBS.TabIndex = 3;
            // 
            // bt_upload
            // 
            this.bt_upload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_upload.BackColor = System.Drawing.Color.White;
            this.bt_upload.FlatAppearance.BorderSize = 0;
            this.bt_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_upload.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.bt_upload.ForeColor = System.Drawing.Color.White;
            this.bt_upload.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.bt_upload.IconColor = System.Drawing.Color.Black;
            this.bt_upload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_upload.IconSize = 32;
            this.bt_upload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_upload.Location = new System.Drawing.Point(653, 130);
            this.bt_upload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_upload.Name = "bt_upload";
            this.bt_upload.Size = new System.Drawing.Size(59, 37);
            this.bt_upload.TabIndex = 26;
            this.bt_upload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_upload.UseVisualStyleBackColor = false;
            this.bt_upload.Click += new System.EventHandler(this.bt_upload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "PartnerCode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "TypeOfDocument";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "SerialNumber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "WBS";
            // 
            // cb_Department
            // 
            this.cb_Department.FormattingEnabled = true;
            this.cb_Department.Items.AddRange(new object[] {
            "Public",
            "Your Department"});
            this.cb_Department.Location = new System.Drawing.Point(26, 216);
            this.cb_Department.Name = "cb_Department";
            this.cb_Department.Size = new System.Drawing.Size(121, 24);
            this.cb_Department.TabIndex = 31;
            // 
            // lb_department
            // 
            this.lb_department.AutoSize = true;
            this.lb_department.Location = new System.Drawing.Point(26, 180);
            this.lb_department.Name = "lb_department";
            this.lb_department.Size = new System.Drawing.Size(77, 16);
            this.lb_department.TabIndex = 32;
            this.lb_department.Text = "Department";
            // 
            // FormAddDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "FormAddDocument";
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