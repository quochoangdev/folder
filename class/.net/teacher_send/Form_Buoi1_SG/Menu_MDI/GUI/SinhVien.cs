using Menu_MDI.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_MDI
{
    public partial class frm_SinhVien : Form
    {
        public frm_SinhVien()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            bllSV = new BLL.BllSinhVien(this);
            bllKhoa = new BLL.BllKhoa(this);
        }
        LopDungChung lopchung;// = new LopDungChung();
        BLL.BllSinhVien bllSV;
        BLL.BllKhoa bllKhoa;
        private void SinhVien_Load(object sender, EventArgs e)
        {
            int nam = DateTime.Now.Year - dateTimePicker1.Value.Year + 1;
            txt_nam.Text = nam.ToString();
            LoadCombo();
            LoadGrid();
        }
        public void LoadCombo()
        {
            bllKhoa.BllCombo();
        }
        public void LoadGrid()
        {
           bllSV.BllGrid();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
           
            String sqlThem = "insert into SINHVIEN1 values('"+txt_MaSV.Text+"', N'"+txt_TenSV.Text+"', " +
                "Convert(Datetime,'"+dateTimePicker1.Value+ "',103), '"+cb_khoa.SelectedValue+"'," +
                "'"+txt_tenHinh.Text+"')";
            pictureBox1.Image.Save(duongdan + txt_tenHinh.Text);
            lopchung.Nonquery(sqlThem);
            LoadGrid();
        }

        private void btn_Dem_Click(object sender, EventArgs e)
        {
            String diaChi = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\Desktop\\NET\\Form_Buoi1_SG\\Menu_MDI\\SqlSinhVien.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(diaChi);
            String sqlDem = "select COUNT (*) from SINHVIEN1";
            SqlCommand comm = new SqlCommand(sqlDem, conn);
            conn.Open();
            int kq = (int)comm.ExecuteScalar();
            conn.Close();
            txt_Dem.Text = kq.ToString();
        }
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINHANH\\";
        private void btn_Sua_Click(object sender, EventArgs e)
        {
    
            String sqlSua = "update SINHVIEN1 set Hoten = N'"+txt_TenSV.Text+"'," +
                " NgayNhapHoc = Convert(Datetime,'"+dateTimePicker1.Value+"',103)," +
                "MaKhoa = '"+cb_khoa.SelectedValue+"'," +
                "TenHinh = '"+txt_tenHinh.Text+"' where MaSV = '"+txt_MaSV.Text+"'";
            pictureBox1.Image.Save(duongdan + txt_tenHinh.Text);
            //pictureBox1.Image.Save("C:\\Users\\Admin\\Desktop\\NET\\Form_Buoi1_SG\\Menu_MDI\\HINHANH\\" + txt_tenHinh.Text);
            lopchung.Nonquery(sqlSua);
            LoadGrid();
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
           
            String sqlXoa = "delete from SINHVIEN1 where MaSV = '" + txt_MaSV.Text + "'";
            File.Delete(duongdan + txt_tenHinh.Text);
            lopchung.Nonquery(sqlXoa);
            LoadGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txt_MaSV.Text = dataGridView1.CurrentRow.Cells["MaSV"].Value.ToString();
            //txt_TenSV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaSV.Text = dataGridView1.CurrentRow.Cells["MaSV"].Value.ToString();
            txt_TenSV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["NgayNhapHoc"].Value.ToString();
            txt_tenHinh.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            pictureBox1.ImageLocation = duongdan + txt_tenHinh.Text;
            tam = 1;
            cb_khoa.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tam = 0;
        }
        int tam = 0;
        private void cb_khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tam == 0)
            {
                String diaChi = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\Desktop\\NET\\Form_Buoi1_SG\\Menu_MDI\\SqlSinhVien.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(diaChi);
                String sqlGrid = "select * from SINHVIEN1 where MaKhoa = '" + cb_khoa.SelectedValue + "'";
                SqlDataAdapter da = new SqlDataAdapter(sqlGrid, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            //tam = 0; vì phải click 2 lần vào combobox
        }

        private void btn_LoadLai_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            String diaChi = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\Desktop\\NET\\Form_Buoi1_SG\\Menu_MDI\\SqlSinhVien.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(diaChi);
            String sqlGrid = "select * from SINHVIEN1 where MaSV like '%"+txt_Tim.Text+"%' or HoTen like '%"+txt_Tim.Text+"%'";
            SqlDataAdapter da = new SqlDataAdapter(sqlGrid, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int nam = DateTime.Now.Year - dateTimePicker1.Value.Year + 1;
            txt_nam.Text = nam.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Hãy chọn hình";
            ofd.Filter = "Tất cả đuôi|*.*|Đuôi jpg|*.jpg|Đuôi png|*.png";
            if(ofd.ShowDialog() == DialogResult.OK)
              pictureBox1.Image = Image.FromFile(ofd.FileName);
        }
    }
}

