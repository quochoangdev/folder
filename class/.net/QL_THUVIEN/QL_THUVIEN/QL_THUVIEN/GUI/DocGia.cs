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
    public partial class frm_DocGia : Form
    {
        BLL.BllDocGia bllDocGia;

        public frm_DocGia()
        {
            InitializeComponent();
            bllDocGia = new BLL.BllDocGia(this);
            LoadGrid();
        }

        public void LoadGrid()
        {
            bllDocGia.BllGrid();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
