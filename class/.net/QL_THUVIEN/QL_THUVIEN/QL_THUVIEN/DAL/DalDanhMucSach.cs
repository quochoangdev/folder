using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_THUVIEN.DAL
{
    internal class DalDanhMucSach
    {
        LopDungChung lopchung;
        public DalDanhMucSach()
        {
            lopchung = new LopDungChung();
        }
        public DataTable DalLoadGrid()
        {
            String sqlGrid = "select * from DanhMucSach";
            return lopchung.LoadDaTa(sqlGrid);

        }

        public DataTable DalLoadGridDetail(String sqlGrid)
        {
            return lopchung.LoadDaTa(sqlGrid);

        }
    }
}
