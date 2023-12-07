using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace QuanLyTrungTam
{
    public partial class frmgiaoviencon : Form
    {
        public frmgiaoviencon(string mgv)
        {
            this.mgv = mgv;
            InitializeComponent();
        }
        private string mgv;
        private void frmgiaoviencon_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mgv))
            {
                this.Text = "Thêm mới giáo viên";
            }
            else
            {
                this.Text = "Cập nhật thông tin giáo viên";
                var r = new database().Select(string.Format("selectGV '" + mgv + "'"));

                txtHoTenGiaoVien.Text = r["HoTen"].ToString();
                mtbGiaoVien.Text = r["NgaySinh"].ToString();
                if (int.Parse(r["GioiTinh"].ToString()) == 1)
                {
                    rbtNamGiaoVien.Checked = true;
                }
                else
                {
                    rbtNuGiaoVien.Checked = true;
                }
                txtDiaChiGiaoVien.Text = r["DiaChi"].ToString();
                txtSoDienThoaiGiaoVien.Text = r["DienThoai"].ToString();
            }
        }

        private void btnLuuGiaoVien_Click(object sender, EventArgs e)
        {
            string sql = "";
            string hoten = txtHoTenGiaoVien.Text;
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.ParseExact(mtbGiaoVien.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                mtbGiaoVien.Select(); 
                return;
            }
            string gioitinh = rbtNamGiaoVien.Checked ? "1" : "0";
            string diachi = txtDiaChiGiaoVien.Text;
            string dienthoai = txtSoDienThoaiGiaoVien.Text;
            List<CustomParameter> lstParameter = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mgv))
            {
                sql = "ThemMoiGV";
            }
            else
            {
                sql = "updateGiaoVien"; 
                lstParameter.Add(new CustomParameter()
                {
                    key = "@MaGiaoVien",
                    value = mgv
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
                key = "@DienThoai",
                value = dienthoai
            });

            var rs = new database().Excute(sql, lstParameter); 
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mgv))
                {
                    MessageBox.Show("Thêm mới giáo viên thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin giáo viên thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi thất bại");
            }
        }

        private void btnHuyGiaoVien_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHoTenGiaoVien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
