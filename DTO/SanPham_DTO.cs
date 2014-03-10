using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.DTO
{
    public class SanPham_DTO
    {
        private int id_SanPham;

        public int Id_SP
        {
            get { return id_SanPham; }
            set { id_SanPham = value; }
        }

        private string maSanPham = "";

        public string MaSP
        {
            get { return maSanPham; }
            set { maSanPham = value; }
        }

        private string tenSanPham = "";

        public string TenSP
        {
            get { return tenSanPham; }
            set { tenSanPham = value; }
        }

        private DateTime d_ngayNhap;

        public DateTime NgayNhap
        {
            get { return d_ngayNhap; }
            set { d_ngayNhap = value; }
        }

        private int i_soLuongTon;

        public int SLTon
        {
            get { return i_soLuongTon; }
            set { i_soLuongTon = value; }
        }

        private int i_giaSi;

        public int GiaSi
        {
            get { return i_giaSi; }
            set { i_giaSi = value; }
        }

        private int i_giaLe;

        public int GiaLe
        {
            get { return i_giaLe; }
            set { i_giaLe = value; }
        }

        private int ch;

        public int Id_CH
        {
            get { return ch; }
            set { ch = value; }
        }

        private int nh;

        public int Id_NH
        {
            get { return nh; }
            set { nh = value; }
        }

        private int dv;

        public int Id_DVT
        {
            get { return dv; }
            set { dv = value; }
        }

        private int nsx;

        public int Id_NSX
        {
            get { return nsx; }
            set { nsx = value; }
        }

    }
}
