using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_THUVIEN.DAL
{
    internal class DalDocGia
    {
        LopDungChung lopchung;
        public DalDocGia()
        {
            lopchung = new LopDungChung();
        }
        public DataTable DalLoadGrid()
        {
            String sqlGrid = "select * from DocGia";
            return lopchung.LoadDaTa(sqlGrid);

        }
    }
}
