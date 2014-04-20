using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class NguoiDung_BUS
    {
        public static object SelectAllData(string ND)
        {
            return NguoiDung_DAO.SelectAllData(ND) ;
        }
    }
}
