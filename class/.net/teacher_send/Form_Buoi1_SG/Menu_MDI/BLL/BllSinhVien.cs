using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_MDI.BLL
{
    internal class BllSinhVien
    {
        DAL.DalSinhVien dalSV;
        frm_SinhVien SV;
        public BllSinhVien(frm_SinhVien fsV)
        {
            dalSV = new DAL.DalSinhVien();
            SV = fsV;
        }
        public void BllGrid()
        {
            SV.dataGridView1.DataSource = dalSV.DalLoadGrid();
        }
    }
}
