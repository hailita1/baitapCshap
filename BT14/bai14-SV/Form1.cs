using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai14_SV
{
    public partial class Form1 : Form
    {
        int stt = 0;
        List<string> DS = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddComboBox()
        {
            cmbKhoa.Items.Add("Công trình");
            cmbKhoa.Items.Add("Công nghệ thông tin");
            cmbKhoa.Items.Add("Vận tải kinh tế");

            cmbYear.Items.Add("53");
            cmbYear.Items.Add("54");
            cmbYear.Items.Add("55");

            lbGT.Items.Add("Tin học đại cương");
            lbGT.Items.Add("Triết học");
            lbGT.Items.Add("Cơ lý thuyết");
            lbGT.Items.Add("Vật lý đại cương");
            lbGT.Items.Add("Giải tích");
            lbGT.Items.Add("Cơ sở dữ liệu");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddComboBox();
            this.KeyPreview = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode.Equals(Keys.H))
                {
                    BtnExit_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.L))
                {
                    BtnRedo_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.K))
                {
                    BtnDK_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.X))
                {
                    BtnDEL_Click(null, null);
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes ==
                MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void BtnRedo_Click(object sender, EventArgs e)
        {
            txtHT.Text = null;
            cmbKhoa.Text = null;
            cmbYear.Text = null;
            lbGT.SelectedItem = null;
        }

        private void BtnDK_Click(object sender, EventArgs e)
        {

            stt += 1;
            if (txtHT.TextLength == 0 || cmbKhoa.Text == null || cmbYear.Text == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string a = " ";
                foreach (object GTs in lbGT.SelectedItems)
                {
                    a += GTs.ToString() + ", ";
                }
                lbDS.Items.Add(+stt + " | " + txtHT.Text + " | " + cmbKhoa.Text + " | " +
                         cmbYear.Text + " | " + "ĐK: " + a);
                DS.Add(txtHT.Text + " | " + cmbKhoa.Text + " | " +
                         cmbYear.Text + " | " + "ĐK: " + a);
            }
        }

        private void BtnDEL_Click(object sender, EventArgs e)
        {
            if (lbDS.SelectedItems.Count != 0)
            {
                while (lbDS.SelectedIndices.Count != 0)
                {
                    if (DialogResult.Yes ==
                            MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        for (int i = 0; i < lbDS.SelectedIndices.Count; i++)
                        {
                            DS.RemoveAt(lbDS.SelectedIndex);
                        }
                        lbDS.Items.Clear();
                        stt = 1; string a = " ";
                        for (int i = 0; i < lbDS.SelectedIndices.Count; i++)
                        {
                            foreach (object GTs in lbGT.SelectedItems)
                            {
                                a += GTs.ToString() + ", ";
                            }
                        }
                        foreach (object gt in DS)
                        {
                            lbDS.Items.Add(stt + " | " + gt);
                            stt++;
                        }
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Bạn cần chọn item để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


// label5.Text += (label5.Text == "" ? "" : ",") + GTs.ToString();
//    label5.Text = "";
