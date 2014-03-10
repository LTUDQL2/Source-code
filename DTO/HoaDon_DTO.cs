using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.DTO
{
    public class HoaDon_DTO
    {
        private int id_HoaDon;

        public int Id_HD
        {
            get { return id_HoaDon; }
            set { id_HoaDon = value; }
        }

        private DateTime _ngaylap;

        public DateTime NgayLap
        {
            get { return _ngaylap; }
            set { _ngaylap = value; }
        }

        private int id_NhanVien;

        public int Id_NV
        {
            get { return id_NhanVien; }
            set { id_NhanVien = value; }
        }

        private string _maphieu = "";

        public string MaPhieu
        {
            get { return _maphieu; }
            set { _maphieu = value; }
        }

        private int tongTienPhaiTra;

        public int TongTien
        {
            get { return tongTienPhaiTra; }
            set { tongTienPhaiTra = value; }
        }

        private string _ghichu = "";

        public string Ghichu
        {
            get { return _ghichu; }
            set { _ghichu = value; }
        }

    }
}
