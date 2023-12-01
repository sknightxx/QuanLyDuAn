namespace BCMP.Forms.Management
{
    partial class Notifications
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notifications));
            this.pn_containerInformation = new System.Windows.Forms.Panel();
            this.lb_Notification = new System.Windows.Forms.Label();
            this.dtgv_MyNotification = new System.Windows.Forms.DataGridView();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MissionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isReadDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.notificationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenMission = new System.Windows.Forms.DataGridViewButtonColumn();
            this.notificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bt_exit = new FontAwesome.Sharp.IconButton();
            this.pn_containerInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_MyNotification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_containerInformation
            // 
            resources.ApplyResources(this.pn_containerInformation, "pn_containerInformation");
            this.pn_containerInformation.Controls.Add(this.lb_Notification);
            this.pn_containerInformation.Controls.Add(this.dtgv_MyNotification);
            this.pn_containerInformation.Controls.Add(this.bt_exit);
            this.pn_containerInformation.Name = "pn_containerInformation";
            this.pn_containerInformation.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_containerInformation_Paint);
            // 
            // lb_Notification
            // 
            resources.ApplyResources(this.lb_Notification, "lb_Notification");
            this.lb_Notification.Name = "lb_Notification";
            // 
            // dtgv_MyNotification
            // 
            resources.ApplyResources(this.dtgv_MyNotification, "dtgv_MyNotification");
            this.dtgv_MyNotification.AutoGenerateColumns = false;
            this.dtgv_MyNotification.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgv_MyNotification.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_MyNotification.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgv_MyNotification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_MyNotification.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn,
            this.MissionId,
            this.titleDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.isReadDataGridViewCheckBoxColumn,
            this.notificationIdDataGridViewTextBoxColumn,
            this.OpenMission});
            this.dtgv_MyNotification.DataSource = this.notificationBindingSource;
            this.dtgv_MyNotification.Name = "dtgv_MyNotification";
            this.dtgv_MyNotification.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_MyNotification_CellContentClick);
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            resources.ApplyResources(this.descriptionDataGridViewTextBoxColumn, "descriptionDataGridViewTextBoxColumn");
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // MissionId
            // 
            this.MissionId.DataPropertyName = "MissionId";
            resources.ApplyResources(this.MissionId, "MissionId");
            this.MissionId.Name = "MissionId";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            resources.ApplyResources(this.titleDataGridViewTextBoxColumn, "titleDataGridViewTextBoxColumn");
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            resources.ApplyResources(this.createDateDataGridViewTextBoxColumn, "createDateDataGridViewTextBoxColumn");
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            // 
            // isReadDataGridViewCheckBoxColumn
            // 
            this.isReadDataGridViewCheckBoxColumn.DataPropertyName = "IsRead";
            resources.ApplyResources(this.isReadDataGridViewCheckBoxColumn, "isReadDataGridViewCheckBoxColumn");
            this.isReadDataGridViewCheckBoxColumn.Name = "isReadDataGridViewCheckBoxColumn";
            // 
            // notificationIdDataGridViewTextBoxColumn
            // 
            this.notificationIdDataGridViewTextBoxColumn.DataPropertyName = "NotificationId";
            resources.ApplyResources(this.notificationIdDataGridViewTextBoxColumn, "notificationIdDataGridViewTextBoxColumn");
            this.notificationIdDataGridViewTextBoxColumn.Name = "notificationIdDataGridViewTextBoxColumn";
            // 
            // OpenMission
            // 
            this.OpenMission.DataPropertyName = "OpenMission";
            resources.ApplyResources(this.OpenMission, "OpenMission");
            this.OpenMission.Name = "OpenMission";
            this.OpenMission.Text = "OpenMission";
            // 
            // notificationBindingSource
            // 
            this.notificationBindingSource.DataSource = typeof(BCMP.DTO.Notification);
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
            // Notifications
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_containerInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notifications";
            this.pn_containerInformation.ResumeLayout(false);
            this.pn_containerInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_MyNotification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_containerInformation;
        private FontAwesome.Sharp.IconButton bt_exit;
        private System.Windows.Forms.DataGridView dtgv_MyNotification;
        private System.Windows.Forms.Label lb_Notification;
        private System.Windows.Forms.BindingSource notificationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MissionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isReadDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notificationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn OpenMission;
    }
}