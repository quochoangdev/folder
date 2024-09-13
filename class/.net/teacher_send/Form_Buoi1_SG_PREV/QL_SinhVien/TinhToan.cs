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
    public partial class frm_TinhToan : Form
    {
        public frm_TinhToan()
        {
            InitializeComponent();
        }
        float a, b;
        public bool Nhap()
        {
            if (float.TryParse(txt_soA.Text, out a))
                if (float.TryParse(txt_soB.Text, out b))
                {
                   return true;
                }
                else MessageBox.Show("Số B sai định dạng");
            else MessageBox.Show("Số A sai định dạng");
            return false;
        }
        private void btn_Cong_Click(object sender, EventArgs e)
        {
           if(Nhap() == true)                   
                    txt_ketQua.Text = (a + b).ToString();      
        }
        private void btn_tru_Click(object sender, EventArgs e){
            int a, b;
            if (int.TryParse(txt_soA.Text, out a))
                if (int.TryParse(txt_soB.Text, out b))
                {
                    int kq = a - b;
                    txt_ketQua.Text = kq.ToString();
                }
                else MessageBox.Show("Số B sai định dạng");
            else MessageBox.Show("Số A sai định dạng");

        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Bạn có muốn Thoát ko", "Thông báo", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DR == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            if (Nhap() == true)
                if (b == 0)
                    MessageBox.Show("Mẫu phải # 0");
                else{
                    float kq = a / b;
                    txt_ketQua.Text = kq.ToString();
                }
        }

        private void btn_XoaSo_Click(object sender, EventArgs e)
        {
            txt_soA.Text = string.Empty;
            txt_soB.Text = null;
            txt_ketQua.Clear();
        }

    }
}
