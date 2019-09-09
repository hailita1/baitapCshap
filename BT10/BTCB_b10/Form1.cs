using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCB_b10
{
    public partial class Form1 : Form
    {
        double x1, x2;
        double dental;
        public Form1()
        {
            InitializeComponent();
            rbPTBN.Checked = true;
            tbNhapa.Focus();
        }

        private void TbNhapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Hãy nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void TbNhapb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Hãy nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void TbNhapc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Hãy nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (dialog == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode.Equals(Keys.T))
                {
                    BtThoat_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.L))
                {
                    BtLL_Click(null, null);
                }
            }
        }

        private void BtLL_Click(object sender, EventArgs e)
        {
            tbNhapa.Text = "";
            tbNhapb.Text = "";
            tbNhapc.Text = "";
            tbKQ.Text = "";
        }

        private void RbPTBN_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPTBN.Checked == true)
            {
                tbNhapc.Text = "";
                tbNhapc.Enabled = false;
            }
        }

        private void RbPTBH_CheckedChanged(object sender, EventArgs e)
        {
            tbNhapc.Enabled = true;
        }

        private void BtGPT_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tbNhapa.Text);
            int b = Convert.ToInt32(tbNhapb.Text);

            if (rbPTBN.Checked == true)
            {
                if (tbNhapa.TextLength == 0 || tbNhapb.TextLength == 0)
                {
                    if (tbNhapa.TextLength == 0)
                    {
                        MessageBox.Show("Bạn chưa nhập a", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbNhapa.Focus();
                    }
                    if (tbNhapb.TextLength == 0)
                    {
                        MessageBox.Show("Bạn chưa nhập b", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbNhapb.Focus();
                    }
                }
                else
                {
                    x1 =Convert.ToDouble(-b) / Convert.ToDouble(a);
                    tbKQ.Text = "Phương trình có nghiệm: x1 = " + x1;
                }
            }
            else if (rbPTBH.Checked == true)
            {

                int c = Convert.ToInt32(tbNhapc.Text);
                if (tbNhapa.TextLength == 0 || tbNhapb.TextLength == 0)
                {
                    if (tbNhapa.TextLength == 0)
                    {
                        MessageBox.Show("Bạn chưa nhập a", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbNhapa.Focus();
                    }
                    if (tbNhapb.TextLength == 0)
                    {
                        MessageBox.Show("Bạn chưa nhập b", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbNhapb.Focus();
                    }
                    if (tbNhapc.TextLength == 0)
                    {
                        MessageBox.Show("Bạn chưa nhập c", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbNhapb.Focus();
                    }
                }
                else
                {
                    dental = b * b - 4 * a * c;
                    if (dental < 0)
                    {
                        tbKQ.Text = "Phương trình vô nghiệm";
                    }
                    if (dental == 0)
                    {
                        x1 = x2 = Convert.ToDouble(-b) / Convert.ToDouble((2 * a));
                        tbKQ.Text = "Phương trình có nghiệm kép x1 = x2 = " + x1;
                    }
                    if (dental > 0)
                    {
                        x1 = Math.Round((-Convert.ToDouble(b) + Math.Sqrt(dental)) / Convert.ToDouble((2 * a)),2);
                        x2 = Math.Round((-Convert.ToDouble(b) - Math.Sqrt(dental)) / Convert.ToDouble((2 * a)),2);
                        tbKQ.Text = "Phương trình có nghiệm\r\n x1 = " + x1 + ", x2 = " + x2;
                    }
                }
            }
        }
    }
}
