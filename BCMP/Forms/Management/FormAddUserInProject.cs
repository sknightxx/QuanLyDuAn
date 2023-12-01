using BCMP.DAO;
using BCMP.DTO;
using BCMP.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCMP.Forms.Management
{
    public partial class FormAddUserInProject : Form
    {
        private int departmentSelectd = 0;
        private FormDetailProject f;
        private List<Employee> listEmp;
        private List<Department> listDepartment = DepartmentDAO.Instance.GetAllDepartment();
        public FormAddUserInProject(FormDetailProject F)
        {
            InitializeComponent();
            f = F;
            LoadDataEmployeeNotInProject();
            cb_Department.DataSource = listDepartment;
            cb_Department.DisplayMember = "Name";
        }

        public void LoadDataEmployeeNotInProject()
        {
            if(f.CurrentProject != null)
            {
                listEmp = EmployeeDAO.Instance.GetAllEmployeeNotInProject(f.CurrentProject.ProjectId,departmentSelectd);
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
                    int columnIndex = 8; // Cột thứ 3 (chỉ số cột bắt đầu từ 0)

                    // Kiểm tra xem ô có tồn tại không
                    if (row.Cells.Count > columnIndex)
                    {
                        // Thực hiện chỉnh sửa giá trị của ô
                        row.Cells[columnIndex].Value = DepartmentDAO.Instance.GetDepartmentById(int.Parse(row.Cells[7].Value.ToString())).Name;
                    }
                    row.Cells[4].Value = RoleDAO.Instance.GetById(int.Parse(row.Cells[3].Value.ToString())).Title;
                    if ((bool)row.Cells[5].Value) 
                    {
                        row.Cells[6].Value = "Internal";
                    } else
                    {
                        row.Cells[6].Value = "Outsourcing";
                    }
                    

                }
            }
        }

        private void bt_addInProject_Click(object sender, EventArgs e)
        {
            int count = 0;
            int target = dtgv_listEmp.SelectedRows.Count;
            if (dtgv_listEmp.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgv_listEmp.SelectedRows)
                {
                    Employee foundEmp = listEmp.Find(emp => emp.UserId == row.Cells[0].Value);
                    if(foundEmp != null)
                    {
                        if(MissionDAO.Instance.InsertEmployeeIntoProjectByMission("Added In Project", "In Project: " + f.CurrentProject.ProjectId, DateTime.Now, DateTime.Now, 1, f.CurrentProject.ProjectId, foundEmp.UserId))
                        {
                            count++;
                        }
                    }
                }

                if(count == target)
                {
                    MessageBox.Show("All Employe joined Successfully");
                    LoadDataEmployeeNotInProject();
                    f.LoadDataEmployeeInProject();
                    f.LoadDepartmentData();
                } else if (count < target && count > 0)
                {
                    MessageBox.Show("Some Employe didn't join Successfully");
                    LoadDataEmployeeNotInProject();
                    f.LoadDataEmployeeInProject();
                    f.LoadDepartmentData();


                }
                else
                {
                    MessageBox.Show("No Employe joined Successfully");

                }
            } else
            {
                MessageBox.Show("No employee selected");
            }
        }

        private void cb_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Department.Focus())
            {
                departmentSelectd = ((Department)cb_Department.SelectedItem).DepartmentId;
                LoadDataEmployeeNotInProject();
            }
        }

        private void bt_Default_Click(object sender, EventArgs e)
        {
            departmentSelectd = 0;
            LoadDataEmployeeNotInProject();
        }
    }
}
