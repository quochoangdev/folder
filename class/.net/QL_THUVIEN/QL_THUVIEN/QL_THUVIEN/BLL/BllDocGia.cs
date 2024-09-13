using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_THUVIEN.BLL
{
    internal class BllDocGia
    {
        DAL.DalDocGia dal;
        frm_DocGia frm;
        public BllDocGia(frm_DocGia frm_1)
        {
            dal = new DAL.DalDocGia();
            frm = frm_1;
        }
        public void BllGrid()
        {
            frm.dataGridView1.DataSource = dal.DalLoadGrid();
        }
    }
}
