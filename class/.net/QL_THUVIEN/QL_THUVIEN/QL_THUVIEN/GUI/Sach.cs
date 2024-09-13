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

namespace QL_THUVIEN
{
    public partial class frm_Sach : Form
    {
        BLL.BllSach bllSach;
        LopDungChung lopchung;
        public frm_Sach()
        {
            InitializeComponent();
            bllSach = new BLL.BllSach(this);
            lopchung = new LopDungChung();
            LoadGrid();
            LoadComboDMS();
            LoadComboNN();
        }

        public void LoadGrid()
        {
            bllSach.BllGrid();
        }

        public void LoadComboDMS()
        {
            bllSach.BllComboDMS();
        }

        public void LoadComboNN()
        {
            bllSach.BllComboNN();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

 


        private void frm_Sach_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
 

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        public bool validate_data()
        {
            if ((txtMS.Text == "" || txtMS.Text == null) || (txtTacGia.Text == "" || txtTacGia.Text == null) ||
                (txtTenSach.Text == "" || txtTenSach.Text == null) || (txtGia.Text == "" || txtGia.Text == null) 
                )
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validate_data())
            {
                string sql = "INSERT INTO Sach VALUES('MaSach','TenSach','MaNN','TacGia','GiaThue','SoLuong','TomTat','MaDMS') " +
              "(N'" + txtMS.Text + "', " +
              "N'" + txtTenSach.Text + "', " +
              "N'" + comboBox3.SelectedValue.ToString() + "', " +
              "N'" + txtTacGia.Text + "', " +
               "N'" + 12000 + "', " +
              "'" + DateTime.Parse("02/02/2024") + "')"; 

                int kq = lopchung.Nonquery(sql);
                if (kq > 0) LoadGrid();
            }

        }
    }
}
