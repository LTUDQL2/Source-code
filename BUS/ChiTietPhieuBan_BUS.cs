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
    class ChiTietPhieuBan_BUS
    {
        public static DataTable gettable(string MaPhieu)
        {
            DataTable dt = new DataTable();
            dt = ChiTietPhieuBan_DAO.gettable(MaPhieu);
            return dt;
        }
        public static DataTable gettable2(string MaPhieu)
        {
            DataTable dt = new DataTable();
            dt = ChiTietPhieuBan_DAO.gettable2(MaPhieu);
            return dt;
        }
        public static DataTable gettable3()
        {
            DataTable dt = new DataTable();
            dt = ChiTietPhieuBan_DAO.gettable3();
            return dt;
        }
        public static List<ChiTietPhieuBan_DTO> getlist(string MaPhieu)
        {
            List<ChiTietPhieuBan_DTO> dt = new List<ChiTietPhieuBan_DTO>();
            dt = ChiTietPhieuBan_DAO.getlist(MaPhieu);
            return dt;
        }

        public static void themchitietphieuban(ChiTietPhieuBan_DTO dvt)
        {
            ChiTietPhieuBan_DAO.themchitietphieuban(dvt);
        }

        public static void capnhatchitietphieuban(ChiTietPhieuBan_DTO dvt)
        {
            ChiTietPhieuBan_DAO.capnhatchitietphieuban(dvt);
        }

        public static void xoachitietphieuban(int dvt, string maphieu)
        {
            ChiTietPhieuBan_DAO.xoaphieuban(dvt, maphieu);
        }
    }
}
