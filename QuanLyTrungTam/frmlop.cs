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
    public partial class frmlop : Form
    {
        public frmlop()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {

        }

        private void frmlop_Load(object sender, EventArgs e)
        {
            dgvlop.DataSource = new database().SelectData("select * from BangLop", null);
        }
    }
}
