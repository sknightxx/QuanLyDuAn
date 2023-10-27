using BCMP.Forms.Management;
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

namespace BCMP.Forms
{
    public partial class FormMission : Form
    {
        public FormMission()
        {
            InitializeComponent();
        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
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

        private void bt_CreateProject_Click(object sender, EventArgs e)
        {
            FormAddMission AddMissionForm = new FormAddMission();
            AddMissionForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDetailMission detailMissionForm = new FormDetailMission();
            detailMissionForm.Show();
        }

        
    }
}
