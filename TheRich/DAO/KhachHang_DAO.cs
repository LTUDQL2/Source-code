using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHang_DAO
    {
        public static DataTable SelectAllData(string kh)
        {
            DataProvider dataProvider = new DataProvider();
            dataProvider.CommandType = System.Data.CommandType.Text;
            DataTable dt = dataProvider.SelectAllData(kh);
            return dt;
        }
    }
}
