﻿using System;
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
        public DataTable xoaphong(int mp)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("xoaphong", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@maphong", mp);
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
        public DataTable datphong(int ma, string tt, string ten, DateTime ndp, string sdt)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("datphong", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@ma", ma);
            cm.Parameters.AddWithValue("@tinhtrang", tt);
            cm.Parameters.AddWithValue("@tenkh", ten);
            cm.Parameters.AddWithValue("@ngaydp", ndp);
            cm.Parameters.AddWithValue("@sdt", sdt);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public DataTable huydatphong(int ma)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("huydatphong", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@ma", ma);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public DataTable doanhthu(int ma)
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
        public DataTable doanhthuthang(string chuoi)
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
        public DataTable danhsachp(int ma)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("danhsachphong", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@ma", ma);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public DataTable danhsachpt(int ma)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("danhsachphongt", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@ma", ma);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public DataTable danhsachpkt(int ma)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("danhsachphongkt", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@ma", ma);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public DataTable xoacpp(int mp)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("xoacpp", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@maphong", mp);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public DataTable xoatongtien(int mp)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("xoatongtien", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@maphong", mp);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public DataTable suaphong(int mp, string rd_kt, string txt_ten, int txt_namsinh, int txt_socm, int txt_songuoidp, DateTime txt_ngaydp, DateTime txt_ngaytp)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("suathongtinphong", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@maphong", mp);
            cm.Parameters.AddWithValue("@tinhtrang", rd_kt);
            cm.Parameters.AddWithValue("@tenkh", txt_ten);
            cm.Parameters.AddWithValue("@namsinh", txt_namsinh);
            cm.Parameters.AddWithValue("@socm", txt_socm);
            cm.Parameters.AddWithValue("@songuoidp", txt_songuoidp);
            cm.Parameters.AddWithValue("@ngaydp", txt_ngaydp);
            cm.Parameters.AddWithValue("@ngaytp", txt_ngaytp);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public DataTable themnv(string ht, string gt, string dc, string ns, int sdt, string tk, string mk)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();

            SqlCommand cm = new SqlCommand("themnv", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@hoten", ht);
            cm.Parameters.AddWithValue("@phai", gt);
            cm.Parameters.AddWithValue("@diachi", dc);
            cm.Parameters.AddWithValue("@ngaysinh", ns);
            cm.Parameters.AddWithValue("@sodt", sdt);
            cm.Parameters.AddWithValue("@taikhoan", tk);
            cm.Parameters.AddWithValue("@matkhau", mk);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public DataTable suanv(string ht, string gt, string dc, string ns, int sdt, string tk, string mk)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();

            SqlCommand cm = new SqlCommand("suanv", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@hoten", ht);
            cm.Parameters.AddWithValue("@phai", gt);
            cm.Parameters.AddWithValue("@diachi", dc);
            cm.Parameters.AddWithValue("@ngaysinh", ns);
            cm.Parameters.AddWithValue("@sodt", sdt);
            cm.Parameters.AddWithValue("@taikhoan", tk);
            cm.Parameters.AddWithValue("@matkhau", mk);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public DataTable xoanhanvien(int manv)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("xoanhanvien", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", manv);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public DataTable hiennv(int ma)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();

            SqlCommand cm = new SqlCommand("hiennhanvien", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", ma);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public SqlDataReader hiennhanvien(int ma)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader ketqua = null;
            SqlCommand cm = new SqlCommand("hiennhanvien", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@manv", ma);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            ketqua = cm.ExecuteReader();
            return ketqua;
        }
    }
}
