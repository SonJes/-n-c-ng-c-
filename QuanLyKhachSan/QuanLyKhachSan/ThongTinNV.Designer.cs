namespace QuanLyKhachSan
{
    partial class ThongTinNV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.Manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg = new System.Windows.Forms.DataGridView();
            this.Tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rd_nu = new System.Windows.Forms.RadioButton();
            this.rd_nam = new System.Windows.Forms.RadioButton();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ngaysinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.bt_sua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(380, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 716;
            this.label8.Text = "Mật Khẩu";
            // 
            // Manv
            // 
            this.Manv.DataPropertyName = "MaNv";
            this.Manv.HeaderText = "Mã Nhân Viên";
            this.Manv.Name = "Manv";
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
            this.Manv,
            this.Tennv});
            this.dg.Location = new System.Drawing.Point(17, 158);
            this.dg.Name = "dg";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(319, 318);
            this.dg.TabIndex = 722;
            this.dg.Click += new System.EventHandler(this.dg_Click);
            // 
            // Tennv
            // 
            this.Tennv.DataPropertyName = "HoTen";
            this.Tennv.HeaderText = "Tên Nhân Viên";
            this.Tennv.Name = "Tennv";
            this.Tennv.Width = 175;
            // 
            // rd_nu
            // 
            this.rd_nu.AutoSize = true;
            this.rd_nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_nu.ForeColor = System.Drawing.Color.DarkCyan;
            this.rd_nu.Location = new System.Drawing.Point(581, 156);
            this.rd_nu.Name = "rd_nu";
            this.rd_nu.Size = new System.Drawing.Size(46, 21);
            this.rd_nu.TabIndex = 704;
            this.rd_nu.TabStop = true;
            this.rd_nu.Text = "Nữ";
            this.rd_nu.UseVisualStyleBackColor = true;
            // 
            // rd_nam
            // 
            this.rd_nam.AutoSize = true;
            this.rd_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_nam.ForeColor = System.Drawing.Color.DarkCyan;
            this.rd_nam.Location = new System.Drawing.Point(497, 156);
            this.rd_nam.Name = "rd_nam";
            this.rd_nam.Size = new System.Drawing.Size(58, 21);
            this.rd_nam.TabIndex = 703;
            this.rd_nam.TabStop = true;
            this.rd_nam.Text = "Nam";
            this.rd_nam.UseVisualStyleBackColor = true;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_matkhau.Location = new System.Drawing.Point(497, 401);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(208, 23);
            this.txt_matkhau.TabIndex = 709;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(380, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 719;
            this.label7.Text = "Tài Khoản";
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taikhoan.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_taikhoan.Location = new System.Drawing.Point(497, 360);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(208, 23);
            this.txt_taikhoan.TabIndex = 708;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(380, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 718;
            this.label6.Text = "Số Điện Thoại";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_sdt.Location = new System.Drawing.Point(497, 279);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(208, 23);
            this.txt_sdt.TabIndex = 707;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(380, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 717;
            this.label5.Text = "Ngày Sinh";
            // 
            // txt_ngaysinh
            // 
            this.txt_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngaysinh.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_ngaysinh.Location = new System.Drawing.Point(497, 319);
            this.txt_ngaysinh.Name = "txt_ngaysinh";
            this.txt_ngaysinh.Size = new System.Drawing.Size(208, 23);
            this.txt_ngaysinh.TabIndex = 706;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(380, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 713;
            this.label4.Text = "Địa Chỉ";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_diachi.Location = new System.Drawing.Point(497, 192);
            this.txt_diachi.Multiline = true;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(208, 70);
            this.txt_diachi.TabIndex = 705;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(380, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 721;
            this.label3.Text = "Giới Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(380, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 715;
            this.label2.Text = "Tên";
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_xoa.Location = new System.Drawing.Point(625, 446);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(80, 30);
            this.bt_xoa.TabIndex = 712;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_them.Location = new System.Drawing.Point(383, 446);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(80, 30);
            this.bt_them.TabIndex = 710;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(190, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(288, 31);
            this.label9.TabIndex = 714;
            this.label9.Text = "Thông Tin Nhân Viên";
            // 
            // txt_ten
            // 
            this.txt_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_ten.Location = new System.Drawing.Point(497, 118);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(208, 23);
            this.txt_ten.TabIndex = 702;
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_sua.Location = new System.Drawing.Point(505, 446);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(80, 30);
            this.bt_sua.TabIndex = 711;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 720;
            this.label1.Text = "Danh Sách Nhân Viên";
            // 
            // ThongTinNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 483);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.rd_nu);
            this.Controls.Add(this.rd_nam);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_taikhoan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ngaysinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.label1);
            this.Name = "ThongTinNV";
            this.Text = "ThongTinNV";
            this.Load += new System.EventHandler(this.thongtinnv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manv;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tennv;
        private System.Windows.Forms.RadioButton rd_nu;
        private System.Windows.Forms.RadioButton rd_nam;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ngaysinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Label label1;
    }
}