using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.DTO
{
    public class NhanVien_DTO
    {
        private int id_NhanVien;

        public int Id_NV
        {
            get { return id_NhanVien; }
            set { id_NhanVien = value; }
        }

        private string maNhanVien = "";

        public string MaNV
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        private string tenNhanVien = "";

        public string TenNV
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }

        private string s_cmnd = "";

        public string CMND
        {
            get { return s_cmnd; }
            set { s_cmnd = value; }
        }

        private DateTime d_ngaySinh = DateTime.Now;

        public DateTime NgaySinh
        {
            get { return d_ngaySinh; }
            set { d_ngaySinh = value; }
        }

        private string s_gioiTinh = "";

        public string GioiTinh
        {
            get { return s_gioiTinh; }
            set { s_gioiTinh = value; }
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

        private string pw = "";

        public string Password
        {
            get { return pw; }
            set { pw = value; }
        }

        private int id_BoPhan;

        public int Id_BP
        {
            get { return id_BoPhan; }
            set { id_BoPhan = value; }
        }

        private int ql;

        public int NVQL
        {
            get { return ql; }
            set { ql = value; }
        }

        private int ch;

        public int Id_CH
        {
            get { return ch; }
            set { ch = value; }
        }

    }
}
