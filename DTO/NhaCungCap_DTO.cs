using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.DTO
{
    public class NhaCungCap_DTO
    {
        private int id_NhaCC;

        public int Id_NCC
        {
            get { return id_NhaCC; }
            set { id_NhaCC = value; }
        }

        private string maNhaCC = "";

        public string MaNCC
        {
            get { return maNhaCC; }
            set { maNhaCC = value; }
        }

        private string tenNhaCC = "";

        public string TenNCC
        {
            get { return tenNhaCC; }
            set { tenNhaCC = value; }
        }

        private string diaChiLienHe = "";

        public string DiaChi
        {
            get { return diaChiLienHe; }
            set { diaChiLienHe = value; }
        }

        private string sdtLienHe = "";

        public string Sdt
        {
            get { return sdtLienHe; }
            set { sdtLienHe = value; }
        }

    }
}
