using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3
{
    public partial class Form1 : Form
    {
        private List<KhachHang> khachHangs = new List<KhachHang>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TbGiaDuThuyen_TextChanged(object sender, EventArgs e)
        {
        }

        private void RBtnCaNgay_CheckedChanged(object sender, EventArgs e)
        {
            tbGiaDuThuyen.Text = "200";
        }

        private void RBtnNuaNgay_CheckedChanged(object sender, EventArgs e)
        {
            tbGiaDuThuyen.Text = "100";
        }

        private void CbbSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbbDoUong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TbTien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
