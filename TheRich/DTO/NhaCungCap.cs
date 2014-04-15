using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class NhaCungCap
    {
        private int id_NCC;
        public int Id_NDD {
            get { return id_NCC; }
            set { id_NCC = value; }
        }

        private string tenNCC;
        public string TenNCC {
            get { return tenNCC; }
            set { tenNCC = value; }
        }

        private string diaChi;
        public string DiaChi {
            get { return diaChi; }
            set { diaChi = value; }
        }

        private string sdt;
        public string SDT {
            get { return sdt; }
            set { sdt = value; }
        }

        private int id_ND;
        public int Id_ND {
            get { return id_ND; }
            set { id_ND = value; }
        }
    }
}
