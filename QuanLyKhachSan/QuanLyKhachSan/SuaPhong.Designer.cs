﻿namespace QuanLyKhachSan
{
    partial class SuaPhong
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mp = new System.Windows.Forms.TextBox();
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.cb_lp = new System.Windows.Forms.ComboBox();
            this.txt_giaphong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_tenp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 111;
            this.label4.Text = "Vnd";
            // 
            // txt_mp
            // 
            this.txt_mp.Location = new System.Drawing.Point(130, 47);
            this.txt_mp.Name = "txt_mp";
            this.txt_mp.Size = new System.Drawing.Size(86, 20);
            this.txt_mp.TabIndex = 102;
            // 
            // bt_huy
            // 
            this.bt_huy.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_huy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_huy.Location = new System.Drawing.Point(173, 170);
            this.bt_huy.Margin = new System.Windows.Forms.Padding(4);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(80, 30);
            this.bt_huy.TabIndex = 106;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = false;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_luu.Location = new System.Drawing.Point(44, 170);
            this.bt_luu.Margin = new System.Windows.Forms.Padding(4);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(80, 30);
            this.bt_luu.TabIndex = 105;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = false;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // cb_lp
            // 
            this.cb_lp.AutoCompleteCustomSource.AddRange(new string[] {
            "VIP",
            "Loại 1",
            "Loại 2"});
            this.cb_lp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_lp.FormattingEnabled = true;
            this.cb_lp.Location = new System.Drawing.Point(130, 125);
            this.cb_lp.Margin = new System.Windows.Forms.Padding(4);
            this.cb_lp.Name = "cb_lp";
            this.cb_lp.Size = new System.Drawing.Size(160, 21);
            this.cb_lp.TabIndex = 104;
            // 
            // txt_giaphong
            // 
            this.txt_giaphong.Location = new System.Drawing.Point(130, 84);
            this.txt_giaphong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_giaphong.Name = "txt_giaphong";
            this.txt_giaphong.Size = new System.Drawing.Size(107, 20);
            this.txt_giaphong.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 107;
            this.label1.Text = "Mã Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 108;
            this.label3.Text = "Loại Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 109;
            this.label2.Text = "Giá Phòng";
            // 
            // lb_tenp
            // 
            this.lb_tenp.AutoSize = true;
            this.lb_tenp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenp.Location = new System.Drawing.Point(71, 14);
            this.lb_tenp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tenp.Name = "lb_tenp";
            this.lb_tenp.Size = new System.Drawing.Size(166, 17);
            this.lb_tenp.TabIndex = 110;
            this.lb_tenp.Text = "Sửa Thông Tin Phòng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(253, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 112;
            this.pictureBox1.TabStop = false;
            // 
            // SuaPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 215);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_mp);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.cb_lp);
            this.Controls.Add(this.txt_giaphong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_tenp);
            this.Name = "SuaPhong";
            this.Text = "SuaPhong";
            this.Load += new System.EventHandler(this.suaphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mp;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.ComboBox cb_lp;
        private System.Windows.Forms.TextBox txt_giaphong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_tenp;
    }
}