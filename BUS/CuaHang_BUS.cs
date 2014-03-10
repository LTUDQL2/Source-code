using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using Project.DAO;
using Project.DTO;

namespace Project.BUS
{
    class CuaHang_BUS
    {
        CuaHang_DAO dao = new CuaHang_DAO();
        public DataTable GetListCH()
        {
            return dao.GetListCH();
        }

        public CuaHang_DTO SetCH(int id)
        {
            return dao.SetCH(id);
        }

        public void Delete(int p1)
        {
            dao.Delete(p1);
        }

        public void Insert(CuaHang_DTO ch_dto)
        {
            dao.Insert(ch_dto);
        }

        public void Update(CuaHang_DTO ch_dto)
        {
            dao.Update(ch_dto);
        }
        public static List<CuaHang_DTO> getlist()
        {
            List<CuaHang_DTO> dt = new List<CuaHang_DTO>();
            dt = CuaHang_DAO.getlist();
            return dt;
        }
        public List<TreeNode> GetListCH_KV(int id)
        {
            return dao.ListNodeCH(id);
        }
    }
}
