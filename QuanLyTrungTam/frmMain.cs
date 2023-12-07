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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNhanVienTitle_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private string taikhoan;
        private string loaitk;
        private void frmMain_Load(object sender, EventArgs e)
        {
            var fn = new frmdangnhap();
            fn.ShowDialog();

            taikhoan = fn.taikhoan;
            loaitk = fn.loaitk;
            if (loaitk.Equals("admin"))
            {
                btnhocvien.Visible = false;
                btnlop.Visible = false;
               
            }
            else
            {
                btngiaovien.Visible = false;
                btnngoaingu.Visible = false;
            }

            frmchaomung f = new frmchaomung();
            Addform(f);
        }

        private void Addform(Form f)
        {
            this.dgvmain.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.dgvmain.Controls.Add(f);
            
        }

        private void btnNhanVienTitle_Click_1(object sender, EventArgs e)
        {
            frmGV f = new frmGV();
            Addform(f);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSV f = new frmSV();
            Addform(f);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmlop f = new frmlop();
            Addform(f);
            f.Show();
        }

        private void btntrogiup_Click(object sender, EventArgs e)
        {
            frmngoaingu f = new frmngoaingu();
            Addform(f);
            f.Show();
        }
    }
}
