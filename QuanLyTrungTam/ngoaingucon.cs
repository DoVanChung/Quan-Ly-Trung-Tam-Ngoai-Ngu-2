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
    public partial class ngoaingucon : Form
    {
        public ngoaingucon(string mnn)
        {   
            this.mnn = mnn;
            InitializeComponent();
        }

        private string mnn;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            string tenngoaingu = txtTenNgoaiNgu.Text;
            List<CustomParameter> lstParameter = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mnn))
            {
                sql = "ThemMoiNN";
            }
            else
            {
                sql = "updateNgoaiNgu";
                lstParameter.Add(new CustomParameter()
                {
                    key = "@MaNgoaiNgu",
                    value = mnn
                });
            }
            lstParameter.Add(new CustomParameter()
            {
                key = "@TenNgoaiNgu",
                value = tenngoaingu
            });
            
            var rs = new database().Excute(sql, lstParameter);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mnn))
                {
                    MessageBox.Show("Thêm mới ngoại ngữ thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin ngoại ngữ thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi thất bại");
            }
        }

        private void ngoaingucon_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mnn))
            {
                this.Text = "Thêm mới Ngoại Ngữ";
            }
            else
            {
                this.Text = "Cập nhật thông tin ngoại ngữ";
                var r = new database().Select(string.Format("selectNN '" + mnn + "'"));

                txtTenNgoaiNgu.Text = r["TenNgoaiNgu"].ToString();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
