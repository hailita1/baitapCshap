using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không ","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes){
                this.Close();
            }
        }

        private void TxtAddNew_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiachi.Text = "";
            txtSTruoc.Text = "";
            txtSNay.Text = "";
        }

        private void TxtSTruoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtSNay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnAddDS_Click(object sender, EventArgs e)
        {
            if (txtMaKH.TextLength < 6)
            {
                MessageBox.Show("Mã khách hàng có >= 6 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKH.Clear();
                txtMaKH.Focus();
            }
            else if(txtTenKH.Text=="" || txtDiachi.Text == "")
            {
                MessageBox.Show("Tên khách hàng và địa chỉ không được để trống","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if(txtSTruoc.Text == "" || txtSNay.Text == "")
            {
                MessageBox.Show("Phải nhập vào số tháng này và số tháng trước","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else {
            double sotruoc = Convert.ToDouble(txtSTruoc.Text);
            double sonay = Convert.ToDouble(txtSNay.Text);
            double hieu = sonay - sotruoc;
            double tongtien = 0;
            double thanhtoan;
            if (hieu < 0)
            {
                MessageBox.Show("Số điện tháng này phải lớn hơn số điện cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSTruoc.Clear();
                txtSNay.Clear();
                txtSTruoc.Focus();
                return;
            }
            if (hieu > 201)
            {
                tongtien = (hieu - 201) * 400 ;
                hieu = 201;
            }else if (hieu > 100)
            {
                tongtien = (hieu - 100) * 300;
                hieu = 100;
            }
            else if(hieu > 50)
            {
                tongtien = hieu * 200;
                hieu = 50;
            }
            else
            {
                tongtien = hieu * 100;
            }
            tongtien += tongtien ;
            thanhtoan = tongtien + tongtien * 0.1;
            ListHienThi.Items.Add(txtMaKH.Text + " | " + txtTenKH.Text +" | "+ txtDiachi.Text  +" | "+txtSTruoc.Text +" | "+txtSNay.Text +" | "+thanhtoan.ToString());
        }
}
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            FormSearch dlg2 = new FormSearch();
            dlg2.ShowDialog();
        }
    }
}
