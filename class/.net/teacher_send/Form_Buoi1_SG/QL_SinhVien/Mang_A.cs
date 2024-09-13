using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SinhVien
{
    public partial class frm_Mang_A : Form
    {
        public frm_Mang_A()
        {
            InitializeComponent();
        }

        private void btn_tinhToan_Click(object sender, EventArgs e)
        {
            String A = txt_MangA.Text;
            String[] M = A.Split(' ');
            int so; int tongC = 0, tongL = 0, tongM = 0;
            for (int i = 0; i < M.Length; i++)
                if (int.TryParse(M[i], out so))
                    if (so % 2 == 0) tongC = tongC + so;
                    else tongL = tongL + so;
            tongM = tongC + tongL;
            txt_tongChan.Text = tongC.ToString();
            txt_tongLe.Text = tongL.ToString();
            txt_tongMang.Text = tongM.ToString();
        }
        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            txt_MangA.Clear();
            txt_tongChan.Text = String.Empty;
            txt_tongLe.Text = null;
            txt_tongMang.Clear();
        }
        int T = 0;
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Bạn có muốn thoát không", "Thông" +
                "báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                //Application.ExitThread();
                //Environment.Exit(0);
                T = 1;
                Application.Exit();
            }
        }
        private void frm_Mang_A_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (T == 0)
            {
                DialogResult DR = MessageBox.Show("Bạn có muốn X ?", "Thông" +
                    "báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void txt_MangA_TextChanged(object sender, EventArgs e)
        {
            //AcceptButton = btn_tinhToan;
            AcceptButton = btn_Thoat;
        }
    }
}
