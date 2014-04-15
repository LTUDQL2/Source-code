using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DiemTichLuy
    {
        private int id_DTL;
        public int Id_DTL {
            get { return id_DTL; }
            set { id_DTL = value; }
        }

        private int soDiem;
        public int SoDiem {
            get { return soDiem; }
            set { soDiem = value; }
        }

        private int tiLeGiam;
        public int TiLeGiam {
            get { return tiLeGiam; }
            set { tiLeGiam = value; }
        }

        private int id_ND;
        public int Id_ND {
            get { return id_ND; }
            set { id_ND = value; }
        }
    }
}
