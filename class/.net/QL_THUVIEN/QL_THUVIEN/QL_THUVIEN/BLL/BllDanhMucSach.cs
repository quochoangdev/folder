using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_THUVIEN.BLL
{
    internal class BllDanhMucSach
    {
        DAL.DalDanhMucSach dalSV;
        frm_DanhMucSach frm;
        public BllDanhMucSach(frm_DanhMucSach frm_1)
        {
            dalSV = new DAL.DalDanhMucSach();
            frm = frm_1;
        }
        public void BllGrid()
        {
            frm.dataGridView1.DataSource = dalSV.DalLoadGrid();
        }

        public void BllGridDetail(String sql)
        {
            frm.dataGridView1.DataSource = dalSV.DalLoadGridDetail(sql);
        }
    }
}
