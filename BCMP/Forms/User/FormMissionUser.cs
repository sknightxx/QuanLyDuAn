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
    public partial class FormMissionUser : Form
    {
        public FormMissionUser()
        {
            InitializeComponent();
        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            if(txt_search.Text == "")
            {
                txt_search.Text = "Search mission by ID";
                txt_search.ForeColor = Color.Gray;
            }
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            if (txt_search.Text == "Search mission by ID")
            {
                txt_search.Text = "";
                txt_search.ForeColor = Color.Black;
            }
        }
    }
}
