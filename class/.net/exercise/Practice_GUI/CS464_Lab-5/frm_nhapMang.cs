using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464_Lab_5
{
    public partial class frm_nhapMang : Form
    {
        private bool isExitButtonClicked = false;
        public frm_nhapMang()
        {
            InitializeComponent();
        }

        private void btn_tinhToan_Click(object sender, EventArgs e)
        {
            int even_number = 0;
            int odd_number = 0;
            int sum_number = 0;
            String currentArr = txt_mangA.Text;
            String[] words = currentArr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (int.TryParse(word, out int number))
                {
                    if (number % 2 == 0)
                    {
                        even_number += number;
                        sum_number += number;
                    }
                    else
                    {
                        odd_number += number;
                        sum_number += number;
                    }
                }
            }
            txt_tongCacSoChan.Text = even_number.ToString();
            txt_tongCacSoLe.Text = odd_number.ToString();
            txt_tongCacSoMangA.Text = sum_number.ToString();
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            txt_mangA.Text = "";
            txt_tongCacSoChan.Text = "";
            txt_tongCacSoLe.Text = "";
            txt_tongCacSoMangA.Text = "";
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            isExitButtonClicked = true;
            DialogResult DR = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frm_nhapMang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExitButtonClicked == false)
            {
                DialogResult DR = MessageBox.Show("Bạn có muốn X không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
