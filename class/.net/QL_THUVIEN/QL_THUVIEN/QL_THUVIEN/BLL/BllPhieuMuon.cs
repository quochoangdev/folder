using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_THUVIEN.BLL
{
    internal class BllPhieuMuon
    {
        DAL.DalPhieuMuon dal;
        frm_PhieuMuon frm;
        public BllPhieuMuon(frm_PhieuMuon frm_1)
        {
            dal = new DAL.DalPhieuMuon();
            frm = frm_1;
        }
        public void BllGrid()
        {
            frm.dataGridView1.DataSource = dal.DalLoadGrid();
        }
    }
}
