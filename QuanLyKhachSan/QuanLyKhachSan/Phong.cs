using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using System.Windows.SqlClient;

namespace QuanLyKhachSan
{
    public partial class Phong : Form
    {
        public Phong()
        {
            InitializeComponent();
        }
        public static int maphong;
        CauLenh cl = new CauLenh();
        DataTable dt = new DataTable();
        //SqlDataReader dr;
        private void load()
        {
            bt_capnhat.Enabled = false;
            bt_tinhtien.Enabled = false;
            if(rd_kt.Checked== true)
            {
                bt_capnhat.Enabled = true;
                bt_tinhtien.Enabled = true;
            }
            else
            {
                bt_capnhat.Enabled = false;
                bt_tinhtien.Enabled = false;
            }
        }
        private void Phong_Load(object sender, EventArgs e)
        {

        }
    }
}
