using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4_DTB
{
    public partial class Form1 : Form
    {
        int tongTC = 0;
        double tongD = 0;
        double DTB = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void AddComboBox()
        {
            cmbMH.Items.Add("Tin học đại cương");
            cmbMH.Items.Add("Giải tích F1");
            cmbMH.Items.Add("Tiếng Anh A0");
            cmbMH.Items.Add("Triết học Mác - Lênin");
            cmbMH.Items.Add("Vật lý F1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            txtTC.Enabled = false;
            AddComboBox();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode.Equals(Keys.H))
                {
                    btnThoat_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.D))
                {
                    BtnTVDS_Click(null, null);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void CmbMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMH.Text == "Tin học đại cương")
            {
                txtTC.Text = "2";
            }
            if (cmbMH.Text == "Giải tích F1")
            {
                txtTC.Text = "3";
            }
            if (cmbMH.Text == "Tiếng Anh A0")
            {
                txtTC.Text = "3";
            }
            if (cmbMH.Text == "Triết học Mác - Lênin")
            {
                txtTC.Text = "2";
            }
            if (cmbMH.Text == "Vật lý F1")
            {
                txtTC.Text = "3";
            }
        }

        private void TxtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txtDiem.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch) && !char.IsControl(ch) && ch != 46) // 46 == "."
            {
                e.Handled = true;
                MessageBox.Show("Điểm phải là dạng số! Hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTVDS_Click(object sender, EventArgs e)
        {
            tongTC = tongTC + Convert.ToInt32(txtTC.Text);
            tongD = tongD + Convert.ToInt32(txtTC.Text) * Convert.ToDouble(txtDiem.Text);
            DTB = tongD / tongTC;
            if(cmbMH.SelectedIndex == null)
            {
                MessageBox.Show("Chưa chọn môn học. Hãy thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtDiem.TextLength == 0 )
            {
                MessageBox.Show("Chưa nhập điểm. Hãy thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(Convert.ToDouble(txtDiem.Text) > 10 || Convert.ToDouble(txtDiem.Text) < 0)
            {
                MessageBox.Show("Điểm phải từ 0 - 10. Hãy thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lbDS.Items.Add(cmbMH.Text + " | " + txtTC.Text + " | " + txtDiem.Text);
            }
        }

        private void BtnTinh_Click(object sender, EventArgs e)
        {

            if (lbDS.Items.Count == 0)
            {
                MessageBox.Show("Bạn chưa nhập thông tin cho môn học nào!" +
                    " Hãy thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtTongTC.Text = Convert.ToString(tongTC);
                txtTongDiem.Text = Convert.ToString(tongD);
                txtDTB.Text = Convert.ToString(DTB);
            }
        }
    }
}
