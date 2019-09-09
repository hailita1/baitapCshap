using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT5
{
    public partial class Form1 : Form
    {
        private List<int> daySo = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void TbnNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private int check()
        {
            if(tbnNhapSo.Text == "")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            rtxtArray.Text = "";
            if (check() == 1)
            {
                daySo.Add(Int16.Parse(tbnNhapSo.Text));
                foreach (int item in daySo)
                {
                    rtxtArray.Text += item + "\n";
                    tbnNhapSo.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Bạn phải nhập vào số!");
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            rtxtArray.Text = "";
            if (check() == 1)
            {
                daySo.Remove(Int16.Parse(tbnNhapSo.Text));
                foreach (int item in daySo)
                {
                    rtxtArray.Text += item + "\n";
                    tbnNhapSo.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Bạn phải nhập vào số!");
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            daySo.Clear();
            rtxtArray.Text = "";
            lbSum.Text = "Tổng: ";
            lbMax.Text = "Max: ";
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            lbSum.Text = "Tổng: ";
            int sum = 0;
            foreach (int item in daySo)
            {
                sum += item;
            }
            lbSum.Text += sum;
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            lbMax.Text = "Max: ";
            int max = 0;
            foreach (int item in daySo)
            {
                if(item > max)
                {
                    max = item;
                }
            }
            lbMax.Text += max;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
