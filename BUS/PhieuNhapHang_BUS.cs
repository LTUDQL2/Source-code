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
    class PhieuNhapHang_BUS
    {
        public static DataTable gettable()
        {
            DataTable dt = new DataTable();
            dt = PhieuNhapHang_DAO.gettable();
            return dt;
        }
        public static DataTable gettable2()
        {
            DataTable dt = new DataTable();
            dt = PhieuNhapHang_DAO.gettable2();
            return dt;
        }
        public static DataTable gettable3()
    {
        DataTable dt = new DataTable();
        dt = PhieuNhapHang_DAO.gettable3();
        return dt;
    }
        public static List<PhieuNhapHang_DTO> getlist()
        {
            List<PhieuNhapHang_DTO> dt = new List<PhieuNhapHang_DTO>();
            dt = PhieuNhapHang_DAO.getlist();
            return dt;
        }

        public static void themphieunhap(PhieuNhapHang_DTO dvt)
        {
            PhieuNhapHang_DAO.themphieunhap(dvt);
        }

        public static void capnhatphieunhap(PhieuNhapHang_DTO dvt)
        {
            PhieuNhapHang_DAO.capnhatphieunhap(dvt);
        }

        public static void xoaphieunhap(string dvt)
        {
            PhieuNhapHang_DAO.xoaphieunhap(dvt);
        }
    }
}
