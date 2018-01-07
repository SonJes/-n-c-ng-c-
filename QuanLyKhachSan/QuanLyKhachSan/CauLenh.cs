using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class CauLenh
    {
        SqlConnection con = new SqlConnection(@"Data Source = JOHAN\SQLEXPRESS; Initial Catalog = Qlks; Integrated Security = True");
        DataTable dt = new DataTable();


        public DataTable dangnhap(string tk, string mk)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("dangnhap", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@taikhoan", tk);
            cm.Parameters.AddWithValue("@matkhau", mk);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public SqlDataReader txphong(int ma)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader kq = null;
            SqlCommand cm = new SqlCommand("txp", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@ma", ma);
            kq = cm.ExecuteReader();
            return kq;
        }
        public DataTable ttphong(int manv)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("tinhtrangphong", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@ma", manv);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public DataTable doimatkhau(string taikhoan, string mkc, string mkm)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();

            SqlCommand cm = new SqlCommand("doimatkhau", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@taikhoan", taikhoan);
            cm.Parameters.AddWithValue("@matkhaucu", mkc);
            cm.Parameters.AddWithValue("@matkhaumoi", mkm);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public SqlDataReader loaiphong(int mp)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader ketqua = null;
            SqlCommand cm = new SqlCommand("hienloaiphong", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@maphong", mp);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            ketqua = cm.ExecuteReader();
            return ketqua;
        }
        public DataTable loaiphong1(int mp)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("hienloaiphong", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@maphong", mp);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public SqlDataReader timphong(int mp)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader ketqua = null;
            SqlCommand cm = new SqlCommand("phongtrong", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@maphong", mp);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            ketqua = cm.ExecuteReader();
            return ketqua;
        }
        public DataTable suaphong(int mp, int gp, string lp)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();

            SqlCommand cm = new SqlCommand("[capnhatgiaphong]", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@maphong", mp);
            cm.Parameters.AddWithValue("@giaphong", gp);
            cm.Parameters.AddWithValue("@loaiphong", lp);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public SqlDataReader loaddp(int ma)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader kq = null;
            SqlCommand cm = new SqlCommand("loaddp", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@ma", ma);
            kq = cm.ExecuteReader();
            return kq;
        }
        public DataTable Doanhthu(int ma)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("doanhthu", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@ma", ma);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public DataTable Doanhthuthang(string chuoi)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("doanhthuthang", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@chuoi", chuoi);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
    }
}
