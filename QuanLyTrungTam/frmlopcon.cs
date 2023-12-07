using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTam
{
    public partial class frmlopcon : Form
    {
        public frmlopcon(string malophoc)
        {   
            this.malophoc = malophoc;   
            InitializeComponent();
        }

        private string malophoc;
        private void bntHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void frmlopcon_Load(object sender, EventArgs e)
        {   
            List<CustomParameter> lstPara = new List<CustomParameter>() 
            { 
                new CustomParameter()
                {
                    key = "@tukhoa",
                    value = ""
                }
            };
            //load du lieu cho hai combo box
            cbbNgoaiNgu.DataSource = new database().SelectData("SELECTAllNGOAINGU", lstPara);
            cbbNgoaiNgu.DisplayMember = "TenNgoaiNgu"; // thuoc tinh hien thi cua combo box
            cbbNgoaiNgu.ValueMember = "MaNgoaiNgu"; // gia tri (key) cua combo box
            cbbNgoaiNgu.SelectedIndex = -1; // set combo b ko chon gia tri nao

            cbbGiaoVien.DataSource = new database().SelectData("SELECTAllGIAOVIEN", lstPara);
            cbbGiaoVien.DisplayMember = "HoTen"; // thuoc tinh hien thi cua combo box
            cbbGiaoVien.ValueMember = "MaGiaoVien"; // gia tri (key) cua combo box
            cbbGiaoVien.SelectedIndex = -1;
            if (string.IsNullOrEmpty(malophoc))
            {
                this.Text = "Thêm mới lớp học";
            }
            else
            {
                this.Text = "Cập nhật lớp học";
                var r = new database().Select(string.Format("SelectLop '" +malophoc+"'"));
                cbbGiaoVien.SelectedValue = r["MaGiaoVien"].ToString();
                cbbNgoaiNgu.SelectedValue = r["MaNgoaiNgu"].ToString();

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {   
            //ràng buộc điều kiện phải điền cả hai
            if(cbbNgoaiNgu.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chon loại ngoại ngữ");
                return;
            }
            if (cbbGiaoVien.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chon giáo viên");
                return;
            }
            List<CustomParameter> lstPara = new List<CustomParameter>();
            string sql = "";
            if (String.IsNullOrEmpty(malophoc))
            {
                sql = "ThemLopHoc";
            }
            else
            {
                sql = "updateLop"; 
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaLop",
                    value = malophoc
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@MaNgoaiNgu",
                value = cbbNgoaiNgu.SelectedValue.ToString() // lay gia tri duoc chon
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@MaGiaoVien",
                value = cbbGiaoVien.SelectedValue.ToString()
            });
            var rs = new database().Excute(sql, lstPara); // truyen hai tham so la cau lenh sql va danh sach cac tham so
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(malophoc))
                {
                    MessageBox.Show("Thêm mới Lớp thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin Lớp thành công");
                }
                this.Dispose(); 
            }
            else
            {
                MessageBox.Show("Thực thi thất bại");
            }
        }
    }
}
