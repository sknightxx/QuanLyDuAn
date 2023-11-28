using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;
using BCMP.DTO;
using BCMP.DAO;
using BCMP.Service;

using FontAwesome.Sharp;
using BCMP.Forms.Management;

namespace BCMP.Forms
{
    public partial class FormEmployee : Form
    {

        private List<Employee> empList = EmployeeDAO.Instance.GetAllEmployee();
        public FormEmployee()
        {
            InitializeComponent();
            LoadDataListEmloyee();
        }

        public void LoadDataListEmloyee()
        {
            if (txt_search.Text == "Search for employees" || String.IsNullOrEmpty(txt_search.Text.ToString()))
            {
                empList = EmployeeDAO.Instance.GetAllEmployee();
                dtgv_ListEmp.DataSource = empList;
            } else
            {
                empList = EmployeeDAO.Instance.GetAllEmployeeBySearch(txt_search.Text);
                dtgv_ListEmp.DataSource = empList;
            }
        }



        private void lb_employees_TextChanged(object sender, EventArgs e)
        {
        }

   
        private void bt_addUser_Click(object sender, EventArgs e)
        {
            FormAddUser AddUserForm = new FormAddUser(this);
            AddUserForm.InsertEmployee += E_InsertEmployee;
            AddUserForm.Show();
            
        }

        

        private void txt_search_Leave(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                txt_search.Text = "Search for employees";
                txt_search.Multiline = true;
                txt_search.ForeColor = Color.Gray;
            }
            
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            if (txt_search.Text == "Search for employees")
            {
                txt_search.Text = "";
                txt_search.Multiline = true;
                txt_search.ForeColor = Color.Black;
            }
            
        }

        private void bt_Create_Click(object sender, EventArgs e)
        {
            FormAddUser AddUserForm = new FormAddUser(this);
            AddUserForm.Show();
        }

        private void E_InsertEmployee(object sender, EventArgs e)
        {
            empList = EmployeeDAO.Instance.GetAllEmployee();
            LoadDataListEmloyee();
        }

        private void E_UpdateEmployee(object sender, EventArgs e)
        {
            empList = EmployeeDAO.Instance.GetAllEmployee();
            LoadDataListEmloyee();
        }

        private void dtgv_ListEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_ListEmp.Columns[e.ColumnIndex].Name == "Edit")
            {
                Employee currEmployee = EmployeeDAO.Instance.GetById(dtgv_ListEmp.Rows[e.RowIndex].Cells[0].Value.ToString());
                FormAddUser formAddUser = new FormAddUser(currEmployee);
                formAddUser.UpdateEmployee += E_UpdateEmployee;
                formAddUser.Show();
            } else if (dtgv_ListEmp.Columns[e.ColumnIndex].Name == "IsDeactivated")
            {
                bool isDeactivated = (bool)dtgv_ListEmp.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                // Now you can use 'isDeactivated' to perform any actions based on whether it's checked or not
                if(EmployeeService.Instance.UpdateIsDeactivatedEmployeeByManager(dtgv_ListEmp.Rows[e.RowIndex].Cells[0].Value.ToString(), isDeactivated))
                {
                    empList = EmployeeDAO.Instance.GetAllEmployee();
                }
            }
        }

        private void dtgv_ListEmp_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dtgv_ListEmp.Rows.Count > 0)
            {
                // Vòng lặp qua tất cả các dòng
                foreach (DataGridViewRow row in dtgv_ListEmp.Rows)
                {
                    // Xác định chỉ mục của cột thứ 3
                    int columnIndex = 3; // Cột thứ 3 (chỉ số cột bắt đầu từ 0)

                    // Kiểm tra xem ô có tồn tại không
                    if (row.Cells.Count > columnIndex)
                    {
                        // Thực hiện chỉnh sửa giá trị của ô
                        row.Cells[columnIndex].Value = DepartmentDAO.Instance.GetDepartmentById(int.Parse(row.Cells[2].Value.ToString())).Name;
                    }
                    row.Cells[5].Value = RoleDAO.Instance.GetById(int.Parse(row.Cells[4].Value.ToString())).Title;
                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text == "Search for employees" || String.IsNullOrEmpty(txt_search.Text.ToString()))
            {
                
                LoadDataListEmloyee();
            } else
            {
                empList = EmployeeDAO.Instance.GetAllEmployeeBySearch(txt_search.Text);
                dtgv_ListEmp.DataSource = empList;
            }
        }
    }
}
