using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.DTO
{
    public class KhuyenMai_DTO
    {
        private int id_KhuyenMai;

        public int Id_KM
        {
            get { return id_KhuyenMai; }
            set { id_KhuyenMai = value; }
        }

        private string soDiemTuongUng = "";

        public string SoDiem
        {
            get { return soDiemTuongUng; }
            set { soDiemTuongUng = value; }
        }

        private int tiLe;

        public int TiLeGiam
        {
            get { return tiLe; }
            set { tiLe = value; }
        }

    }
}
