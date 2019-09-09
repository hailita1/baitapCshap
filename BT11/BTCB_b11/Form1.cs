using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCB_b11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cbFONT.Items.Add(".vnTime");
            cbFONT.Items.Add(".vnTimeH");
            cbFONT.Items.Add(".vnArial");
            cbFONT.Items.Add(".vnArialH");
            cbFONT.Items.Add(".vnUniverse");
            cbFONT.Items.Add(".vnUniverseH");

            cbSIZE.Items.Add("14");
            cbSIZE.Items.Add("15");
            cbSIZE.Items.Add("16");
            cbSIZE.Items.Add("17");
            cbSIZE.Items.Add("18");
            cbSIZE.Items.Add("19");
            cbSIZE.Items.Add("20");
            cbSIZE.Items.Add("21");
            cbSIZE.Items.Add("22");
            cbSIZE.Items.Add("23");
            cbSIZE.Items.Add("24");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtLL_Click(object sender, EventArgs e)
        {
            cbFONT.SelectedItem = false;
            cbSIZE.SelectedItem = false;
            ckbDAM.Checked = false;
            ckbGACHCHAN.Checked = false;
            ckbNGHIENG.Checked = false;
            rbDEN.Checked = false;
            rbDO.Checked = false;
            rbXANH.Checked = false;
            textBox1.Clear();
        }

        private void CbFONT_SelectedValueChanged(object sender, EventArgs e)
        {
            checkFont(".vnTime");
            checkFont(".vnTimeH");
            checkFont(".vnArial");
            checkFont(".vnArialH");
            checkFont(".vnUniverse");
            checkFont(".vnUniverseH");
        }

        private void CbSIZE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFONT.Text == "")
            {
                if (cbSIZE.SelectedItem == "14")
                {
                    textBox1.Font = new Font("Microsoft Sans Serif", 14);
                }
                else if (cbSIZE.SelectedItem == "15")
                {
                    textBox1.Font = new Font("Microsoft Sans Serif", 15);
                }
                else if (cbSIZE.SelectedItem == "16")
                {
                    textBox1.Font = new Font("Microsoft Sans Serif", 16);
                }
                else if (cbSIZE.SelectedItem == "17")
                {
                    textBox1.Font = new Font("Microsoft Sans Serif", 17);
                }
                else if (cbSIZE.SelectedItem == "18")
                {
                    textBox1.Font = new Font("Microsoft Sans Serif", 18);
                }
                else if (cbSIZE.SelectedItem == "19")
                {
                    textBox1.Font = new Font("Microsoft Sans Serif", 19);
                }
                else if (cbSIZE.SelectedItem == "20")
                {
                    textBox1.Font = new Font("Microsoft Sans Serif", 20);
                }
                else if (cbSIZE.SelectedItem == "21")
                {
                    textBox1.Font = new Font("Microsoft Sans Serif", 21);
                }
                else if (cbSIZE.SelectedItem == "22")
                {
                    textBox1.Font = new Font("Microsoft Sans Serif", 22);
                }
                else if (cbSIZE.SelectedItem == "23")
                {
                    textBox1.Font = new Font("Microsoft Sans Serif", 23);
                }
                else if (cbSIZE.SelectedItem == "24")
                {
                    textBox1.Font = new Font("Microsoft Sans Serif", 24);
                }
            }
            else if (cbFONT.Text == ".vnTime")
            {
                if (cbSIZE.SelectedItem == "14")
                {
                    textBox1.Font = new Font(".vnTime", 14);
                }
                else if (cbSIZE.SelectedItem == "15")
                {
                    textBox1.Font = new Font(".vnTime", 15);
                }
                else if (cbSIZE.SelectedItem == "16")
                {
                    textBox1.Font = new Font(".vnTime", 16);
                }
                else if (cbSIZE.SelectedItem == "17")
                {
                    textBox1.Font = new Font(".vnTime", 17);
                }
                else if (cbSIZE.SelectedItem == "18")
                {
                    textBox1.Font = new Font(".vnTime", 18);
                }
                else if (cbSIZE.SelectedItem == "19")
                {
                    textBox1.Font = new Font(".vnTime", 19);
                }
                else if (cbSIZE.SelectedItem == "20")
                {
                    textBox1.Font = new Font(".vnTime", 20);
                }
                else if (cbSIZE.SelectedItem == "21")
                {
                    textBox1.Font = new Font(".vnTime", 21);
                }
                else if (cbSIZE.SelectedItem == "22")
                {
                    textBox1.Font = new Font(".vnTime", 22);
                }
                else if (cbSIZE.SelectedItem == "23")
                {
                    textBox1.Font = new Font(".vnTime", 23);
                }
                else if (cbSIZE.SelectedItem == "24")
                {
                    textBox1.Font = new Font(".vnTime", 24);
                }
            }
            else if (cbFONT.Text == ".vnTimeH")
            {
                if (cbSIZE.SelectedItem == "14")
                {
                    textBox1.Font = new Font(".vnTimeH", 14);
                }
                else if (cbSIZE.SelectedItem == "15")
                {
                    textBox1.Font = new Font(".vnTimeH", 15);
                }
                else if (cbSIZE.SelectedItem == "16")
                {
                    textBox1.Font = new Font(".vnTimeH", 16);
                }
                else if (cbSIZE.SelectedItem == "17")
                {
                    textBox1.Font = new Font(".vnTimeH", 17);
                }
                else if (cbSIZE.SelectedItem == "18")
                {
                    textBox1.Font = new Font(".vnTimeH", 18);
                }
                else if (cbSIZE.SelectedItem == "19")
                {
                    textBox1.Font = new Font(".vnTimeH", 19);
                }
                else if (cbSIZE.SelectedItem == "20")
                {
                    textBox1.Font = new Font(".vnTimeH", 20);
                }
                else if (cbSIZE.SelectedItem == "21")
                {
                    textBox1.Font = new Font(".vnTimeH", 21);
                }
                else if (cbSIZE.SelectedItem == "22")
                {
                    textBox1.Font = new Font(".vnTimeH", 22);
                }
                else if (cbSIZE.SelectedItem == "23")
                {
                    textBox1.Font = new Font(".vnTimeH", 23);
                }
                else if (cbSIZE.SelectedItem == "24")
                {
                    textBox1.Font = new Font(".vnTimeH", 24);
                }
            }
            else if (cbFONT.Text == ".vnArial")
            {
                if (cbSIZE.SelectedItem == "14")
                {
                    textBox1.Font = new Font(".vnArial", 14);
                }
                else if (cbSIZE.SelectedItem == "15")
                {
                    textBox1.Font = new Font(".vnArial", 15);
                }
                else if (cbSIZE.SelectedItem == "16")
                {
                    textBox1.Font = new Font(".vnArial", 16);
                }
                else if (cbSIZE.SelectedItem == "17")
                {
                    textBox1.Font = new Font(".vnArial", 17);
                }
                else if (cbSIZE.SelectedItem == "18")
                {
                    textBox1.Font = new Font(".vnArial", 18);
                }
                else if (cbSIZE.SelectedItem == "19")
                {
                    textBox1.Font = new Font(".vnArial", 19);
                }
                else if (cbSIZE.SelectedItem == "20")
                {
                    textBox1.Font = new Font(".vnArial", 20);
                }
                else if (cbSIZE.SelectedItem == "21")
                {
                    textBox1.Font = new Font(".vnArial", 21);
                }
                else if (cbSIZE.SelectedItem == "22")
                {
                    textBox1.Font = new Font(".vnArial", 22);
                }
                else if (cbSIZE.SelectedItem == "23")
                {
                    textBox1.Font = new Font(".vnArial", 23);
                }
                else if (cbSIZE.SelectedItem == "24")
                {
                    textBox1.Font = new Font(".vnArial", 24);
                }
            }
            else if (cbFONT.Text == ".vnArialH")
            {
                if (cbSIZE.SelectedItem == "14")
                {
                    textBox1.Font = new Font(".vnArialH", 14);
                }
                else if (cbSIZE.SelectedItem == "15")
                {
                    textBox1.Font = new Font(".vnArialH", 15);
                }
                else if (cbSIZE.SelectedItem == "16")
                {
                    textBox1.Font = new Font(".vnArialH", 16);
                }
                else if (cbSIZE.SelectedItem == "17")
                {
                    textBox1.Font = new Font(".vnArialH", 17);
                }
                else if (cbSIZE.SelectedItem == "18")
                {
                    textBox1.Font = new Font(".vnArialH", 18);
                }
                else if (cbSIZE.SelectedItem == "19")
                {
                    textBox1.Font = new Font(".vnArialH", 19);
                }
                else if (cbSIZE.SelectedItem == "20")
                {
                    textBox1.Font = new Font(".vnArialH", 20);
                }
                else if (cbSIZE.SelectedItem == "21")
                {
                    textBox1.Font = new Font(".vnArialH", 21);
                }
                else if (cbSIZE.SelectedItem == "22")
                {
                    textBox1.Font = new Font(".vnArialH", 22);
                }
                else if (cbSIZE.SelectedItem == "23")
                {
                    textBox1.Font = new Font(".vnArialH", 23);
                }
                else if (cbSIZE.SelectedItem == "24")
                {
                    textBox1.Font = new Font(".vnArialH", 24);
                }
            }
            else if (cbFONT.Text == ".vnUniverse")
            {
                if (cbSIZE.SelectedItem == "14")
                {
                    textBox1.Font = new Font(".vnUniverse", 14);
                }
                else if (cbSIZE.SelectedItem == "15")
                {
                    textBox1.Font = new Font(".vnUniverse", 15);
                }
                else if (cbSIZE.SelectedItem == "16")
                {
                    textBox1.Font = new Font(".vnUniverse", 16);
                }
                else if (cbSIZE.SelectedItem == "17")
                {
                    textBox1.Font = new Font(".vnUniverse", 17);
                }
                else if (cbSIZE.SelectedItem == "18")
                {
                    textBox1.Font = new Font(".vnUniverse", 18);
                }
                else if (cbSIZE.SelectedItem == "19")
                {
                    textBox1.Font = new Font(".vnUniverse", 19);
                }
                else if (cbSIZE.SelectedItem == "20")
                {
                    textBox1.Font = new Font(".vnUniverse", 20);
                }
                else if (cbSIZE.SelectedItem == "21")
                {
                    textBox1.Font = new Font(".vnUniverse", 21);
                }
                else if (cbSIZE.SelectedItem == "22")
                {
                    textBox1.Font = new Font(".vnUniverse", 22);
                }
                else if (cbSIZE.SelectedItem == "23")
                {
                    textBox1.Font = new Font(".vnUniverse", 23);
                }
                else if (cbSIZE.SelectedItem == "24")
                {
                    textBox1.Font = new Font(".vnUniverse", 24);
                }
            }
            else if (cbFONT.Text == ".vnUniverseH")
            {
                if (cbSIZE.SelectedItem == "14")
                {
                    textBox1.Font = new Font(".vnUniverseH", 14);
                }
                else if (cbSIZE.SelectedItem == "15")
                {
                    textBox1.Font = new Font(".vnUniverseH", 15);
                }
                else if (cbSIZE.SelectedItem == "16")
                {
                    textBox1.Font = new Font(".vnUniverseH", 16);
                }
                else if (cbSIZE.SelectedItem == "17")
                {
                    textBox1.Font = new Font(".vnUniverseH", 17);
                }
                else if (cbSIZE.SelectedItem == "18")
                {
                    textBox1.Font = new Font(".vnUniverseH", 18);
                }
                else if (cbSIZE.SelectedItem == "19")
                {
                    textBox1.Font = new Font(".vnUniverseH", 19);
                }
                else if (cbSIZE.SelectedItem == "20")
                {
                    textBox1.Font = new Font(".vnUniverseH", 20);
                }
                else if (cbSIZE.SelectedItem == "21")
                {
                    textBox1.Font = new Font(".vnUniverseH", 21);
                }
                else if (cbSIZE.SelectedItem == "22")
                {
                    textBox1.Font = new Font(".vnUniverseH", 22);
                }
                else if (cbSIZE.SelectedItem == "23")
                {
                    textBox1.Font = new Font(".vnUniverseH", 23);
                }
                else if (cbSIZE.SelectedItem == "24")
                {
                    textBox1.Font = new Font(".vnUniverseH", 24);
                }
            }
            if(ckbDAM.Checked == true)
            {
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Bold);
            }
            if(ckbNGHIENG.Checked == true){
                CkbNGHIENG_Click(null,null);
            }
            if(ckbGACHCHAN.Checked == true){
                CkbGACHCHAN_Click(null,null);
            }
        }

        private void CkbDAM_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Bold);
        }

        private void CkbNGHIENG_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Italic);
        }

        private void CkbGACHCHAN_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Underline); 
        }

        private void RbDO_Click(object sender, EventArgs e)
        {
            if (rbDO.Checked == true)
            {
                textBox1.ForeColor = Color.Red;
            }
            if (rbDO.Checked == false)
            {
                textBox1.ForeColor = Color.Red;
            }
        }

        private void RbXANH_Click(object sender, EventArgs e)
        {
            if (rbDO.Checked == true)
            {
                textBox1.ForeColor = Color.Green;
            }
            if (rbDO.Checked == false)
            {
                textBox1.ForeColor = Color.Green;
            }
        }

        private void RbDEN_Click(object sender, EventArgs e)
        {
            if (rbDO.Checked == true)
            {
                textBox1.ForeColor = Color.Black;
            }
            if (rbDO.Checked == false)
            {
                textBox1.ForeColor = Color.Black;
            }
        }

        public void checkFont(string a)
        {
            if (cbFONT.SelectedItem == "" + a)
            {
                FontFamily f = new FontFamily("" + a);
                textBox1.Font = new Font(f, textBox1.Font.Size);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
                if (e.Alt)
                {
                    if (e.KeyCode.Equals(Keys.T))
                    {
                        Button2_Click(null, null);
                    }
                    if (e.KeyCode.Equals(Keys.L))
                    {
                        BtLL_Click(null, null);
                    }
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}
