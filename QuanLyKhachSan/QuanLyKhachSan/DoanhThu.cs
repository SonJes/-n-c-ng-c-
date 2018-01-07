﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKhachSan
{
    public partial class DoanhThu : Form
    {
        public DoanhThu()
        {
            InitializeComponent();
        }
        CauLenh cl = new CauLenh();
        DataTable dt = new DataTable();
        private double tt = 0;
        private void load()
        {
            txt_mp.Enabled = false;
            txt_n1.Enabled = false;
            txt_n2.Enabled = false;
            txt_t.Enabled = false;
            dt = cl.Doanhthu(0);
            dg.DataSource = dt;
            tt = 0;
            for (int i = 0; i < dg.RowCount; i++)
            {
                tt += Convert.ToDouble(dg.Rows[i].Cells["Tienphong"].Value);
            }
            lb_dt.Text = tt.ToString();

        }
        private void Doanhthu_Load(object sender, EventArgs e)
        {
            load();
        }
        private void rd_mp_Click(object sender, EventArgs e)
        {
            txt_mp.Enabled = true;
            txt_n1.Enabled = false;
            txt_n2.Enabled = false;
            txt_t.Enabled = false;
            txt_n1.Text = "31/12";
            txt_n2.Text = "31/12";
            txt_t.Text = "1/ or 12";
            txt_mp.Focus();
        }

        private void rd_ngay_Click(object sender, EventArgs e)
        {
            txt_n1.Enabled = true;
            txt_n2.Enabled = true;
            txt_mp.Enabled = false;
            txt_t.Enabled = false;
            txt_mp.Text = "";
            txt_t.Text = "1/ or 12";
            txt_n1.Text = "/";
            txt_n2.Text = "/";
            txt_n1.Focus();
        }

        private void dr_thang_Click(object sender, EventArgs e)
        {
            txt_t.Enabled = true;
            txt_mp.Enabled = false;
            txt_n1.Enabled = false;
            txt_n2.Enabled = false;
            txt_n1.Text = "31/12";
            txt_n2.Text = "31/12";
            txt_t.Text = "/";
            txt_mp.Text = "";

            txt_t.Focus();

        }
    }
}
