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
    public partial class frmGV : Form
    {
        public frmGV()
        {
            InitializeComponent();
        }

        string connectionString;
        SqlConnection conn = new SqlConnection();
        DataSet ds;
        SqlDataAdapter da;
        private string tukhoa = "";
        private void frmGV_Load(object sender, EventArgs e)
        {
            dgvgiaovien.DataSource = new database().SelectData("select * from BangGiaoVien", null);
        }
        private void LoadHV()
        {   //khaibao listCustomParameter
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            
            dgvgiaovien.DataSource = new database().SelectData("SELECTALLHOCVIEN", lstPara);
        }

            private void btnthem_Click(object sender, EventArgs e)
        {

        }
    }
}
