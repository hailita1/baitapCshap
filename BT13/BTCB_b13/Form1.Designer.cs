namespace BTCB_b13
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbSopt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbDay = new System.Windows.Forms.Label();
            this.btSDNN = new System.Windows.Forms.Button();
            this.lbSDNN = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSok = new System.Windows.Forms.TextBox();
            this.btTim = new System.Windows.Forms.Button();
            this.btLL = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số phần tử: ";
            // 
            // tbSopt
            // 
            this.tbSopt.Location = new System.Drawing.Point(141, 19);
            this.tbSopt.Name = "tbSopt";
            this.tbSopt.Size = new System.Drawing.Size(100, 20);
            this.tbSopt.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nhập dãy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Location = new System.Drawing.Point(12, 61);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(35, 13);
            this.lbDay.TabIndex = 3;
            this.lbDay.Text = "label2";
            // 
            // btSDNN
            // 
            this.btSDNN.Location = new System.Drawing.Point(12, 98);
            this.btSDNN.Name = "btSDNN";
            this.btSDNN.Size = new System.Drawing.Size(131, 23);
            this.btSDNN.TabIndex = 4;
            this.btSDNN.Text = "Tìm số dương nhỏ nhất";
            this.btSDNN.UseVisualStyleBackColor = true;
            this.btSDNN.Click += new System.EventHandler(this.BtSDNN_Click);
            // 
            // lbSDNN
            // 
            this.lbSDNN.AutoSize = true;
            this.lbSDNN.Location = new System.Drawing.Point(12, 139);
            this.lbSDNN.Name = "lbSDNN";
            this.lbSDNN.Size = new System.Drawing.Size(35, 13);
            this.lbSDNN.TabIndex = 5;
            this.lbSDNN.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhập 1 số k = ";
            // 
            // tbSok
            // 
            this.tbSok.Location = new System.Drawing.Point(141, 172);
            this.tbSok.Name = "tbSok";
            this.tbSok.Size = new System.Drawing.Size(100, 20);
            this.tbSok.TabIndex = 7;
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(305, 171);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 23);
            this.btTim.TabIndex = 8;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.BtTim_Click);
            // 
            // btLL
            // 
            this.btLL.Location = new System.Drawing.Point(202, 226);
            this.btLL.Name = "btLL";
            this.btLL.Size = new System.Drawing.Size(75, 23);
            this.btLL.TabIndex = 9;
            this.btLL.Text = "Làm lại";
            this.btLL.UseVisualStyleBackColor = true;
            this.btLL.Click += new System.EventHandler(this.BtLL_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(305, 226);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 10;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.BtThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 268);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btLL);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.tbSok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSDNN);
            this.Controls.Add(this.btSDNN);
            this.Controls.Add(this.lbDay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbSopt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSopt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.Button btSDNN;
        private System.Windows.Forms.Label lbSDNN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSok;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Button btLL;
        private System.Windows.Forms.Button btThoat;
    }
}

