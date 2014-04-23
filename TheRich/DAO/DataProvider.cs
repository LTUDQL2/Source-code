using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class DataProvider
    {
        private string commentText;

        public string CommentText
        {
            get { return commentText; }
            set { commentText = value; }
        }

        private CommandType commandType = CommandType.StoredProcedure;

        public CommandType CommandType
        {
            get { return commandType; }
            set { commandType = value; }
        }

        public static SqlConnection ConnectionData() {
            string cnStr = "Data Source=Huyen;Initial Catalog=TheRich;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnStr);
            cn.Open();
            return cn;
        }

        public DataTable GetDataTable()
        {
            SqlConnection conn = ConnectionData();
            SqlCommand sqlCOmmand = new SqlCommand(commentText, conn);
            sqlCOmmand.CommandType = this.commandType;
            SqlDataAdapter da = new SqlDataAdapter(sqlCOmmand);
            DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable SelectAllData(string table)
        {
            commentText = "Select * from " + table;
            SqlConnection conn = ConnectionData();
            SqlCommand sqlCOmmand = new SqlCommand(commentText, conn);
            sqlCOmmand.CommandType = this.commandType;
            SqlDataAdapter da = new SqlDataAdapter(sqlCOmmand);
            DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
