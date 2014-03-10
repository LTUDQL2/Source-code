using Project.DAO;
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
    class KhuVuc_BUS
    {
        KhuVuc_DAO dao = new KhuVuc_DAO();
        public List<TreeNode> ListNodeKV_NodeCha()
        {
            return dao.ListNodeKV_NodeCha();
        }
        public List<TreeNode> ListNodeKV_NodeCon(int id)
        {
            return dao.ListNodeKV_NodeCon(id);
        }
        public KhuVuc_DTO SetKV(int id)
        {
            return dao.SetKV(id);
        }
        public DataTable GetListKV()
        {
            return dao.GetListKV();
        }
        public DataTable GetListKV_TT()
        {
            return dao.GetListKV_TT();
        }
        public void Update(KhuVuc_DTO kv_dto)
        {
            dao.Update(kv_dto);
        }
        public void Insert(KhuVuc_DTO kv_dto)
        {
            dao.Insert(kv_dto);
        }
        public void Delete(int id)
        {
            dao.Delete(id);
        }
    }
}
