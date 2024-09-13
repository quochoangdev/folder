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
    public partial class frm_TheLoai : Form
    {
        LopDungChung lopChung;
        public frm_TheLoai()
        {
            InitializeComponent();
            lopChung = new LopDungChung();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            String sqlThem = "insert into TheLoai values(" + txt_maTheLoai.Text + ", N'" + txt_tenTheLoai.Text + "')";
            int kq = lopChung.Nonquery(sqlThem);
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            String sqlSua = "update TheLoai set TenTheLoai = N'" + txt_tenTheLoai.Text + "' where MaSV = '" + txt_maTheLoai.Text + "'";
            lopChung.Nonquery(sqlSua);
        }
    }
}
