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
    public partial class frmngoaingu : Form
    {
        public frmngoaingu()
        {
            InitializeComponent();
        }
        string connectionString;
        SqlConnection conn = new SqlConnection();
        DataSet ds;
        SqlDataAdapter da;
        private string tukhoa = "";

        private void frmngoaingu_Load(object sender, EventArgs e)
        {
            LoadNN();
        }
        private void LoadNN()
        {
            //khaibao listCustomParameter
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvngoaingu.DataSource = null;
            dgvngoaingu.DataSource = new database().SelectData("SELECTALLNGOAINGU", lstPara);

            dgvngoaingu.Columns["MaNgoaiNgu"].HeaderText = "Mã NN";
            dgvngoaingu.Columns["TenNgoaiNgu"].HeaderText = "Tên Ngoại Ngữ";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new ngoaingucon(null).ShowDialog();
            LoadNN();
        }

        private void dgvngoaingu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mgv = dgvngoaingu.Rows[e.RowIndex].Cells["MaNgoaiNgu"].Value.ToString();
                new ngoaingucon(mgv).ShowDialog();
                LoadNN();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txttimkiem.Text;
            LoadNN();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int CurrentIndex = dgvngoaingu.CurrentCell.RowIndex;
            var mathuoc = dgvngoaingu.Rows[CurrentIndex].Cells["MaNgoaiNgu"].Value.ToString();
            if (MessageBox.Show("Bạn có chắc muốn xóa Loại Ngoại Ngữ này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string ma = mathuoc.ToString();
                List<CustomParameter> lstpara = new List<CustomParameter>();
                string sql = "deleteNN";
                {

                    lstpara.Add(new CustomParameter()
                    {
                        key = "@MaNgoaiNgu",
                        value = ma
                    });
                }
                var rs = new database().Excute(sql, lstpara);
                if (rs == 1)
                {
                    if (string.IsNullOrEmpty(ma))
                    {
                        MessageBox.Show("Xóa Loại Ngoại Ngữ Thành Công!", "Thông Báo");
                        LoadNN();
                    }
                }
                else
                {
                    MessageBox.Show("Xóa Loại Ngoại Ngữ Thất Bại!", "Thông Báo");
                }

            }
            LoadNN();
        }
    }
    
}
