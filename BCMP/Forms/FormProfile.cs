using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace BCMP.Forms
{
    public partial class FormProfile : Form
    {
        public FormProfile()
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

       
    }
}
