namespace BT3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTien = new System.Windows.Forms.TextBox();
            this.cbbSoLuong = new System.Windows.Forms.ComboBox();
            this.cbbDoUong = new System.Windows.Forms.ComboBox();
            this.tbGiaDuThuyen = new System.Windows.Forms.TextBox();
            this.rBtnNuaNgay = new System.Windows.Forms.RadioButton();
            this.rBtnCaNgay = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnThemVaoDS = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTien);
            this.groupBox1.Controls.Add(this.cbbSoLuong);
            this.groupBox1.Controls.Add(this.cbbDoUong);
            this.groupBox1.Controls.Add(this.tbGiaDuThuyen);
            this.groupBox1.Controls.Add(this.rBtnNuaNgay);
            this.groupBox1.Controls.Add(this.rBtnCaNgay);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.btnThemVaoDS);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách hàng đặt tour";
            // 
            // tbTien
            // 
            this.tbTien.Location = new System.Drawing.Point(244, 170);
            this.tbTien.Name = "tbTien";
            this.tbTien.Size = new System.Drawing.Size(57, 20);
            this.tbTien.TabIndex = 13;
            this.tbTien.TextChanged += new System.EventHandler(this.TbTien_TextChanged);
            // 
            // cbbSoLuong
            // 
            this.cbbSoLuong.FormattingEnabled = true;
            this.cbbSoLuong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbbSoLuong.Location = new System.Drawing.Point(159, 170);
            this.cbbSoLuong.Name = "cbbSoLuong";
            this.cbbSoLuong.Size = new System.Drawing.Size(61, 21);
            this.cbbSoLuong.TabIndex = 12;
            this.cbbSoLuong.SelectedIndexChanged += new System.EventHandler(this.CbbSoLuong_SelectedIndexChanged);
            // 
            // cbbDoUong
            // 
            this.cbbDoUong.FormattingEnabled = true;
            this.cbbDoUong.Items.AddRange(new object[] {
            "Coca",
            "Pepsi",
            "7UP"});
            this.cbbDoUong.Location = new System.Drawing.Point(28, 170);
            this.cbbDoUong.Name = "cbbDoUong";
            this.cbbDoUong.Size = new System.Drawing.Size(113, 21);
            this.cbbDoUong.TabIndex = 11;
            this.cbbDoUong.SelectedIndexChanged += new System.EventHandler(this.CbbDoUong_SelectedIndexChanged);
            // 
            // tbGiaDuThuyen
            // 
            this.tbGiaDuThuyen.Location = new System.Drawing.Point(120, 85);
            this.tbGiaDuThuyen.Name = "tbGiaDuThuyen";
            this.tbGiaDuThuyen.Size = new System.Drawing.Size(167, 20);
            this.tbGiaDuThuyen.TabIndex = 10;
            this.tbGiaDuThuyen.TextChanged += new System.EventHandler(this.TbGiaDuThuyen_TextChanged);
            // 
            // rBtnNuaNgay
            // 
            this.rBtnNuaNgay.AutoSize = true;
            this.rBtnNuaNgay.Location = new System.Drawing.Point(174, 55);
            this.rBtnNuaNgay.Name = "rBtnNuaNgay";
            this.rBtnNuaNgay.Size = new System.Drawing.Size(71, 17);
            this.rBtnNuaNgay.TabIndex = 9;
            this.rBtnNuaNgay.TabStop = true;
            this.rBtnNuaNgay.Text = "Nửa ngày";
            this.rBtnNuaNgay.UseVisualStyleBackColor = true;
            this.rBtnNuaNgay.CheckedChanged += new System.EventHandler(this.RBtnNuaNgay_CheckedChanged);
            // 
            // rBtnCaNgay
            // 
            this.rBtnCaNgay.AutoSize = true;
            this.rBtnCaNgay.Location = new System.Drawing.Point(49, 55);
            this.rBtnCaNgay.Name = "rBtnCaNgay";
            this.rBtnCaNgay.Size = new System.Drawing.Size(64, 17);
            this.rBtnCaNgay.TabIndex = 8;
            this.rBtnCaNgay.TabStop = true;
            this.rBtnCaNgay.Text = "Cả ngày";
            this.rBtnCaNgay.UseVisualStyleBackColor = true;
            this.rBtnCaNgay.CheckedChanged += new System.EventHandler(this.RBtnCaNgay_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 7;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(212, 224);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 6;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            // 
            // btnThemVaoDS
            // 
            this.btnThemVaoDS.Location = new System.Drawing.Point(28, 224);
            this.btnThemVaoDS.Name = "btnThemVaoDS";
            this.btnThemVaoDS.Size = new System.Drawing.Size(136, 23);
            this.btnThemVaoDS.TabIndex = 5;
            this.btnThemVaoDS.Text = "Thêm vào danh sách";
            this.btnThemVaoDS.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn đồ uống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá du thuyền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(346, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 231);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đặt tour";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(318, 205);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(516, 250);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(155, 36);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 306);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnThemVaoDS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox tbTien;
        private System.Windows.Forms.ComboBox cbbSoLuong;
        private System.Windows.Forms.ComboBox cbbDoUong;
        private System.Windows.Forms.TextBox tbGiaDuThuyen;
        private System.Windows.Forms.RadioButton rBtnNuaNgay;
        private System.Windows.Forms.RadioButton rBtnCaNgay;
        private System.Windows.Forms.TextBox textBox1;
    }
}

