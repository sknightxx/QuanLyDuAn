using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCMP.Forms;
using FontAwesome.Sharp;


namespace BCMP
{
    public partial class Management : Form
    {
        private IconButton currenBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;



        public Management()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,60);
            pn_leftDashBoard.Controls.Add(leftBorderBtn);

            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
           

        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 140, 0);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 144);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                //Button
                DisableButton();
                currenBtn = (IconButton)senderBtn;
                currenBtn.BackColor = Color.FromArgb(37, 36, 81);
                currenBtn.ForeColor = color;
                currenBtn.TextAlign = ContentAlignment.MiddleCenter;
                currenBtn.IconColor = color;
                currenBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currenBtn.ImageAlign = ContentAlignment.MiddleRight;

                //leftButton
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currenBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //IconCurrentChildform
                iconCurrentChildform.IconChar = currenBtn.IconChar;
                iconCurrentChildform.ForeColor = color;

                lb_tittleChildform.ForeColor = color;
                bt_exit.IconColor = color;
                bt_maximize.IconColor = color;
                bt_minimize.IconColor = color;
                bt_notifications.IconColor = color;
                bt_remind.IconColor = color;
                bt_mail.IconColor = color;
                bt_user.IconColor = color;
                bt_user.ForeColor = color;

               
                
                
                

            }
        }

        private void DisableButton()
        {
            if (currenBtn != null)
            {
                currenBtn.BackColor = Color.FromArgb(31, 32, 71);
                currenBtn.ForeColor = Color.DarkOrange;
                currenBtn.TextAlign = ContentAlignment.MiddleCenter;
                currenBtn.IconColor = Color.DarkOrange;
                currenBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currenBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn_container.Controls.Add(childForm);
            pn_container.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        

        private void bt_home_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormHome());
            lb_tittleChildform.Text = "Home";

        }

        private void bt_employee_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormEmployee());
            lb_tittleChildform.Text = "Employee";


        }

        private void bt_mission_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new FormMission());
            lb_tittleChildform.Text = "Mission";
        }

        private void bt_project_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormProject());
            lb_tittleChildform.Text = "Project";


        }

        private void bt_report_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormReport());
            lb_tittleChildform.Text = "Report";

        }

        private void bt_setting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormSetting());
            lb_tittleChildform.Text = "Setting";


        }

        private void ptb_logo_Click(object sender, EventArgs e)
        {
            if ( currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();

        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildform.IconChar = IconChar.Home;
            iconCurrentChildform.ForeColor = Color.DarkOrange;
            lb_tittleChildform.Text = "Home";
            lb_tittleChildform.ForeColor = Color.DarkOrange;
            bt_maximize.IconColor = Color.DarkOrange;
            bt_minimize.IconColor = Color.DarkOrange;
            bt_exit.IconColor = Color.DarkOrange;
            bt_notifications.IconColor = Color.DarkOrange;
            bt_remind.IconColor = Color.DarkOrange;
            bt_mail.IconColor = Color.DarkOrange;
            bt_user.IconColor = Color.DarkOrange;
            bt_user.ForeColor = Color.DarkOrange;
            pn_container.Controls.Clear();


        }

        private void bt_exit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private bool isMaximized = false;
        private void bt_maximize_Click(object sender, EventArgs e)
        {

            if (isMaximized)
            {
                this.WindowState = FormWindowState.Normal;
                isMaximized = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                isMaximized = true;

            }
        }

        private void bt_minimize_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Minimized;

        }

        //Drag Form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pn_tittleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        
    }
}
