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
    public partial class frm_TrangChu : Form
    {
        public frm_TrangChu()
        {
            InitializeComponent();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            toogle_frm("frm_Sach");
        }


        public void toogle_frm(String frm_Name)
        {
            this.Hide();
            if (Application.OpenForms[frm_Name] == null)
            {
                Form frm;
                switch (frm_Name)
                {
                    case "frm_Sach":
                        frm = new frm_Sach();
                        break;
                    case "frm_DanhMucSach":
                        frm = new frm_DanhMucSach();
                        break;
                    case "frm_NguoiDung":
                        frm = new frm_NguoiDung();
                        break;
                    case "frm_DocGia":
                        frm = new frm_DocGia();
                        break;
                    case "frm_PhieuMuon":
                        frm = new frm_PhieuMuon();
                        break;
                    default:
                        throw new ArgumentException("Invalid form name specified");
                }

                frm.Show(); 
            }
            else
            {
                Application.OpenForms[frm_Name].Show();
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

            toogle_frm("frm_DanhMucSach");
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            toogle_frm("frm_NguoiDung");
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            toogle_frm("frm_DocGia");
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            toogle_frm("frm_PhieuMuon");
        }
    }
}
