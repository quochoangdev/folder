using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_MDI.DAL
{
    internal class DalKhoa
    {

        LopDungChung lopchung;
        public DalKhoa()
        {
            lopchung = new LopDungChung();
        }
        public DataTable DalLoadCombo()
        {
            String sqlGrid = "select * from KHOA";
            return lopchung.LoadDaTa(sqlGrid);

        }
    }
}
