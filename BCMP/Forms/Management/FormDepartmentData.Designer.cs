namespace BCMP.Forms.Management
{
    partial class FormDepartmentData
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
            this.dgv_DepartmentData = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DepartmentData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DepartmentData
            // 
            this.dgv_DepartmentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DepartmentData.Location = new System.Drawing.Point(145, 100);
            this.dgv_DepartmentData.Name = "dgv_DepartmentData";
            this.dgv_DepartmentData.Size = new System.Drawing.Size(578, 150);
            this.dgv_DepartmentData.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "depart";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormDepartmentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_DepartmentData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDepartmentData";
            this.Text = "FormDepartmentData";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DepartmentData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DepartmentData;
        private System.Windows.Forms.Button button1;
    }
}