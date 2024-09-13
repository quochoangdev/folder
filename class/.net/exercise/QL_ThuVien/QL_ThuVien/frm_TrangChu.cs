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
    public partial class frm_TrangChu : Form
    {
        public frm_TrangChu()
        {
            InitializeComponent();
        }

        private void btn_QuanLySach_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Application.OpenForms["frm_Sach"] == null)
            {
                frm_Sach frm_S = new frm_Sach();
                frm_S.Show();
            }
            else Application.OpenForms["frm_Sach"].Show();
        }

        private void btn_QuanLyTheLoai_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Application.OpenForms["frm_TheLoai"] == null)
            {
                frm_TheLoai frm_T = new frm_TheLoai();
                frm_T.Show();
            }
            else Application.OpenForms["frm_TheLoai"].Show();
        }
    }
}
