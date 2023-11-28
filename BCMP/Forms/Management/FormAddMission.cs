using BCMP.DAO;
using BCMP.DTO;
using BCMP.Service;
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
using MessageBox = System.Windows.Forms.MessageBox;

namespace BCMP.Forms.Management
{
    public partial class FormAddMission : Form
    {
        #region Control
        private Label lb_Management;
        private Panel panel1;
        private Panel pn_tittleAddProject;
        private Label lb_newMission;
        private FontAwesome.Sharp.IconButton bt_exit;
        private Button bt_cancel;
        private Button bt_save;
        private TextBox txt_name;
        private Label lb_member;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label lb_description;
        private DateTimePicker dateTimePicker2;
        private Panel pn_container;
        private TextBox txt_Description;
        private Label lb_document;
        private Label label2;
        private TextBox txt_document;
        private TextBox txt_relateProject;
        private Label lb_relateProject;
        private Label lb_status;
        private ComboBox cbb_status;
        private Label lb_ValidDescription;
        private Label lb_ValidRelate;
        private Label lb_ValidDocument;
        private Label lb_ValidManagement;
        private Label lb_ValidTittle;
        private Label lb_ValidIdMission;
        private Label lb_Tittle;
        #endregion

        private Mission currMission;
        private FormDetailMission f;
        private Label label4;
        private ComboBox cb_department;
        private List<Department> listDepartment;
        private List<Employee> listEmployee;
        private ComboBox cb_ListEmp;
        private FormDetailProject f_p;
        private int departmentSelected = 0;
        private Project currProject;

        public Project CurrProject { get => currProject; set => currProject = value; }

        public FormAddMission(FormDetailProject F_p)
        {
            InitializeComponent();
            this.f_p = F_p;
            lb_status.Visible = false;
            lb_relateProject.Visible = false;
            txt_relateProject.Visible = false;
            CurrProject = f_p.CurrentProject;
            LoadListDepartmentInProject(CurrProject.ProjectId);
            LoadListEmployeeInProject(CurrProject.ProjectId, departmentSelected);
        }




