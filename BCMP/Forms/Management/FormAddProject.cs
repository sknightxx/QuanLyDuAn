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
using System.Windows;
using System.Windows.Forms;
using System.Xml.Linq;
using MessageBox = System.Windows.Forms.MessageBox;

namespace BCMP.Forms
{
    public partial class FormAddProject : Form
    {
        public FormAddProject()
        {
            InitializeComponent();
            LoadDataDepartment();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_cancel_MouseEnter(object sender, EventArgs e)
        {
            bt_cancel.Font = new Font(bt_cancel.Font, System.Drawing.FontStyle.Underline);
        }

        private void bt_cancel_MouseLeave(object sender, EventArgs e)
        {
            bt_cancel.Font = new Font(bt_cancel.Font, System.Drawing.FontStyle.Regular);
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pn_containerAddProject_Paint(object sender, PaintEventArgs e)
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

        private void txt_IdProject_Leave(object sender, EventArgs e)
        {
            if (txt_IdProject.Text.ToString() == "")
            {
                lb_ValidIdProject.Visible = true;
                lb_ValidIdProject.Text = "Is empty";
                lb_ValidIdProject.ForeColor = Color.Red;
            }
            else
            {
                if (AuthService.Instance.ProjectIsExist(txt_IdProject.Text.ToString()))
                {
                    lb_ValidIdProject.Visible = true;
                    lb_ValidIdProject.Text = "This Identity is already exist";
                    lb_ValidIdProject.ForeColor = Color.Red;
                }
                else
                {
                    lb_ValidIdProject.Visible = true;
                    lb_ValidIdProject.Text = "Valid";
                    lb_ValidIdProject.ForeColor = Color.Green;
                }
            }
        }

        private void txt_IdProject_Enter(object sender, EventArgs e)
        {
            if (txt_IdProject.Text == "Enter ID project")
            {
                txt_IdProject.Text = "";
                txt_IdProject.Multiline = true;
                txt_IdProject.ForeColor = Color.Gray;
            }
        }

        

        

        private void txt_nameProject_Leave(object sender, EventArgs e)
        {
            if (txt_nameProject.Text.ToString() == "")
            {
                lb_ValidNameProject.Visible = true;
                lb_ValidNameProject.Text = "Is empty";
                lb_ValidNameProject.ForeColor = Color.Red;
            }
            else
            {
                lb_ValidNameProject.Visible = true;
                lb_ValidNameProject.Text = "Valid";
                lb_ValidNameProject.ForeColor = Color.Green;
            }
        }

        private void txt_nameProject_Enter(object sender, EventArgs e)
        {
            if (txt_nameProject.Text == "Enter name of project")
            {
                txt_nameProject.Text = "";
                txt_nameProject.ForeColor = Color.Gray;
            }
        }

        private void cbb_department_Leave(object sender, EventArgs e)
        {

        }

        private void txt_Description_Leave(object sender, EventArgs e)
        {
            if (txt_Description.Text.ToString() == "")
            {
                lb_ValidDesciption.Visible = true;
                lb_ValidDesciption.Text = "Is empty";
                lb_ValidDesciption.ForeColor = Color.Red;
            }
            else
            {
                lb_ValidDesciption.Visible = true;
                lb_ValidDesciption.Text = "Valid";
                lb_ValidDesciption.ForeColor = Color.Green;
            }
        }

        private void txt_Description_Enter(object sender, EventArgs e)
        {
            if (txt_Description.Text == "Enter desciption about project")
            {
                txt_Description.Text = "";
                txt_Description.ForeColor = Color.Gray;
            }
        }

        private void txt_IdProject_TextChanged(object sender, EventArgs e)
        {

        }

        public void DefaultState()
        {
            lb_ValidNameProject.Visible = false;
            lb_ValidIdProject.Visible = false;
            lb_ValidIdProject.Visible = false;

            txt_Description.Text = "";
            txt_nameProject.Text = "";
            txt_IdProject.Text = "";
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

        private void bt_save_Click(object sender, EventArgs e)
        {
            string projectid = txt_IdProject.Text.ToString();
            string name = txt_nameProject.Text.ToString();
            string description = txt_Description.Text.ToString();
            DateTime plannedStartDate = dtpkPlannedStart.Value;
            DateTime plannedEndDate = dtpkPlannedEnd.Value;
            int departmentId = 0;
            foreach (Department item in DepartmentService.Instance.GetAllListDepartment())
            {
                if (item.Name.Equals(cbb_department.SelectedItem.ToString()))
                {
                    departmentId = item.DepartmentId;
                }
            }
            if (lb_ValidNameProject.Text == "Valid" && lb_ValidDesciption.Text == "Valid" && lb_ValidIdProject.Text == "Valid")
            {
                if (ProjectService.Instance.InsertValidateProject(projectid, name, description, plannedStartDate, plannedEndDate, departmentId))
                {
                    MessageBox.Show("Add Project Successfully");
                    DefaultState();
                }
                else
                {
                    MessageBox.Show("Add Project Failed");
                }
            }
            else
            {
                MessageBox.Show("Inputs are missed");
            }
        }
    }


}

