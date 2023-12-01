using BCMP.DAO;
using BCMP.DTO;
using BCMP.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCMP.Forms.Management
{
    public partial class FormPublicData : Form
    {

        private List<Document> listDocumentPublic;
        private Employee curEmp = AuthService.Instance.GetCurrentEmployee();
        public FormPublicData()
        {
            InitializeComponent();
            LoadListDocumentPublic();
        }

        public void LoadListDocumentPublic()
        {
            if(curEmp.RoleId != 1 && curEmp.RoleId !=2)
            {
                listDocumentPublic = DocumentDAO.Instance.GetAllDocumentInPublicUser(curEmp.UserId);
                dtgv_PublicData.DataSource = listDocumentPublic;
            } else
            {
                listDocumentPublic = DocumentDAO.Instance.GetAllDocumentInPublic();
                dtgv_PublicData.DataSource = listDocumentPublic;
            }
            if (listDocumentPublic.Count > 0)
            {
                dtgv_PublicData.DataSource = listDocumentPublic;
            }

        }

        private void dtgv_PublicData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_PublicData.Columns[e.ColumnIndex].Name == "Download")
            {
                string url = dtgv_PublicData.Rows[e.RowIndex].Cells[1].Value.ToString();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = dtgv_PublicData.Rows[e.RowIndex].Cells[0].Value.ToString().Replace("*","Star");
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

            } else if (dtgv_PublicData.Columns[e.ColumnIndex].Name == "Delete")
            {
                string serialNumber = dtgv_PublicData.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (DocumentDAO.Instance.DeletDocumentByCEO(serialNumber))
                {
                    LoadListDocumentPublic();
                }
            }
        }

        private void dtgv_PublicData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dtgv_PublicData.Rows.Count > 0)
            {
                // Vòng lặp qua tất cả các dòng
                foreach (DataGridViewRow row in dtgv_PublicData.Rows)
                {
                    if (curEmp.RoleId > 2)
                    {
                        dtgv_PublicData.Columns[12].Visible = false;
                    }
                   
                }
            }
        }
    }
}
