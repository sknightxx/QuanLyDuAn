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

namespace BCMP.Forms
{
    public partial class FormAddProject : Form
    {
        public FormAddProject()
        {
            InitializeComponent();
            LoadDataDepartment();
        }

        private void FormAddProject_Paint(object sender, PaintEventArgs e)
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_cancel_MouseEnter(object sender, EventArgs e)
        {
            bt_cancel.Font = new Font(bt_cancel.Font, FontStyle.Underline);
        }

        private void bt_cancel_MouseLeave(object sender, EventArgs e)
        {
            bt_cancel.Font = new Font(bt_cancel.Font, FontStyle.Regular);
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadDataDepartment()
        {
            List<String> list = new List<String>();
            foreach (Department item in DepartmentService.Instance.GetAllListDepartment())
            {
                list.Add(item.Name);
            }
            cb_department.DataSource = list;
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            string projectid = txt_projectId.Text.ToString();
            string name = txt_nameProject.Text.ToString();
            string description = txt_Description.Text.ToString();
            DateTime plannedStartDate = dtpkPlannedStart.Value;
            DateTime plannedEndDate = dtpkPlannedEnd.Value;
            int departmentId = 0;
            foreach (Department item in DepartmentService.Instance.GetAllListDepartment())
            {
                if (item.Name.Equals(cb_department.SelectedItem.ToString()))
                {
                    departmentId = item.DepartmentId;
                }
            }
            if (lbname.Text == "Valid" && lbdescription.Text =="Valid" && lbid.Text == "Valid")
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

        private void txt_nameProject_Leave(object sender, EventArgs e)
        {
            if(txt_nameProject.Text.ToString() == "")
            {
                lbname.Visible = true;
                lbname.Text = "Is empty";
                lbname.ForeColor = Color.Red;
            } else
            {
                lbname.Visible = true;
                lbname.Text = "Valid";
                lbname.ForeColor = Color.Green;
            }
        }

        private void txt_projectId_Leave(object sender, EventArgs e)
        {
            if (txt_projectId.Text.ToString() == "")
            {
                lbid.Visible = true;
                lbid.Text = "Is empty";
                lbid.ForeColor = Color.Red;
            } else
            {
                if (AuthService.Instance.ProjectIsExist(txt_projectId.Text.ToString()))
                {
                    lbid.Visible = true;
                    lbid.Text = "This Identity is already exist";
                    lbid.ForeColor = Color.Red;
                } else
                {
                    lbid.Visible = true;
                    lbid.Text = "Valid";
                    lbid.ForeColor = Color.Green;
                }
            }
        }

        private void txt_Description_Leave(object sender, EventArgs e)
        {
            if(txt_Description.Text.ToString() == "")
            {
                lbdescription.Visible = true;
                lbdescription.Text = "Is empty";
                lbdescription.ForeColor = Color.Red;
            } else
            {
                lbdescription.Visible = true;
                lbdescription.Text = "Valid";
                lbdescription.ForeColor = Color.Green;
            }
        }


        public void DefaultState()
        {
            lbname.Visible = false;
            lbdescription.Visible = false;
            lbid.Visible = false;

            txt_Description.Text = "";
            txt_nameProject.Text = "";
            txt_projectId.Text = "";
        }
    }
}

