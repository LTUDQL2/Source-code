using Project.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO;

namespace Project.BUS
{
    class Help_BUS
    {
         public List<TreeNode> GetNodeCha()
         {
        List<TreeNode> list = new List<TreeNode>();

        SqlConnection cn  = DataProvider.ConnectionData();
        SqlCommand cmd = new SqlCommand("usp_GetListHelp_NodeCha", cn);
        cmd.CommandType = CommandType.StoredProcedure;

        SqlDataReader rd  = cmd.ExecuteReader();
        while (rd.Read())
             {
            Help_DTO h = new Help_DTO();
            if (rd.IsDBNull(0))
                h.Id = 0;
            else 
                h.Id = rd.GetInt32(0);
            if (rd.IsDBNull(1))
                h.Title = "";
            else 
                h.Title = rd.GetString(1);
            TreeNode trn = new TreeNode();
            trn.Text = h.Title;
            trn.Tag = h.Id;
            list.Add(trn);
             }
        cn.Close();
        return list;
         }
    public List<TreeNode>  GetNodeCon(int id)
    {
        List<TreeNode> list = new List<TreeNode> ();
        SqlConnection cn  = DataProvider.ConnectionData();
        SqlCommand cmd = new SqlCommand("usp_GetListHelp_NodeCon", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("id", id);
        SqlDataReader rd  = cmd.ExecuteReader();
        while (rd.Read())
        {
            Help_DTO h = new Help_DTO();
            if (rd.IsDBNull(0))
                h.Id = 0;
            else 
                h.Id = rd.GetInt32(0);
            if (rd.IsDBNull(1))
                h.Title = "";
            else 
                h.Title = rd.GetString(1);
            TreeNode trn = new TreeNode();
            trn.Text = h.Title;
            trn.Tag = h.Id;
            list.Add(trn);
        }
        cn.Close();
        return list;
    }
    public string GetBodyHelp(int id)
    {
        SqlConnection cn  = DataProvider.ConnectionData();
        SqlCommand cmd = new SqlCommand("usp_GetBodyHelp", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("id", id);
        SqlDataReader rd = cmd.ExecuteReader();
        Help_DTO h = new Help_DTO();
        while (rd.Read())
        {
            h.Body = rd.GetString(0);
        }
        cn.Close();
        return h.Body;
    }
    }
}
