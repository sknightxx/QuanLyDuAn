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
        public FormAddUser()
        {
            InitializeComponent();
            LoadDataDepartment();
            LoadDataRole();
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
        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
           /* if (txt_Email.Text.ToString() == "")
            {
                lbemail.Visible = true;
                lbemail.Text = "Is empty";
                lbemail.ForeColor = Color.Red;
            }
            else
            {
                if (EmployeeService.Instance.EmailValidate(txt_Email.Text.ToString()))
                {
                    lbemail.Visible = true;
                    lbemail.Text = "Valid";
                    lbemail.ForeColor = Color.Green;
                }
                else
                {
                    lbemail.Visible = true;
                    lbemail.Text = "Email is invalid";
                    lbemail.ForeColor = Color.Red;
                }
            }*/
        }
        private void txt_phone_Leave(object sender, EventArgs e)
        {
            /*if (txt_phone.Text.ToString() == "")
            {
                lbphone.Visible = true;
                lbphone.Text = "Is empty";
                lbphone.ForeColor = Color.Red;
            } else
            {
                if(txt_phone.Text.Length > 9 && txt_phone.Text.Length <12)
                {
                    lbphone.Visible = true;
                    lbphone.Text = "Valid";
                    lbphone.ForeColor = Color.Green;
                } else
                {
                    lbphone.Visible = true;
                    lbphone.Text = "Length of phone is required at least 10";
                    lbphone.ForeColor = Color.Red;
                }
            }*/
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
            /*if (txt_password.Text.ToString() == "")
            {
                lbpassword.Visible = true;
                lbpassword.Text = "Is empty";
                lbpassword.ForeColor = Color.Red;
            }
            else
            {
                if (txt_password.Text.Length > 7)
                {
                    lbpassword.Visible = true;
                    lbpassword.Text = "Valid";
                    lbpassword.ForeColor = Color.Green;
                }
                else
                {
                    lbpassword.Visible = true;
                    lbpassword.Text = "Length at least 8";
                    lbpassword.ForeColor = Color.Red;
                }
            }*/
        }

        private void txt_checkpassword_Leave(object sender, EventArgs e)
        {
            /*if (txt_checkpassword.Text.ToString() == "")
            {
                lbcheckpassword.Visible = true;
                lbcheckpassword.Text = "Is empty";
                lbcheckpassword.ForeColor = Color.Red;
            }
            else
            {
                if (txt_checkpassword.Text.ToString().Equals(txt_password.Text.ToString()))
                {
                    lbcheckpassword.Visible = true;
                    lbcheckpassword.Text = "Valid";
                    lbcheckpassword.ForeColor = Color.Green;
                }
                else
                {
                    lbcheckpassword.Visible = true;
                    lbcheckpassword.Text = "The confirm password is not correct";
                    lbcheckpassword.ForeColor = Color.Red;
                }
            }*/
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
            /*if (txt_IdStaff.Text.ToString() == "")
            {
                lbuserid.Visible = true;
                lbuserid.Text = "Is empty";
                lbuserid.ForeColor = Color.Red;
            }
            else
            {
                if (AuthService.Instance.EmployeeIsExist(txt_IdStaff.Text.ToString()))
                {
                    lbuserid.Visible = true;
                    lbuserid.Text = "User id is already exist";
                    lbuserid.ForeColor = Color.Red;
                }
                else
                {
                    lbuserid.Visible = true;
                    lbuserid.Text = "Valid";
                    lbuserid.ForeColor = Color.Green;
                }
            }*/
        }

        private void txt_name_Leave(object sender, EventArgs e)
        {
            /*if (txt_name.Text.ToString() == "")
            {
                lbname.Visible = true;
                lbname.Text = "Is empty";
                lbname.ForeColor = Color.Red;
            }
            else
            {
                lbname.Visible = true;
                lbname.Text = "Valid";
                lbname.ForeColor = Color.Green;
            }*/
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
            /*List<String> list = new List<String>();
            foreach(Department item in DepartmentService.Instance.GetAllListDepartment())
            {
                list.Add(item.Name);
            }
            cb_department.DataSource = list;*/
        }

        public void LoadDataRole()
        {
            /*List<String> list = new List<String>();
            foreach(Role item in RoleService.Instance.GetAllListRole())
            {
                list.Add(item.Title);
            }
            cb_role.DataSource = list;*/
        }

        

        private void bt_save_Click(object sender, EventArgs e)
        {
            /*if(lbuserid.Text == "Valid" && lbname.Text == "Valid" &&
                lbpassword.Text == "Valid" && lbcheckpassword.Text == "Valid" &&
                lbemail.Text == "Valid")
            {
                String userid = txt_IdStaff.Text.ToString();
                String password = txt_password.Text.ToString();
                String email = txt_Email.Text.ToString();
                String name = txt_name.Text.ToString();
                String phone = txt_phone.Text.ToString();
                int departmentid = 0;
                int roleid = 0;
                foreach(Department item in DepartmentService.Instance.GetAllListDepartment())
                {
                    if (item.Name.Equals(cb_department.SelectedItem.ToString()))
                    {
                        departmentid = item.DepartmentId;
                    }
                }

                foreach (Role item in RoleService.Instance.GetAllListRole())
                {
                    if (item.Title.Equals(cb_role.SelectedItem.ToString()))
                    {
                        roleid = item.RoleId;
                    }
                }
                if (EmployeeService.Instance.InsertEmployeeVaildate(email, password,phone, userid, departmentid, roleid))
                {
                    MessageBox.Show("Add employee successfully");
                } else
                {
                    MessageBox.Show("Add employee failed");
                }
            } else
            {
                MessageBox.Show("Inputs are missed");
            }*/
        }

        
    }
}
