using BCMP.DAO;
using BCMP.DTO;
using BCMP.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCMP.Forms.Management
{
    public partial class FormDetailMission : Form
    {
        private Mission currMission;
        private FormDetailProject f;
        private FormMission f_mission;
        private Employee currEmp = AuthService.Instance.GetCurrentEmployee();
        private List<Document> documentList;




        public Mission CurrMission { get => currMission; set => currMission = value; }

        public FormDetailMission(Mission mission, FormDetailProject F)
        {
            InitializeComponent();
            CurrMission = mission;
            LoadDataCurrMission();
            this.f = F;
            LoadListDocument();
            if(currEmp.RoleId == 4)
            {
                bt_EditMission.Visible = false;
            }
        }

        public FormDetailMission(Mission mission)
        {
            InitializeComponent();
            CurrMission = mission;
            LoadDataCurrMission();
            this.bt_EditMission.Visible = false;
            LoadListDocument();
            if (currEmp.RoleId == 4)
            {
                bt_EditMission.Visible = false;
            }
        }

        public FormDetailMission(Mission mission, FormMission f)
        {
            InitializeComponent();
            CurrMission = mission;
            LoadDataCurrMission();
            f_mission = f;
            this.bt_EditMission.Visible = false;
            LoadListDocument();
            if (currEmp.RoleId == 4)
            {
                bt_EditMission.Visible = false;
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            if(f != null)
            {
                f.LoadDataListMission();
            }
            this.Close();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            if (f != null)
            {
                f.LoadDataListMission();
            }
            this.Close();
        }

        private void bt_EditMission_Click(object sender, EventArgs e)
        {
            if (CurrMission != null)
            {
                FormAddMission AddMissionForm = new FormAddMission(this);
                AddMissionForm.Show();
            }
        }

        private void bt_cancel_MouseLeave(object sender, EventArgs e)
        {
            bt_cancel.Font = new Font(bt_cancel.Font, System.Drawing.FontStyle.Regular);

        }

        private void bt_cancel_MouseEnter(object sender, EventArgs e)
        {
            bt_cancel.Font = new Font(bt_cancel.Font, System.Drawing.FontStyle.Underline);

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

        public void LoadDataCurrMission()
        {
            if(CurrMission != null)
            {
                CurrMission = MissionDAO.Instance.GetMissionById(CurrMission.MissionId);
                txt_management.Text = CurrMission.UserId.ToString();
                txt_tittle.Text = CurrMission.Title.ToString();
                txt_Description.Text = CurrMission.Description.ToString();
                txt_relateProject.Text = CurrMission.ProjectId.ToString();
                dtp_From.Text = CurrMission.PlannedStartDate.ToString();
                dtp_To.Text = CurrMission.PlannedEndDate.ToString();
                cbb_status.Text = CurrMission.Status.ToString();
            }
       
        }

        public void LoadListDocument()
        {
            documentList = DocumentDAO.Instance.GetAllDocumentInMission(currMission.MissionId);
            if(documentList.Count > 0)
            {
                dtgv_ListDocument.DataSource = documentList;
                if(f != null)
                {
                    f.LoadDataListDocument();
                }
            }
        }

        private void cbb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = cbb_status.SelectedItem.ToString();
            if (MissionService.Instance.UpdateStatusMissionByUser(currMission.MissionId, status))
            {
                if(f != null)
                {
                    f.LoadDataListMission();
                } else if(f_mission != null)
                {
                    f_mission.LoadDataMyMission();
                }

            }
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            FormAddDocument formAddDocument = new FormAddDocument(this);
            formAddDocument.Show();
        }

        private void dtgv_ListDocument_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_ListDocument.Columns[e.ColumnIndex].Name == "Download")
            {
                string url = dtgv_ListDocument.Rows[e.RowIndex].Cells[1].Value.ToString();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = dtgv_ListDocument.Rows[e.RowIndex].Cells[0].Value.ToString().Replace("*","Star");
                saveFileDialog.Filter = "All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileName = saveFileDialog.FileName;
                    using (var client = new HttpClient())
                    {
                        using (var s = client.GetStreamAsync(url))
                        {
                            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
                            {
                                s.Result.CopyTo(fs);
                            }
                        }
                    }
                }
            }
        }
    }
}
