using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTam
{
    public partial class frmGV : Form
    {
        public frmGV()
        {
            InitializeComponent();
        }

        string connectionString;
        SqlConnection conn = new SqlConnection();
        DataSet ds;
        SqlDataAdapter da;
        private string tukhoa = "";
        private void frmGV_Load(object sender, EventArgs e)
        {
            LoadGV();
        }
        
        private void LoadGV()
        {
            //khaibao listCustomParameter
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvgiaovien.DataSource = null;
            dgvgiaovien.DataSource = new database().SelectData("SELECTALLGIAOVIEN", lstPara);

            dgvgiaovien.Columns["MaGiaoVien"].HeaderText = "Mã GV";
            dgvgiaovien.Columns["HoTen"].HeaderText = "Họ tên";
            dgvgiaovien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvgiaovien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvgiaovien.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvgiaovien.Columns["DienThoai"].HeaderText = "Điện Thoại";
        }

            private void btnthem_Click(object sender, EventArgs e)
        {
            new frmgiaoviencon(null).ShowDialog();
            LoadGV();
        }

        private void dgvgiaovien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mgv = dgvgiaovien.Rows[e.RowIndex].Cells["MaGiaoVien"].Value.ToString();
                new frmgiaoviencon(mgv).ShowDialog();
                LoadGV();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txttimkiem.Text;
            LoadGV();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int CurrentIndex = dgvgiaovien.CurrentCell.RowIndex;
            var mathuoc = dgvgiaovien.Rows[CurrentIndex].Cells["MaGiaoVien"].Value.ToString();
            if (MessageBox.Show("Bạn có chắc muốn xóa Giáo Viên này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string ma = mathuoc.ToString();
                List<CustomParameter> lstpara = new List<CustomParameter>();
                string sql = "deleteGV";
                {

                    lstpara.Add(new CustomParameter()
                    {
                        key = "@MaGiaoVien",
                        value = ma
                    });
                }
                var rs = new database().Excute(sql, lstpara);
                if (rs == 1)
                {
                    if (string.IsNullOrEmpty(ma))
                    {
                        MessageBox.Show("Xóa Giáo Viên Thành Công!", "Thông Báo");
                        LoadGV();
                    }
                }
                else
                {
                    MessageBox.Show("Xóa Giáo Viên Thất Bại!", "Thông Báo");
                }

            }
            LoadGV();
        }
    }
}
