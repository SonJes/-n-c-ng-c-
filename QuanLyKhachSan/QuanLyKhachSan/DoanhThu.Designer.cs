namespace QuanLyKhachSan
{
    partial class DoanhThu
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
            this.label5 = new System.Windows.Forms.Label();
            this.lb_dt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_t = new System.Windows.Forms.TextBox();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.bt_tim = new System.Windows.Forms.Button();
            this.rd_mp = new System.Windows.Forms.RadioButton();
            this.Tienphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rd_thang = new System.Windows.Forms.RadioButton();
            this.rd_ngay = new System.Windows.Forms.RadioButton();
            this.dg = new System.Windows.Forms.DataGridView();
            this.txt_mp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 261);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 89;
            this.label5.Text = "Vnd";
            // 
            // lb_dt
            // 
            this.lb_dt.AutoSize = true;
            this.lb_dt.Location = new System.Drawing.Point(190, 261);
            this.lb_dt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_dt.Name = "lb_dt";
            this.lb_dt.Size = new System.Drawing.Size(35, 13);
            this.lb_dt.TabIndex = 88;
            this.lb_dt.Text = "Trống";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 86;
            this.label4.Text = "Tổng doanh thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Đến ngày";
            // 
            // txt_t
            // 
            this.txt_t.Location = new System.Drawing.Point(183, 205);
            this.txt_t.Margin = new System.Windows.Forms.Padding(4);
            this.txt_t.Name = "txt_t";
            this.txt_t.Size = new System.Drawing.Size(159, 20);
            this.txt_t.TabIndex = 95;
            this.txt_t.Text = "1/ or 12";
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(276, 145);
            this.txt_n2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(66, 20);
            this.txt_n2.TabIndex = 84;
            this.txt_n2.Text = "31/12";
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(118, 145);
            this.txt_n1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(65, 20);
            this.txt_n1.TabIndex = 81;
            this.txt_n1.Text = "31/12";
            // 
            // bt_tim
            // 
            this.bt_tim.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_tim.ForeColor = System.Drawing.Color.LightCyan;
            this.bt_tim.Location = new System.Drawing.Point(230, 303);
            this.bt_tim.Margin = new System.Windows.Forms.Padding(4);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(112, 32);
            this.bt_tim.TabIndex = 94;
            this.bt_tim.Text = "Tìm";
            this.bt_tim.UseVisualStyleBackColor = false;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // rd_mp
            // 
            this.rd_mp.AutoSize = true;
            this.rd_mp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_mp.ForeColor = System.Drawing.Color.DarkCyan;
            this.rd_mp.Location = new System.Drawing.Point(10, 63);
            this.rd_mp.Margin = new System.Windows.Forms.Padding(4);
            this.rd_mp.Name = "rd_mp";
            this.rd_mp.Size = new System.Drawing.Size(165, 21);
            this.rd_mp.TabIndex = 91;
            this.rd_mp.TabStop = true;
            this.rd_mp.Text = "Tìm theo ma phòng";
            this.rd_mp.UseVisualStyleBackColor = true;
            this.rd_mp.Click += new System.EventHandler(this.rd_mp_Click);
            // 
            // Tienphong
            // 
            this.Tienphong.DataPropertyName = "tt";
            this.Tienphong.HeaderText = "Tiền Phòng";
            this.Tienphong.Name = "Tienphong";
            this.Tienphong.Width = 200;
            // 
            // Maphong
            // 
            this.Maphong.DataPropertyName = "MaPhong";
            this.Maphong.HeaderText = "Mã Phòng";
            this.Maphong.Name = "Maphong";
            // 
            // rd_thang
            // 
            this.rd_thang.AutoSize = true;
            this.rd_thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_thang.ForeColor = System.Drawing.Color.DarkCyan;
            this.rd_thang.Location = new System.Drawing.Point(10, 206);
            this.rd_thang.Margin = new System.Windows.Forms.Padding(4);
            this.rd_thang.Name = "rd_thang";
            this.rd_thang.Size = new System.Drawing.Size(135, 21);
            this.rd_thang.TabIndex = 92;
            this.rd_thang.TabStop = true;
            this.rd_thang.Text = "Tìm theo tháng";
            this.rd_thang.UseVisualStyleBackColor = true;
            this.rd_thang.Click += new System.EventHandler(this.dr_thang_Click);
            // 
            // rd_ngay
            // 
            this.rd_ngay.AutoSize = true;
            this.rd_ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_ngay.ForeColor = System.Drawing.Color.DarkCyan;
            this.rd_ngay.Location = new System.Drawing.Point(10, 113);
            this.rd_ngay.Margin = new System.Windows.Forms.Padding(4);
            this.rd_ngay.Name = "rd_ngay";
            this.rd_ngay.Size = new System.Drawing.Size(129, 21);
            this.rd_ngay.TabIndex = 93;
            this.rd_ngay.TabStop = true;
            this.rd_ngay.Text = "Tìm theo ngày";
            this.rd_ngay.UseVisualStyleBackColor = true;
            this.rd_ngay.Click += new System.EventHandler(this.rd_ngay_Click);
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AllowUserToResizeColumns = false;
            this.dg.AllowUserToResizeRows = false;
            this.dg.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maphong,
            this.Tienphong});
            this.dg.Location = new System.Drawing.Point(407, 65);
            this.dg.Margin = new System.Windows.Forms.Padding(4);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(337, 273);
            this.dg.TabIndex = 90;
            // 
            // txt_mp
            // 
            this.txt_mp.Location = new System.Drawing.Point(183, 62);
            this.txt_mp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mp.Name = "txt_mp";
            this.txt_mp.Size = new System.Drawing.Size(159, 20);
            this.txt_mp.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(282, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 82;
            this.label2.Text = "Doanh Thu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "Từ ngay";
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 356);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_dt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_t);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.bt_tim);
            this.Controls.Add(this.rd_mp);
            this.Controls.Add(this.rd_thang);
            this.Controls.Add(this.rd_ngay);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.txt_mp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DoanhThu";
            this.Text = "DoanhThu";
            this.Load += new System.EventHandler(this.Doanhthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_dt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_t;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.RadioButton rd_mp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tienphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphong;
        private System.Windows.Forms.RadioButton rd_thang;
        private System.Windows.Forms.RadioButton rd_ngay;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.TextBox txt_mp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}