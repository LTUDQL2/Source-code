using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
namespace BUS
{
    public class SanPham_BUS
    {
        public static DataTable GetSanPham()
        {
            return SanPham_DAO.GetDataTable();
        }
    }
}
