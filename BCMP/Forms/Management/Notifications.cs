﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCMP.DTO;
using BCMP.DAO;

namespace BCMP.Forms.Management
{
    public partial class Notifications : Form
    {
        private List<Notification> myNotifyList;
        private Employee currEmp;
        
        private bool isDragging = false;
        private Point lastLocation;

        public Employee CurrEmp { get => currEmp; set => currEmp = value; }

        public Notifications(Employee currEmp)
        {
            InitializeComponent();
            this.CurrEmp = currEmp;
            LoadDataNotification();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pn_containerInformation_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 10; // Độ cong của góc (có thể điều chỉnh)
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
            GraphicsPath path = new GraphicsPath();

            // Vẽ góc bo tròn
            path.AddArc(bounds.Left, bounds.Top, borderRadius * 2, borderRadius * 2, 180, 90);
            path.AddArc(bounds.Right - borderRadius * 2, bounds.Top, borderRadius * 2, borderRadius * 2, 270, 90);
            path.AddArc(bounds.Right - borderRadius * 2, bounds.Bottom - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);
            base.OnPaintBackground(e);
        }

       

        private void pn_containerInformation_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;

        }

        private void pn_containerInformation_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void pn_containerInformation_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
        }

        private void LoadDataNotification()
        {
            if(CurrEmp != null)
            {
                myNotifyList = NotificationDAO.Instance.GetNotificationByUserId(CurrEmp.UserId.ToString());
                dtgv_MyNotification.DataSource = myNotifyList;
            }
        }

        private void dtgv_MyNotification_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_MyNotification.Columns[e.ColumnIndex].Name == "OpenMission")
            {
                int missionId = -1;
                Mission mission = MissionDAO.Instance.GetMissionById(int.Parse(dtgv_MyNotification.Rows[e.RowIndex].Cells[1].Value.ToString()));
                missionId = int.Parse(dtgv_MyNotification.Rows[e.RowIndex].Cells[1].Value.ToString());
                if(mission == null && missionId > 0)
                {
                    FormDetailProject DetailProjectForm = new FormDetailProject(ProjectDAO.Instance.GetProjectByMissionId(missionId),this);
                    DetailProjectForm.Show();
                } else
                {
                    FormDetailMission DetailMissionForm = new FormDetailMission(mission);
                    DetailMissionForm.Show();
                }

            }
        }
    }
}
