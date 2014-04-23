using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
namespace BUS
{
    public class SanPham_BUS
    {
        public static List<SanPham> GetList()
        {
            List<SanPham> lstSP = new List<SanPham>();
            lstSP = SanPhamDAO.GetList();
            return lstSP;
        }

        public static void Them(SanPham SP)
        {
            SanPhamDAO.Them(SP);

        }

        public static void CapNhat(SanPham SP)
        {
            SanPhamDAO.CapNhat(SP);

        }

        public static DataTable GetTable()
        {
            DataTable SP = new DataTable();
            SP = SanPhamDAO.GetTable();
            return SP;
        }


        public static void Xoa(String maSP)
        {
            SanPhamDAO.Xoa(maSP);

        }


    }
}
