﻿using System;
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
    public partial class frmGV : Form
    {
        public frmGV()
        {
            InitializeComponent();
        }

        private void frmGV_Load(object sender, EventArgs e)
        {
            dgvgiaovien.DataSource = new database().SelectData("select * from BangGiaoVien", null);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

        }
    }
}
