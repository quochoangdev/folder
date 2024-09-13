using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamQuocHoang_OnThi
{
    public partial class DanhMuc : Form
    {
        public DanhMuc()
        {
            InitializeComponent();
        }

        private void thựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_ThucDon"] == null)
            {
                frm_ThucDon frm = new frm_ThucDon();
                frm.MdiParent = this;
                frm.Show();
            }
            else Application.OpenForms["frm_ThucDon"].Activate();
        }
    }
}
