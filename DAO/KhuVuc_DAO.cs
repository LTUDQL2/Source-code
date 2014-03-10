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
    public class KhuVuc_DAO
    {
        public List<TreeNode> ListNodeKV_NodeCha()
        {
            List<TreeNode> list = new List<TreeNode>();

            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_GetListKV_NodeCha", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                KhuVuc_DTO kv = new KhuVuc_DTO();
                if (rd.IsDBNull(0))
                {
                    kv.Id_KV = 0;
                }
                else
                    kv.Id_KV = rd.GetInt32(0);
                if (rd.IsDBNull(1))
                {
                    kv.MaKV = "";
                }
                else
                    kv.MaKV = rd.GetString(1);
                if (rd.IsDBNull(2))
                {
                    kv.TenKV = "";
                }
                else
                    kv.TenKV = rd.GetString(2);
                TreeNode trn = new TreeNode(kv.TenKV);
                trn.Tag = kv.Id_KV;
                list.Add(trn);
            }
            cn.Close();
            return list;
        }
        public List<TreeNode> ListNodeKV_NodeCon(int id)
        {
            List<TreeNode> list = new List<TreeNode>();

            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_GetListKV_NodeCon", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter para = new SqlParameter("ma", SqlDbType.Int);
            para.Value = id;
            para.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para);

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                KhuVuc_DTO kv = new KhuVuc_DTO();
                if (rd.IsDBNull(0))
                {
                    kv.Id_KV = 0;
                }
                else
                    kv.Id_KV = rd.GetInt32(0);
                if (rd.IsDBNull(1))
                {
                    kv.MaKV = "";
                }
                else
                    kv.MaKV = rd.GetString(1);
                if (rd.IsDBNull(2))
                {
                    kv.TenKV = "";
                }
                else
                    kv.TenKV = rd.GetString(2);
                TreeNode trn = new TreeNode(kv.TenKV);
                trn.Tag = kv.Id_KV;
                list.Add(trn);
            }
            cn.Close();
            return list;
        }
        public KhuVuc_DTO SetKV(int id)
        {
            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_SetKV", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", id);
            KhuVuc_DTO kv = new KhuVuc_DTO();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                kv.Id_KV = Convert.ToInt32(rd[0].ToString());
                kv.MaKV = rd[1].ToString();
                kv.TenKV = rd[2].ToString();
                if (rd.IsDBNull(3))
                {
                    kv.TrucThuoc = 0;
                }
                else
                    kv.TrucThuoc = Convert.ToInt32(rd[3].ToString());
            }
            cn.Close();
            return kv;
        }
        public DataTable GetListKV()
        {
            DataTable dt = new DataTable();

            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_GetListKV", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cmd.ExecuteNonQuery();
            cn.Close();
            return dt;
        }
        public DataTable GetListKV_TT()
        {
            DataTable dt = new DataTable();

            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_GetListKV_TT", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cmd.ExecuteNonQuery();
            cn.Close();
            return dt;
        }
        public void Update(KhuVuc_DTO kv)
        {
            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_UpdateKV", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter para1 = new SqlParameter("id_kv", SqlDbType.Int);
            para1.Value = kv.Id_KV;
            para1.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para1);

            SqlParameter para2 = new SqlParameter("ma", SqlDbType.Char, 3);
            para2.Value = kv.MaKV;
            para2.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para2);

            SqlParameter para3 = new SqlParameter("ten", SqlDbType.NVarChar, 20);
            para3.Value = kv.TenKV;
            para3.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para3);

            SqlParameter para4 = new SqlParameter("tructhuoc", SqlDbType.Int);
            para4.Value = kv.TrucThuoc;
            para4.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para4);

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Insert(KhuVuc_DTO kv)
        {
            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_InsertKV", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter para1 = new SqlParameter("ma", SqlDbType.Char, 3);
            para1.Value = kv.MaKV;
            para1.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para1);

            SqlParameter para2 = new SqlParameter("ten", SqlDbType.NVarChar, 20);
            para2.Value = kv.TenKV;
            para2.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para2);

            SqlParameter para3 = new SqlParameter("tructhuoc", SqlDbType.Int);
            para3.Value = kv.TrucThuoc;
            para3.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para3);

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Delete(int id)
        {
            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_DeleteKV", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter para = new SqlParameter("id_kv", SqlDbType.Int);
            para.Value = id;
            para.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para);

            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
