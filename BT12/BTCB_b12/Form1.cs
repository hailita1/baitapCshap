using System;
using System.Windows.Forms;

namespace BTCB_b12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtLM_Click(object sender, EventArgs e)
        {
            tbNhap.Text = "";
            tbNhap.Focus();
            listBox1.Items.Clear();
            lbKQ.Text = "";
            lbKQ.Visible = false;
        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNhap.TextLength == 0)
                {
                    MessageBox.Show("Bạn chưa nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbNhap.Focus();
                }
                else
                {
                    Convert.ToInt32(tbNhap.Text);
                    listBox1.Items.Add(tbNhap.Text);
                    tbNhap.Text = "";
                    tbNhap.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Phải nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNhap.Text = "";
                tbNhap.Focus();
            }
        }

        private void BtXoa_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn mục nào để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (listBox1.SelectedIndices.Count != 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void BtKT_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Chọn mục để kiểm tra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (listBox1.SelectedIndices.Count != 0)
            {
                int n = Convert.ToInt32(listBox1.SelectedItem);
                lbKQ.Visible = true;
                if (n < 2)
                {
                    lbKQ.Text = n + " không phải là số nguyên tố";
                }
                else
                {
                    int count = 0;
                    for (int i = 2; i <= Math.Sqrt(n); i++)
                    {
                        if (n % i == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        lbKQ.Text = n + " là số nguyên tố";
                    }
                    else
                    {
                        lbKQ.Text = n + " không phải là số nguyên tố";
                    }
                }
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode.Equals(Keys.T))
                {
                    BtLM_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.L))
                {
                    BtThoat_Click(null, null);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}
