using BCMP.DAO;
using BCMP.DTO;
using BCMP.Service;
using Firebase.Auth;
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
    public partial class ChangePasswordForm : Form
    {
        private Employee currEmployee;
        public ChangePasswordForm(Employee currEmployee)
        {
            InitializeComponent();
            this.currEmployee = currEmployee;
            LoadDataEmployee();
        }

        private void lb_Email_Click(object sender, EventArgs e)
        {

        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pn_containerChangePass_Paint(object sender, PaintEventArgs e)
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

        private void LoadDataEmployee()
        {
            txt_IdStaff.Enabled = false;
            txt_IdStaff.Text = currEmployee.UserId.ToString();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if (txt_Password.Text.ToString().Equals(""))
            {
                MessageBox.Show("Your Old Password is empty");
            } else if(!AuthService.Instance.LoginValidateEmployee(txt_IdStaff.Text.ToString(), txt_Password.Text.ToString()))
            {
                MessageBox.Show("Your Old Password is not correct");
            } else if (txt_ConfirmPassword.Text.ToString().Equals(""))
            {
                MessageBox.Show("Your New Password is empty");
            } else
            {
                if (txt_ConfirmPassword.Text.Length > 7)
                {
                    if (EmployeeService.Instance.UpdateChangePassword(txt_IdStaff.Text.ToString(), txt_ConfirmPassword.Text.ToString()))
                    {
                        MessageBox.Show("Update your password sucessfully");
                    } else
                    {
                        MessageBox.Show("Update your password failed");
                    }
                }
                else
                {
                    MessageBox.Show("Your New Password must have length at least is 8");
                }
            }
        }

        
            
        
    }
}
