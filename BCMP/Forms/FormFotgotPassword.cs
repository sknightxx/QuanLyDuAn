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
    public partial class FormFotgotPassword : Form
    {
        public FormFotgotPassword()
        {
            InitializeComponent();
        }

       

        private void txt_idPass_Leave(object sender, EventArgs e)
        {
            if (txt_idPass.Text == "")
            {
                txt_idPass.Text = "Enter your id";
                txt_idPass.ForeColor = Color.Gray;
            }
        }

        private void txt_idPass_Enter(object sender, EventArgs e)
        {
            if (txt_idPass.Text == "Enter your id")
            {
                txt_idPass.Text = "";
                txt_idPass.ForeColor = Color.Black;
            }
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (txt_email.Text == "")
            {
                txt_email.Text = "Enter email";
                txt_email.ForeColor = Color.Gray;
            }
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            if (txt_email.Text == "Enter email")
            {
                txt_email.Text = "";
                txt_email.ForeColor = Color.Black;
            }
        }

       

        private void bt_iconBackLogin_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void bt_iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
