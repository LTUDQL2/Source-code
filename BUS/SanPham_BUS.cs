using Project.DTO;
using Project.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project.BUS
{
    class SanPham_BUS
    {
        public static DataTable gettable()
        {
            DataTable dt = new DataTable();
            dt = SanPham_DAO.gettable();
            return dt;
        }
        public static DataTable gettable2()
        {
            DataTable dt = new DataTable();
            dt = SanPham_DAO.gettable2();
            return dt;
        }
        public static DataTable gettable3(int a)
        {
            DataTable dt = new DataTable();
            dt = SanPham_DAO.gettable3(a);
            return dt;
        }
        public static DataTable gettable4(int a)
        {
            DataTable dt = new DataTable();
            dt = SanPham_DAO.gettable4(a);
            return dt;
        }
        public static List<SanPham_DTO> getlist()
        {
            List<SanPham_DTO> dt = new List<SanPham_DTO>();
            dt = SanPham_DAO.getlist();
            return dt;
        }

        public static void themSP(SanPham_DTO sp)
        {
            SanPham_DAO.ThemSP(sp);
        }

        public static void capnhatsp(SanPham_DTO sp)
        {
            SanPham_DAO.capnhatSP(sp);
        }
        public static void capnhatsoluongsanpham(int ID, int Soluong)
        {
            SanPham_DAO.capnhatsoluongsanpham(ID, Soluong);
        }
        public static void capnhatxoaluongsanpham(int ID, int Soluong)
        {
            SanPham_DAO.capnhatsoxoaluongsanpham(ID, Soluong);
        }
        public static void xoaP(int sp)
        {
            SanPham_DAO.xoaSP(sp);
        }
        public static void chuyenhang(SanPham_DTO sp, int khochuyen, int soluong)
        {
            SanPham_DAO.chuyencuahang(sp, khochuyen, soluong);
        }
        SanPham_DAO dao = new SanPham_DAO();
        public DataTable GetListSP()
        {
            return dao.GetListSP();
        }

        public SanPham_DTO SetSP(int id)
        {
            return dao.SetSP(id);
        }
        public void Insert(SanPham_DTO sp)
        {
            dao.Insert(sp);
        }

        public void Update(SanPham_DTO sp_dto)
        {
            dao.Update(sp_dto);
        }

        public void Delete(int id)
        {
            dao.Delete(id);
        }

        public Object GetListSP_CH(int id)
        {
            return dao.GetListSP_CH(id);
        }
    }
}
