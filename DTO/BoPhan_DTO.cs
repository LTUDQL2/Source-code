using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTO
{
    public class BoPhan_DTO
    {
        private int Id_BoPhan;

        public int Id_BP
        {
            get { return Id_BoPhan; }
            set { Id_BoPhan = value; }
        }

        private string maBoPhan = "";

        public string MaBP
        {
            get { return maBoPhan; }
            set { maBoPhan = value; }
        }

        private string tenBoPhan = "";

        public string TenBP
        {
            get { return tenBoPhan; }
            set { tenBoPhan = value; }
        }
    }
}
