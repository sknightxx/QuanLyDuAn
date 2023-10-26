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
using FontAwesome.Sharp;

namespace BCMP.Forms
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();

        }

        private void lb_employees_TextChanged(object sender, EventArgs e)
        {
        }

   
        private void bt_addUser_Click(object sender, EventArgs e)
        {
            FormAddUser AddUserForm = new FormAddUser();
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
            FormAddUser AddUserForm = new FormAddUser();
            AddUserForm.Show();
        }
    }
}
