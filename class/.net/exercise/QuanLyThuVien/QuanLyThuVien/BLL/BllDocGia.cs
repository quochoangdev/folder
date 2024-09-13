using QuanLyThuVien.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.BLL
{
    class BllDocGia
    {
        DAL.DalDocGia dalDG;
        frm_DocGia DG;
        public BllDocGia(frm_DocGia fdG)
        {
            dalDG = new DAL.DalDocGia();
            DG = fdG;
        }
        public void BllGrid()
        {
            DG.dataGridView1.DataSource = dalDG.DalLoadGrid();
        }
    }
}
