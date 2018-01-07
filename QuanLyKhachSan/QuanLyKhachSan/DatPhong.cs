using System;
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
    public partial class DatPhong : Form
    {
        public DatPhong()
        {
            InitializeComponent();
        }
        public static int mp;
        CauLenh cl = new CauLenh();
        DataTable dt = new DataTable();
        SqlDataReader dr;
        private void load()
        {
            dr = cl.loaddp(mp);
            while (dr.Read())
            {
                if (dr.GetString(0) == "Đặt Phòng")
                {
                    rd_dp.Checked = true;
                    txt_ten.Text = dr.GetString(1).ToString();
                    dt_ngay.Text = dr.GetDateTime(2).ToString();
                    txt_sdt.Text = dr.GetString(3).ToString();
                }
                else
                {
                    rd_huy.Checked = true;
                }
            }
        }
        private void datphong_Load(object sender, EventArgs e)
        {
            lb_mp.Text = mp.ToString();
            load();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
