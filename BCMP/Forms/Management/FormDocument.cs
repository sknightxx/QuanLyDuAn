using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCMP.Forms.Management
{
    public partial class FormDocument : Form
    {
        private Form currentChildForm;

        public FormDocument()
        {
            InitializeComponent();

        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn_containerDocument.Controls.Add(childForm);
            pn_containerDocument.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void lb_file_Click(object sender, EventArgs e)
        {

        }

        private void bt_publicData_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPublicData());

        }

        private void bt_departmentData_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDepartmentData());

        }
    }
}
