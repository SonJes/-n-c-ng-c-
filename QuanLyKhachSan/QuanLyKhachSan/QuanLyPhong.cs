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
        private string tinhtrang(int ma)
        {
            dt.Clear();
            dt = cl.ttphong(ma);
            string tt = dt.Rows[0]["TinhTrang"].ToString();
            string hinh = null;
            if (tt == "Không")
            {
                hinh = hinh2;
            }
            if (tt == "Trống")
            {
                hinh = hinh1;
            }
            if (tt == "Đặt Phòng")
            {
                hinh = hinh3;
            }
            return hinh;
        }
        private bool txp(int ma)
        {
            dr = cl.txphong(ma);
            while (dr.Read())
            {
                string tt = dr.GetString(1);

                if (tt == "Hiện")
                    return true;
            }
            return false;
        }
        public void load_tinhtrangphong()
        {
            bt_101.Image = Image.FromFile(tinhtrang(101));
            bt_102.Image = Image.FromFile(tinhtrang(102));
            bt_103.Image = Image.FromFile(tinhtrang(103));
            bt_104.Image = Image.FromFile(tinhtrang(104));
            bt_105.Image = Image.FromFile(tinhtrang(105));
            bt_106.Image = Image.FromFile(tinhtrang(106));
            bt_107.Image = Image.FromFile(tinhtrang(107));
            bt_108.Image = Image.FromFile(tinhtrang(108));
            bt_109.Image = Image.FromFile(tinhtrang(109));
            bt_110.Image = Image.FromFile(tinhtrang(110));

            bt_201.Image = Image.FromFile(tinhtrang(201));
            bt_202.Image = Image.FromFile(tinhtrang(202));
            bt_203.Image = Image.FromFile(tinhtrang(203));
            bt_204.Image = Image.FromFile(tinhtrang(204));
            bt_205.Image = Image.FromFile(tinhtrang(205));
            bt_206.Image = Image.FromFile(tinhtrang(206));
            bt_207.Image = Image.FromFile(tinhtrang(207));
            bt_208.Image = Image.FromFile(tinhtrang(208));
            bt_209.Image = Image.FromFile(tinhtrang(209));
            bt_210.Image = Image.FromFile(tinhtrang(210));

            bt_301.Image = Image.FromFile(tinhtrang(301));
            bt_302.Image = Image.FromFile(tinhtrang(302));
            bt_303.Image = Image.FromFile(tinhtrang(303));
            bt_304.Image = Image.FromFile(tinhtrang(304));
            bt_305.Image = Image.FromFile(tinhtrang(305));
            bt_306.Image = Image.FromFile(tinhtrang(306));
            bt_307.Image = Image.FromFile(tinhtrang(307));
            bt_308.Image = Image.FromFile(tinhtrang(308));
            bt_309.Image = Image.FromFile(tinhtrang(309));
            bt_310.Image = Image.FromFile(tinhtrang(310));

            bt_401.Image = Image.FromFile(tinhtrang(401));
            bt_402.Image = Image.FromFile(tinhtrang(402));
            bt_403.Image = Image.FromFile(tinhtrang(403));
            bt_404.Image = Image.FromFile(tinhtrang(404));
            bt_405.Image = Image.FromFile(tinhtrang(405));
            bt_406.Image = Image.FromFile(tinhtrang(406));
            bt_407.Image = Image.FromFile(tinhtrang(407));
            bt_408.Image = Image.FromFile(tinhtrang(408));
            bt_409.Image = Image.FromFile(tinhtrang(409));
            bt_410.Image = Image.FromFile(tinhtrang(410));

            bt_501.Image = Image.FromFile(tinhtrang(501));
            bt_502.Image = Image.FromFile(tinhtrang(502));
            bt_503.Image = Image.FromFile(tinhtrang(503));
            bt_504.Image = Image.FromFile(tinhtrang(504));
            bt_505.Image = Image.FromFile(tinhtrang(505));
            bt_506.Image = Image.FromFile(tinhtrang(506));
            bt_507.Image = Image.FromFile(tinhtrang(507));
            bt_508.Image = Image.FromFile(tinhtrang(508));
            bt_509.Image = Image.FromFile(tinhtrang(509));
            bt_510.Image = Image.FromFile(tinhtrang(510));

        }
        public void load_bt()
        {
            bt_101.Visible = txp(101);
            bt_102.Visible = txp(102);
            bt_103.Visible = txp(103);
            bt_104.Visible = txp(104);
            bt_105.Visible = txp(105);
            bt_106.Visible = txp(106);
            bt_107.Visible = txp(107);
            bt_108.Visible = txp(108);
            bt_109.Visible = txp(109);
            bt_110.Visible = txp(110);

            bt_201.Visible = txp(201);
            bt_202.Visible = txp(202);
            bt_203.Visible = txp(203);
            bt_204.Visible = txp(204);
            bt_205.Visible = txp(205);
            bt_206.Visible = txp(206);
            bt_207.Visible = txp(207);
            bt_208.Visible = txp(208);
            bt_209.Visible = txp(209);
            bt_210.Visible = txp(210);

            bt_301.Visible = txp(301);
            bt_302.Visible = txp(302);
            bt_303.Visible = txp(303);
            bt_304.Visible = txp(304);
            bt_305.Visible = txp(305);
            bt_306.Visible = txp(306);
            bt_307.Visible = txp(307);
            bt_308.Visible = txp(308);
            bt_309.Visible = txp(309);
            bt_310.Visible = txp(310);

            bt_401.Visible = txp(401);
            bt_402.Visible = txp(402);
            bt_403.Visible = txp(403);
            bt_404.Visible = txp(404);
            bt_405.Visible = txp(405);
            bt_406.Visible = txp(406);
            bt_407.Visible = txp(407);
            bt_408.Visible = txp(408);
            bt_409.Visible = txp(409);
            bt_410.Visible = txp(410);

            bt_501.Visible = txp(501);
            bt_502.Visible = txp(502);
            bt_503.Visible = txp(503);
            bt_504.Visible = txp(504);
            bt_505.Visible = txp(505);
            bt_506.Visible = txp(506);
            bt_507.Visible = txp(507);
            bt_508.Visible = txp(508); ;
            bt_509.Visible = txp(509);
            bt_510.Visible = txp(510);
        }
        public void load_lb()
        {
            lb_101.Visible = txp(101);
            lb_102.Visible = txp(102);
            lb_103.Visible = txp(103);
            lb_104.Visible = txp(104);
            lb_105.Visible = txp(105);
            lb_106.Visible = txp(106);
            lb_107.Visible = txp(107);
            lb_108.Visible = txp(108);
            lb_109.Visible = txp(109);
            lb_110.Visible = txp(110);

            lb_201.Visible = txp(201);
            lb_202.Visible = txp(202);
            lb_203.Visible = txp(203);
            lb_204.Visible = txp(204);
            lb_205.Visible = txp(205);
            lb_206.Visible = txp(206);
            lb_207.Visible = txp(207);
            lb_208.Visible = txp(208);
            lb_209.Visible = txp(209);
            lb_210.Visible = txp(210);

            lb_301.Visible = txp(301);
            lb_302.Visible = txp(302);
            lb_303.Visible = txp(303);
            lb_304.Visible = txp(304);
            lb_305.Visible = txp(305);
            lb_306.Visible = txp(306);
            lb_307.Visible = txp(307);
            lb_308.Visible = txp(308);
            lb_309.Visible = txp(309);
            lb_310.Visible = txp(310);

            lb_401.Visible = txp(401);
            lb_402.Visible = txp(402);
            lb_403.Visible = txp(403);
            lb_404.Visible = txp(404);
            lb_405.Visible = txp(405);
            lb_406.Visible = txp(406);
            lb_407.Visible = txp(407);
            lb_408.Visible = txp(408);
            lb_409.Visible = txp(409);
            lb_410.Visible = txp(410);

            lb_501.Visible = txp(501);
            lb_502.Visible = txp(502);
            lb_503.Visible = txp(503);
            lb_504.Visible = txp(504);
            lb_505.Visible = txp(505);
            lb_506.Visible = txp(506);
            lb_507.Visible = txp(507);
            lb_508.Visible = txp(508);
            lb_509.Visible = txp(509);
            lb_510.Visible = txp(510);
        }
        public void frm_load()
        {

            lbl_ten.Text = "Chào " + nguoi_dn;
            if (nguoi_dn != "admin")
            {
                sửaPhòngToolStripMenuItem.Enabled = false;
                nhânViênToolStripMenuItem.Enabled = false;
                thốngKêToolStripMenuItem.Enabled = false;
            }

            load_tinhtrangphong();
            load_bt();
            load_lb();

        }
        public string layttp(int ma)
        {
            string kq = null;
            dt.Clear();
            dt = cl.ttphong(ma);
            string tt = dt.Rows[0]["TinhTrang"].ToString();
            if (tt == "Đặt Phòng")
                return kq = "dp";
            if (tt == "Không")
                return kq = "kt";
            else
                return kq = "kdp";
        }
        private void qlks_Load(object sender, EventArgs e)
        {
            frm_load();

        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dn = new DangNhap();
            dn.Show();
            //DangNhap dn = new DangNhap();
            //dn.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void danhSáchPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachPhong p = new DanhSachPhong();
            p.ShowDialog();
        }
        private void bt_101_Click(object sender, EventArgs e)
        {
            tt = layttp(101);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 101;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_102_Click(object sender, EventArgs e)
        {
            tt = layttp(102);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 102;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_103_Click(object sender, EventArgs e)
        {
            tt = layttp(103);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 103;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_104_Click(object sender, EventArgs e)
        {
            tt = layttp(104);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 104;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_105_Click(object sender, EventArgs e)
        {
            tt = layttp(105);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 105;
                Phong p = new Phong();
                p.ShowDialog();
                load_tinhtrangphong();
            }
        }
        private void bt_106_Click(object sender, EventArgs e)
        {
            tt = layttp(106);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 106;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_107_Click(object sender, EventArgs e)
        {
            tt = layttp(107);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 107;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_108_Click(object sender, EventArgs e)
        {
            tt = layttp(108);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 108;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_109_Click(object sender, EventArgs e)
        {
            tt = layttp(109);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 109;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_110_Click(object sender, EventArgs e)
        {
            tt = layttp(110);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 110;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_210_Click(object sender, EventArgs e)
        {
            tt = layttp(120);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 210;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_209_Click(object sender, EventArgs e)
        {
            tt = layttp(209);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 209;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_208_Click(object sender, EventArgs e)
        {
            tt = layttp(208);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 208;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_207_Click(object sender, EventArgs e)
        {
            tt = layttp(207);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 207;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_206_Click(object sender, EventArgs e)
        {
            tt = layttp(206);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 206;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_205_Click(object sender, EventArgs e)
        {
            tt = layttp(205);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 205;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_204_Click(object sender, EventArgs e)
        {
            tt = layttp(204);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 204;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_203_Click(object sender, EventArgs e)
        {
            tt = layttp(203);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 203;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_202_Click(object sender, EventArgs e)
        {
            tt = layttp(202);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 202;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_201_Click(object sender, EventArgs e)
        {
            tt = layttp(201);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 201;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_301_Click(object sender, EventArgs e)
        {
            tt = layttp(301);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 301;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_302_Click(object sender, EventArgs e)
        {
            tt = layttp(302);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 302;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_303_Click(object sender, EventArgs e)
        {
            tt = layttp(303);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 303;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_304_Click(object sender, EventArgs e)
        {
            tt = layttp(304);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 304;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_305_Click(object sender, EventArgs e)
        {
            tt = layttp(305);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 305;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_306_Click(object sender, EventArgs e)
        {
            tt = layttp(306);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 306;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_307_Click(object sender, EventArgs e)
        {
            tt = layttp(307);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 307;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_308_Click(object sender, EventArgs e)
        {
            tt = layttp(308);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 308;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_309_Click(object sender, EventArgs e)
        {
            tt = layttp(309);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 309;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_310_Click(object sender, EventArgs e)
        {
            tt = layttp(310);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 310;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_401_Click(object sender, EventArgs e)
        {
            tt = layttp(401);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 401;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_402_Click(object sender, EventArgs e)
        {
            tt = layttp(402);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 402;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_403_Click(object sender, EventArgs e)
        {
            tt = layttp(403);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 403;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_404_Click(object sender, EventArgs e)
        {
            tt = layttp(404);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 404;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_405_Click(object sender, EventArgs e)
        {
            tt = layttp(405);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 405;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_406_Click(object sender, EventArgs e)
        {
            tt = layttp(406);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 406;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_407_Click(object sender, EventArgs e)
        {
            tt = layttp(407);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 407;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_408_Click(object sender, EventArgs e)
        {
            tt = layttp(408);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 408;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_409_Click(object sender, EventArgs e)
        {
            tt = layttp(409);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 409;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_410_Click(object sender, EventArgs e)
        {
            tt = layttp(410);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 410;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_501_Click(object sender, EventArgs e)
        {
            tt = layttp(501);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 501;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_502_Click(object sender, EventArgs e)
        {
            tt = layttp(502);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 502;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_503_Click(object sender, EventArgs e)
        {
            tt = layttp(503);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 503;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_504_Click(object sender, EventArgs e)
        {
            tt = layttp(504);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 504;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_505_Click(object sender, EventArgs e)
        {
            tt = layttp(505);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 505;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_506_Click(object sender, EventArgs e)
        {
            tt = layttp(506);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 506;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_507_Click(object sender, EventArgs e)
        {
            tt = layttp(507);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 507;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_508_Click(object sender, EventArgs e)
        {
            tt = layttp(508);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 508;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_509_Click(object sender, EventArgs e)
        {
            tt = layttp(509);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 509;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_510_Click(object sender, EventArgs e)
        {
            tt = layttp(510);
            if (tt == "dp")
            {

            }
            else
            {
                Phong.maphong = 510;
                Phong p = new Phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }
    }
}
