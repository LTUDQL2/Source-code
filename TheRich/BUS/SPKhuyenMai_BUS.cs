using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class SPKhuyenMai_BUS
    {
        public static List<SPKhuyenMai> GetList()
        {
            List<SPKhuyenMai> lstSP = new List<SPKhuyenMai>();
            lstSP = SPKhuyenMai_DAO.GetList();
            return lstSP;
        }

        public static void Them(SPKhuyenMai SP)
        {
            SPKhuyenMai_DAO.Them(SP);

        }

        public static void CapNhat(SPKhuyenMai SP)
        {
            SPKhuyenMai_DAO.CapNhat(SP);

        }

        public static DataTable GetTable()
        {
            DataTable SP = new DataTable();
            SP = SPKhuyenMai_DAO.GetTable();
            return SP;
        }


        public static void Xoa(String maSP)
        {
            SPKhuyenMai_DAO.Xoa(maSP);

        }
    }
}
