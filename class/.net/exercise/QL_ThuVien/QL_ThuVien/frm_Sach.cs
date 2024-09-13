using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_ThuVien
{
    public partial class frm_Sach : Form
    {
        LopDungChung lopChung;
        public frm_Sach()
        {
            InitializeComponent();
            lopChung = new LopDungChung();
        }

        public void LoadGrid()
        {
            String sqlGrid = "select * from Sach";
            dataGridView1.DataSource = lopChung.LoadDaTa(sqlGrid);
        }

        private void btn_quayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Application.OpenForms["frm_TrangChu"] == null)
            {
                frm_TrangChu frm_S = new frm_TrangChu();
                frm_S.Show();
            }
            else Application.OpenForms["frm_TrangChu"].Show();
        }

        public void LoadCombo()
        {
            String sqlcomBo = "select * from TheLoai";
            cb_loai.DataSource = lopChung.LoadDaTa(sqlcomBo);
            cb_loai.DisplayMember = "TenTheLoai";
            cb_loai.ValueMember = "MaTheLoai";
        }

        private void frm_TheLoai_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadCombo();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_loadLai_Click(object sender, EventArgs e)
        {
            
        }

        private void cb_Loai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
