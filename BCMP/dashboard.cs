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
using BCMP.DTO;
using BCMP.Forms;
using BCMP.Forms.Management;
using BCMP.Forms.User;
using BCMP.Service;
using FontAwesome.Sharp;


namespace BCMP
{
    public partial class dashboard : Form
    {
        private IconButton currenBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private Employee empLogin;


        public dashboard(Employee empLogin)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,60);
            pn_leftDashBoard.Controls.Add(leftBorderBtn);
            this.empLogin = empLogin;

            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
           

        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 140, 0);

        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                //Button
                DisableButton();
                currenBtn = (IconButton)senderBtn;
                currenBtn.BackColor = Color.FromArgb(50, 55, 60);
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
                currenBtn.BackColor = Color.FromArgb(35, 40, 45);
                currenBtn.ForeColor = Color.Snow;
                currenBtn.TextAlign = ContentAlignment.MiddleCenter;
                currenBtn.IconColor = Color.Snow;
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
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormEmployee());
            lb_tittleChildform.Text = "Employee";


        }

        private void bt_mission_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormMission(empLogin));
            lb_tittleChildform.Text = "Mission";
        }

        private void bt_project_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormProject());
            lb_tittleChildform.Text = "Project";


        }

        private void bt_report_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormReport());
            lb_tittleChildform.Text = "Report";

        }

        private void bt_document_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormDocument());
            lb_tittleChildform.Text = "Document";


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
            iconCurrentChildform.ForeColor = Color.Snow;
            lb_tittleChildform.Text = "Home";
            lb_tittleChildform.ForeColor = Color.Snow;
            bt_maximize.IconColor = Color.Snow;
            bt_minimize.IconColor = Color.Snow;
            bt_exit.IconColor = Color.Snow;
            bt_notifications.IconColor = Color.Snow;
            bt_remind.IconColor = Color.Snow;
            bt_mail.IconColor = Color.Snow;
            bt_user.IconColor = Color.Snow;
            bt_user.ForeColor = Color.Snow;
            pn_container.Controls.Clear();


        }

        private void bt_exit_Click(object sender, EventArgs e)
        {

            this.Close();
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

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pn_container.VerticalScroll.Value = vScrollBar1.Value;
        }

        private void bt_user_Click(object sender, EventArgs e)
        {
            dropdownMenu1.Show(bt_user, bt_user.Width, 0);
        }

        private void bt_Info_Click(object sender, EventArgs e)
        {
            InformationForm informationForm = new InformationForm(empLogin);
            informationForm.Show();
        }

        private void bt_changePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(empLogin);
            changePasswordForm.Show();
        }

        private void bt_notifications_Click(object sender, EventArgs e)
        {
            Notifications notificationForm = new Notifications(empLogin);
            notificationForm.Show();
        }

        private void bt_mail_Click(object sender, EventArgs e)
        {
            MailForm mailForm = new MailForm();
            mailForm.Show();
        }

        private void bt_remind_Click(object sender, EventArgs e)
        {
            RemindForm remindForm = new RemindForm();
            remindForm.Show();
        }

        private void bt_logOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_vietnamese_Click(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();
            changeLanguage.UpdateConfig("language", "vi");
            Application.Restart();
        }

        private void bt_english_Click(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();
            changeLanguage.UpdateConfig("language", "en");
            Application.Restart();
        }
    }
}
