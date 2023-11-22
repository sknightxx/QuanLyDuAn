using BCMP.Forms.Management;
using BCMP.DTO;
using BCMP.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCMP.Service;
using System.Windows.Shell;

namespace BCMP.Forms
{
    public partial class FormMission : Form
    {
        private Employee currEmployee;
        private List<Mission> myMissionList;
        public FormMission(Employee employee)
        {
            InitializeComponent();
            this.currEmployee = employee;
            LoadDataMyMission();
        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                txt_search.Text = "Search mission by ID";
                txt_search.ForeColor = Color.Gray;
            }
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            if (txt_search.Text == "Search mission by ID")
            {
                txt_search.Text = "";
                txt_search.ForeColor = Color.Black;
            }
        }

        private void bt_CreateProject_Click(object sender, EventArgs e)
        {
            FormAddMission AddMissionForm = new FormAddMission();
            AddMissionForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void LoadDataMyMission()
        {
            if (currEmployee != null)
            {
                myMissionList = MissionDAO.Instance.GetAllMissionsByUserId(currEmployee.UserId.ToString());
                dtgvMyMission.DataSource = myMissionList;
            }
            
        }

        private void dtgvMyMission_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvMyMission.Columns[e.ColumnIndex].Name == "Detail")
            {
                try
                {
                    Mission mission = MissionDAO.Instance.GetMissionById(int.Parse(dtgvMyMission.Rows[e.RowIndex].Cells[1].Value.ToString()));
                    if (mission != null)
                    {
                        FormDetailMission DetailMissionForm = new FormDetailMission(mission);
                        DetailMissionForm.Show();
                    }
                } catch
                {
                    MessageBox.Show("Err");
                }

            }
        }

        private void dtgvMyMission_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvMyMission.Columns[e.ColumnIndex].Name == "Status")
            {
                // Lấy giá trị được chọn từ ComboBox
                DataGridViewComboBoxCell comboBoxCell = (DataGridViewComboBoxCell)dtgvMyMission.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string status = comboBoxCell.Value.ToString();

                // Thực hiện các hành động cần thiết với giá trị đã chọn
                if (MissionService.Instance.UpdateStatusMissionByUser(int.Parse(dtgvMyMission.Rows[e.RowIndex].Cells[1].Value.ToString()), status))
                {
                    // Cập nhật thành công, có thể thực hiện các hành động khác ở đây
                    LoadDataMyMission();
                }
                else
                {
                    // Xử lý khi cập nhật không thành công
                }
            }
        }
    }
}
