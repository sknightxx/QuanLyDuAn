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
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCMP.Forms
{
    public partial class FormAddUser : Form
    {


        private Employee currEmployee;

        private event EventHandler insertEmployee;
        public event EventHandler InsertEmployee
        {
            add { insertEmployee += value; }
            remove { insertEmployee -= value; }
        }

        private event EventHandler updateEmployee;

        public event EventHandler UpdateEmployee
        {
            add { updateEmployee += value; }
            remove { updateEmployee -= value; }
        }
        public FormAddUser()
        {
            InitializeComponent();
            LoadDataDepartment();
            LoadDataRole();
            currEmployee = null;
        }

        public FormAddUser(Employee currEmployee)
        {
            InitializeComponent();
            LoadDataDepartment();
            LoadDataRole();
            this.currEmployee = currEmployee;
            LoadDataCurrentEmployee();
        }

        private void LoadDataCurrentEmployee()
        {
            txt_confirmPassword.Enabled = false;
            txt_IdStaff.Enabled = false;
            txt_IdStaff.Text = currEmployee.UserId.ToString();
            txt_password.Text = currEmployee.Password.ToString();
            txt_Email.Text = currEmployee.Email.ToString();
            txt_phone.Text = currEmployee.PhoneNumber.ToString();
            cb_Role.Text = RoleDAO.Instance.GetById(currEmployee.RoleId).Title.ToString();
            cb_Department.Text = DepartmentDAO.Instance.GetDepartmentById(currEmployee.DepartmentId).Name.ToString();
            txt_Email_Leave(this, new EventArgs());
            txt_phone_Leave(this, new EventArgs());
            txt_password_Leave(this, new EventArgs());


        }


        private void bt_cancelAddUser_MouseEnter(object sender, EventArgs e)
        {
            bt_cancelAddUser.Font = new Font(bt_cancelAddUser.Font, FontStyle.Underline);

        }

        private void bt_cancelAddUser_MouseLeave(object sender, EventArgs e)
        {
            bt_cancelAddUser.Font = new Font(bt_cancelAddUser.Font, FontStyle.Regular);

        }

        private void pn_containerFormAddUser_Paint(object sender, PaintEventArgs e)
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

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        #region Check Validated Employee Input

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            if (txt_Email.Text.ToString() == "")
            {
                lb_ValidEmail.Visible = true;
                lb_ValidEmail.Text = "Is empty";
                lb_ValidEmail.ForeColor = Color.Red;
            }
            else
            {
                if (EmployeeService.Instance.EmailValidate(txt_Email.Text.ToString()))
                {
                    lb_ValidEmail.Visible = true;
                    lb_ValidEmail.Text = "Valid";
                    lb_ValidEmail.ForeColor = Color.Green;
                }
                else
                {
                    lb_ValidEmail.Visible = true;
                    lb_ValidEmail.Text = "Email is invalid";
                    lb_ValidEmail.ForeColor = Color.Red;
                }
            }
        }
        private void txt_phone_Leave(object sender, EventArgs e)
        {
            if (txt_phone.Text.ToString() == "")
            {
                lb_ValidPhone.Visible = true;
                lb_ValidPhone.Text = "Is empty";
                lb_ValidPhone.ForeColor = Color.Red;
            }
            else
            {
                if (txt_phone.Text.Length > 9 && txt_phone.Text.Length < 12)
                {
                    lb_ValidPhone.Visible = true;
                    lb_ValidPhone.Text = "Valid";
                    lb_ValidPhone.ForeColor = Color.Green;
                }
                else
                {
                    lb_ValidPhone.Visible = true;
                    lb_ValidPhone.Text = "Length of phone is required at least 10";
                    lb_ValidPhone.ForeColor = Color.Red;
                }
            }
        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
            if (txt_phone.Text.Length > 11)
            {
                txt_phone.Text = txt_phone.Text.Substring(0, 11);
                txt_phone.SelectionStart = txt_phone.Text.Length;// Giới hạn độ dài là 11 ký tự
            }
            else
            {
                string input = txt_phone.Text;
                string numericOnly = new string(input.Where(char.IsDigit).ToArray()); // Chỉ cho phép nhập số

                if (numericOnly != input)
                {
                    txt_phone.Text = numericOnly;
                }
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text.ToString() == "")
            {
                lb_ValidPassword.Visible = true;
                lb_ValidPassword.Text = "Is empty";
                lb_ValidPassword.ForeColor = Color.Red;
            }
            else
            {
                if (txt_password.Text.Length > 7)
                {
                    lb_ValidPassword.Visible = true;
                    lb_ValidPassword.Text = "Valid";
                    lb_ValidPassword.ForeColor = Color.Green;
                }
                else
                {
                    lb_ValidPassword.Visible = true;
                    lb_ValidPassword.Text = "Length at least 8";
                    lb_ValidPassword.ForeColor = Color.Red;
                }
            }
        }

        private void txt_checkpassword_Leave(object sender, EventArgs e)
        {
            if (txt_confirmPassword.Text.ToString() == "")
            {
                lb_ValidConfirm.Visible = true;
                lb_ValidConfirm.Text = "Is empty";
                lb_ValidConfirm.ForeColor = Color.Red;
            }
            else
            {
                if (txt_confirmPassword.Text.ToString().Equals(txt_password.Text.ToString()))
                {
                    lb_ValidConfirm.Visible = true;
                    lb_ValidConfirm.Text = "Valid";
                    lb_ValidConfirm.ForeColor = Color.Green;
                }
                else
                {
                    lb_ValidConfirm.Visible = true;
                    lb_ValidConfirm.Text = "The confirm password is not correct";
                    lb_ValidConfirm.ForeColor = Color.Red;
                }
            }
        }

        private void txt_IdStaff_TextChanged(object sender, EventArgs e)
        {
            string username = txt_IdStaff.Text;

            // Kiểm tra độ dài tên người dùng
            if (username.Length > 15)
            {
                txt_IdStaff.Text = username.Substring(0, username.Length - 1);
                txt_IdStaff.SelectionStart = txt_IdStaff.Text.Length;
            }
            else if (!Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$"))
            {
                txt_IdStaff.Text = Regex.Replace(username, @"[^a-zA-Z0-9_]", "");
                txt_IdStaff.SelectionStart = txt_IdStaff.Text.Length;
            }
        }

        private void txt_IdStaff_Leave(object sender, EventArgs e)
        {
            if (txt_IdStaff.Text.ToString() == "")
            {
                lb_Valid_UserId.Visible = true;
                lb_Valid_UserId.Text = "Is empty";
                lb_Valid_UserId.ForeColor = Color.Red;
            }
            else
            {
                if (AuthService.Instance.EmployeeIsExist(txt_IdStaff.Text.ToString()))
                {
                    lb_Valid_UserId.Visible = true;
                    lb_Valid_UserId.Text = "User id is already exist";
                    lb_Valid_UserId.ForeColor = Color.Red;
                }
                else
                {
                    lb_Valid_UserId.Visible = true;
                    lb_Valid_UserId.Text = "Valid";
                    lb_Valid_UserId.ForeColor = Color.Green;
                }
            }
        }

        private void txt_name_Leave(object sender, EventArgs e)
        {
            if (txt_name.Text.ToString() == "")
            {
                lb_ValidFullname.Visible = true;
                lb_ValidFullname.Text = "Is empty";
                lb_ValidFullname.ForeColor = Color.Red;
            }
            else
            {
                lb_ValidFullname.Visible = true;
                lb_ValidFullname.Text = "Valid";
                lb_ValidFullname.ForeColor = Color.Green;
            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            string input = txt_name.Text;


            // Kiểm tra ký tự đặc biệt hoặc số
            if (Regex.IsMatch(input, @"[^a-zA-Z\s]|\d"))
            {
                // Nếu chứa ký tự đặc biệt hoặc số, xóa ký tự cuối cùng
                txt_name.Text = input.Substring(0, input.Length - 1);
                txt_name.SelectionStart = txt_name.Text.Length; // Di chuyển con trỏ đến cuối TextBox
            }
        }
        #endregion

        public void LoadDataDepartment()
        {
            List<String> list = new List<String>();
            foreach (Department item in DepartmentService.Instance.GetAllListDepartment())
            {
                list.Add(item.Name);
            }
            cb_Department.DataSource = list;
        }

        public void LoadDataRole()
        {
            List<String> list = new List<String>();
            foreach (Role item in RoleService.Instance.GetAllListRole())
            {
                list.Add(item.Title);
            }
            cb_Role.DataSource = list;
        }

        

        private void bt_save_Click(object sender, EventArgs e)
        {
            if(currEmployee == null)
            {
                AddNewUser();
            }
            else
            {
                EditCurrentUser();
            }
        }

        private void AddNewUser()
        {
            if (lb_Valid_UserId.Text == "Valid" && lb_ValidFullname.Text == "Valid" &&
                lb_ValidPassword.Text == "Valid" &&
                lb_ValidEmail.Text == "Valid" && lb_ValidPhone.Text == "Valid")
            {
                String userid = txt_IdStaff.Text.ToString();
                String password = txt_password.Text.ToString();
                String email = txt_Email.Text.ToString();
                String name = txt_name.Text.ToString();
                String phone = txt_phone.Text.ToString();
                int departmentid = 0;
                int roleid = 0;
                foreach (Department item in DepartmentService.Instance.GetAllListDepartment())
                {
                    if (item.Name.Equals(cb_Department.SelectedItem.ToString()))
                    {
                        departmentid = item.DepartmentId;
                    }
                }

                foreach (Role item in RoleService.Instance.GetAllListRole())
                {
                    if (item.Title.Equals(cb_Role.SelectedItem.ToString()))
                    {
                        roleid = item.RoleId;
                    }
                }
                if (EmployeeService.Instance.InsertEmployeeVaildate(email, password, phone, userid, departmentid, roleid))
                {
                    MessageBox.Show("Add employee successfully");
                    updateEmployee(this, new EventArgs());
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Add employee failed");
                }
            }
            else
            {
                MessageBox.Show("Inputs are missed");
            }
        }

        private void EditCurrentUser()
        {
            if (lb_ValidFullname.Text == "Valid" &&
                lb_ValidPassword.Text == "Valid" &&
                lb_ValidEmail.Text == "Valid" && lb_ValidPhone.Text == "Valid")
            {
                String userid = txt_IdStaff.Text.ToString();
                String password = txt_password.Text.ToString();
                String email = txt_Email.Text.ToString();
                String name = txt_name.Text.ToString();
                String phone = txt_phone.Text.ToString();
                int departmentid = 0;
                int roleid = 0;
                foreach (Department item in DepartmentService.Instance.GetAllListDepartment())
                {
                    if (item.Name.Equals(cb_Department.SelectedItem.ToString()))
                    {
                        departmentid = item.DepartmentId;
                    }
                }

                foreach (Role item in RoleService.Instance.GetAllListRole())
                {
                    if (item.Title.Equals(cb_Role.SelectedItem.ToString()))
                    {
                        roleid = item.RoleId;
                    }
                }
                if (EmployeeService.Instance.UpdateEmployeeByManager(email, password, phone, userid, departmentid, roleid,currEmployee.IsDeactivated))
                {
                    MessageBox.Show("Update employee successfully");
                    updateEmployee(this, new EventArgs());
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update employee failed");
                }
            }
            else
            {
                MessageBox.Show("Inputs are missed");
            }
        }
    }
}
