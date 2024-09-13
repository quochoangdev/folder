using QuanLyThuVien.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.GUI
{
    public partial class frm_DocGia : Form
    {
        LopDungChung lopChung;
        public frm_DocGia()
        {
            InitializeComponent();
            lopChung = new LopDungChung();
        }
        public void LoadGrid()
        {
            String sqlGrid = "select * from DocGia";
            dataGridView1.DataSource = lopChung.LoadDaTa(sqlGrid);
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            String sqlThem = "insert into DocGia values('" + txt_maDocGia + "', N'" + txt_hoVaTen + "', '" + txt_lop + "'," +
"'" + txt_soDienThoai + "')";
            int kq = lopChung.Nonquery(sqlThem);
            if (kq == 0)
            {
                MessageBox.Show("ok");
                LoadGrid();
            }
            else MessageBox.Show("no ok");
            MessageBox.Show("ok");

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1111");
        }
    }
}
