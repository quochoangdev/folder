using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_MDI
{
    internal class LopDungChung
    {
        String diaChi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\class\.net\teacher_send\Form_Buoi1_SG\Menu_MDI\SqlSinhVien.mdf;Integrated Security=True";
        SqlConnection conn;
        public LopDungChung()
        {
            conn = new SqlConnection(diaChi);
        }
        public void Nonquery(String sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close();
            if (kq >= 1)
            {
                MessageBox.Show("Thành công");
            }
            else MessageBox.Show("Thất bại");
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
            String diaChi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\class\.net\teacher_send\Form_Buoi1_SG\Menu_MDI\SqlSinhVien.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(diaChi);
            SqlDataAdapter da = new SqlDataAdapter(sqlData, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
