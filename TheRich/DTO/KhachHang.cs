using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class KhachHang
    {
        private int id_KH;
        public int Id_KH {
            get { return id_KH; }
            set { id_KH = value; }
        }

        private string ht;
        public string HoTen {
            get { return ht; }
            set { ht = value; }
        }

        private DateTime ngaySinh;
        public DateTime NgaySinh {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        private string gioiTinh;
        public string GioiTinh {
            get { return gioiTinh; }
            set { gioiTinh = value; }
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

        private int dtl;
        public int DiemTichLuy {
            get { return dtl; }
            set { dtl = value; }
        }

        private int id_ND;
        public int Id_ND {
            get { return id_ND; }
            set { id_ND = value; }
        }
    }
}
