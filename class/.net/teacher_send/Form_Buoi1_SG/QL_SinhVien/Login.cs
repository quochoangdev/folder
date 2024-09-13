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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        int dem = 0;
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            
            if (txt_tenDN.Text == "DTU" && txt_matKhau.Text == "123")
            {
                frm_Mang_A f = new frm_Mang_A();
                f.Show();
                dem = 0;
            }
            else
            {
                dem++;
                MessageBox.Show("Sai tên ĐN hoặc MK lần " + dem);
                if(dem == 3)
                {
                    MessageBox.Show("Sai lần 3, Thoát CT");
                    Application.Exit();
                }
            }
        }
    }
}
