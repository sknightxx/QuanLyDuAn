using BCMP.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using BCMP.DTO;
using BCMP.DAO;

namespace BCMP.Forms.Management
{
    public partial class FormAddDocument : Form
    {
        private FirebaseService firebaseService;
        private FormDetailMission f_mission;

        private List<TypeOfDocument> listType;
        private List<PartnerCode> listPartner;

        private FormDetailProject f_project;
        public FormAddDocument(FormDetailMission F)
        {
            InitializeComponent();
            firebaseService = new FirebaseService();
            f_mission = F;
            LoadListPartnerCode();
            LoadListTypeOfDocument();
            cb_Department.Visible = false;
            lb_department.Visible = false;
        }

        public FormAddDocument(FormDetailProject F)
        {
            InitializeComponent();
            firebaseService = new FirebaseService();
            f_project = F;
            LoadListPartnerCode();
            LoadListTypeOfDocument();
            cb_Department.Text = "Public";
        }

        public void LoadListPartnerCode()
        {
            listPartner = PartnerCodeDAO.Instance.GetAllPartnerCode();
            cb_PartnerCode.DataSource = listPartner;
            cb_PartnerCode.DisplayMember = "PartnerCodeId";
        }

        public void LoadListTypeOfDocument()
        {
            listType = TypeOfDocumentDAO.Instance.GetAllTypeOfDocument();
            cb_TypeDocument.DataSource = listType;
            cb_TypeDocument.DisplayMember = "Type";
        }



        private void bt_upload_Click(object sender, EventArgs e)
        {
            if(f_mission != null)
            {
                AddDocumentInMission();
            } else if (f_project != null)
            {
                AddDocumentInProject();
            }
        }

        public async void AddDocumentInMission()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "All files (*.*)|*.*|PDF files (*.pdf)|*.pdf|Office Files|*.doc;*.xls;*.ppt|Text files (*.txt)|*.txt";

            string name = f_mission.CurrMission.ProjectId + "_" + cb_PartnerCode.Text + "_" + cb_TypeDocument.Text + "_" + txt_WBS.Text + "_" + txt_SerialNumber.Text;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                var filename = openFileDialog.FileName;
                FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None);
                var extenstion = Path.GetExtension(filename);
                var newfilename = name + extenstion;
                var path = await firebaseService.UploadFileToStorage(fileStream, newfilename);

                if (DocumentDAO.Instance.InsertDocument(newfilename, (string)path, DateTime.Now, (string)extenstion, txt_SerialNumber.Text, "Upload Succesffuly", f_mission.CurrMission.ProjectId, f_mission.CurrMission.MissionId, f_mission.CurrMission.UserId, cb_PartnerCode.Text, cb_TypeDocument.Text, 0))
                {
                    MessageBox.Show("Upload File Successfully");
                    f_mission.LoadListDocument();
                }
                else
                {
                    MessageBox.Show("Upload File Failed");
                }
            }
        }

        public async void AddDocumentInProject()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "All files (*.*)|*.*|PDF files (*.pdf)|*.pdf|Office Files|*.doc;*.xls;*.ppt|Text files (*.txt)|*.txt";

            string name = f_project.CurrentProject.ProjectId + "_" + cb_PartnerCode.Text + "_" + cb_TypeDocument.Text + "_" + txt_WBS.Text + "_" + txt_SerialNumber.Text;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                int departmentid = 0;
                if (!cb_Department.Text.Equals("Public"))
                {
                    departmentid = AuthService.Instance.GetCurrentEmployee().DepartmentId;
                }
                var filename = openFileDialog.FileName;
                FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None);
                var extenstion = Path.GetExtension(filename);
                var newfilename = name + extenstion;
                var path = await firebaseService.UploadFileToStorage(fileStream, newfilename);

                if (DocumentDAO.Instance.InsertDocument(newfilename, (string)path, DateTime.Now, (string)extenstion, txt_SerialNumber.Text, "Upload Succesffuly", f_project.CurrentProject.ProjectId, -1, AuthService.Instance.GetCurrentEmployee().UserId, cb_PartnerCode.Text, cb_TypeDocument.Text, departmentid))
                {
                    MessageBox.Show("Upload File Successfully");
                    f_project.LoadDataListMission();
                }
                else
                {
                    MessageBox.Show("Upload File Failed");
                }
            }
        }
    }
}
