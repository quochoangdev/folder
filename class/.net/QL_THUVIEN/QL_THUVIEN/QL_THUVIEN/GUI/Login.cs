using QL_THUVIEN.DAL;
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
    public partial class frm_Login : Form
    {
        LopDungChung lopchung;
        public frm_Login()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Application.OpenForms["frm_Register"] == null)
            {
                frm_Register frm = new frm_Register();
                frm.Show();
            }else
            {
                Application.OpenForms["frm_Register"].Show();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)

        {
            String sql = "select count (*) from TaiKhoan " +
                "where Username = '" + txtUserName.Text + "' and Password = '" + txtPassword.Text + "'";
            int kq = (int)lopchung.Scalar(sql);
            if (kq > 0)
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                if (Application.OpenForms["frm_TrangChu"] == null)
                {
                    frm_TrangChu frm = new frm_TrangChu();
                    frm.Show();
                }
                else
                {
                    Application.OpenForms["frm_TrangChu"].Show();
                }
            }
            else MessageBox.Show("Sai tài khoản/mật khẩu!!");
           
        }
    }
}
