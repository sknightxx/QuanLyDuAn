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
    public partial class FormDepartmentData : Form
    {
        private List<Document> listDocument;
        private Employee curremployee;
        public FormDepartmentData()
        {
            InitializeComponent();
            curremployee = AuthService.Instance.GetCurrentEmployee();
            LoadListDocument();
        }

        public void LoadListDocument()
        {
          
            
            listDocument = DocumentDAO.Instance.GetAllDocumentInDepartment(curremployee.DepartmentId);
            if(listDocument.Count > 0)
            {
                dgv_DepartmentData.DataSource = listDocument;
            }
            
        }

        private void dgv_DepartmentData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_DepartmentData.Columns[e.ColumnIndex].Name == "Download")
            {
                string url = dgv_DepartmentData.Rows[e.RowIndex].Cells[1].Value.ToString();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = dgv_DepartmentData.Rows[e.RowIndex].Cells[0].Value.ToString().Replace("*","Star");
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
