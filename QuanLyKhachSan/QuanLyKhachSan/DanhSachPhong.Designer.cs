namespace QuanLyKhachSan
{
    partial class DanhSachPhong
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
            this.dg = new System.Windows.Forms.DataGridView();
            this.Maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giaphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_loc = new System.Windows.Forms.Button();
            this.rd_kt = new System.Windows.Forms.RadioButton();
            this.rd_t = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maphong,
            this.Tinhtrang,
            this.Loaiphong,
            this.Giaphong});
            this.dg.Location = new System.Drawing.Point(12, 107);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(443, 441);
            this.dg.TabIndex = 6;
            // 
            // Maphong
            // 
            this.Maphong.DataPropertyName = "MaPhong";
            this.Maphong.HeaderText = "Mã Phòng";
            this.Maphong.Name = "Maphong";
            // 
            // Tinhtrang
            // 
            this.Tinhtrang.DataPropertyName = "TinhTrang";
            this.Tinhtrang.HeaderText = "Tình Trạng";
            this.Tinhtrang.Name = "Tinhtrang";
            // 
            // Loaiphong
            // 
            this.Loaiphong.DataPropertyName = "LoaiPhong";
            this.Loaiphong.HeaderText = "Loại Phòng";
            this.Loaiphong.Name = "Loaiphong";
            // 
            // Giaphong
            // 
            this.Giaphong.DataPropertyName = "GiaPhong";
            this.Giaphong.HeaderText = "Giá Phòng";
            this.Giaphong.Name = "Giaphong";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh Sách Phòng";
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_xoa.Location = new System.Drawing.Point(334, 64);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(80, 30);
            this.bt_xoa.TabIndex = 9;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_loc
            // 
            this.bt_loc.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_loc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_loc.Location = new System.Drawing.Point(224, 64);
            this.bt_loc.Name = "bt_loc";
            this.bt_loc.Size = new System.Drawing.Size(80, 30);
            this.bt_loc.TabIndex = 10;
            this.bt_loc.Text = "Lọc";
            this.bt_loc.UseVisualStyleBackColor = false;
            this.bt_loc.Click += new System.EventHandler(this.bt_loc_Click);
            // 
            // rd_kt
            // 
            this.rd_kt.AutoSize = true;
            this.rd_kt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_kt.ForeColor = System.Drawing.Color.DarkCyan;
            this.rd_kt.Location = new System.Drawing.Point(12, 73);
            this.rd_kt.Name = "rd_kt";
            this.rd_kt.Size = new System.Drawing.Size(171, 21);
            this.rd_kt.TabIndex = 8;
            this.rd_kt.TabStop = true;
            this.rd_kt.Text = "Phòng Không Trống";
            this.rd_kt.UseVisualStyleBackColor = true;
            this.rd_kt.Click += new System.EventHandler(this.rd_kt_Click);
            // 
            // rd_t
            // 
            this.rd_t.AutoSize = true;
            this.rd_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_t.ForeColor = System.Drawing.Color.DarkCyan;
            this.rd_t.Location = new System.Drawing.Point(12, 48);
            this.rd_t.Name = "rd_t";
            this.rd_t.Size = new System.Drawing.Size(120, 21);
            this.rd_t.TabIndex = 7;
            this.rd_t.TabStop = true;
            this.rd_t.Text = "Phòng Trống";
            this.rd_t.UseVisualStyleBackColor = true;
            this.rd_t.Click += new System.EventHandler(this.rd_t_Click);
            // 
            // DanhSachPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 557);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_loc);
            this.Controls.Add(this.rd_kt);
            this.Controls.Add(this.rd_t);
            this.Name = "DanhSachPhong";
            this.Text = "DanhSachPhong";
            this.Load += new System.EventHandler(this.danhsachphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giaphong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_loc;
        private System.Windows.Forms.RadioButton rd_kt;
        private System.Windows.Forms.RadioButton rd_t;
    }
}