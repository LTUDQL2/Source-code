using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        public static SqlConnection ConnectionData()
        {
            string cnStr = "Data Source=(local);Initial Catalog=QLSP;Integrated Security=True";

            SqlConnection cn = new SqlConnection(cnStr);
            cn.Open();
            return cn;
        }

        public static string GetConnString()
        {
            string rs = "Data Source=(local);Initial Catalog=QLSP;Integrated Security=True";
            return rs;
        }
    }
}
