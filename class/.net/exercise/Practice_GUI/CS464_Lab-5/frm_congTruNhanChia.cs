using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464_Lab_5
{
    public partial class frm_congTruNhanChia : Form
    {
        private bool isExitButtonClicked = false;
        public frm_congTruNhanChia()
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
                else MessageBox.Show("So B sai dinh dang");
            else MessageBox.Show("So A sai dinh dang");
            return false;
        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            if (Nhap() == true)
            {
                float kq = a + b;
                txt_ketQua.Text = kq.ToString();
            }
        }

        private void btn_tru_Click(object sender, EventArgs e)
        {
            if (Nhap() == true)
            {
                float kq = a - b;
                txt_ketQua.Text = kq.ToString();
            }
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            if (Nhap() == true)
            {
                float kq = a * b;
                txt_ketQua.Text = kq.ToString();
            }
        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            if (Nhap() == true)
            {
                if (b != 0)
                {
                    float kq = a / b;
                    txt_ketQua.Text = kq.ToString();
                }
                else MessageBox.Show("Mẫu phải # 0");
            }
        }

        private void frm_nhapMang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExitButtonClicked == false)
            {
                DialogResult DR = MessageBox.Show("Bạn có muốn X không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            isExitButtonClicked = true;
            DialogResult DR = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
