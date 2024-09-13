using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhToan
{
    public partial class frm_phepTinh : Form
    {
        public frm_phepTinh()
        {
            InitializeComponent();
        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            int a =  int.Parse(txt_soA.Text);
            int b = int.Parse(txt_soB.Text);
            int kq = a + b;
            txt_ketQua.Text = kq.ToString();
        }

        private void btn_tru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt_soA.Text);
            int b = int.Parse(txt_soB.Text);
            int kq = a - b;
            txt_ketQua.Text = kq.ToString();
           
        }

        private void btn_N_Click(object sender, EventArgs e)
        {
            txt_soA.Clear();
            txt_soB.Text = string.Empty;
            txt_ketQua.Text = null;
        }
    }
}
