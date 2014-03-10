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
    class PhieuBanHang_BUS
    {
        public static DataTable gettable()
        {
            DataTable dt = new DataTable();
            dt = PhieuBanHang_DAO.gettable();
            return dt;
        }
        public static DataTable gettable2()
        {
            DataTable dt = new DataTable();
            dt = PhieuBanHang_DAO.gettable2();
            return dt;
        }
        public static DataTable gettable3()
        {
            DataTable dt = new DataTable();
            dt = PhieuBanHang_DAO.gettable3();
            return dt;
        }
        public static List<PhieuBanHang_DTO> getlist()
        {
            List<PhieuBanHang_DTO> dt = new List<PhieuBanHang_DTO>();
            dt = PhieuBanHang_DAO.getlist();
            return dt;
        }

        public static void themphieuban(PhieuBanHang_DTO dvt)
        {
            PhieuBanHang_DAO.themphieuban(dvt);
        }

        public static void capnhatphieuban(PhieuBanHang_DTO dvt)
        {
            PhieuBanHang_DAO.capnhatphieuban(dvt);
        }

        public static void xoaphieuban(string dvt)
        {
            PhieuBanHang_DAO.xoaphieuban(dvt);
        }
    }
}
