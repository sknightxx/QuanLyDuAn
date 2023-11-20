using BCMP.DAO;
using BCMP.DTO;
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

        public Project CurrentProject { get => currentProject; set => currentProject = value; }

        public FormDetailProject(Project currentProject)
        {
            InitializeComponent();
            CurrentProject = currentProject;
            LoadCurrentProject();
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
            FormAddProject AddProjectForm = new FormAddProject();
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
        }
    }
}
