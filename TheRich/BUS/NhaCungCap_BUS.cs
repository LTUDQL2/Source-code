using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using DTO;
using DAO;
using System.Data;
namespace BUS
{
    public class NhaCungCap_BUS
    {
        //public static void Them(NhaCungCap objNVL)
        //{
        //    NhaCungCap_DAO.Them(objNVL);

        //}

        public static DataTable SelectAllData()
        {
            return NhaCungCap_DAO.SelectAllData("NhaCungCap");
        }
        public static void Xoa(int ncc)
        {
            NhaCungCap_DAO.Xoa(ncc);

        }

        public static List<NhaCungCap> GetList()
        {
            List<NhaCungCap> lstNVL = new List<NhaCungCap>();
            lstNVL = NhaCungCap_DAO.GetList();
            return lstNVL;
        }

        public static void Them(NhaCungCap objNVL)
        {
            NhaCungCap_DAO.Them(objNVL);

        }

        public static void CapNhat(NhaCungCap objNVL)
        {
            NhaCungCap_DAO.CapNhat(objNVL);

        }

        public static DataTable GetTable()
        {
            DataTable dtMonAn = new DataTable();
            dtMonAn = NhaCungCap_DAO.GetTable();
            return dtMonAn;
        }

        //public static DataTable TimKiemTheoMaNVL(String maNVL)
        //{
        //    DataTable dtMonAn = new DataTable();
        //    dtMonAn = NguyenVatLieuDAO.TimKiemTheoMaNVL(maNVL);
        //    return dtMonAn;
        //}

        //public static DataTable TimKiemTheoTenNVL(String tenNVL)
        //{
        //    DataTable dtMonAn = new DataTable();
        //    dtMonAn = NguyenVatLieuDAO.TimKiemTheoTenNVL(tenNVL);
        //    return dtMonAn;
        //}

        //public static DataTable TimKiemTheoTenLoai(String tenloai)
        //{
        //    DataTable dtMonAn = new DataTable();
        //    dtMonAn = NguyenVatLieuDAO.TimKiemTheoTenLoai(tenloai);
        //    return dtMonAn;
        //}


        //public static void Xoa(String maNVL)
        //{
        //    DoanTauDAO.Xoa(maNVL);

        //}
    }
}
