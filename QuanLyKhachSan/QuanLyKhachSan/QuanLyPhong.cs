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
    public partial class QuanLyPhong : Form
    {
        public QuanLyPhong()
        {
            InitializeComponent();
        }

        public static string nguoi_dn;
        public string hinh1 = @"Hinh\hinh1.png";
        public string hinh2 = @"Hinh\hinh2.png";
        public string hinh3 = @"Hinh\dp.png";
        public string h1 = @"Hinh\h1.jpg";
        public string h2 = @"Hinh\h2.jpg";
        public string h3 = @"Hinh\h3.jpg";
        public string h4 = @"Hinh\h4.png";
        public string h5 = @"Hinh\h5.jpg";
        public string h6 = @"Hinh\h6.jpg";
        CauLenh cl = new CauLenh();
        DataTable dt = new DataTable();
        SqlDataReader dr;
        public string tt = null;

    }
}
