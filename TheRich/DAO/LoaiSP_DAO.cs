using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class LoaiSP_DAO
    {
        public static DataTable SelectAllData(string LoaiSP)
        {
            DataProvider dataProvider = new DataProvider();
            dataProvider.CommandType = System.Data.CommandType.Text;
            DataTable dt = dataProvider.SelectAllData(LoaiSP);
            return dt;
        }
    }
}
