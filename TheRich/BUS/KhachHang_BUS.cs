using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using DTO;
namespace BUS
{
    public class KhachHang_BUS
    {
        public static List<KhachHang> GetList()
        {
            List<KhachHang> lstNVL = new List<KhachHang>();
            lstNVL = KhachHang_DAO.GetList();
            return lstNVL;
        }

        public static void Them(KhachHang objNVL)
        {
            KhachHang_DAO.Them(objNVL);

        }

        ////public static void CapNhat(KhachHang objNVL)
        ////{
        ////    KhachHang_DAO.CapNhat(objNVL);

        ////}
        //public static void Xoa(int ncc)
        //{
        //    KhachHang_DAO.Xoa(ncc);

        //}
        public static DataTable GetTable()
        {
            DataTable dtMonAn = new DataTable();
            dtMonAn = KhachHang_DAO.GetTable();
            return dtMonAn;
        }
        public static DataTable SelectAllData()
        {
            return KhachHang_DAO.SelectAllData("KhachHang");
        }
    }
}
