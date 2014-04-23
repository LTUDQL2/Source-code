using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class LoaiSP_BUS
    {
        public static DataTable SelectAllData(string p)
        {
            return LoaiSP_DAO.SelectAllData(p);
        }
    }
}
