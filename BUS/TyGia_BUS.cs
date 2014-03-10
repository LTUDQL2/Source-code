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
    class TyGia_BUS
    {
        TyGia_DAO dao = new TyGia_DAO();
        public DataTable GetListTG()
        {
            return dao.GetListTG();
        }
        public DataTable AutoUpdateTG(DataGridView dgv)
        {
            return dao.AutoUpdateTG(dgv);
        }

    }
}
