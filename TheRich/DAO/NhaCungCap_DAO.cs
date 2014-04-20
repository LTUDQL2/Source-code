using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhaCungCap_DAO
    {
        public static DataTable SelectAllData(string NhaCungCap)
        {
            DataProvider dataProvider = new DataProvider();
            dataProvider.CommandType = System.Data.CommandType.Text;
            DataTable dt = dataProvider.SelectAllData(NhaCungCap);
            return dt;
        }
    }
}
