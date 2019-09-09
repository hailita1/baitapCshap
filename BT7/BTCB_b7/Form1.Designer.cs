namespace BTCB_b7
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
            this.tbNhapso = new System.Windows.Forms.TextBox();
            this.btNhapday = new System.Windows.Forms.Button();
            this.lbHTday = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCN = new System.Windows.Forms.ComboBox();
            this.lbKQ = new System.Windows.Forms.Label();
            this.btLL = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số phần tử của dãy:";
            // 
            // tbNhapso
            // 
            this.tbNhapso.Location = new System.Drawing.Point(175, 33);
            this.tbNhapso.Name = "tbNhapso";
            this.tbNhapso.Size = new System.Drawing.Size(51, 20);
            this.tbNhapso.TabIndex = 1;
            this.tbNhapso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNhapso_KeyPress);
            // 
            // btNhapday
            // 
            this.btNhapday.Location = new System.Drawing.Point(307, 31);
            this.btNhapday.Name = "btNhapday";
            this.btNhapday.Size = new System.Drawing.Size(75, 23);
            this.btNhapday.TabIndex = 2;
            this.btNhapday.Text = "Nhập dãy";
            this.btNhapday.UseVisualStyleBackColor = true;
            this.btNhapday.Click += new System.EventHandler(this.BtNhapday_Click);
            // 
            // lbHTday
            // 
            this.lbHTday.AutoSize = true;
            this.lbHTday.Location = new System.Drawing.Point(29, 80);
            this.lbHTday.Name = "lbHTday";
            this.lbHTday.Size = new System.Drawing.Size(105, 13);
            this.lbHTday.TabIndex = 3;
            this.lbHTday.Text = "Dãy số vừa nhập là: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chọn chức năng:";
            // 
            // cbCN
            // 
            this.cbCN.FormattingEnabled = true;
            this.cbCN.Location = new System.Drawing.Point(124, 123);
            this.cbCN.Name = "cbCN";
            this.cbCN.Size = new System.Drawing.Size(177, 21);
            this.cbCN.TabIndex = 5;
            this.cbCN.SelectedValueChanged += new System.EventHandler(this.CbCN_SelectedValueChanged);
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Location = new System.Drawing.Point(32, 174);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(21, 13);
            this.lbKQ.TabIndex = 6;
            this.lbKQ.Text = "lb2";
            // 
            // btLL
            // 
            this.btLL.Location = new System.Drawing.Point(195, 246);
            this.btLL.Name = "btLL";
            this.btLL.Size = new System.Drawing.Size(75, 23);
            this.btLL.TabIndex = 7;
            this.btLL.Text = "Làm lại";
            this.btLL.UseVisualStyleBackColor = true;
            this.btLL.Click += new System.EventHandler(this.BtLL_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(307, 246);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 8;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.BtThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 292);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btLL);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.cbCN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbHTday);
            this.Controls.Add(this.btNhapday);
            this.Controls.Add(this.tbNhapso);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNhapso;
        private System.Windows.Forms.Button btNhapday;
        private System.Windows.Forms.Label lbHTday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCN;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.Button btLL;
        private System.Windows.Forms.Button btThoat;
    }
}

