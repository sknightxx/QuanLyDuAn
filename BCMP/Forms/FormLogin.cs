using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCMP
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void lb_login_Click(object sender, EventArgs e)
        {

        }

        private void lb_id_Click(object sender, EventArgs e)
        {

        }

        private void lb_logo_Click(object sender, EventArgs e)
        {

        }

        private void lb_gachngang_Click(object sender, EventArgs e)
        {

        }

        private void lb_password_Click(object sender, EventArgs e)
        {

        }

        private void lb_gachngang2_Click(object sender, EventArgs e)
        {

        }

        private void llb_forgotpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormFotgotPassword forgotpass = new FormFotgotPassword();
            forgotpass.ShowDialog();
            this.Hide();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Management dashboardD = new Management();
            dashboardD.Show();
            

        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_Password.Text == "Password")
            {
                txt_Password.Text = "";
                txt_Password.Multiline = false;
                txt_Password.ForeColor = Color.Black;
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_Password.Text == "")
            {
                txt_Password.Text = "Password";
                txt_Password.Multiline = true;
                txt_Password.ForeColor = Color.Gray;
            }
        }

        private void txt_userID_Enter(object sender, EventArgs e)
        {
            if (txt_userID.Text == "Enter your ID")
            {
                txt_userID.Text = "";
                txt_userID.ForeColor = Color.Black;
            }
        }

        private void txt_userID_Leave(object sender, EventArgs e)
        {
            if (txt_userID.Text == "")
            {
                txt_userID.Text = "Enter your ID";
                txt_userID.ForeColor = Color.Gray;
            }
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
