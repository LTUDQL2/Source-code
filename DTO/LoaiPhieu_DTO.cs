using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.DTO
{
    public class LoaiPhieu_DTO
    {
        private int id_LoaiPhieu;

        public int Id_LP
        {
            get { return id_LoaiPhieu; }
            set { id_LoaiPhieu = value; }
        }

        private string maLoaiPhieu = "";

        public string MaLP
        {
            get { return maLoaiPhieu; }
            set { maLoaiPhieu = value; }
        }

        private string tenLoaiPhieu = "";

        public string TenLP
        {
            get { return tenLoaiPhieu; }
            set { tenLoaiPhieu = value; }
        }

    }
}
