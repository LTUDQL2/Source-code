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
    public class HoaDonBan_DAO
    {
        public static DataTable gettable()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "HoaDonBan_select";
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
            cmd.CommandText = "HoaDonBan_select2";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static List<HoaDonBan_DTO> getlist()
        {
            List<HoaDonBan_DTO> ls = new List<HoaDonBan_DTO>();
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "HoaDonBan_select";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlDataReader cusor = cmd.ExecuteReader();
            while (cusor.Read())
            {
                HoaDonBan_DTO da = new HoaDonBan_DTO();
                da.Id_HD = Convert.ToInt32(cusor["Id_HoaDon"]);
                da.Id_NV = Convert.ToInt32(cusor["ID_NV"]);
                da.MaPhieu = cusor["MaPhieu"].ToString();
                da.TongTien = Convert.ToInt32(cusor["TongTien"]);
                da.NgayGiao = Convert.ToDateTime(cusor["NgayGiao"]);
                ls.Add(da);
            }
            cusor.Close();
            conn.Close();
            return ls;
        }
        public static void themhoadonban(HoaDonBan_DTO phieu)
        {
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "HoaDonBan_insert";
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

            SqlParameter para5 = new SqlParameter("@NgayGiao", SqlDbType.DateTime);
            para5.Direction = ParameterDirection.Input;
            para5.Value = phieu.NgayGiao;
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
        public static void xoahoadonban(int ID)
        {
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "HoaDonBan_delete";
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
