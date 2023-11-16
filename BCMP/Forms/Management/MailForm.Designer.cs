namespace BCMP.Forms.Management
{
    partial class MailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailForm));
            this.pn_containerInformation = new System.Windows.Forms.Panel();
            this.lb_mail = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_exit = new FontAwesome.Sharp.IconButton();
            this.pn_containerInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_containerInformation
            // 
            resources.ApplyResources(this.pn_containerInformation, "pn_containerInformation");
            this.pn_containerInformation.Controls.Add(this.lb_mail);
            this.pn_containerInformation.Controls.Add(this.dataGridView1);
            this.pn_containerInformation.Controls.Add(this.bt_exit);
            this.pn_containerInformation.Name = "pn_containerInformation";
            this.pn_containerInformation.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_containerInformation_Paint);
            // 
            // lb_mail
            // 
            resources.ApplyResources(this.lb_mail, "lb_mail");
            this.lb_mail.Name = "lb_mail";
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            // 
            // bt_exit
            // 
            resources.ApplyResources(this.bt_exit, "bt_exit");
            this.bt_exit.BackColor = System.Drawing.Color.Transparent;
            this.bt_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_exit.FlatAppearance.BorderSize = 0;
            this.bt_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_exit.ForeColor = System.Drawing.Color.Transparent;
            this.bt_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.bt_exit.IconColor = System.Drawing.Color.Black;
            this.bt_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_exit.IconSize = 30;
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // MailForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_containerInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MailForm";
            this.pn_containerInformation.ResumeLayout(false);
            this.pn_containerInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_containerInformation;
        private System.Windows.Forms.Label lb_mail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton bt_exit;
    }
}