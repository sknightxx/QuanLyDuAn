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
using BCMP.DAO;
using BCMP.Forms.Management;
using BCMP.Service;
using BCMP.DTO;

namespace BCMP.Forms
{
    public partial class FormProject : Form
    {
        private static List<Project> proList;
        private Employee currEmployee = AuthService.Instance.GetCurrentEmployee();
        public FormProject()
        {
            InitializeComponent();
            if(currEmployee.RoleId != 1 && currEmployee.RoleId != 2)
            {
                proList = ProjectDAO.Instance.GetProjectByUserId(currEmployee.UserId);
                bt_CreateProject.Visible = false;
            } else
            {
                proList = ProjectDAO.Instance.GetAllProject();
            }
            LoadProjectList();
        }

        private void bt_CreateProject_Click(object sender, EventArgs e)
        {
            FormAddProject AddProjectForm = new FormAddProject();
            AddProjectForm.InsertProject += P_InsertProject;
            AddProjectForm.Show();
        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                txt_search.Text = "Search for project";
                txt_search.Multiline = true;
                txt_search.ForeColor = Color.Gray;
            }
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            if (txt_search.Text == "Search for project")
            {
                txt_search.Text = "";
                txt_search.Multiline = true;
                txt_search.ForeColor = Color.Black;
            }
        }

        private void txt_search_Move(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                txt_search.Text = "Search for project";
                txt_search.Multiline = true;
                txt_search.ForeColor = Color.Gray;
            }
        }

        private void FormProject_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 5; // Độ cong của góc (có thể điều chỉnh)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void LoadProjectList()
        {
            dtgv_Project.DataSource = proList;
        }

        private void dtgv_Project_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_Project.Columns[e.ColumnIndex].Name == "Detail")
            {
                Project currProject = ProjectDAO.Instance.GetProjectById(dtgv_Project.Rows[e.RowIndex].Cells[0].Value.ToString());
                FormDetailProject DetailProjectForm = new FormDetailProject(currProject);
                DetailProjectForm.UpdateProject += P_UpdateProject;
                DetailProjectForm.Show();
            }
        }

        private void P_InsertProject(object sender, EventArgs e)
        {
            proList = ProjectDAO.Instance.GetAllProject();
            LoadProjectList();
        }

        private void P_UpdateProject(object sender, EventArgs e)
        {
            proList = ProjectDAO.Instance.GetAllProject();
            LoadProjectList();
        }

        private void pn_tittle_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
