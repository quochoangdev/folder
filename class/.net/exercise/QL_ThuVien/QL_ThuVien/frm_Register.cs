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
    public partial class frm_Register : Form
    {
        LopDungChung lopChung;
        public frm_Register()
        {
            InitializeComponent();
            lopChung = new LopDungChung();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            load_login();
        }

        public void load_login()
        {
            this.Hide();
            if (Application.OpenForms["frm_Login"] == null)
            {
                frm_Login frm_L = new frm_Login();
                frm_L.Show();
            }
            else Application.OpenForms["frm_Login"].Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if ((txt_username.Text == "" || txt_username.Text == null) || (txt_password.Text == "" || txt_password.Text == null) || (txt_password2.Text == "" || txt_password2.Text == null))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
                return;
            }
            String sql = "insert into TaiKhoan values('" + txt_username.Text + "','" + txt_password.Text + "')";
            int kq = lopChung.Nonquery(sql);
            if (kq == 0)
            {
                load_login();
            }
        }
    }
}
