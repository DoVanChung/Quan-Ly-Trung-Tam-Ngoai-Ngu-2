using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace QuanLyTrungTam
{
    class database
    {   //chuoi ket noi
        private string connetionString = @"Data Source=DESKTOP-NGA43BC\DOCHUNG;Initial Catalog=QuanLyTrungTamNgoaiNguV12;Integrated Security=True";
        //Khai báo một đối tượng SqlConnection
        private SqlConnection conn;
        //Luu csdl
        private DataTable dt;
        //khai bao de truy van
        private SqlCommand cmd;

        public database()
        {
            try
            {
                conn = new SqlConnection(connetionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại: " + ex.Message);
            }
        }
        //truy van den csdl
        public DataTable SelectData(string sql, List<CustomParameter> lstParameter)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var para in lstParameter)
                {
                    cmd.Parameters.AddWithValue(para.key, para.value);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataRow Select(string sql)
        {
            try
            {
                conn.Open (); //mở kết nối
                cmd = new SqlCommand(sql, conn); // truyền giá trị vào cmd
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());//thực thi câu lệnh
                return dt.Rows[0];// trả về kết quả
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load thông tin chi tiết: "+ex.Message);
                return null;
            }
            finally { conn.Close(); } //cuối cùng đóng kết nối
        }

        public int Excute(string sql, List<CustomParameter> lstParameter)
        {
            try
            {   
                conn.Open (); //mở kết nối
                cmd = new SqlCommand(sql, conn);//  thực thi câu lệnh sql
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var p in lstParameter) // gan cac tham so vao cmd
                {
                    cmd.Parameters.AddWithValue(p.key,p.value);
                }
                var rs = cmd.ExecuteNonQuery();

                return (int)rs;//trả về kết quả

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thưc thi câu lênh: "+ ex.Message);
                return -100;
            }
            finally
            {
                conn.Close ();
            }

        }
    }
}
