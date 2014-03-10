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
    class NhaSanXuat_BUS
    {
        NhaSanXuat_DAO dao = new NhaSanXuat_DAO();
        public void AutoUpdate(DataGridView dgv)
        {
            dao.AutoUpdate(dgv);
        }
        public DataTable GetListNSX()
        {
            return dao.GetListNSX();
        }
    }
}
