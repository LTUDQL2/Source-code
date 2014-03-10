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
    public class CuaHang_DAO
    {
        public DataTable GetListCH()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            SqlCommand sqlCmd = new SqlCommand("usp_GetListCH", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);

            conn.Open();
            sqlCmd.ExecuteNonQuery();
            conn.Close();
            return dt;
        }

        public CuaHang_DTO SetCH(int id)
        {
            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_SetCH", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", id);

            CuaHang_DTO ch = new CuaHang_DTO();
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                ch.Id_CH = int.Parse(rd[0].ToString());
                ch.TenCH = rd[1].ToString();
                ch.Sdt = rd[2].ToString();
                ch.DiaChi = rd[3].ToString();
                if (rd.IsDBNull(4))
                {
                    ch.Id_KV = 0;
                }
                else
                    ch.Id_KV = int.Parse(rd[4].ToString());
            }

            cn.Close();
            return ch;
        }

        public void Delete(int p1)
        {
            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_DeleteCH", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", p1);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Insert(CuaHang_DTO ch_dto)
        {
            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_InsertCH", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("ten", ch_dto.TenCH);
            cmd.Parameters.AddWithValue("sdt", ch_dto.Sdt);
            cmd.Parameters.AddWithValue("diaChi", ch_dto.DiaChi);
            cmd.Parameters.AddWithValue("id_kv", ch_dto.Id_KV);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Update(CuaHang_DTO ch_dto)
        {
            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_UpdateCH", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id_ch", ch_dto.Id_CH);
            cmd.Parameters.AddWithValue("ten", ch_dto.TenCH);
            cmd.Parameters.AddWithValue("sdt", ch_dto.Sdt);
            cmd.Parameters.AddWithValue("diaChi", ch_dto.DiaChi);
            cmd.Parameters.AddWithValue("id_kv", ch_dto.Id_KV);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static List<CuaHang_DTO> getlist()
        {
            List<CuaHang_DTO> ls = new List<CuaHang_DTO>();
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "CuaHang_select";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlDataReader cusor = cmd.ExecuteReader();
            while (cusor.Read())
            {
                CuaHang_DTO da = new CuaHang_DTO();
                da.Id_CH = Convert.ToInt32(cusor["Id_CH"]);
                da.TenCH = cusor["TenCH"].ToString();
                ls.Add(da);
            }

            cusor.Close();
            conn.Close();
            return ls;
        }
        public List<TreeNode> ListNodeCH(int id)
        {
            List<TreeNode> list = new List<TreeNode>();
            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_GetListCH_KV", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", id);

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                CuaHang_DTO ch = new CuaHang_DTO();
                if (rd.IsDBNull(0))
                {
                    ch.Id_CH = 0;
                }
                else
                    ch.Id_CH = rd.GetInt32(0);
                if (rd.IsDBNull(1))
                {
                    ch.TenCH = "";
                }
                else
                    ch.TenCH = rd.GetString(1);
                TreeNode trn = new TreeNode(ch.TenCH);
                trn.Tag = ch.Id_CH;
                list.Add(trn);
            }
            cn.Close();
            return list;
        }
    }
}
