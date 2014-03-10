using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Project.DAO;
using System.Data;
using Project.DTO;
namespace Project.BUS
{
    class ChiTietPhieu_BUS
    {
        public static DataTable gettable(string MaPhieu)
        {
            DataTable dt = new DataTable();
            dt = ChiTietPhieu_DAO.gettable(MaPhieu);
            return dt;
        }
        public static DataTable gettable2(string MaPhieu)
        {
            DataTable dt = new DataTable();
            dt = ChiTietPhieu_DAO.gettable2(MaPhieu);
            return dt;
        }
        public static List<ChiTietPhieu_DTO> getlist(string MaPhieu)
        {
            List<ChiTietPhieu_DTO> dt = new List<ChiTietPhieu_DTO>();
            dt = ChiTietPhieu_DAO.getlist(MaPhieu);
            return dt;
        }

        public static void themchitiet(ChiTietPhieu_DTO dvt)
        {
            ChiTietPhieu_DAO.themchitiet(dvt);
        }

        public static void capnhatchitiet(ChiTietPhieu_DTO dvt)
        {
            ChiTietPhieu_DAO.capnhatchitiet(dvt);
        }

        public static void xoachitietphieu(int dvt, string maphieu)
        {
            ChiTietPhieu_DAO.xoaphieunhap(dvt, maphieu);
        }
    }
}
