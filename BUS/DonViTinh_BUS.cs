using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project.DAO;
using System.Data;
using Project.DTO;
using System.Windows.Forms;
namespace Project.BUS
{
    class DonViTinh_BUS
    {
        DonViTinh_DAO dao = new DonViTinh_DAO();
        public Object GetListDVT()
        {
            return dao.GetListDVT();
        }

        public void AutoUpdate(DataGridView dataGridView)
        {
            dao.AutoUpdate(dataGridView);
        }
    }
}
