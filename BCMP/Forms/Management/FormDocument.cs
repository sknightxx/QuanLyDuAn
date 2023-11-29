using BCMP.Service;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;

namespace BCMP.Forms.Management
{
    public partial class FormDocument : Form
    {
        private Form currentChildForm;
        private FirebaseService firebaseService;

        public FormDocument()
        {
            InitializeComponent();
            OpenChildForm(new FormPublicData());
            firebaseService = new FirebaseService();
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

        private void txt_search_Leave(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                txt_search.Text = "Search for document";
                txt_search.Multiline = true;
                txt_search.ForeColor = Color.Gray;
            }
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            if (txt_search.Text == "Search for document")
            {
                txt_search.Text = "";
                txt_search.Multiline = true;
                txt_search.ForeColor = Color.Black;
            }
        }

        private async void bt_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "All files (*.*)|*.*|PDF files (*.pdf)|*.pdf|Office Files|*.doc;*.xls;*.ppt|Text files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filename = openFileDialog.FileName;
                FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None);
                var extenstion = Path.GetExtension(filename);
                var path = await firebaseService.UploadFileToStorage(fileStream, openFileDialog.SafeFileName);
                if (currentChildForm is FormPublicData)
                {
                    // Save to DB with Document DAO public
                } else
                {
                    // Save to DB with Document DAO department
                }
            }
        }

        private void bt_download_Click(object sender, EventArgs e)
        {
            string url = "https://firebasestorage.googleapis.com/v0/b/hans-shop.appspot.com/o/11-29-2023-11%3A27-AM-Ta%CC%80i%20lie%CC%A3%CC%82u%20Coding%20%28tham%20kh%E1%BA%A3o%29.pdf?alt=media&token=2d9c0d3b-465a-4d5d-84b7-6d44c1615e15";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "ABC.pdf";
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

        private void bt_delete_Click(object sender, EventArgs e)
        {

        }

        private void bt_print_Click(object sender, EventArgs e)
        {

        }
    }
}
