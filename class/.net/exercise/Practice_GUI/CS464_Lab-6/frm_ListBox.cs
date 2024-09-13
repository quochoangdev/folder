using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464_Lab_6
{
    public partial class frm_ListBox : Form
    {
        public frm_ListBox()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            for (int i = Lib_A.SelectedItems.Count - 1; i >= 0; --i)
            {
                Lib_B.Items.Add(Lib_A.SelectedItems[i]);
                Lib_A.Items.Remove(Lib_A.SelectedItems[i]);
            }
            Lib_B.Sorted = true;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            for (int i = Lib_A.Items.Count - 1; i >= 0; --i)
            {
                Lib_B.Items.Add(Lib_A.Items[i]);
                Lib_A.Items.Remove(Lib_A.Items[i]);
            }
            Lib_B.Sorted = true;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            for (int i = Lib_B.SelectedItems.Count - 1; i >= 0; --i)
            {
                Lib_A.Items.Add(Lib_B.SelectedItems[i]);
                Lib_B.Items.Remove(Lib_B.SelectedItems[i]);
            }
            Lib_B.Sorted = true;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            for (int i = Lib_B.Items.Count - 1; i >= 0; --i)
            {
                Lib_A.Items.Add(Lib_B.Items[i]);
                Lib_B.Items.Remove(Lib_B.Items[i]);
            }
            Lib_B.Sorted = true;
        }
    }
}
