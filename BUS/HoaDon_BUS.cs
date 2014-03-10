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
    class HoaDon_BUS
    {
        public static DataTable gettable()
        {
            DataTable dt = new DataTable();
            dt = HoaDon_DAO.gettable();
            return dt;
        }
        public static DataTable gettable2()
        {
            DataTable dt = new DataTable();
            dt = HoaDon_DAO.gettable2();
            return dt;
        }
        public static List<HoaDon_DTO> getlist()
        {
            List<HoaDon_DTO> dt = new List<HoaDon_DTO>();
            dt = HoaDon_DAO.getlist();
            return dt;
        }

        public static void themhoadon(HoaDon_DTO dvt)
        {
            HoaDon_DAO.themhoadonnhap(dvt);
        }

        public static void xoahoadon(int dvt)
        {
            HoaDon_DAO.xoahoadon(dvt);
        }
    }
}
