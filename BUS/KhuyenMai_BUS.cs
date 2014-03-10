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
    class KhuyenMai_BUS
    {
        public static List<KhuyenMai_DTO> getlist()
        {
            List<KhuyenMai_DTO> dt = new List<KhuyenMai_DTO>();
            dt = KhuyenMai_DAO.getlist();
            return dt;
        }
    }
}
