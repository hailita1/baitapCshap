using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BTCB_b13
{
    public partial class Form1 : Form
    {
        List<int> dayso = new List<int>();
        List<int> VT = new List<int>();
        public Form1()
        {
            InitializeComponent();
            lbDay.Visible = false;
            lbSDNN.Visible = false;
            btTim.Enabled = false;
            btSDNN.Enabled = false;
            lbDay.Text = "Dãy vừa nhập là:";
            lbSDNN.Text = "Số dương nhỏ nhất là:";
        }

        public bool checkregex(string str)
        {
            Regex regex = new Regex(@"^[+-]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(str);
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtLL_Click(object sender, EventArgs e)
        {
            tbSopt.Text = "";
            tbSok.Text = "";
            lbDay.Text = "";
            lbSDNN.Text = "";
            lbDay.Visible = false;
            lbSDNN.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbSopt.TextLength == 0)
                {
                    MessageBox.Show("Bạn chưa nhập số phần tử", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbSopt.Focus();
                }
                else
                {
                    int c = 0;
                    Convert.ToInt32(tbSopt.Text);
                    string a = Interaction.InputBox("Nhập các phần tử của dãy", "Nhập dãy", "Các phần tử cách nhau bơi dấu ','");
                    string[] a1 = a.Split(new char[] { ',' });
                    if (a1.Length != Convert.ToInt32(tbSopt.Text))
                    {
                        if (a == "")
                        {

                        }
                        else
                        {
                            MessageBox.Show("Chuỗi không hợp lệ! Phải nhâp " + tbSopt.Text + " số và cách nhau bởi dấu ','", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbSopt.Text = "";
                            tbSopt.Focus();
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
                                lbDay.Text += " " + a1[i];
                                dayso.Add(Convert.ToInt32(a1[i]));
                            }
                        }
                        lbDay.Visible = true;
                        btTim.Enabled = true;
                        btSDNN.Enabled = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Phải nhập số nguyên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSopt.Text = "";
                tbSopt.Focus();
            }
        }

        private void BtSDNN_Click(object sender, EventArgs e)
        {
            int min = 100;
            lbSDNN.Visible = true;
            for (int i = 0; i < dayso.Count; i++)
            {
                if (min > dayso[i] && dayso[i] > 0)
                {
                    min = dayso[i];
                }
            }
            lbSDNN.Text += " " + Convert.ToString(min);
        }

        private void BtTim_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbSok.TextLength == 0)
                {
                    MessageBox.Show("Bạn chưa nhập số cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbSok.Focus();
                }
                else
                {

                    int count = 0;
                    int k = Convert.ToInt32(tbSok.Text);
                    string vitri = "";
                    for (int i = 0; i < dayso.Count; i++)
                    {
                        if (dayso[i] == k)
                        {
                            count++;
                            VT.Add(i);
                        }
                    }
                    if (count != 0)
                    {
                        for (int i = 0; i < VT.Count; i++)
                        {
                            vitri += "," + (VT[i] + 1).ToString();
                        }
                        MessageBox.Show("Số phần tử có giá trị " + k + " là " + count + " nằm ở vị trí " + vitri, "Tìm phần tử", MessageBoxButtons.OK);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hãy nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSok.Text = "";
                tbSok.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode.Equals(Keys.T))
                {
                    BtLL_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.L))
                {
                    BtThoat_Click(null, null);
                }
            }
        }
    }
}
