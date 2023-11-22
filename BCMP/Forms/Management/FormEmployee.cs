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
            empList = EmployeeDAO.Instance.GetAllEmployee();
            dtgv_ListEmp.DataSource = empList;
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
            if (AuthService.roleCur.Title == "Employee")
            {
            } else
            {
                FormAddUser AddUserForm = new FormAddUser(this);
                AddUserForm.Show();
            }
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
            try
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
            } catch
            {
                MessageBox.Show("aaa");
            }
        }
    }
}
