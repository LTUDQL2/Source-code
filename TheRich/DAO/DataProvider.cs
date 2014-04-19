using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class DataProvider
    {
        public static SqlConnection ConnectionData() {
            string cnStr = "Data Source=kvhgiang-PC;Initial Catalog=TheRich;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnStr);
            cn.Open();
            return cn;
        }
    }
}
