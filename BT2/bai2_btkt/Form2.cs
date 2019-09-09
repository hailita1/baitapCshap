using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2_btkt
{
    public partial class Form2 : Form
    {
        List<NguoiGui> listNguoiGuis;
        public Form2()
        {
            InitializeComponent();
            listNguoiGuis = StaticData.NguoiGuis;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int timthay = 0;
            foreach (NguoiGui i in listNguoiGuis)
            {
                if (i.MaKH1 == Convert.ToInt32(textBox1.Text))
                {
                    timthay = 1;

                    textBox2.Text = "Khách hàng " + i.TenKH1 + " phải trả "+ i.Tien1 + " nghìn đồng ";
                }
            }

            if (timthay == 0)
            {
                textBox2.Text = "Khách hàng " + textBox1.Text + " không có trong danh sách";
            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int timthay = 0;
            foreach (NguoiGui i in listNguoiGuis)
            {
                if (i.TenKH1.Equals(textBox1.Text))
                {
                    timthay = 1;

                    textBox2.Text = "Khách hàng " + i.TenKH1 + " phải trả " + i.Tien1 + " nghìn đồng ";
                }
            }

            if (timthay == 0)
            {
                textBox2.Text = "Khách hàng " + textBox1.Text + " không có trong danh sách";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            String nguoiGuiNhieuNhat = "";
            Double max = 0;
            foreach(NguoiGui i in listNguoiGuis)
            {
                if(i.Tien1 > max)
                {
                    max = i.Tien1;
                }
            }
            foreach (NguoiGui i in listNguoiGuis)
            {
                if (i.Tien1 == max)
                {
                    nguoiGuiNhieuNhat = i.TenKH1;
                }
            }
            textBox2.Text = nguoiGuiNhieuNhat + "gửi nhiều nhất!";
        }
    }
    }
