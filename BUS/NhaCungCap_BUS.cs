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
    class NhaCungCap_BUS
    {
        NhaCungCap_DAO dao = new NhaCungCap_DAO();
        public DataTable GetListNCC()
        {
            return dao.GetListNCC();
        }

        public void AutoUpdate(DataGridView dataGridView)
        {
            dao.AutoUpdate(dataGridView);
        }
        public static DataTable gettable()
        {
            DataTable dt = new DataTable();
            dt = NhaCungCap_DAO.gettable();
            return dt;
        }
        public static List<NhaCungCap_DTO> getlist()
        {
            List<NhaCungCap_DTO> dt = new List<NhaCungCap_DTO>();
            dt = NhaCungCap_DAO.getlist();
            return dt;
        }
        public static void themnhaphanphoi(NhaCungCap_DTO nhacc)
        {
            NhaCungCap_DAO.themnhaphanphoi(nhacc);
        }
        public static void capnhatnhaphanphoi(NhaCungCap_DTO nhacc)
        {
            NhaCungCap_DAO.themnhaphanphoi(nhacc);
        }
        public static void xoanhaphanphoi(int nhacc)
        {
            NhaCungCap_DAO.xoanhaphanphoi(nhacc);
        }
    }
}