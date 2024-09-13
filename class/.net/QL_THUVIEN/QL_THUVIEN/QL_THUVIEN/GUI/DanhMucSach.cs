using QL_THUVIEN.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_THUVIEN
{
    public partial class frm_DanhMucSach : Form
    {
        BLL.BllDanhMucSach bllDMS;
        public frm_DanhMucSach()
        {
            InitializeComponent();
            bllDMS = new BLL.BllDanhMucSach(this);
            lopchung = new LopDungChung();
            LoadGrid();
        }

        LopDungChung lopchung;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadGrid()
        {
            txtSL.Text = lopchung.Scalar("select count(*) from DanhMucSach").ToString();
            bllDMS.BllGrid();
        }

        public void LoadGridDetail(String sql)
        {
            txtSL.Text = lopchung.Scalar("select count(*) from DanhMucSach where MaDMS = '" + txtMDS.Text + "'").ToString();
            bllDMS.BllGridDetail(sql);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            back();
        }

        public void back()
        {
            this.Hide();
            if (Application.OpenForms["frm_TrangChu"] == null)
            {
                frm_TrangChu frm = new frm_TrangChu();
                frm.Show();
            }
            else Application.OpenForms["frm_TrangChu"].Show();
        }
        public bool validate_data()
        {
            if ((txtMDS.Text == "" || txtMDS.Text == null) || (txtTen.Text == "" || txtTen.Text == null))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(validate_data())
            {
                String sql = "insert into DanhMucSach values (N'" + txtMDS.Text + "',N'" + txtTen.Text + "')";
                int kq = lopchung.Nonquery(sql);
                if (kq > 0) LoadGrid();
            }
      
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validate_data())
            {
                String sql = "update DanhMucSach set TenDMS = N'" + txtTen.Text + "' where MaDMS = N'"+ txtMDS.Text+ "'";
                int kq = lopchung.Nonquery(sql);
                if (kq > 0) LoadGrid();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if ((txtMDS.Text == "" || txtMDS.Text == null))
            {
                MessageBox.Show("Vui lòng nhập mã danh mục sản phẩm để xoá.");
                return;
            }
            String sql = "select * from DanhMucSach where MaDMS = '" + txtMDS.Text + "'";
            int kq = lopchung.Nonquery(sql);
            if (kq > 0) LoadGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtMDS.Text == "" || txtMDS.Text == null))
            {
                LoadGrid();
            }
            else
            {
                String sql = "select * from DanhMucSach where MaDMS = '" + txtMDS.Text + "'";
                LoadGridDetail(sql);

            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMDS.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
