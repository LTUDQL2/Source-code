using Project.DAO;
using Project.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project.BUS
{
    class HoaDonBan_BUS
    {
        public static DataTable gettable()
        {
            DataTable dt = new DataTable();
            dt = HoaDonBan_DAO.gettable();
            return dt;
        }
        public static DataTable gettable2()
        {
            DataTable dt = new DataTable();
            dt = HoaDonBan_DAO.gettable2();
            return dt;
        }
        public static List<HoaDonBan_DTO> getlist()
        {
            List<HoaDonBan_DTO> dt = new List<HoaDonBan_DTO>();
            dt = HoaDonBan_DAO.getlist();
            return dt;
        }

        public static void themhoadonban(HoaDonBan_DTO dvt)
        {
            HoaDonBan_DAO.themhoadonban(dvt);
        }

        public static void xoahoadonban(int dvt)
        {
            HoaDonBan_DAO.xoahoadonban(dvt);
        }
    }
}