        public FormAddMission(FormDetailMission F)
        {
            InitializeComponent();
            this.f = F;
            this.currMission = f.CurrMission;
            if (currMission != null)
            {
                LoadDataCurrentMission();
                LoadDataStatus();
                CurrProject = ProjectDAO.Instance.GetProjectByMissionId(currMission.MissionId);
                LoadListEmployeeInProject(currProject.ProjectId, departmentSelected);
                LoadListDepartmentInProject(CurrProject.ProjectId);
                cb_ListEmp.Text = currMission.UserId;
                this.departmentSelected = ((Employee)listEmployee.Find(emp => emp.UserId == this.currMission.UserId)).DepartmentId;
                LoadListEmployeeInProject(currProject.ProjectId, departmentSelected);
                cb_department.Text = listDepartment.Find(dep => dep.DepartmentId == departmentSelected).Name;
            }

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddMission));
            this.lb_Management = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_ValidDescription = new System.Windows.Forms.Label();
            this.lb_ValidRelate = new System.Windows.Forms.Label();
            this.lb_ValidDocument = new System.Windows.Forms.Label();
            this.lb_ValidManagement = new System.Windows.Forms.Label();
            this.lb_ValidTittle = new System.Windows.Forms.Label();
            this.lb_ValidIdMission = new System.Windows.Forms.Label();
            this.cbb_status = new System.Windows.Forms.ComboBox();
            this.txt_relateProject = new System.Windows.Forms.TextBox();
            this.lb_relateProject = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.txt_document = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lb_description = new System.Windows.Forms.Label();
            this.pn_tittleAddProject = new System.Windows.Forms.Panel();
            this.lb_newMission = new System.Windows.Forms.Label();
            this.bt_exit = new FontAwesome.Sharp.IconButton();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lb_member = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.pn_container = new System.Windows.Forms.Panel();
            this.lb_document = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Tittle = new System.Windows.Forms.Label();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_ListEmp = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.pn_tittleAddProject.SuspendLayout();
            this.pn_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Management
            // 
            resources.ApplyResources(this.lb_Management, "lb_Management");
            this.lb_Management.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Management.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_Management.Name = "lb_Management";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_ListEmp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cb_department);
            this.panel1.Controls.Add(this.lb_ValidDescription);
            this.panel1.Controls.Add(this.lb_ValidRelate);
            this.panel1.Controls.Add(this.lb_ValidDocument);
            this.panel1.Controls.Add(this.lb_ValidManagement);
            this.panel1.Controls.Add(this.lb_ValidTittle);
            this.panel1.Controls.Add(this.lb_ValidIdMission);
            this.panel1.Controls.Add(this.cbb_status);
            this.panel1.Controls.Add(this.txt_relateProject);
            this.panel1.Controls.Add(this.lb_relateProject);
            this.panel1.Controls.Add(this.lb_status);
            this.panel1.Controls.Add(this.txt_document);
            this.panel1.Controls.Add(this.lb_Management);
            this.panel1.Controls.Add(this.txt_Description);
            this.panel1.Controls.Add(this.lb_description);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lb_ValidDescription
            // 
            resources.ApplyResources(this.lb_ValidDescription, "lb_ValidDescription");
            this.lb_ValidDescription.Name = "lb_ValidDescription";
            // 
            // lb_ValidRelate
            // 
            resources.ApplyResources(this.lb_ValidRelate, "lb_ValidRelate");
            this.lb_ValidRelate.Name = "lb_ValidRelate";
            // 
            // lb_ValidDocument
            // 
            resources.ApplyResources(this.lb_ValidDocument, "lb_ValidDocument");
            this.lb_ValidDocument.Name = "lb_ValidDocument";
            // 
            // lb_ValidManagement
            // 
            resources.ApplyResources(this.lb_ValidManagement, "lb_ValidManagement");
            this.lb_ValidManagement.Name = "lb_ValidManagement";
            // 
            // lb_ValidTittle
            // 
            resources.ApplyResources(this.lb_ValidTittle, "lb_ValidTittle");
            this.lb_ValidTittle.Name = "lb_ValidTittle";
            // 
            // lb_ValidIdMission
            // 
            resources.ApplyResources(this.lb_ValidIdMission, "lb_ValidIdMission");
            this.lb_ValidIdMission.Name = "lb_ValidIdMission";
            // 
            // cbb_status
            // 
            this.cbb_status.FormattingEnabled = true;
            this.cbb_status.Items.AddRange(new object[] {
            resources.GetString("cbb_status.Items"),
            resources.GetString("cbb_status.Items1"),
            resources.GetString("cbb_status.Items2")});
            resources.ApplyResources(this.cbb_status, "cbb_status");
            this.cbb_status.Name = "cbb_status";
            // 
            // txt_relateProject
            // 
            resources.ApplyResources(this.txt_relateProject, "txt_relateProject");
            this.txt_relateProject.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_relateProject.Name = "txt_relateProject";
            this.txt_relateProject.ReadOnly = true;
            this.txt_relateProject.Enter += new System.EventHandler(this.txt_relateProject_Enter);
            this.txt_relateProject.Leave += new System.EventHandler(this.txt_relateProject_Leave);
            // 
            // lb_relateProject
            // 
            resources.ApplyResources(this.lb_relateProject, "lb_relateProject");
            this.lb_relateProject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_relateProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_relateProject.Name = "lb_relateProject";
            // 
            // lb_status
            // 
            resources.ApplyResources(this.lb_status, "lb_status");
            this.lb_status.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_status.Name = "lb_status";
            // 
            // txt_document
            // 
            resources.ApplyResources(this.txt_document, "txt_document");
            this.txt_document.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_document.Name = "txt_document";
            this.txt_document.Enter += new System.EventHandler(this.txt_document_Enter);
            this.txt_document.Leave += new System.EventHandler(this.txt_document_Leave);
            // 
            // txt_Description
            // 
            resources.ApplyResources(this.txt_Description, "txt_Description");
            this.txt_Description.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Enter += new System.EventHandler(this.txt_Description_Enter);
            this.txt_Description.Leave += new System.EventHandler(this.txt_Description_Leave);
            // 
            // lb_description
            // 
            resources.ApplyResources(this.lb_description, "lb_description");
            this.lb_description.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_description.Name = "lb_description";
            // 
            // pn_tittleAddProject
            // 
            this.pn_tittleAddProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pn_tittleAddProject.Controls.Add(this.lb_newMission);
            this.pn_tittleAddProject.Controls.Add(this.bt_exit);
            resources.ApplyResources(this.pn_tittleAddProject, "pn_tittleAddProject");
            this.pn_tittleAddProject.Name = "pn_tittleAddProject";
            // 
            // lb_newMission
            // 
            resources.ApplyResources(this.lb_newMission, "lb_newMission");
            this.lb_newMission.ForeColor = System.Drawing.Color.Black;
            this.lb_newMission.Name = "lb_newMission";
            // 
            // bt_exit
            // 
            resources.ApplyResources(this.bt_exit, "bt_exit");
            this.bt_exit.BackColor = System.Drawing.Color.Transparent;
            this.bt_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_exit.FlatAppearance.BorderSize = 0;
            this.bt_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_exit.ForeColor = System.Drawing.Color.Black;
            this.bt_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.bt_exit.IconColor = System.Drawing.Color.Black;
            this.bt_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_exit.IconSize = 30;
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.White;
            this.bt_cancel.FlatAppearance.BorderSize = 0;
            this.bt_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.bt_cancel, "bt_cancel");
            this.bt_cancel.ForeColor = System.Drawing.Color.Black;
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            this.bt_cancel.MouseEnter += new System.EventHandler(this.bt_cancel_MouseEnter);
            this.bt_cancel.MouseLeave += new System.EventHandler(this.bt_cancel_MouseLeave);
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.bt_save, "bt_save");
            this.bt_save.ForeColor = System.Drawing.Color.White;
            this.bt_save.Name = "bt_save";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // txt_name
            // 
            resources.ApplyResources(this.txt_name, "txt_name");
            this.txt_name.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_name.Name = "txt_name";
            this.txt_name.Enter += new System.EventHandler(this.txt_name_Enter);
            this.txt_name.Leave += new System.EventHandler(this.txt_name_Leave);
            // 
            // lb_member
            // 
            resources.ApplyResources(this.lb_member, "lb_member");
            this.lb_member.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_member.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_member.Name = "lb_member";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label3.Name = "label3";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dateTimePicker2, "dateTimePicker2");
            this.dateTimePicker2.Name = "dateTimePicker2";
            // 
            // pn_container
            // 
            this.pn_container.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_container.Controls.Add(this.lb_document);
            this.pn_container.Controls.Add(this.label2);
            this.pn_container.Controls.Add(this.txt_name);
            this.pn_container.Controls.Add(this.label3);
            this.pn_container.Controls.Add(this.lb_Tittle);
            this.pn_container.Controls.Add(this.dateTimePicker1);
            this.pn_container.Controls.Add(this.dateTimePicker2);
            this.pn_container.Controls.Add(this.panel1);
            resources.ApplyResources(this.pn_container, "pn_container");
            this.pn_container.Name = "pn_container";
            this.pn_container.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_container_Paint);
            // 
            // lb_document
            // 
            resources.ApplyResources(this.lb_document, "lb_document");
            this.lb_document.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_document.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_document.Name = "lb_document";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label2.Name = "label2";
            // 
            // lb_Tittle
            // 
            resources.ApplyResources(this.lb_Tittle, "lb_Tittle");
            this.lb_Tittle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Tittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lb_Tittle.Name = "lb_Tittle";
            // 
            // cb_department
            // 
            this.cb_department.FormattingEnabled = true;
            resources.ApplyResources(this.cb_department, "cb_department");
            this.cb_department.Name = "cb_department";
            this.cb_department.SelectedIndexChanged += new System.EventHandler(this.cb_department_SelectedIndexChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label4.Name = "label4";
            // 
            // cb_ListEmp
            // 
            this.cb_ListEmp.FormattingEnabled = true;
            resources.ApplyResources(this.cb_ListEmp, "cb_ListEmp");
            this.cb_ListEmp.Name = "cb_ListEmp";
            // 
            // FormAddMission
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.pn_tittleAddProject);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.lb_member);
            this.Controls.Add(this.pn_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddMission";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_tittleAddProject.ResumeLayout(false);
            this.pn_tittleAddProject.PerformLayout();
            this.pn_container.ResumeLayout(false);
            this.pn_container.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_cancel_MouseEnter(object sender, EventArgs e)
        {
            bt_cancel.Font = new Font(bt_cancel.Font, System.Drawing.FontStyle.Underline);

        }

        private void bt_cancel_MouseLeave(object sender, EventArgs e)
        {
            bt_cancel.Font = new Font(bt_cancel.Font, System.Drawing.FontStyle.Regular);

        }

        private void pn_container_Paint(object sender, PaintEventArgs e)
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





        private void txt_name_Leave(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                txt_name.Text = "Enter tittle of mission";
                txt_name.ForeColor = Color.Black;
            }
        }

        private void txt_name_Enter(object sender, EventArgs e)
        {
            if (txt_name.Text == "Enter tittle of mission")
            {
                txt_name.Text = "";
                txt_name.ForeColor = Color.Gray;
            }
        }

        private void txt_document_Leave(object sender, EventArgs e)
        {
            if (txt_document.Text == "")
            {
                txt_document.Text = "Attachments";
                txt_document.ForeColor = Color.Black;
            }
        }

        private void txt_document_Enter(object sender, EventArgs e)
        {
            if (txt_document.Text == "Attachments")
            {
                txt_document.Text = "";
                txt_document.ForeColor = Color.Gray;
            }
        }

        private void txt_relateProject_Leave(object sender, EventArgs e)
        {
            if (txt_relateProject.Text == "")
            {
                txt_relateProject.Text = "Enter related project";
                txt_relateProject.ForeColor = Color.Black;
            }
        }

        private void txt_relateProject_Enter(object sender, EventArgs e)
        {
            if (txt_relateProject.Text == "Enter related project")
            {
                txt_relateProject.Text = "";
                txt_relateProject.ForeColor = Color.Gray;
            }
        }

        private void txt_Description_Leave(object sender, EventArgs e)
        {
            if (txt_Description.Text == "")
            {
                txt_Description.Text = "Enter desciption about mission";
                txt_Description.ForeColor = Color.Black;
            }
        }

        private void txt_Description_Enter(object sender, EventArgs e)
        {
            if (txt_Description.Text == "Enter desciption about mission")
            {
                txt_Description.Text = "";
                txt_Description.ForeColor = Color.Gray;
            }

        }



        private void bt_save_Click(object sender, EventArgs e)
        {
            if (currMission == null)
            {
                DateTime plannedStartDate = dateTimePicker1.Value;
                DateTime plannedEndDate = dateTimePicker2.Value;
                if (MissionService.Instance.InsertValidateMission(txt_name.Text.ToString(), txt_Description.Text.ToString(), plannedStartDate, plannedEndDate, 0, f_p.CurrentProject.ProjectId, cb_ListEmp.Text.ToString()))
                {
                    DateTime now = DateTime.Now;
                    MessageBox.Show("Add Mission Successfully");
                    f_p.LoadDataListMission();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Add Mission Failed");
                }
            }
            else
            {
                if (EditCurrentMission())
                {
                    MessageBox.Show("Update Mission Successfully");
                    f.LoadDataCurrMission();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update Mission Failed");
                }
            }

        }

        public void LoadDataCurrentMission()
        {
            if (currMission != null)
            {
                txt_Description.Text = currMission.Description != null ? currMission.Description.ToString() : "";
                cb_ListEmp.Text = currMission.UserId.ToString();
                txt_relateProject.Text = currMission.ProjectId.ToString();
                txt_name.Text = currMission.Title.ToString();
                dateTimePicker1.Value = currMission.PlannedStartDate.Value;
                dateTimePicker2.Value = currMission.PlannedEndDate.Value;
            }
        }

        public void LoadDataStatus()
        {
            cbb_status.Visible = true;
            cbb_status.Text = currMission.Status.ToString();
        }

        private bool EditCurrentMission()
        {
            string title = txt_name.Text;
            string description = txt_Description.Text;
            string project = txt_relateProject.Text;
            string userId = cb_ListEmp.Text;
            string status = cbb_status.Text;
            DateTime plannedStartDate = dateTimePicker1.Value;
            DateTime plannedEndDate = dateTimePicker2.Value;

            if (MissionService.Instance.UpdateMissionByManager(currMission.MissionId, title, description, plannedStartDate, plannedEndDate, (int)currMission.Progress, status, project, userId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LoadListDepartmentInProject(string projectId)
        {
            listDepartment = DepartmentDAO.Instance.GetAllDepartmentInProject(projectId);
            cb_department.DataSource = listDepartment;
            cb_department.DisplayMember = "Name";

        }

        public void LoadListEmployeeInProject(string projectId, int departmentId)
        {
            listEmployee = EmployeeDAO.Instance.GetAllEmployeeInProject(projectId, departmentId);
            cb_ListEmp.DataSource = listEmployee;
            cb_ListEmp.DisplayMember = "UserId";
        }



        private void cb_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_department.Focus())
            {
                departmentSelected = ((Department)cb_department.SelectedItem).DepartmentId;
                LoadListEmployeeInProject(CurrProject.ProjectId, departmentSelected);
            }
        }
    }
}
