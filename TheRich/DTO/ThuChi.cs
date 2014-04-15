using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ThuChi
    {
        private int id_TC;
        public int Id_TC {
            get { return id_TC; }
            set { id_TC = value; }
        }

        private string loaiTC;
        public string LoaiTC {
            get { return loaiTC; }
            set { loaiTC = value; }
        }

        private DateTime ngay;
        public DateTime NgayTC {
            get { return ngay; }
            set { ngay = value; }
        }

        private string nguyenNhan;
        public string NguyenNhan {
            get { return nguyenNhan; }
            set { nguyenNhan = value; }
        }

        private int st;
        public int SoTien {
            get { return st; }
            set { st = value; }
        }

        private int id_ND;
        public int Id_ND {
            get { return id_ND; }
            set { id_ND = value; }
        }

        private int id_HD;
        public int Id_HD {
            get { return id_HD; }
            set { id_HD = value; }
        }
    }
}
