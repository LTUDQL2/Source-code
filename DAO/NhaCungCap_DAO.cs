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
    public class NhaCungCap_DAO
    {
        public DataTable AutoUpdate(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            SqlCommand sqlCmd = new SqlCommand("usp_GetListNCC", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);

            dt = (DataTable)dgv.DataSource;
            DataColumn[] keys = new DataColumn[2];
            keys[1] = dt.Columns[0];
            keys[2] = dt.Columns[1];
            dt.PrimaryKey = keys;

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(dt);
            return dt;
        }
        public DataTable GetListNCC()
        {
            DataTable dt = new DataTable();

            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_GetListNCC", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cmd.ExecuteNonQuery();
            cn.Close();
            return dt;
        }
        public static DataTable gettable()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "nhaCC_select2";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static List<NhaCungCap_DTO> getlist()
        {
            List<NhaCungCap_DTO> ls = new List<NhaCungCap_DTO>();
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "nhaCC_select";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlDataReader cusor = cmd.ExecuteReader();
            while (cusor.Read())
            {
                NhaCungCap_DTO da = new NhaCungCap_DTO();
                da.Id_NCC = Convert.ToInt32(cusor["Id_NCC"]);
                da.MaNCC = cusor["MaNCC"].ToString();
                da.TenNCC = cusor["TenNCC"].ToString();
                da.DiaChi = cusor["DIachi"].ToString();
                da.Sdt = cusor["Sdt"].ToString();
                ls.Add(da);
            }
            cusor.Close();
            conn.Close();
            return ls;
        }
        public static void themnhaphanphoi(NhaCungCap_DTO nhacc)
        {
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "nhaCC_insert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter para = new SqlParameter("@MaNCC", SqlDbType.VarChar, 50);
            para.Direction = ParameterDirection.Input;
            para.Value = nhacc.MaNCC;
            cmd.Parameters.Add(para);

            SqlParameter para2 = new SqlParameter("@TenNCC", SqlDbType.NVarChar, 30);
            para2.Direction = ParameterDirection.Input;
            para2.Value = nhacc.TenNCC;
            cmd.Parameters.Add(para2);

            SqlParameter para4 = new SqlParameter("@Diachi", SqlDbType.NVarChar, 50);
            para4.Direction = ParameterDirection.Input;
            para4.Value = nhacc.DiaChi;
            cmd.Parameters.Add(para4);

            SqlParameter para5 = new SqlParameter("@Sdt", SqlDbType.NChar, 12);
            para5.Direction = ParameterDirection.Input;
            para5.Value = nhacc.DiaChi;
            cmd.Parameters.Add(para5);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void capnhatnhaphanphoi(NhaCungCap_DTO nhacc)
        {
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "nhaCC_update";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter para = new SqlParameter("@MaNCC", SqlDbType.VarChar, 50);
            para.Direction = ParameterDirection.Input;
            para.Value = nhacc.MaNCC;
            cmd.Parameters.Add(para);

            SqlParameter para2 = new SqlParameter("@TenNCC", SqlDbType.NVarChar, 30);
            para2.Direction = ParameterDirection.Input;
            para2.Value = nhacc.TenNCC;
            cmd.Parameters.Add(para2);

            SqlParameter para4 = new SqlParameter("@Diachi", SqlDbType.NVarChar, 50);
            para4.Direction = ParameterDirection.Input;
            para4.Value = nhacc.DiaChi;
            cmd.Parameters.Add(para4);

            SqlParameter para5 = new SqlParameter("@Sdt", SqlDbType.NChar, 12);
            para5.Direction = ParameterDirection.Input;
            para5.Value = nhacc.DiaChi;
            cmd.Parameters.Add(para5);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void xoanhaphanphoi(int nhacc)
        {
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "nhaCC_delete";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter para = new SqlParameter("@ID_NCC", SqlDbType.Int);
            para.Direction = ParameterDirection.Input;
            para.Value = nhacc;
            cmd.Parameters.Add(para);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
