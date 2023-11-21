using BCMP.DAO;
using BCMP.DTO;
using BCMP.EventsHandler;
using BCMP.Service;
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

namespace BCMP.Forms.Management
{
    public partial class FormDetailProject : Form
    {
        private Project currentProject;

        private List<Mission> missionsList;

        private event EventHandler updateProject;

        public event EventHandler UpdateProject
        {
            add { updateProject += value; }
            remove { updateProject -= value; }
        }

        public Project CurrentProject { get => currentProject; set => currentProject = value; }

        public FormDetailProject(Project currentProject)
        {
            InitializeComponent();
            CurrentProject = currentProject;
            LoadCurrentProject();
            LoadDataListMission();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void bt_cancel_MouseLeave(object sender, EventArgs e)
        {
            bt_cancel.Font = new Font(bt_cancel.Font, System.Drawing.FontStyle.Regular);

        }

        private void bt_cancel_MouseEnter(object sender, EventArgs e)
        {
            bt_cancel.Font = new Font(bt_cancel.Font, System.Drawing.FontStyle.Underline);

        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            FormAddProject AddProjectForm = new FormAddProject(currentProject);
            AddProjectForm.UpdateProject += P_Detail_Update;
            AddProjectForm.Show();
        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
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

        public void LoadCurrentProject()
        {
            txt_IdProject.Text = currentProject.ProjectId.ToString();
            txt_nameProject.Text = currentProject.Name.ToString();
            txt_Description.Text = currentProject.Description.ToString();
            LoadDepartmentData();
            dtpkPlannedEnd.Text = currentProject.PlannedEndDate.ToString();
            dtpkPlannedStart.Text = currentProject.PlannedStartDate.ToString();
        }

        public void LoadDepartmentData()
        {
            List<String> list = new List<String>();
            foreach (Department item in DepartmentService.Instance.GetAllListDepartment())
            {
                list.Add(item.Name);
                if (item.DepartmentId.Equals(currentProject.DepartmentId))
                {
                    cbb_department.Text = item.Name;
                }
            }
            cbb_department.DataSource = list;
            cbb_department.Text = DepartmentDAO.Instance.GetDepartmentById(currentProject.DepartmentId).Name.ToString();
         
        }

        private void P_Detail_Update(object sender, EventArgs e)
        {
            currentProject = ProjectDAO.Instance.GetProjectById(currentProject.ProjectId);
            LoadCurrentProject();
            updateProject(this, new EventArgs());

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadDataListMission()
        {
            if(currentProject != null)
            {
                missionsList = MissionDAO.Instance.GetAllMissionsByProjectId(currentProject.ProjectId.ToString());
                dtgvMissionList.DataSource = missionsList;
            }
        }

        private void dtgvMissionList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvMissionList.Columns[e.ColumnIndex].Name == "Detail")
            {
                Mission mission = MissionDAO.Instance.GetMissionById(int.Parse(dtgvMissionList.Rows[e.RowIndex].Cells[1].Value.ToString()));
                if(mission != null)
                {
                    FormDetailMission DetailMissionForm = new FormDetailMission(mission);
                    DetailMissionForm.Show();
                }

            }
        }
    }
}
