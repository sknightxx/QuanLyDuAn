using BCMP.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCMP.Forms.User
{
    public partial class FormProjectUser : Form
    {
        private Employee empLogin;
        public FormProjectUser(Employee emp)
        {
            InitializeComponent();
            this.empLogin = emp;
        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                txt_search.Text = "Search for project";
                txt_search.Multiline = true;
                txt_search.ForeColor = Color.Gray;
            }
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            if (txt_search.Text == "Search for project")
            {
                txt_search.Text = "";
                txt_search.Multiline = true;
                txt_search.ForeColor = Color.Black;
            }
        }
    }
}
