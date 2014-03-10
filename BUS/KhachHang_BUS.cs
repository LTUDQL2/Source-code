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
    class KhachHang_BUS
    {
        public int check;
        KhachHang_DAO dao = new KhachHang_DAO();
        public DataTable SearchCustomer(string keyWord)
        {
            return dao.SearchCustomer(keyWord, check);
        }
        public DataTable SearchAllCustomer(string keyWord)
        {
            return dao.SearchAllCustomer(keyWord);
        }
        public DataTable GetList()
        {
            return dao.GetListCustomer();
        }

        public KhachHang_DTO SetKH(int id)
        {
            return dao.SetCustomer(id);
        }

        public void Insert(KhachHang_DTO KH)
        {
            dao.Insert(KH);
        }

        public void Update(KhachHang_DTO KH)
        {
            dao.Update(KH);
        }

        public void Delete(int id)
        {
            dao.Delete(id);
        }
        public static void capnhatkhuyenmai(int ID_KH, int sodiem)
        {
            KhachHang_DAO.capnhatkhuyenmai(ID_KH, sodiem);
        }
        public static List<KhachHang_DTO> getlists()
        {
            List<KhachHang_DTO> lst = new List<KhachHang_DTO>();
            lst = KhachHang_DAO.getlist();
            return lst;
        }
    }
}
