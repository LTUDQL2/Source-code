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
    class NhomHang_BUS
    {
        NhomHang_DAO dao = new NhomHang_DAO();
        public Object GetListNH()
        {
            return dao.GetListNH();
        }

        public DataTable AutoUpdate(DataGridView dataGridView)
        {
            return dao.AutoUpdate(dataGridView);
        }

    }
}
