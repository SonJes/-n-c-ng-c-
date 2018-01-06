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
    }
}
