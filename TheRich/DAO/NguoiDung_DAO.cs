using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NguoiDung_DAO
    {
        public static DataTable SelectAllData(string ND)
        {
            DataProvider dataProvider = new DataProvider();
            dataProvider.CommandType = System.Data.CommandType.Text;
            return dataProvider.SelectAllData(ND);
        }

        
    }
}
