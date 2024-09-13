using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_MDI
{
    public partial class frm_MenuCha : Form
    {
        public frm_MenuCha()
        {
            InitializeComponent();
        }

        private void openFormConToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Con1"] == null)
            {
                frm_Con1 co = new frm_Con1();
                co.MdiParent = this;
                co.Show();
            }else Application.OpenForms["frm_Con1"].Activate();
        }

        private void openFormChauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Chau"] == null)
            {
                frm_Chau ch = new frm_Chau();
               // ch.MdiParent = this;
                ch.Show();
            }
           // else Application.OpenForms["frm_Chau"].Activate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void moformConToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Con1"] == null)
            {
                frm_Con1 co = new frm_Con1();
                co.MdiParent = this;
                co.Show();
            }
            else Application.OpenForms["frm_Con1"].Activate();
        }

        private void moFormChauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Chau"] == null)
            {
                this.Visible = false;
                frm_Chau ch = new frm_Chau();
                ch.ShowDialog();
                //ch.Show();
                this.Visible = true;
            }
            else Application.OpenForms["frm_Chau"].Activate();
        }

        private void dongFormConToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (Application.OpenForms["frm_Con1"] != null)
            //    Application.OpenForms["frm_Con1"].Close();

            foreach(Form pom in this.MdiChildren){
                if (pom is frm_Con1)
                {
                    pom.Close();
                    break;
                }
            }
        }

        private void frm_MenuCha_Load(object sender, EventArgs e)
        {

        }
    }
}
