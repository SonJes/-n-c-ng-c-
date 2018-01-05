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

namespace Qlks
{
    public partial class phong : Form
    {
        public phong()
        {
            InitializeComponent();
        }
        public static int maphong;
        CauLenh cl = new CauLenh();
        DataTable dt = new DataTable() ;
        SqlDataReader dr;
        private void load()
        {
            bt_capnhat.Enabled = false;
            bt_tinhtien.Enabled = false;
            if(rd_kt.Checked == true)
            {
                bt_capnhat.Enabled = true;
                bt_tinhtien.Enabled = true;
            }
            else
            {
                bt_capnhat.Enabled = false;
                bt_tinhtien.Enabled = false;
            }
            label1.Text = "Thông Tin Phòng " + maphong.ToString();
            lb_tenp.Text = "Phòng Số: " + maphong.ToString();
            dr = cl.timphong(maphong);
            while (dr.Read())
            {
                //lb_tt.Text = dr.GetString(1);
                if (dr.GetString(1) == "Trống")
                {
                    rd_t.Checked = true;
                    rd_kt.Checked = false;
                    txt_ten.Text = "";
                    txt_namsinh.Text = "";
                    txt_socm.Text = "";
                    txt_songuoidp.Text = "";

                }
                else
                {
                    rd_kt.Checked = true;
                    rd_t.Checked = false;
                    txt_ten.Text = dr.GetString(2);
                    txt_namsinh.Text = dr.GetInt32(3).ToString();
                    txt_socm.Text = dr.GetInt32(4).ToString();
                    txt_songuoidp.Text = dr.GetInt32(5).ToString();
                    lb_ngaydp.Text = dr.GetDateTime(6).ToString();
                    lb_ngaytp.Text = dr.GetDateTime(7).ToString();
                }
            }
            dr = cl.loaiphong(maphong);
            while(dr.Read())
            {
                lb_lp.Text = dr.GetString(1);
                lp_gp.Text = dr.GetInt32(0).ToString();
            }
        }
        private void phong_Load(object sender, EventArgs e)
        {
            load();            
        }

       
        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

     
    }
}
