using System;
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
    public class HoaDon_DAO
    {
        public static DataTable gettable()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "HoaDon_select";
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
            cmd.CommandText = "HoaDon_select2";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static List<HoaDon_DTO> getlist()
        {
            List<HoaDon_DTO> ls = new List<HoaDon_DTO>();
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "HoaDon_select";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlDataReader cusor = cmd.ExecuteReader();
            while (cusor.Read())
            {
                HoaDon_DTO da = new HoaDon_DTO();
                da.Id_HD = Convert.ToInt32(cusor["Id_HoaDon"]);
                da.Id_NV = Convert.ToInt32(cusor["ID_NV"]);
                da.MaPhieu = cusor["MaPhieu"].ToString();
                da.TongTien = Convert.ToInt32(cusor["TongTien"]);
                da.NgayLap = Convert.ToDateTime(cusor["NgayLap"]);
                ls.Add(da);
            }
            cusor.Close();
            conn.Close();
            return ls;
        }
        public static void themhoadonnhap(HoaDon_DTO phieu)
        {
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "HoaDon_insert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter para = new SqlParameter("@MaPhieu", SqlDbType.NChar, 10);
            para.Direction = ParameterDirection.Input;
            para.Value = phieu.MaPhieu;
            cmd.Parameters.Add(para);

            SqlParameter para3 = new SqlParameter("@ID_NV", SqlDbType.Int);
            para3.Direction = ParameterDirection.Input;
            para3.Value = phieu.Id_NV;
            cmd.Parameters.Add(para3);

            SqlParameter para5 = new SqlParameter("@NgayLap", SqlDbType.DateTime);
            para5.Direction = ParameterDirection.Input;
            para5.Value = phieu.NgayLap;
            cmd.Parameters.Add(para5);

            SqlParameter para7 = new SqlParameter("@TongTien", SqlDbType.Int);
            para7.Direction = ParameterDirection.Input;
            para7.Value = phieu.TongTien;
            cmd.Parameters.Add(para7);

            SqlParameter para8 = new SqlParameter("@GhiChu", SqlDbType.NVarChar, 50);
            para8.Direction = ParameterDirection.Input;
            para8.Value = phieu.Ghichu;
            cmd.Parameters.Add(para8);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void xoahoadon(int ID)
        {
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "HoaDon_delete";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter para = new SqlParameter("@ID_HD", SqlDbType.Int);
            para.Direction = ParameterDirection.Input;
            para.Value = ID;
            cmd.Parameters.Add(para);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
