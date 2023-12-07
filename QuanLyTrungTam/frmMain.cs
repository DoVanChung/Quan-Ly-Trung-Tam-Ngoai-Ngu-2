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

        private void frmMain_Load(object sender, EventArgs e)
        {
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
            f.Show();
        }

        private void btnNhanVienTitle_Click_1(object sender, EventArgs e)
        {
            frmGV f = new frmGV();
            Addform(f);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSV f = new frmSV();
            Addform(f);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmlop f = new frmlop();
            Addform(f);
        }

        private void btntrogiup_Click(object sender, EventArgs e)
        {
            frmngoaingu f = new frmngoaingu();
            Addform(f);
        }
    }
}
