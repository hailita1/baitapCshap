using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCB_b6
{
    public partial class Form1 : Form
    {
        double[] b = new double[100];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btXoa.Enabled = false;
            label2.Visible = false;
            tbNhap.Text = "";
            this.KeyPreview = true;

            Random rd = new Random();
            double[] a = new double[100];
            for (int i = 0; i < 3; i++)
            {
                a[i] = rd.Next(1, 100);
                listDS.Items.Add(a[i]);
            }
        }

        private void BtLL_Click(object sender, EventArgs e)
        {
            btXoa.Enabled = false;
            label2.Visible = false;
            tbNhap.Text = "";
            listDS.Items.Clear();
            tbNhap.Focus();
            Random rd = new Random();
            double[] a = new double[100];
            for (int i = 0; i < 3; i++)
            {
                a[i] = rd.Next(1, 100);
                listDS.Items.Add(a[i]);
            }
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(tbNhap.Text);
                listDS.Items.Add(tbNhap.Text);
                tbNhap.Text = "";
                tbNhap.Focus();
            }
            catch
            {
                MessageBox.Show("Hãy nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNhap.Text = "";
                tbNhap.Focus();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode.Equals(Keys.L))
                {
                    BtLL_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.H))
                {
                    BtThoat_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.T))
                {
                    BtThem_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.X))
                {
                    BtXoa_Click(null, null);
                }
            }
        }

        private void ListDS_SelectedValueChanged(object sender, EventArgs e)
        {
            btXoa.Enabled = true;
        }

        private void BtXoa_Click(object sender, EventArgs e)
        {
            if (listDS.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn mục nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialog1 = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (dialog1 == DialogResult.Yes)
                    {
                        listDS.Items.RemoveAt(listDS.SelectedIndex);
                    }
                }
            }
        }

        private void BtTim_Click(object sender, EventArgs e)
        {
            double max = 0;
            List<double> listso = new List<double>();
            for (int i = 0; i < listDS.Items.Count; i++)
            {
                listso.Add(Convert.ToDouble(listDS.Items[i]));
            }

            for (int i = 0; i < listso.Count; i++)
            {
                if (listso[i] > max)
                {
                    max = listso[i];
                }
            }
            label2.Visible = true;
            label2.Text = "Giá trị lớn nhất của dãy là: " + max;
        }

        private void ListDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDS.SelectedItem != null)
            {
                btXoa.Enabled = true;
            }else
            {
                btXoa.Enabled = false;
            }
        }
    }
}
