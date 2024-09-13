using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_THUVIEN.DAL
{
    internal class DalSach
    {
        LopDungChung lopchung;
        public DalSach()
        {
            lopchung = new LopDungChung();
        }
        public DataTable DalLoadGrid()
        {
            String sqlGrid = "select * from Sach";
            return lopchung.LoadDaTa(sqlGrid);

        }

        public DataTable DalLoadComboDMS()
        {
            String sqlGrid = "select * from DanhMucSach";
            return lopchung.LoadDaTa(sqlGrid);

        }

        public DataTable DalLoadComboNN()
        {
            String sqlGrid = "select * from NgonNgu";
            return lopchung.LoadDaTa(sqlGrid);

        }
    }
}
