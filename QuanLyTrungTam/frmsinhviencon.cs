using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTam
{
    public partial class frmsinhviencon : Form
    {
        public frmsinhviencon(string mhv)
        {   //truyen lai msv khi form chay
            this.mhv = mhv; 
            InitializeComponent();
        }

        private string mhv;

        private void frmsinhviencon_Load(object sender, EventArgs e)
        {
            //neu mhv khong co thi them moi sinh vien
            if(string.IsNullOrEmpty(mhv))
            {
                this.Text = "Thêm mới học viên";
            }
            else
            {
                this.Text = "Cập nhật thông tin hoc viên";
                //lay thong tin chi tiet cuar mot hoc vien dua vao ma hoc vien
                var r = new database().Select(string.Format("selectHV '"+mhv+"'"));
                // set các giá trị vào component của form 

                txtHoTenHocVien.Text = r["HoTen"].ToString();
                mtbNgaySinhHocVien.Text = r["NgaySinh"].ToString() ;
                if(int.Parse(r["GioiTinh"].ToString()) == 1)
                {
                    rbtNamHocVien.Checked = true;
                }
                else
                {
                    rbtNuHocVien.Checked = true;
                }
                txtDiaChiHocVien.Text = r["DiaChi"].ToString();
                txtSoDienThoaiHocVien.Text = r["SoDienThoai"].ToString();
            }
        }

        private void txtMaHocVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            string hoten = txtHoTenHocVien.Text;
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.ParseExact(mtbNgaySinhHocVien.Text,"dd/MM/yyyy",CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                mtbNgaySinhHocVien.Select(); //tro chuot vao mtbngaysinh
                return;
            }
            string gioitinh = rbtNamHocVien.Checked ? "1" : "0";
            string diachi = txtDiaChiHocVien.Text;
            string sodienthoai = txtSoDienThoaiHocVien.Text;
            //Khai bao mot danh sach tham so = class customparameter
            List<CustomParameter> lstParameter = new List<CustomParameter>();
            //Neu ma hoc vien khong co gia tri -> them moi hoc vien
            if(string.IsNullOrEmpty(mhv))
            {
                sql = "ThemMoiHV"; // goi toi procedure them moi hoc vien 
            }
            //Neu ma hoc vien co gia tri -> cap nhat thong tin hoc vien
            else
            {
                sql = "updateHocVien"; // goi toi procedure cap nhat hoc vien
                lstParameter.Add(new CustomParameter()
                {
                    key = "@MaHocVien",
                    value = mhv
                });
            }
            lstParameter.Add(new CustomParameter()
            {
                key = "@HoTen",
                value = hoten
            });
            lstParameter.Add(new CustomParameter()
            {
                key = "@NgaySinh",
                value = ngaysinh.ToString("yyyy-MM-dd")
            });
            lstParameter.Add(new CustomParameter()
            {
                key = "@GioiTinh",
                value = gioitinh
            });
            lstParameter.Add(new CustomParameter()
            {
                key = "@DiaChi",
                value = diachi
            });
            lstParameter.Add(new CustomParameter()
            {
                key = "@SoDienThoai",
                value = sodienthoai
            });

            var rs = new database().Excute(sql,lstParameter); // truyen hai tham so la cau lenh sql va danh sach cac tham so
            if(rs == 1) 
            {
                if(string.IsNullOrEmpty(mhv))
                {
                    MessageBox.Show("Thêm mới học viên thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin học viên thành công");
                }
                this.Dispose(); // dong form
            }
            else
            {
                MessageBox.Show("Thực thi thất bại");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
