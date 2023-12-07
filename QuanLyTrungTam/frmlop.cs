using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        string connectionString;
        SqlConnection conn = new SqlConnection();
        DataSet ds;
        SqlDataAdapter da;
        private string tukhoa = "";


        private void btnthem_Click(object sender, EventArgs e)
        {
            new frmlopcon(null).ShowDialog();
            LoadLop();
        }

        private void frmlop_Load(object sender, EventArgs e)
        {
            LoadLop();
        }

        private void LoadLop()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvlop.DataSource = null;
            dgvlop.DataSource = new database().SelectData("SELECTALLLOP", lstPara);


        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txttimkiem.Text;
            LoadLop();
        }

        private void dgvlop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var malophoc = dgvlop.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();
                new frmlopcon(malophoc).ShowDialog();
                LoadLop();
            }
        }
    }
}
