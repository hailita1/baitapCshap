using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCB_b9
{
    public partial class Form1 : Form
    {
        int tong = 0;
        int tongtien = 0;
        List<sach> SACH = new List<sach>();
        List<int> TT = new List<int>();
        public Form1()
        {
            InitializeComponent();
            addcbox();
        }

        public void addTT()
        {

        }

        private void addcbox()
        {
            cbTenSach.Items.Add("Tin đại cương");
            cbTenSach.Items.Add("Tiếng Anh F2");
            cbTenSach.Items.Add("Giải tích F1");
            cbTenSach.Items.Add("Đại số tuyến tính");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (listSACH.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn mục nào để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listSACH.Items.RemoveAt(listSACH.SelectedIndex);
                SACH.RemoveAt(Convert.ToInt32(listSACH.SelectedValue));
                TT.RemoveAt(Convert.ToInt32(listSACH.SelectedValue));
            }
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(cbTenSach.SelectedItem) == "Tin đại cương")
            {
                tbGia.Text = "22000";
            }
            if (Convert.ToString(cbTenSach.SelectedItem) == "Tiếng Anh F2")
            {
                tbGia.Text = "27000";
            }
            if (Convert.ToString(cbTenSach.SelectedItem) == "Giải tích F1")
            {
                tbGia.Text = "25000";
            }
            if (Convert.ToString(cbTenSach.SelectedItem) == "Đại số tuyến tính")
            {
                tbGia.Text = "26000";
            }
        }

        private void RadioButton1_Click(object sender, EventArgs e)
        {
            {
                if (rbATM.Checked == true)
                {
                    rbATM.Checked = false;
                    rbTM.Checked = true;
                }
                else rbTM.Checked = true;
            }
            tbGG.Text = "5";
        }

        private void RadioButton2_Click(object sender, EventArgs e)
        {
            if (rbTM.Checked == true)
            {
                rbTM.Checked = false;
                rbATM.Checked = true;
            }
            else rbATM.Checked = true;
            tbGG.Text = "10";
        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(cbTenSach.SelectedIndex) == null || tbSL.TextLength == 0 || rbTM.Checked == false && rbATM.Checked == false)
            {
                if (cbTenSach.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn sách muốn mua", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tbSL.TextLength == 0)
                {
                    MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (rbTM.Checked == false && rbATM.Checked == false)
                {
                    MessageBox.Show("Bạn chưa chọn loại thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (rbATM.Checked == true)
                {
                    tong = (Convert.ToInt32(tbGia.Text) * Convert.ToInt32(tbSL.Text)) * 95 / 100;
                    listSACH.Items.Add(cbTenSach.Text + "," + tbGia.Text + "-" + tong);
                    SACH.Add(new sach(cbTenSach.Text, Convert.ToInt32(tbGia.Text), Convert.ToInt32(tbSL.Text)));
                    TT.Add(tong);
                }
                else if (rbTM.Checked == true)
                {
                    tong = (Convert.ToInt32(tbGia.Text) * Convert.ToInt32(tbSL.Text)) * 90 / 100;
                    listSACH.Items.Add(cbTenSach.Text + "," + tbGia.Text + "-" + tong);
                    SACH.Add(new sach(cbTenSach.Text, Convert.ToInt32(tbGia.Text), Convert.ToInt32(tbSL.Text)));
                    TT.Add(tong);
                }
            }
        }

        private void BtTinhtong_Click(object sender, EventArgs e)
        {
            tongtien = TT.Sum();
            tbTT.Text = Convert.ToString(tongtien);
        }

        private void TbSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSL.Text = "";
                tbSL.Focus();
            }
        }
    }
}
