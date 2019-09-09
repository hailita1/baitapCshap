using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCB_b7
{
    public partial class Form1 : Form
    {
        List<double> ds = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        public bool checkregex(string str)
        {
            Regex regex = new Regex(@"^[+-]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(str);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbNhapso.Text = "";
            tbNhapso.Focus();
            lbHTday.Visible = false;
            lbKQ.Visible = false;
            cbCN.SelectedItem = false;
            this.KeyPreview = true;
            addcb1();
        }

        private void addcb1()
        {
            cbCN.Items.Add("Trung bình cộng của dãy");
            cbCN.Items.Add("Đếm số phần tử âm");
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtLL_Click(object sender, EventArgs e)
        {
            tbNhapso.Text = "";
            lbHTday.Visible = false;
            lbKQ.Visible = false;
            cbCN.SelectedItem = false;
            cbCN.Text = null;
            tbNhapso.Focus();
        }

        private void TbNhapso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Hãy nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNhapso.Text = "";
                tbNhapso.Focus();
            }
        }

        private void BtNhapday_Click(object sender, EventArgs e)
        {
            if (tbNhapso.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập số phần tử của dãy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNhapso.Focus();
            }
            else if (tbNhapso.TextLength != 0)
            {
                int c = 0;
                string a = Interaction.InputBox("Nhập các phân tử của dãy", "Nhập dãy", "Nhập các số cách nhau bởi dấu ','");
                string[] a1 = a.Split(new char[] { ',' });
                if (a1.Length != Convert.ToInt32(tbNhapso.Text))
                {
                    if (a == "")
                    {

                    }
                    else
                    {
                        MessageBox.Show("Chuỗi không hợp lệ! Phải nhâp " + tbNhapso.Text + " số và cách nhau bởi dấu ','", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbNhapso.Text = "";
                        tbNhapso.Focus();
                    }
                }
                else
                {
                    for (int i = 0; i < a1.Length; i++)

                    {
                        if (checkregex(a1[i]) == false)
                        {
                            c = 1; break;
                        }
                    }
                    if (c == 0)
                    {
                        for (int i = 0; i < a1.Length; i++)
                        {
                            lbHTday.Text += a1[i] + " ";
                            ds.Add(Convert.ToDouble(a1[i]));
                        }
                    }
                    lbHTday.Visible = true;
                }
            }
        }

        public void TBC()
        {
            double s=0, tbc=0;
            for(int i = 0; i < ds.Count; i++)
            {
                s = s + ds[i];
            }
            tbc = s / ds.Count;
            lbKQ.Text = "Trung bình cộng của dãy: " + tbc;
            lbKQ.Visible = true;
        }

        public void DSA()
        {
            int dem=0;
            for(int i = 0; i < ds.Count; i++)
            {
                if (ds[i] < 0)
                {
                    dem = dem +1; 
                }
            }
            lbKQ.Text = "Số âm trong dãy là: " + dem;
            lbKQ.Visible = true;
        }

        private void CbCN_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbCN.SelectedItem == "Trung bình cộng của dãy")
            {
                TBC();
            }
            else if(cbCN.SelectedItem == "Đếm số phần tử âm")
            {
                DSA();
            }
        }
    }
}
