using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_MDI.BLL
{
    internal class BllKhoa
    {
        DAL.DalKhoa dalKHOA;
        frm_SinhVien SV;
        public BllKhoa(frm_SinhVien fsV)
        {
            dalKHOA = new DAL.DalKhoa();
            SV = fsV;
        }
        public void BllCombo()
        {
            SV.cb_khoa.DataSource = dalKHOA.DalLoadCombo();
            SV.cb_khoa.DisplayMember = "TenKhoa";
            SV.cb_khoa.ValueMember = "MaKhoa";
        }
    }
}
