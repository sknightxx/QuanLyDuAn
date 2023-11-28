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

        private int departmentSelectd = 0;

        private Notifications f;

        private List<Employee> listEmp;
        private List<Department> listDepartment;

        private List<Mission> missionsList;

        private event EventHandler updateProject;

        public event EventHandler UpdateProject
        {
            add { updateProject += value; }
            remove { updateProject -= value; }
        }

        public Project CurrentProject { get => currentProject; set => currentProject = value; }

        public FormDetailProject(Project currentProject, Notifications F)
        {
            InitializeComponent();
            CurrentProject = currentProject;
            LoadCurrentProject();
            LoadDataListMission();
            LoadListDepartment();

            this.f = F;
            if (f.CurrEmp.RoleId == 4)
            {
                bt_CreateEmployee.Visible = false;
                bt_CreateMission.Visible = false;
                bt_save.Visible = false;
            }
            cb_Department.DataSource = listDepartment;
            LoadDataEmployeeInProject();
        }

        public FormDetailProject(Project currentProject)
        {
            InitializeComponent();
            CurrentProject = currentProject;
            LoadCurrentProject();
            LoadDataListMission();
            LoadListDepartment();
            LoadDataEmployeeInProject();
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

        public void LoadDataListMission()
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
                    FormDetailMission DetailMissionForm = new FormDetailMission(mission,this);
                    DetailMissionForm.Show();
                }

            }
        }

        private void bt_CreateMission_Click(object sender, EventArgs e)
        {
            FormAddMission formAddMission = new FormAddMission(this);
            formAddMission.Show();
        }

        private void bt_CreateEmployee_Click(object sender, EventArgs e)
        {
            FormAddUserInProject formAddUserInProject = new FormAddUserInProject(this);
            formAddUserInProject.Show();
        }

        public void LoadDataEmployeeInProject()
        {
            if (CurrentProject != null)
            {
                listEmp = EmployeeDAO.Instance.GetAllEmployeeInProject(CurrentProject.ProjectId, departmentSelectd);
                dtgv_listEmp.DataSource = listEmp;
            }
        }

        private void dtgv_listEmp_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dtgv_listEmp.Rows.Count > 0)
            {
                // Vòng lặp qua tất cả các dòng
                foreach (DataGridViewRow row in dtgv_listEmp.Rows)
                {
                    // Xác định chỉ mục của cột thứ 3
                    int columnIndex = 9; // Cột thứ 3 (chỉ số cột bắt đầu từ 0)

                    // Kiểm tra xem ô có tồn tại không
                    if (row.Cells.Count > columnIndex)
                    {
                        // Thực hiện chỉnh sửa giá trị của ô
                        row.Cells[columnIndex].Value = DepartmentDAO.Instance.GetDepartmentById(int.Parse(row.Cells[8].Value.ToString())).Name;
                    }
                    row.Cells[5].Value = RoleDAO.Instance.GetById(int.Parse(row.Cells[4].Value.ToString())).Title;
                    if ((bool)row.Cells[6].Value)
                    {
                        row.Cells[7].Value = "Internal";
                    }
                    else
                    {
                        row.Cells[7].Value = "Outsourcing";
                    }


                }
            }
        }

        private void cb_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Department.Focus())
            {
                departmentSelectd = ((Department)cb_Department.SelectedItem).DepartmentId;
                LoadDataEmployeeInProject();
            }
        }

        private void bt_default_Click(object sender, EventArgs e)
        {
            departmentSelectd = 0;
            LoadDataEmployeeInProject();
        }

        private void LoadListDepartment()
        {
            listDepartment = DepartmentDAO.Instance.GetAllDepartmentInProject(CurrentProject.ProjectId);
            cb_Department.DataSource = listDepartment;
            cb_Department.DisplayMember = "Name";
        }
    }
}
