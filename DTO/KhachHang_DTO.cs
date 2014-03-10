using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.DTO
{
    public class KhachHang_DTO
    {
        private int id_KhachHang;

        public int Id_KH
        {
            get { return id_KhachHang; }
            set { id_KhachHang = value; }
        }

        private int id_KhuyenMai;

        public int Id_KM
        {
            get { return id_KhuyenMai; }
            set { id_KhuyenMai = value; }
        }

        private string hoTenKhachHang = "";

        public string HoTen
        {
            get { return hoTenKhachHang; }
            set { hoTenKhachHang = value; }
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

        private int diemTichLuy;

        public int DiemTL
        {
            get { return diemTichLuy; }
            set { diemTichLuy = value; }
        }

        private int id_CuaHang;

        public int Id_CH
        {
            get { return id_CuaHang; }
            set { id_CuaHang = value; }
        }

    }
}
