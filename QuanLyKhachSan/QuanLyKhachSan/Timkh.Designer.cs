namespace QuanLyKhachSan
{
    partial class Timkh
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
            this.Tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Socm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaydp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaytp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_ct = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_tk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AllowUserToOrderColumns = true;
            this.dg.AllowUserToResizeColumns = false;
            this.dg.AllowUserToResizeRows = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maphong,
            this.Tenkh,
            this.Socm,
            this.Namsinh,
            this.Ngaydp,
            this.Ngaytp});
            this.dg.Location = new System.Drawing.Point(-4, 106);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(784, 206);
            this.dg.TabIndex = 11;
            // 
            // Maphong
            // 
            this.Maphong.DataPropertyName = "MaPhong";
            this.Maphong.HeaderText = "Mã Phòng";
            this.Maphong.Name = "Maphong";
            // 
            // Tenkh
            // 
            this.Tenkh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tenkh.DataPropertyName = "TenKh";
            this.Tenkh.HeaderText = "Tên Khách Hàng";
            this.Tenkh.Name = "Tenkh";
            // 
            // Socm
            // 
            this.Socm.DataPropertyName = "SoCm";
            this.Socm.HeaderText = "Số Cmnd";
            this.Socm.Name = "Socm";
            // 
            // Namsinh
            // 
            this.Namsinh.DataPropertyName = "NamSinh";
            this.Namsinh.HeaderText = "Năm Sinh";
            this.Namsinh.Name = "Namsinh";
            // 
            // Ngaydp
            // 
            this.Ngaydp.DataPropertyName = "NgayDp";
            this.Ngaydp.HeaderText = "Ngày Đặt Phòng";
            this.Ngaydp.Name = "Ngaydp";
            // 
            // Ngaytp
            // 
            this.Ngaytp.DataPropertyName = "NgayTp";
            this.Ngaytp.HeaderText = "Ngày Trả Phòng";
            this.Ngaytp.Name = "Ngaytp";
            // 
            // txt_tk
            // 
            this.txt_tk.Location = new System.Drawing.Point(231, 68);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(242, 20);
            this.txt_tk.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(254, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tìm Kiếm Khách Đặt Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(64, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "(Họ Tên, Năm sinh, Sô cmnd..)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nhập";
            // 
            // bt_ct
            // 
            this.bt_ct.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_ct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_ct.Location = new System.Drawing.Point(676, 61);
            this.bt_ct.Name = "bt_ct";
            this.bt_ct.Size = new System.Drawing.Size(75, 32);
            this.bt_ct.TabIndex = 4;
            this.bt_ct.Text = "Chi Tiết";
            this.bt_ct.UseVisualStyleBackColor = false;
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_xoa.Location = new System.Drawing.Point(595, 61);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 32);
            this.bt_xoa.TabIndex = 5;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            // 
            // bt_tk
            // 
            this.bt_tk.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_tk.Location = new System.Drawing.Point(494, 61);
            this.bt_tk.Name = "bt_tk";
            this.bt_tk.Size = new System.Drawing.Size(95, 32);
            this.bt_tk.TabIndex = 6;
            this.bt_tk.Text = "Tìm Kiếm";
            this.bt_tk.UseVisualStyleBackColor = false;
            // 
            // Timkh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 329);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_ct);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_tk);
            this.Name = "Timkh";
            this.Text = "Timkh";
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Socm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaydp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaytp;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_ct;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_tk;
    }
}