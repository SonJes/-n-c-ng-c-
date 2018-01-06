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
    }
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
}
