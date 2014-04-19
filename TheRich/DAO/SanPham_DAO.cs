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
        public static DataTable GetDataTabel()
        {
            string commandText = "SelectSanPham";
            DataProvider dataProvider = new DataProvider();
            dataProvider.CommentText = commandText;
            dataProvider.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable dt = dataProvider.GetDataTable();
            return dt;
        }
    }
}
