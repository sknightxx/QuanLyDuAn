using BCMP.DAO;
using BCMP.DTO;
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
        public FormPublicData()
        {
            InitializeComponent();
            LoadListDocumentPublic();
        }

        public void LoadListDocumentPublic()
        {
            listDocumentPublic = DocumentDAO.Instance.GetAllDocumentInPublic();
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
                saveFileDialog.FileName = dtgv_PublicData.Rows[e.RowIndex].Cells[0].Value.ToString();
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
