using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamQuocHoang_OnThi
{
    internal class LopDungChung
    {
        String diaChi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\class\.net\exercise\PhamQuocHoang_OnThi\PhamQuocHoang_OnThi\QuanLyQuanCafe.mdf;Integrated Security=True";
        SqlConnection conn;
        public LopDungChung()
        {
            conn = new SqlConnection(diaChi);
        }
        public int Nonquery(String sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                int kq = comm.ExecuteNonQuery();

                if (kq >= 1)
                {
                    MessageBox.Show("Thành công");
                }
                else MessageBox.Show("Thất bại");
                conn.Close();
                return kq;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();

            }
            return 0;
        }
        public object Scalar(String sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = (int)comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
        public DataTable LoadDaTa(String sqlData)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlData, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
