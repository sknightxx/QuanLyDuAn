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
    public partial class InformationForm : Form
    {
        private Employee currEmployee;
        private bool isDragging = false;
        private Point lastLocation;
        public InformationForm(Employee currEmployee)
        {
            InitializeComponent();
            this.currEmployee = EmployeeDAO.Instance.GetById(currEmployee.UserId);
            LoadDataCurrentEmployee();
        }

        private void InformationForm_Load(object sender, EventArgs e)
        {

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

        private void LoadDataCurrentEmployee()
        {
            txt_IdStaff.Text = currEmployee.UserId.ToString();
            txt_Email.Text = currEmployee.Email.ToString();
            txt_phone.Text = currEmployee.PhoneNumber.ToString();
            cbb_role.Text = RoleDAO.Instance.GetById(currEmployee.RoleId).Title.ToString();
            cbb_department.Text = DepartmentDAO.Instance.GetDepartmentById(currEmployee.DepartmentId).Name.ToString();
            txt_name.Text = currEmployee.FullName.ToString();
        }

        public void LoadDataDepartment()
        {
            List<String> list = new List<String>();
            foreach (Department item in DepartmentService.Instance.GetAllListDepartment())
            {
                list.Add(item.Name);
            }
            cbb_department.DataSource = list;
        }

        public void LoadDataRole()
        {
            List<String> list = new List<String>();
            foreach (Role item in RoleService.Instance.GetAllListRole())
            {
                list.Add(item.Title);
            }
            cbb_role.DataSource = list;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string email = txt_Email.Text;
            string phone = txt_phone.Text;

            if (EmployeeDAO.Instance.UpdateEmployeeByUserId(email, currEmployee.Password, phone, currEmployee.UserId, currEmployee.DepartmentId, currEmployee.RoleId, currEmployee.IsDeactivated, name, currEmployee.TypeEmployee))
            {
                MessageBox.Show("Update your infomation successfully");
                this.Close();
            } else
            {
                MessageBox.Show("Update your infomation failed");

            }
        }
    }
}
