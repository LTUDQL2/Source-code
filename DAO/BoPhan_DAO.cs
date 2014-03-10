using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project.DTO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using DAO;
using System.Threading.Tasks;

namespace Project.DAO
{
    public class BoPhan_DAO
    {
        private BoPhan_DTO bp = new BoPhan_DTO();

        public List<TreeNode> ListNodeBP()
        {
            List<TreeNode> list = new List<TreeNode>();

            SqlConnection cn = DataProvider.ConnectionData();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "usp_GetListBP";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                BoPhan_DTO bp = new BoPhan_DTO();

                bp.Id_BP = rd.GetInt32(0);
                bp.MaBP = rd.GetString(1);
                bp.TenBP = rd.GetString(2);
                TreeNode trn = new TreeNode(bp.TenBP);
                trn.Tag = bp.Id_BP;
                trn.ToolTipText = "Double click để xem thông tin nhân viên của cả bộ phận";
                list.Add(trn);
            }
            cn.Close();

            return list;
        }

        public DataTable GetListBP()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            SqlCommand sqlCmd = new SqlCommand("usp_GetListBP", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);

            conn.Open();
            sqlCmd.ExecuteNonQuery();
            conn.Close();

            return dt;
        }
        public DataTable AutoUpdate(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            SqlCommand sqlCmd = new SqlCommand("usp_GetListBP", conn);
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
    }
}
