using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace BCMP.Forms
{
    public partial class FormAddProject : Form
    {
        public FormAddProject()
        {
            InitializeComponent();
    


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_cancel_MouseEnter(object sender, EventArgs e)
        {
            bt_cancel.Font = new Font(bt_cancel.Font, System.Drawing.FontStyle.Underline);
        }

        private void bt_cancel_MouseLeave(object sender, EventArgs e)
        {
            bt_cancel.Font = new Font(bt_cancel.Font, System.Drawing.FontStyle.Regular);
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pn_containerAddProject_Paint(object sender, PaintEventArgs e)
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

        private void txt_IdProject_Leave(object sender, EventArgs e)
        {
            if (txt_IdProject.Text == "")
            {
                txt_IdProject.Text = "Enter ID project";
                txt_IdProject.Multiline = false;
                txt_IdProject.ForeColor = Color.Black;
            }
        }

        private void txt_IdProject_Enter(object sender, EventArgs e)
        {
            if (txt_IdProject.Text == "Enter ID project")
            {
                txt_IdProject.Text = "";
                txt_IdProject.Multiline = true;
                txt_IdProject.ForeColor = Color.Gray;
            }
        }

        

        

        private void txt_nameProject_Leave(object sender, EventArgs e)
        {
            if (txt_nameProject.Text == "")
            {
                txt_nameProject.Text = "Enter name of project";
                txt_nameProject.ForeColor = Color.Black;
            }
        }

        private void txt_nameProject_Enter(object sender, EventArgs e)
        {
            if (txt_nameProject.Text == "Enter name of project")
            {
                txt_nameProject.Text = "";
                txt_nameProject.ForeColor = Color.Gray;
            }
        }

        private void cbb_department_Leave(object sender, EventArgs e)
        {

        }

        private void txt_Description_Leave(object sender, EventArgs e)
        {
            if (txt_Description.Text == "")
            {
                txt_Description.Text = "Enter desciption about project";
                txt_Description.ForeColor = Color.Black;
            }
        }

        private void txt_Description_Enter(object sender, EventArgs e)
        {
            if (txt_Description.Text == "Enter desciption about project")
            {
                txt_Description.Text = "";
                txt_Description.ForeColor = Color.Gray;
            }
        }

        private void txt_IdProject_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

