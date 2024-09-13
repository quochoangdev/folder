using QuanLyThuVien.DAL;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
    class DalDocGia
    {
        LopDungChung lopChung;
        public DalDocGia()
        {
            lopChung = new LopDungChung();
        }

        public DataTable DalLoadGrid()
        {
            String sqlGrid = "select * from DocGia";
            return lopChung.LoadDaTa(sqlGrid);
        }

        public void DalThem(String maDocGia, String hoVaTen, String lop, String soDienThoai)
        {
            String sqlThem = "insert into DocGia values('" + maDocGia + "', N'" + hoVaTen + "', '" + lop + "'," +
    "'" + soDienThoai + "')";
            lopChung.Nonquery(sqlThem);
        }
        public void DalSua(String maDocGia, String hoVaTen, String lop, String soDienThoai)
        {
            String sqlSua = "update DocGia set HoVaTen = N'" + hoVaTen + "'," +
               "Lop = '" + lop + "'," +
               "SoDienThoai = '" + soDienThoai + "' where MaDocGia = '" + maDocGia + "'";
            lopChung.Nonquery(sqlSua);
        }
        public void DalXoa(String maDocGia)
        {
            String sqlXoa = "delete from DocGia where MaDocGia = '" + maDocGia + "'";
            lopChung.Nonquery(sqlXoa);
        }
    }
}
