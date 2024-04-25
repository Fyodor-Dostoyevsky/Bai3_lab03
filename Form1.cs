using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co muon thoat?", "Thong bao",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnTatCaBangSo_Click(object sender, EventArgs e)
        {
            lsbBangSo.Items.Clear();
            for (int i = 0; i <= 9999; i++)
            {
                string s = string.Format("{0:0000}", i);
                lsbBangSo.Items.Add(s);

            }
            lbDem.Text = lsbBangSo.Items.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lsbBangSo.Items.Clear();
            for (int i = 0; i <= 9999; i++)
            {
                string s = string.Format("{0:0000}", i);
                int s1 = Convert.ToInt16(s.Substring(0, 1));
                int s2 = Convert.ToInt16(s.Substring(1, 1));
                int s3 = Convert.ToInt16(s.Substring(2, 1));
                int s4 = Convert.ToInt16(s.Substring(3, 1));
                string tong = Convert.ToString(s1 + s2 + s3 + s4);
                if (tong.Substring(tong.Length - 1, 1) == "9") ;
                lsbBangSo.Items.Add(s);
            }
            lbDem.Text = lsbBangSo.Items.Count.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            lsbBangSo.Items.Clear();
            for (int i = 1; i <= 9999; i++)
            {
                string s = String.Format("{0:0000}", i);
                int s1 = Convert.ToInt32(s.Substring(0, 1));
                int s2 = Convert.ToInt32(s.Substring(1, 1));
                int s3 = Convert.ToInt32(s.Substring(2, 1));
                int s4 = Convert.ToInt32(s.Substring(3, 1));
                if (s1 == s4 && s2 == s3)
                {
                    lsbBangSo.Items.Add(s);
                }

            }
            lbDem.Text = lsbBangSo.Items.Count.ToString();
        }

        private void btnGanh_Click(object sender, EventArgs e)
        {
            lsbBangSo.Items.Clear();
            for (int i = 1; i <= 9999; i++)
            {
                string s = String.Format("{0:0000}", i);
                int s1 = Convert.ToInt32(s.Substring(0, 1));
                int s2 = Convert.ToInt32(s.Substring(1, 1));
                int s3 = Convert.ToInt32(s.Substring(2, 1));
                int s4 = Convert.ToInt32(s.Substring(3, 1));

                if ((s1 == s3 || s2 == s4) && ((s1 != s2 && s2 != s3) || (s2 != s3 && s3 != s4)))
                {
                    lsbBangSo.Items.Add(s);
                }
            }
            lbDem.Text = lsbBangSo.Items.Count.ToString();


        }

        private void btnTangLienTiep_Click(object sender, EventArgs e)
        {
            lsbBangSo.Items.Clear();
            for (int i = 1; i <= 9999; i++)
            {
                string s = String.Format("{0:0000}", i);
                int s1 = Convert.ToInt32(s.Substring(0, 1));
                int s2 = Convert.ToInt32(s.Substring(1, 1));
                int s3 = Convert.ToInt32(s.Substring(2, 1));
                int s4 = Convert.ToInt32(s.Substring(3, 1));

                if ((s1 <= s2 && s2 < s3 && s3 > s4) || (s2 <= s3 && s3 < s4 && s1 > s2))
                {
                    lsbBangSo.Items.Add(s);
                }
            }
            lbDem.Text = lsbBangSo.Items.Count.ToString();
        }

        private void btnKhonggiam_Click(object sender, EventArgs e)
        {
            lsbBangSo.Items.Clear();
            for (int i = 1; i <= 9999; i++)
            {
                string s = String.Format("{0:0000}", i);
                int s1 = Convert.ToInt32(s.Substring(0, 1));
                int s2 = Convert.ToInt32(s.Substring(1, 1));
                int s3 = Convert.ToInt32(s.Substring(2, 1));
                int s4 = Convert.ToInt32(s.Substring(3, 1));


                if (s1 <= s2 && s2 <= s3 && s3 <= s4)
                    lsbBangSo.Items.Add(s);
            }
            lbDem.Text = lsbBangSo.Items.Count.ToString();
        }

        private void lsbBangSo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}