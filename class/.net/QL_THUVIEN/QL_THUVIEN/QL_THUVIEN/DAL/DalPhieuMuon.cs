using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_THUVIEN.DAL
{
    internal class DalPhieuMuon
    {
        LopDungChung lopchung;
        public DalPhieuMuon()
        {
            lopchung = new LopDungChung();
        }
        public DataTable DalLoadGrid()
        {
            String sqlGrid = "select * from PhieuMuon";
            return lopchung.LoadDaTa(sqlGrid);

        }
    }
}
