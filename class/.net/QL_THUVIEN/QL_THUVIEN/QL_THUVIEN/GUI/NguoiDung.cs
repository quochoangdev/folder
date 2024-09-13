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
    public partial class frm_NguoiDung : Form
    {
        public frm_NguoiDung()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            back();
        }

        public void back()
        {
            this.Hide();
            if (Application.OpenForms["frm_TrangChu"] == null)
            {
                frm_TrangChu frm = new frm_TrangChu();
                frm.Show();
            }
            else Application.OpenForms["frm_TrangChu"].Show();
        }
    }
}
