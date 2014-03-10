using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.DTO
{
    public class CuaHang_DTO
    {
        private int id_CuaHang;

        public int Id_CH
        {
            get { return id_CuaHang; }
            set { id_CuaHang = value; }
        }

        private string tenCuaHang = "";

        public string TenCH
        {
            get { return tenCuaHang; }
            set { tenCuaHang = value; }
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

        private int kv;

        public int Id_KV
        {
            get { return kv; }
            set { kv = value; }
        }

    }
}
