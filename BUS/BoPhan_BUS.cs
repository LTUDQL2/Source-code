using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Project.DAO;
using System.Data;
using System.Threading.Tasks;

namespace Project.BUS
{
    public class BoPhan_BUS
    {
        BoPhan_DAO dao = new BoPhan_DAO();
        public DataTable GetListBP()
        {
            return dao.GetListBP();
        }
        public List<TreeNode> ListNodeBP()
        {
            return dao.ListNodeBP();
        }
        public void AutoUpdate(DataGridView dgv)
        {
            dao.AutoUpdate(dgv);
        }
    }
}
