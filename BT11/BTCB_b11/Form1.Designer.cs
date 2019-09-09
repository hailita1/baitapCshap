namespace BTCB_b11
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSIZE = new System.Windows.Forms.ComboBox();
            this.cbFONT = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbGACHCHAN = new System.Windows.Forms.CheckBox();
            this.ckbNGHIENG = new System.Windows.Forms.CheckBox();
            this.ckbDAM = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbDEN = new System.Windows.Forms.RadioButton();
            this.rbXANH = new System.Windows.Forms.RadioButton();
            this.rbDO = new System.Windows.Forms.RadioButton();
            this.btLL = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 50);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbSIZE);
            this.groupBox1.Controls.Add(this.cbFONT);
            this.groupBox1.Location = new System.Drawing.Point(22, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiểu chữ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kích thước";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Font";
            // 
            // cbSIZE
            // 
            this.cbSIZE.FormattingEnabled = true;
            this.cbSIZE.Location = new System.Drawing.Point(291, 19);
            this.cbSIZE.Name = "cbSIZE";
            this.cbSIZE.Size = new System.Drawing.Size(121, 21);
            this.cbSIZE.TabIndex = 1;
            this.cbSIZE.SelectedIndexChanged += new System.EventHandler(this.CbSIZE_SelectedIndexChanged);
            // 
            // cbFONT
            // 
            this.cbFONT.FormattingEnabled = true;
            this.cbFONT.Location = new System.Drawing.Point(62, 19);
            this.cbFONT.Name = "cbFONT";
            this.cbFONT.Size = new System.Drawing.Size(121, 21);
            this.cbFONT.TabIndex = 0;
            this.cbFONT.SelectedValueChanged += new System.EventHandler(this.CbFONT_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbGACHCHAN);
            this.groupBox2.Controls.Add(this.ckbNGHIENG);
            this.groupBox2.Controls.Add(this.ckbDAM);
            this.groupBox2.Location = new System.Drawing.Point(22, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 59);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HIệu ứng chữ";
            // 
            // ckbGACHCHAN
            // 
            this.ckbGACHCHAN.AutoSize = true;
            this.ckbGACHCHAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbGACHCHAN.Location = new System.Drawing.Point(327, 30);
            this.ckbGACHCHAN.Name = "ckbGACHCHAN";
            this.ckbGACHCHAN.Size = new System.Drawing.Size(79, 17);
            this.ckbGACHCHAN.TabIndex = 2;
            this.ckbGACHCHAN.Text = "Gạch chân";
            this.ckbGACHCHAN.UseVisualStyleBackColor = true;
            this.ckbGACHCHAN.Click += new System.EventHandler(this.CkbGACHCHAN_Click);
            // 
            // ckbNGHIENG
            // 
            this.ckbNGHIENG.AutoSize = true;
            this.ckbNGHIENG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNGHIENG.Location = new System.Drawing.Point(174, 30);
            this.ckbNGHIENG.Name = "ckbNGHIENG";
            this.ckbNGHIENG.Size = new System.Drawing.Size(66, 17);
            this.ckbNGHIENG.TabIndex = 1;
            this.ckbNGHIENG.Text = "Nghiêng";
            this.ckbNGHIENG.UseVisualStyleBackColor = true;
            this.ckbNGHIENG.Click += new System.EventHandler(this.CkbNGHIENG_Click);
            // 
            // ckbDAM
            // 
            this.ckbDAM.AutoSize = true;
            this.ckbDAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbDAM.Location = new System.Drawing.Point(23, 30);
            this.ckbDAM.Name = "ckbDAM";
            this.ckbDAM.Size = new System.Drawing.Size(51, 17);
            this.ckbDAM.TabIndex = 0;
            this.ckbDAM.Text = "Đậm";
            this.ckbDAM.UseVisualStyleBackColor = true;
            this.ckbDAM.Click += new System.EventHandler(this.CkbDAM_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbDEN);
            this.groupBox3.Controls.Add(this.rbXANH);
            this.groupBox3.Controls.Add(this.rbDO);
            this.groupBox3.Location = new System.Drawing.Point(22, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 59);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Màu chữ";
            // 
            // rbDEN
            // 
            this.rbDEN.AutoSize = true;
            this.rbDEN.ForeColor = System.Drawing.Color.Black;
            this.rbDEN.Location = new System.Drawing.Point(327, 31);
            this.rbDEN.Name = "rbDEN";
            this.rbDEN.Size = new System.Drawing.Size(45, 17);
            this.rbDEN.TabIndex = 2;
            this.rbDEN.Text = "Đen";
            this.rbDEN.UseVisualStyleBackColor = true;
            this.rbDEN.Click += new System.EventHandler(this.RbDEN_Click);
            // 
            // rbXANH
            // 
            this.rbXANH.AutoSize = true;
            this.rbXANH.ForeColor = System.Drawing.Color.Green;
            this.rbXANH.Location = new System.Drawing.Point(174, 31);
            this.rbXANH.Name = "rbXANH";
            this.rbXANH.Size = new System.Drawing.Size(81, 17);
            this.rbXANH.TabIndex = 1;
            this.rbXANH.Text = "Xanh lá cây";
            this.rbXANH.UseVisualStyleBackColor = true;
            this.rbXANH.Click += new System.EventHandler(this.RbXANH_Click);
            // 
            // rbDO
            // 
            this.rbDO.AutoSize = true;
            this.rbDO.ForeColor = System.Drawing.Color.Red;
            this.rbDO.Location = new System.Drawing.Point(23, 31);
            this.rbDO.Name = "rbDO";
            this.rbDO.Size = new System.Drawing.Size(39, 17);
            this.rbDO.TabIndex = 0;
            this.rbDO.Text = "Đỏ";
            this.rbDO.UseVisualStyleBackColor = true;
            this.rbDO.Click += new System.EventHandler(this.RbDO_Click);
            // 
            // btLL
            // 
            this.btLL.Location = new System.Drawing.Point(121, 303);
            this.btLL.Name = "btLL";
            this.btLL.Size = new System.Drawing.Size(84, 34);
            this.btLL.TabIndex = 4;
            this.btLL.Text = "Làm lại";
            this.btLL.UseVisualStyleBackColor = true;
            this.btLL.Click += new System.EventHandler(this.BtLL_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 349);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btLL);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Thay đổi font chữ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btLL;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbSIZE;
        private System.Windows.Forms.ComboBox cbFONT;
        private System.Windows.Forms.CheckBox ckbGACHCHAN;
        private System.Windows.Forms.CheckBox ckbNGHIENG;
        private System.Windows.Forms.CheckBox ckbDAM;
        private System.Windows.Forms.RadioButton rbDEN;
        private System.Windows.Forms.RadioButton rbXANH;
        private System.Windows.Forms.RadioButton rbDO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

