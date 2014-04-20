using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class KhachHang_BUS
    {
        public static DataTable SelectAllData()
        {
            return KhachHang_DAO.SelectAllData("KhachHang");
        }
    }
}
