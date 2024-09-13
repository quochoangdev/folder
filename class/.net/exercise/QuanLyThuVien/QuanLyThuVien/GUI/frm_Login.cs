using QuanLyThuVien.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.GUI
{
    public partial class frm_Login : Form
    {
        LopDungChung lopChung;
        public frm_Login()
        {
            InitializeComponent();
            lopChung = new LopDungChung();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            if (Application.OpenForms["frm_Register"] == null)
            {
                frm_Register frm_R = new frm_Register();
                frm_R.Show();
            }
            else Application.OpenForms["frm_Register"].Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String sql = "select count (*) from TaiKhoan " +
                "where Username = '" + txt_username.Text + "' and Password = '" + txt_password.Text + "'";
            int kq = (int)lopChung.Scalar(sql);
            if (kq > 0)
            {
                MessageBox.Show("Đăng nhập thàng công!");
                this.Hide();
                if (Application.OpenForms["frm_TrangChu"] == null)
                {
                    frm_TrangChu frm_H = new frm_TrangChu();
                    frm_H.Show();
                }
                else Application.OpenForms["frm_TrangChu"].Show();
            }
            else MessageBox.Show("Sai tài khoản/mật khẩu!!");
        }
    }
}
