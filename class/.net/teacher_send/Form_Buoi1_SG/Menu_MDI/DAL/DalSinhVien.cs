using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_MDI.DAL
{
    internal class DalSinhVien
    {
        LopDungChung lopchung;
        public DalSinhVien()
        {
            lopchung = new LopDungChung();
        }
        public DataTable DalLoadGrid()
        {
            String sqlGrid = "select * from SINHVIEN1";
            return lopchung.LoadDaTa(sqlGrid);
        }
    }
}
