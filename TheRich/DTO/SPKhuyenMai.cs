using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class SPKhuyenMai
    {
        private int id_SPKM;
        public int Id_SPKM {
            get { return id_SPKM; }
            set { id_SPKM = value; }
        }

        private string tenSP;
        public string TenSPKM {
            get { return tenSP; }
            set { tenSP = value; }
        }

        private int sl;
        public int SoLuong {
            get { return sl; }
            set { sl = value; }
        }

        private int giaBan;
        public int GiaBan {
            get { return giaBan; }
            set { giaBan = value; }
        }

        private int id_ND;
        public int Id_ND {
            get { return id_ND; }
            set { id_ND = value; }
        }
    }
}
