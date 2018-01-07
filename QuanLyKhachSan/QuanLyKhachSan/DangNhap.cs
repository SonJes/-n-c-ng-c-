using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        CauLenh cl = new CauLenh();
        DataTable dt = new DataTable();

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bt_dn_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = cl.dangnhap(txt_tk.Text, txt_mk.Text);
            if (!string.IsNullOrEmpty(txt_tk.Text))
            {
                if (!string.IsNullOrEmpty(txt_mk.Text))
                {
                    if (dt.Rows[0]["errcode"].ToString() == "0")
                    {
                        QuanLyPhong.nguoi_dn = txt_tk.Text;
                        Tinhtien.nv = txt_tk.Text;
                        txt_mk.Text = "";
                        txt_tk.Text = "";
                        txt_tk.Focus();
                        this.Hide();
                        QuanLyPhong ql = new QuanLyPhong();
                        ql.ShowDialog();
                    }

                    else
                    {
                        MessageBox.Show("Sai Tài Khoản Hoặc Mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_tk.Text = "";
                        txt_mk.Text = "";
                        txt_tk.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Nhập Mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_mk.Focus();
                }
            }
            else
            {
                MessageBox.Show("Nhập Tài Khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_tk.Focus();
            }
        }
    }
}
