using System;
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
        public Notifications(Employee currEmp)
        private bool isDragging = false;
        private Point lastLocation;
        public Notification()
        {
            InitializeComponent();
            this.currEmp = currEmp;
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
            if(currEmp != null)
            {
                myNotifyList = NotificationDAO.Instance.GetNotificationByUserId(currEmp.UserId.ToString());
                dtgv_MyNotification.DataSource = myNotifyList;
            }
        }

        private void dtgv_MyNotification_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_MyNotification.Columns[e.ColumnIndex].Name == "OpenMission")
            {
                Mission mission = MissionDAO.Instance.GetMissionById(int.Parse(dtgv_MyNotification.Rows[e.RowIndex].Cells[1].Value.ToString()));
                MessageBox.Show(mission.MissionId.ToString());
                if (mission != null)
                {
                    FormDetailMission DetailMissionForm = new FormDetailMission(mission);
                    DetailMissionForm.Show();
                }

            }
        }
    }
}
