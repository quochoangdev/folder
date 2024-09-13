using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_THUVIEN.BLL
{
    internal class BllSach
    {
        DAL.DalSach dal;
        frm_Sach frm;
        public BllSach(frm_Sach frm_1)
        {
            dal = new DAL.DalSach();
            frm = frm_1;
        }
        public void BllGrid()
        {
            frm.dataGridView1.DataSource = dal.DalLoadGrid();
        }

        public void BllComboDMS()
        {
            frm.comboBox1.DataSource = dal.DalLoadComboDMS();
            frm.comboBox1.DisplayMember = "TenDMS";
            frm.comboBox1.ValueMember = "MaDMS";
        }

        public void BllComboNN()
        {
            frm.comboBox2.DataSource = dal.DalLoadComboNN();
            frm.comboBox2.DisplayMember = "TenNN";
            frm.comboBox2.ValueMember = "MaNN";

            frm.comboBox3.DataSource = dal.DalLoadComboNN();
            frm.comboBox3.DisplayMember = "TenNN";
            frm.comboBox3.ValueMember = "MaNN";
        }
    }
}
