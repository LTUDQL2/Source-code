using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class NhaCungCap_BUS
    {
        public static DataTable SelectAllData()
        {
            return NhaCungCap_DAO.SelectAllData("NhaCungCap");
        }
    }
}
