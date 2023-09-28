using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bth3.baitap2
{
    public partial class Pheptinh : Form
    {
        public Pheptinh()
        {
            InitializeComponent();
        }

        private void rbcong_CheckedChanged(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt1.Text);
            double b = Convert.ToDouble(txt2.Text);
            double tong = a + b;
            if (rbcong.Checked == true)
            {
                txtketqua.Text = tong.ToString();

            }
        }

        private void Pheptinh_Load(object sender, EventArgs e)
        {

        }

        private void rbtru_CheckedChanged(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt1.Text);
            double b = Convert.ToDouble(txt2.Text);
            double hieu = a - b;
            if (rbtru.Checked == true)
            {
                txtketqua.Text = hieu.ToString();
            }
        }

        private void rbnhan_CheckedChanged(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt1.Text);
            double b = Convert.ToDouble(txt2.Text);
            double tich = a * b;
            if (rbnhan.Checked == true)
            {
                txtketqua.Text = tich.ToString();

            }
        }

        private void rbchia_CheckedChanged(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt1.Text);
            double b = Convert.ToDouble(txt2.Text);
            if (b == 0)
            {
                txtketqua.Text = "Không thể chia!";
            } else
            {
                double thuong = a / b;
                if (rbchia.Checked == true)
                {
                    txtketqua.Text = thuong.ToString();
                }
            }
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                errorProvider1.SetError(txt1, "Hãy nhập số!");
            } else errorProvider1.Clear();
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            if (txt2.Text == "")
            {
                errorProvider2.SetError(txt2, "Hãy nhập số!");
            } else errorProvider2.Clear();
        }
    }
}
