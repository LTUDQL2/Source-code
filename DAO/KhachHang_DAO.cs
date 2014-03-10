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
    public class KhachHang_DAO
    {
        public DataTable SearchCustomer(string keyWord, int check)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            SqlCommand sqlCmd = new SqlCommand("usp_SearchCustomer", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlParameter para1 = new SqlParameter("keyWord", SqlDbType.NVarChar, 50);
            para1.Direction = ParameterDirection.Input;
            para1.Value = keyWord;
            sqlCmd.Parameters.Add(para1);

            SqlParameter para2 = new SqlParameter("check", SqlDbType.Int);
            para2.Direction = ParameterDirection.Input;
            sqlCmd.Parameters.Add(para2);
            para2.Value = check;

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);
            conn.Open();
            sqlCmd.ExecuteNonQuery();
            conn.Close();
            return dt;
        }

        public DataTable SearchAllCustomer(string keyWord)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            SqlCommand sqlCmd = new SqlCommand("usp_GetAllCustomer", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);

            conn.Open();
            sqlCmd.ExecuteNonQuery();
            conn.Close();
            return dt;
        }
        public DataTable GetListCustomer()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            SqlCommand sqlCmd = new SqlCommand("usp_GetAllCustomer", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);

            conn.Open();
            sqlCmd.ExecuteNonQuery();
            conn.Close();
            return dt;
        }

        public KhachHang_DTO SetCustomer(int id)
        {
            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_SetKH", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", id);
            KhachHang_DTO kh = new KhachHang_DTO();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                kh.Id_KH = Convert.ToInt32(rd[0].ToString());
                kh.HoTen = rd[1].ToString();
                kh.Sdt = rd[2].ToString();
                kh.DiaChi = rd[3].ToString();
                if (rd.IsDBNull(4))
                {
                    kh.Id_CH = 0;
                }
                else
                    kh.Id_CH = Convert.ToInt32(rd[4].ToString());
            }
            cn.Close();
            return kh;
        }

        public void Insert(KhachHang_DTO KH)
        {
            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_InsertKH", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter para1 = new SqlParameter("ten", SqlDbType.NVarChar, 50);
            para1.Value = KH.HoTen;
            para1.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para1);

            SqlParameter para2 = new SqlParameter("sdt", SqlDbType.NChar, 12);
            para2.Value = KH.Sdt;
            para2.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para2);

            SqlParameter para3 = new SqlParameter("diaChi", SqlDbType.NVarChar, 50);
            para3.Value = KH.DiaChi;
            para3.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para3);

            SqlParameter para4 = new SqlParameter("id_ch", SqlDbType.Int);
            para4.Value = KH.Id_CH;
            para4.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para4);

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Update(KhachHang_DTO KH)
        {
            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_UpdateKH", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter para1 = new SqlParameter("id_kh", SqlDbType.Int);
            para1.Value = KH.Id_KH;
            para1.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para1);

            SqlParameter para2 = new SqlParameter("ten", SqlDbType.NVarChar, 50);
            para2.Value = KH.HoTen;
            para2.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para2);

            SqlParameter para3 = new SqlParameter("sdt", SqlDbType.NChar, 12);
            para3.Value = KH.Sdt;
            para3.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para3);

            SqlParameter para4 = new SqlParameter("diaChi", SqlDbType.NVarChar, 50);
            para4.Value = KH.DiaChi;
            para4.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para4);

            SqlParameter para5 = new SqlParameter("id_ch", SqlDbType.Int);
            para5.Value = KH.Id_CH;
            para5.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para5);

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Delete(int id)
        {
            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_DeleteKH", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter para = new SqlParameter("id", SqlDbType.Int);
            para.Value = id;
            para.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para);

            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static void capnhatkhuyenmai(int ID_KH, int sodiem)
        {
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "KhachHang_updatekhuyenmai";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter para = new SqlParameter("@DiemTichLuy", SqlDbType.Int);
            para.Direction = ParameterDirection.Input;
            para.Value = sodiem;
            cmd.Parameters.Add(para);

            SqlParameter para3 = new SqlParameter("@ID_KH", SqlDbType.Int);
            para3.Direction = ParameterDirection.Input;
            para3.Value = ID_KH;
            cmd.Parameters.Add(para3);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static List<KhachHang_DTO> getlist()
        {
            List<KhachHang_DTO> ls = new List<KhachHang_DTO>();
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "KhachHang_select";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlDataReader cusor = cmd.ExecuteReader();
            while (cusor.Read())
            {
                KhachHang_DTO da = new KhachHang_DTO();
                da.Id_KH = Convert.ToInt32(cusor["Id_KH"]);
                da.HoTen = cusor["HoTen"].ToString();

                if (cusor["Id_KM"] is DBNull)
                {
                    da.Id_KM = 0;
                }
                else
                    da.Id_KM = Convert.ToInt32(cusor["Id_KM"]);
                ls.Add(da);
            }
            cusor.Close();
            conn.Close();
            return ls;
        }
    }
}
