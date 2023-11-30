using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTam
{
    public partial class frmSV : Form
    {   
        public frmSV()
        {
            InitializeComponent();
        }
      

        private void frmSV_Load(object sender, EventArgs e)
        {
            LoadHV();
        }
        private void LoadHV()
        {
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
            var mhv = dgvsinhvien.Rows[e.RowIndex].Cells["MaHocVien"].Value.ToString();
            new frmsinhviencon(mhv).ShowDialog();
            //Sau khi form hoc vien dong lai can load lai danh sach hoc vien
            LoadHV();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {   //neu them moi sinh vien thi ma sinh vien la null
            new frmsinhviencon(null).ShowDialog();
            LoadHV();
        }

        private void dgvsinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
