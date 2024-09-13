﻿using System;
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
    public partial class frm_PhieuMuon : Form
    {
        BLL.BllPhieuMuon bllPhieuMuon;

        public frm_PhieuMuon()
        {
            InitializeComponent();
            bllPhieuMuon = new BLL.BllPhieuMuon(this);
            LoadGrid();
        }

        public void LoadGrid()
        {
            bllPhieuMuon.BllGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
