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
    public partial class frm_dangNhap : Form
    {
        private bool isExitButtonClicked = false;
        private int count_err_password = 0;
        public frm_dangNhap()
        {
            InitializeComponent();
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            string username = txt_tenTaiKhoan.Text;
            string password = txt_matKhau.Text;
            string username_default = "quochoangdev";
            string password_default = "111111";
            {

            }
            if (username == username_default && password == password_default)
            {
                frm_nhapMang frm_show = new frm_nhapMang();
                frm_show.Show();
                count_err_password = 0;
            }
            else
            {
                count_err_password += 1;
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu lần " + count_err_password);
                if (count_err_password == 3)
                {
                    isExitButtonClicked = true;
                    MessageBox.Show("Sai lần 3, Thoát CT");
                    this.Close();
                }
            }
        }

        private void btn_nhapLai_Click(object sender, EventArgs e)
        {
            txt_tenTaiKhoan.Text = "";
            txt_matKhau.Text = "";
        }

        private void txt_thoat_Click(object sender, EventArgs e)
        {
            isExitButtonClicked = true;
            DialogResult DR = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frm_dangNhap_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
