using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyTrungTam
{
    public partial class frmSV : Form
    {   
        public frmSV()
        {
            InitializeComponent();
        }
        string connectionString;
        SqlConnection conn = new SqlConnection();
        DataSet ds;
        SqlDataAdapter da;
        private string tukhoa = "";
        private void frmSV_Load(object sender, EventArgs e)
        {
            LoadHV();
        }
        private void LoadHV()
        {   //khaibao listCustomParameter
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvsinhvien.DataSource = null; // reset lai csdl
            //load toan bo danh sach hoc vien khi form duoc load
            //khai bao list custom parameter 
            dgvsinhvien.DataSource = new database().SelectData(null, null);

            //dat ten cot
            dgvsinhvien.Columns["MaHocVien"].HeaderText = "Mã HV";
            dgvsinhvien.Columns["HoTen"].HeaderText = "Họ tên";
            dgvsinhvien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvsinhvien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvsinhvien.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvsinhvien.Columns["SoDienThoai"].HeaderText = "Điện Thoại";
        }
        private void dgvsinhvien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {   //Lay msv
            if (e.RowIndex >= 0)
            {
                var mhv = dgvsinhvien.Rows[e.RowIndex].Cells["MaHocVien"].Value.ToString();
                new frmsinhviencon(mhv).ShowDialog();
                //Sau khi form hoc vien dong lai can load lai danh sach hoc vien
                LoadHV();
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {   //neu them moi sinh vien thi ma sinh vien la null
            new frmsinhviencon(null).ShowDialog();
            LoadHV();
        }

        private void dgvsinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {//xoahocvien co gi nho check lai doan MaHocVien
            int CurrentIndex = dgvsinhvien.CurrentCell.RowIndex;
            var mathuoc = dgvsinhvien.Rows[CurrentIndex].Cells["MaHocVien"].Value.ToString();
            if (MessageBox.Show("Bạn có chắc muốn xóa Học Viên này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string ma = mathuoc.ToString();
                List<CustomParameter> lstpara = new List<CustomParameter>();
                string sql = "deleteHV";
                {

                    lstpara.Add(new CustomParameter()
                    {
                        key = "@MaHocVien",
                        value = ma
                    });
                }
                var rs = new database().Excute(sql, lstpara);
                if (rs == 1)
                {
                    if (string.IsNullOrEmpty(ma))
                    {
                        MessageBox.Show("Xóa Học Viên Thành Công!", "Thông Báo");
                        LoadHV();
                    }
                }
                else
                {
                    MessageBox.Show("Xóa Giảng Viên Thất Bại!", "Thông Báo");
                }

            }
            LoadHV();
        }

        private void button1_Click(object sender, EventArgs e)
        {//timkiem hoc vien
            tukhoa = txttimkiem.Text;
            LoadHV();
        }
    }
}
