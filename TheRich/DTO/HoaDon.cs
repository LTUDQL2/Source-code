using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class HoaDon
    {
        private int id_HD;
        public int Id_HD {
            get { return id_HD; }
            set { id_HD = value; }
        }

        private string loaiHD;
        private string LoaiHD {
            get { return loaiHD; }
            set { loaiHD = value; }
        }

        private DateTime ngayLap;
        private DateTime NgayLap {
            get { return ngayLap; }
            set { ngayLap = value; }
        }

        private int tongTien;
        public int TongTien {
            get { return tongTien; }
            set { tongTien = value; }
        }

        private string tinhTrang;
        public string TinhTrang {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }

        private int id_ND;
        public int Id_ND {
            get { return id_ND; }
            set { id_ND = value; }
        }

        private int id_KH;
        public int Id_KH {
            get { return id_KH; }
            set { id_KH = value; }
        }
    }
}
