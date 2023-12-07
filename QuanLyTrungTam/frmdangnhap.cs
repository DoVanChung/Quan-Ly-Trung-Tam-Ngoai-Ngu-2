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
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }
        public string loaitk = "";
        public string taikhoan = "";
        private void frmdangnhap_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbbchucvu.SelectedIndex < 0)
            {
                MessageBox.Show("Chưa chọn loại tài khoản");
                return;
            }

            if (string.IsNullOrEmpty(txttk.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
                txttk.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtmk.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
            }

            taikhoan = txttk.Text;
            loaitk = "";

            #region swtk
            switch (cbbchucvu.Text)
            {
                case "Quản trị viên":
                    loaitk = "admin";
                    break;
                case "Giáo viên":
                    loaitk = "gv";
                    break;
            } 
            #endregion

            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@loaitaikhoan",
                    value = loaitk
                },
                new CustomParameter()
                {
                    key = "@taikhoan",
                    value = txttk.Text
                },
                new CustomParameter()
                {
                    key = "@matkhau",
                    value = txtmk.Text
                },
            };

            var rs = new database().SelectData("dangnhap", lst);
            if (rs.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vui lòng thử lại");
            }
            //this.Hide();
        }
    }
}
