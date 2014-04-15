using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class LoaiSP
    {
        private int id_LSP;
        public int Id_LSP{
            get { return id_LSP; }
            set { id_LSP = value; }
        }

        private string ten;
        public string TenLoai {
            get { return ten; }
            set { ten = value; }
        }

        private int id_ND;
        public int Id_ND {
            get { return id_ND; }
            set { id_ND = value; }
        }
    }
}
