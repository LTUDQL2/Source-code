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
    public class NhaSanXuat_DAO
    {
        public DataTable AutoUpdate(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            SqlCommand sqlCmd = new SqlCommand("usp_GetListNSX", conn);
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
        public DataTable GetListNSX()
        {
            DataTable dt = new DataTable();

            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_GetListNSX", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cmd.ExecuteNonQuery();
            cn.Close();
            return dt;
        }
    }
}
