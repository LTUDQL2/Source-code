using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class CTHoaDon
    {
        private int id_CT;
        public int Id_CT {
            get { return id_CT; }
            set { id_CT = value; }
        }

        private int sl;
        public int SoLuong {
            get { return sl; }
            set { sl = value; }
        }

        private int thanhTien;
        public int ThanhTien {
            get { return thanhTien; }
            set { thanhTien = value; }
        }

        private int id_SP;
        public int Id_SP {
            get { return id_SP; }
            set { id_SP = value; }
        }

        private int id_HD;
        public int Id_HD {
            get { return id_HD; }
            set { id_HD = value; }
        }
    }
}
