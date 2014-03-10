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
    public class ChiTietPhieuBan_DAO
    {
        public static DataTable gettable(string MaPhieu)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ChiTietPhieuBan_select";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            SqlParameter para = new SqlParameter("@MaPhieu", SqlDbType.NChar, 10);
            para.Direction = ParameterDirection.Input;
            para.Value = MaPhieu;
            cmd.Parameters.Add(para);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable gettable2(string MaPhieu)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ChiTietPhieuBan_select2";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter para = new SqlParameter("@MaPhieu", SqlDbType.NChar, 10);
            para.Direction = ParameterDirection.Input;
            para.Value = MaPhieu;
            cmd.Parameters.Add(para);
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
            cmd.CommandText = "ChiTietPhieuBan_select3";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static List<ChiTietPhieuBan_DTO> getlist(string MaPhieu)
        {
            List<ChiTietPhieuBan_DTO> ls = new List<ChiTietPhieuBan_DTO>();
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ChiTietPhieuBan_select";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter para = new SqlParameter("@MaPhieu", SqlDbType.NChar, 10);
            para.Direction = ParameterDirection.Input;
            para.Value = MaPhieu;
            cmd.Parameters.Add(para);
            SqlDataReader cusor = cmd.ExecuteReader();
            while (cusor.Read())
            {
                ChiTietPhieuBan_DTO da = new ChiTietPhieuBan_DTO();
                da.ID_CTP = Convert.ToInt32(cusor["Id_CTP"]);
                da.ID_SP = Convert.ToInt32(cusor["ID_SP"]);
                da.Soluong = Convert.ToInt32(cusor["SoLuong"]);
                da.ThanhTien = Convert.ToInt32(cusor["ThanhTien"]);
                da.DonGia = Convert.ToInt32(cusor["DonGia"]);
                da.Maphieu = cusor["MaPhieu"].ToString();
                ls.Add(da);
            }
            cusor.Close();
            conn.Close();
            return ls;
        }
        public static void themchitietphieuban(ChiTietPhieuBan_DTO phieu)
        {
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ChiTietPhieuBan_insert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter para = new SqlParameter("@MaPhieu", SqlDbType.NChar, 10);
            para.Direction = ParameterDirection.Input;
            para.Value = phieu.Maphieu;
            cmd.Parameters.Add(para);

            SqlParameter para2 = new SqlParameter("@ID_SP", SqlDbType.Int);
            para2.Direction = ParameterDirection.Input;
            para2.Value = phieu.ID_SP;
            cmd.Parameters.Add(para2);

            SqlParameter para3 = new SqlParameter("@SoLuong", SqlDbType.Int);
            para3.Direction = ParameterDirection.Input;
            para3.Value = phieu.Soluong;
            cmd.Parameters.Add(para3);

            SqlParameter para4 = new SqlParameter("@DonGia", SqlDbType.Int);
            para4.Direction = ParameterDirection.Input;
            para4.Value = phieu.DonGia;
            cmd.Parameters.Add(para4);

            SqlParameter para6 = new SqlParameter("@ThanhTien", SqlDbType.Int);
            para6.Direction = ParameterDirection.Input;
            para6.Value = phieu.ThanhTien;
            cmd.Parameters.Add(para6);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void capnhatchitietphieuban(ChiTietPhieuBan_DTO phieu)
        {
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ChiTietPhieuBan_update";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter para = new SqlParameter("@MaPhieu", SqlDbType.NChar, 10);
            para.Direction = ParameterDirection.Input;
            para.Value = phieu.Maphieu;
            cmd.Parameters.Add(para);

            SqlParameter para2 = new SqlParameter("@ID_SP", SqlDbType.Int);
            para2.Direction = ParameterDirection.Input;
            para2.Value = phieu.ID_SP;
            cmd.Parameters.Add(para2);

            SqlParameter para3 = new SqlParameter("@SoLuong", SqlDbType.Int);
            para3.Direction = ParameterDirection.Input;
            para3.Value = phieu.Soluong;
            cmd.Parameters.Add(para3);

            SqlParameter para4 = new SqlParameter("@DonGia", SqlDbType.Int);
            para4.Direction = ParameterDirection.Input;
            para4.Value = phieu.DonGia;
            cmd.Parameters.Add(para4);

            SqlParameter para6 = new SqlParameter("@ThanhTien", SqlDbType.Int);
            para6.Direction = ParameterDirection.Input;
            para6.Value = phieu.ThanhTien;
            cmd.Parameters.Add(para6);

            SqlParameter para7 = new SqlParameter("@ID_CTP", SqlDbType.Int);
            para7.Direction = ParameterDirection.Input;
            para7.Value = phieu.ID_CTP;
            cmd.Parameters.Add(para7);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void xoaphieuban(int ID, string Maphieu)
        {
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ChiTietPhieuBan_delete";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter para = new SqlParameter("@ID_CTP", SqlDbType.Int);
            para.Direction = ParameterDirection.Input;
            para.Value = ID;
            cmd.Parameters.Add(para);

            SqlParameter para2 = new SqlParameter("@MaPhieu", SqlDbType.NChar, 10);
            para2.Direction = ParameterDirection.Input;
            para2.Value = Maphieu;
            cmd.Parameters.Add(para2);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
