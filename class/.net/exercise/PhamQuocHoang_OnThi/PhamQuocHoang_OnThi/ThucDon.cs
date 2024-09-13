using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamQuocHoang_OnThi
{
    public partial class frm_ThucDon : Form
    {
        LopDungChung lopchung;
        public frm_ThucDon()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
        }

        private void frm_ThucDon_Load(object sender, EventArgs e)
        {
            LoadGrid();
            int nam = dateTimePicker1.Value.Year + 1;
            txt_namHetHanThe.Text = nam.ToString();
        }

        public void LoadGrid()
        {
            String sqlGrid = "select * from THUCDON";
            dataGridView1.DataSource = lopchung.LoadDaTa(sqlGrid);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int nam = dateTimePicker1.Value.Year + 1;
            txt_namHetHanThe.Text = nam.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maTD.Text = dataGridView1.CurrentRow.Cells["MATD"].Value.ToString();
            txt_tenTD.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["NGAYCAP"].Value.ToString();
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            String sqlTim = "select * from THUCDON where MATD like '%" + txt_timKiem.Text + "%' or TENTD like '%" + txt_timKiem.Text + "%'";
            dataGridView1.DataSource = lopchung.LoadDaTa(sqlTim);
        }

        private void btn_dem_Click(object sender, EventArgs e)
        {
            String sqlDem = "select COUNT (*) from THUCDON";
            txt_dem.Text = lopchung.Scalar(sqlDem).ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            String sqlThem = "insert into THUCDON values('" + txt_maTD.Text + "', N'" + txt_tenTD.Text + "', " +
  "Convert(Datetime,'" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "',103),'" + txt_namHetHanThe.Text + "')";
            lopchung.Nonquery(sqlThem);
            LoadGrid();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            String sqlSua = "update THUCDON set NGAYCAP = Convert(Datetime,'" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "',103)," +
   "TENTD = N'" + txt_tenTD.Text + "'," +"NAMHETHAN = N'" + txt_namHetHanThe.Text + "' where MATD = '" + txt_maTD.Text + "'";
            lopchung.Nonquery(sqlSua);
            LoadGrid();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            String sqlXoa = "delete from THUCDON where MATD = '" + txt_maTD.Text + "'";
            lopchung.Nonquery(sqlXoa);
            LoadGrid();
        }
    }
}
