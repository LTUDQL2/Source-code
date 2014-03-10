﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project.DTO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using DAO;
namespace Project.DAO
{
    public class PhieuNhapHang_DAO
    {
        public static DataTable gettable()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "PhieuMuaHang_select";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable gettable2()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "PhieuMuaHang_select2";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable gettable3()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "PhieuMuaHang_select3";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static List<PhieuNhapHang_DTO> getlist()
        {
            List<PhieuNhapHang_DTO> ls = new List<PhieuNhapHang_DTO>();
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "PhieuMuaHang_select";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlDataReader cusor = cmd.ExecuteReader();
            while (cusor.Read())
            {
                PhieuNhapHang_DTO da = new PhieuNhapHang_DTO();
                da.MaPNH = cusor["Ma_PNH"].ToString();
                da.Id_NCC = Convert.ToInt32(cusor["Id_NCC"]);
                da.TongTien = Convert.ToInt32(cusor["TongTien"]);
                da.Diachi = cusor["Diachi"].ToString();
                da.SDT = cusor["Sdt"].ToString();
                da.Ngaynhap = Convert.ToDateTime(cusor["NgayNhap"].ToString());
                da.Id_NV = Convert.ToInt32(cusor["Id_NV"]);
                da.TinhTrang = Convert.ToInt32(cusor["TinhTrang"]);
                ls.Add(da);
            }
            cusor.Close();
            conn.Close();
            return ls;
        }
        public static void themphieunhap(PhieuNhapHang_DTO phieu)
        {
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "PhieuMuaHang_insert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter para = new SqlParameter("@Ma_PNH", SqlDbType.NChar, 10);
            para.Direction = ParameterDirection.Input;
            para.Value = phieu.MaPNH;
            cmd.Parameters.Add(para);

            SqlParameter para2 = new SqlParameter("@ID_NCC", SqlDbType.Int);
            para2.Direction = ParameterDirection.Input;
            para2.Value = phieu.Id_NCC;
            cmd.Parameters.Add(para2);

            SqlParameter para3 = new SqlParameter("@ID_NV", SqlDbType.Int);
            para3.Direction = ParameterDirection.Input;
            para3.Value = phieu.Id_NV;
            cmd.Parameters.Add(para3);

            SqlParameter para4 = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 50);
            para4.Direction = ParameterDirection.Input;
            para4.Value = phieu.Diachi;
            cmd.Parameters.Add(para4);

            SqlParameter para5 = new SqlParameter("@Sdt", SqlDbType.NChar, 12);
            para5.Direction = ParameterDirection.Input;
            para5.Value = phieu.SDT;
            cmd.Parameters.Add(para5);

            SqlParameter para6 = new SqlParameter("@TinhTrang", SqlDbType.Int);
            para6.Direction = ParameterDirection.Input;
            para6.Value = phieu.TinhTrang;
            cmd.Parameters.Add(para6);

            SqlParameter para7 = new SqlParameter("@TongTien", SqlDbType.Int);
            para7.Direction = ParameterDirection.Input;
            para7.Value = phieu.TongTien;
            cmd.Parameters.Add(para7);

            SqlParameter para8 = new SqlParameter("@NgayNhap", SqlDbType.DateTime);
            para8.Direction = ParameterDirection.Input;
            para8.Value = phieu.Ngaynhap;
            cmd.Parameters.Add(para8);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void capnhatphieunhap(PhieuNhapHang_DTO phieu)
        {
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "PhieuMuaHang_update";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter para = new SqlParameter("@Ma_PNH", SqlDbType.NChar, 10);
            para.Direction = ParameterDirection.Input;
            para.Value = phieu.MaPNH;
            cmd.Parameters.Add(para);

            SqlParameter para2 = new SqlParameter("@ID_NCC", SqlDbType.Int);
            para2.Direction = ParameterDirection.Input;
            para2.Value = phieu.Id_NCC;
            cmd.Parameters.Add(para2);

            SqlParameter para3 = new SqlParameter("@ID_NV", SqlDbType.Int);
            para3.Direction = ParameterDirection.Input;
            para3.Value = phieu.Id_NV;
            cmd.Parameters.Add(para3);

            SqlParameter para4 = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 50);
            para4.Direction = ParameterDirection.Input;
            para4.Value = phieu.Diachi;
            cmd.Parameters.Add(para4);

            SqlParameter para5 = new SqlParameter("@Sdt", SqlDbType.NChar, 12);
            para5.Direction = ParameterDirection.Input;
            para5.Value = phieu.SDT;
            cmd.Parameters.Add(para5);

            SqlParameter para8 = new SqlParameter("@NgayNhap", SqlDbType.DateTime);
            para8.Direction = ParameterDirection.Input;
            para8.Value = phieu.Ngaynhap;
            cmd.Parameters.Add(para8);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void xoaphieunhap(string ID)
        {
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "PhieuMuaHang_delete";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter para = new SqlParameter("@Ma_PNH", SqlDbType.NChar, 10);
            para.Direction = ParameterDirection.Input;
            para.Value = ID;
            cmd.Parameters.Add(para);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
