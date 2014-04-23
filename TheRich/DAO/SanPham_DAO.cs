using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class SanPham_DAO
    {
        public static DataTable GetDataTable()
        {
            string commandText = "SelectSanPham";
            DataProvider dataProvider = new DataProvider();
            dataProvider.CommentText = commandText;
            dataProvider.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable dt = dataProvider.GetDataTable();
            return dt;
        }

        public static DataTable GetSPTheoLoai(int l, int ch)
        {
            DataTable dt = new DataTable();
            SqlConnection cn;
            cn = DataProvider.ConnectionData();


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SelectSPTheoLoai";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            SqlParameter para;
            para = new SqlParameter("maLoai", SqlDbType.Int);
            para.Direction = ParameterDirection.Input;
            para.Value = l;
            cmd.Parameters.Add(para);

            para = new SqlParameter("maCH", SqlDbType.Int);
            para.Direction = ParameterDirection.Input;
            para.Value = ch;
            cmd.Parameters.Add(para);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
        }
    }
}
