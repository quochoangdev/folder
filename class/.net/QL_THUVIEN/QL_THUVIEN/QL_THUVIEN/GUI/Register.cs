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
    public partial class frm_Register : Form
    {

        LopDungChung lopchung;
        public frm_Register()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
        }
        private void lbRegister_Click(object sender, EventArgs e)
           
        {
            load_login();
        }

        public void load_login()
        {
            this.Hide();
            if (Application.OpenForms["frm_Login"] == null)
            {
                frm_Login frm = new frm_Login();
                frm.Show();
            }
            else
            {
                Application.OpenForms["frm_Login"].Show();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {   
            if((txtUserName.Text == "" || txtUserName.Text == null) || (txtPWD1.Text == "" || txtPWD1.Text == null) || (txtPWD2.Text == "" || txtPWD2.Text == null))
            {
                 MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
                 return;
            }
            String sql = "insert into TaiKhoan values('"+txtUserName.Text+"','" + txtPWD1.Text+"')";
            int kq = lopchung.Nonquery(sql);
            
            if(kq > 0)
            {
                load_login();
            }
          
        }
    }
}
