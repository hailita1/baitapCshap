namespace BTCB_b10
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPTBH = new System.Windows.Forms.RadioButton();
            this.rbPTBN = new System.Windows.Forms.RadioButton();
            this.lbNhapa = new System.Windows.Forms.Label();
            this.lbNhapb = new System.Windows.Forms.Label();
            this.lbNhapc = new System.Windows.Forms.Label();
            this.lbKQ = new System.Windows.Forms.Label();
            this.tbNhapa = new System.Windows.Forms.TextBox();
            this.tbNhapb = new System.Windows.Forms.TextBox();
            this.tbNhapc = new System.Windows.Forms.TextBox();
            this.tbKQ = new System.Windows.Forms.TextBox();
            this.btGPT = new System.Windows.Forms.Button();
            this.btLL = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(139, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải Phương Trình";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPTBH);
            this.groupBox1.Controls.Add(this.rbPTBN);
            this.groupBox1.Location = new System.Drawing.Point(27, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chức năng";
            // 
            // rbPTBH
            // 
            this.rbPTBH.AutoSize = true;
            this.rbPTBH.Location = new System.Drawing.Point(62, 53);
            this.rbPTBH.Name = "rbPTBH";
            this.rbPTBH.Size = new System.Drawing.Size(123, 17);
            this.rbPTBH.TabIndex = 1;
            this.rbPTBH.Text = "Phương trình bậc hai";
            this.rbPTBH.UseVisualStyleBackColor = true;
            this.rbPTBH.CheckedChanged += new System.EventHandler(this.RbPTBH_CheckedChanged);
            // 
            // rbPTBN
            // 
            this.rbPTBN.AutoSize = true;
            this.rbPTBN.Location = new System.Drawing.Point(62, 19);
            this.rbPTBN.Name = "rbPTBN";
            this.rbPTBN.Size = new System.Drawing.Size(130, 17);
            this.rbPTBN.TabIndex = 0;
            this.rbPTBN.Text = "Phương trình bậc nhất";
            this.rbPTBN.UseVisualStyleBackColor = true;
            this.rbPTBN.CheckedChanged += new System.EventHandler(this.RbPTBN_CheckedChanged);
            // 
            // lbNhapa
            // 
            this.lbNhapa.AutoSize = true;
            this.lbNhapa.Location = new System.Drawing.Point(21, 164);
            this.lbNhapa.Name = "lbNhapa";
            this.lbNhapa.Size = new System.Drawing.Size(45, 13);
            this.lbNhapa.TabIndex = 2;
            this.lbNhapa.Text = "Nhập a:";
            // 
            // lbNhapb
            // 
            this.lbNhapb.AutoSize = true;
            this.lbNhapb.Location = new System.Drawing.Point(21, 201);
            this.lbNhapb.Name = "lbNhapb";
            this.lbNhapb.Size = new System.Drawing.Size(45, 13);
            this.lbNhapb.TabIndex = 3;
            this.lbNhapb.Text = "Nhập b:";
            // 
            // lbNhapc
            // 
            this.lbNhapc.AutoSize = true;
            this.lbNhapc.Location = new System.Drawing.Point(21, 238);
            this.lbNhapc.Name = "lbNhapc";
            this.lbNhapc.Size = new System.Drawing.Size(45, 13);
            this.lbNhapc.TabIndex = 4;
            this.lbNhapc.Text = "Nhập c:";
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Location = new System.Drawing.Point(21, 275);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(47, 13);
            this.lbKQ.TabIndex = 5;
            this.lbKQ.Text = "Kết quả:";
            // 
            // tbNhapa
            // 
            this.tbNhapa.Location = new System.Drawing.Point(89, 161);
            this.tbNhapa.Multiline = true;
            this.tbNhapa.Name = "tbNhapa";
            this.tbNhapa.Size = new System.Drawing.Size(183, 20);
            this.tbNhapa.TabIndex = 6;
            this.tbNhapa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNhapa_KeyPress);
            // 
            // tbNhapb
            // 
            this.tbNhapb.Location = new System.Drawing.Point(89, 198);
            this.tbNhapb.Multiline = true;
            this.tbNhapb.Name = "tbNhapb";
            this.tbNhapb.Size = new System.Drawing.Size(183, 20);
            this.tbNhapb.TabIndex = 7;
            this.tbNhapb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNhapb_KeyPress);
            // 
            // tbNhapc
            // 
            this.tbNhapc.Location = new System.Drawing.Point(89, 235);
            this.tbNhapc.Multiline = true;
            this.tbNhapc.Name = "tbNhapc";
            this.tbNhapc.Size = new System.Drawing.Size(183, 20);
            this.tbNhapc.TabIndex = 8;
            this.tbNhapc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNhapc_KeyPress);
            // 
            // tbKQ
            // 
            this.tbKQ.Location = new System.Drawing.Point(89, 272);
            this.tbKQ.Multiline = true;
            this.tbKQ.Name = "tbKQ";
            this.tbKQ.ReadOnly = true;
            this.tbKQ.Size = new System.Drawing.Size(183, 63);
            this.tbKQ.TabIndex = 9;
            // 
            // btGPT
            // 
            this.btGPT.Location = new System.Drawing.Point(286, 164);
            this.btGPT.Name = "btGPT";
            this.btGPT.Size = new System.Drawing.Size(102, 33);
            this.btGPT.TabIndex = 10;
            this.btGPT.Text = "Giải phương trình";
            this.btGPT.UseVisualStyleBackColor = true;
            this.btGPT.Click += new System.EventHandler(this.BtGPT_Click);
            // 
            // btLL
            // 
            this.btLL.Location = new System.Drawing.Point(286, 223);
            this.btLL.Name = "btLL";
            this.btLL.Size = new System.Drawing.Size(102, 33);
            this.btLL.TabIndex = 11;
            this.btLL.Text = "Làm lại";
            this.btLL.UseVisualStyleBackColor = true;
            this.btLL.Click += new System.EventHandler(this.BtLL_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(286, 282);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(102, 33);
            this.btThoat.TabIndex = 12;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.BtThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 347);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btLL);
            this.Controls.Add(this.btGPT);
            this.Controls.Add(this.tbKQ);
            this.Controls.Add(this.tbNhapc);
            this.Controls.Add(this.tbNhapb);
            this.Controls.Add(this.tbNhapa);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.lbNhapc);
            this.Controls.Add(this.lbNhapb);
            this.Controls.Add(this.lbNhapa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Giải phuong trình";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPTBH;
        private System.Windows.Forms.RadioButton rbPTBN;
        private System.Windows.Forms.Label lbNhapa;
        private System.Windows.Forms.Label lbNhapb;
        private System.Windows.Forms.Label lbNhapc;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.TextBox tbNhapa;
        private System.Windows.Forms.TextBox tbNhapb;
        private System.Windows.Forms.TextBox tbNhapc;
        private System.Windows.Forms.TextBox tbKQ;
        private System.Windows.Forms.Button btGPT;
        private System.Windows.Forms.Button btLL;
        private System.Windows.Forms.Button btThoat;
    }
}

