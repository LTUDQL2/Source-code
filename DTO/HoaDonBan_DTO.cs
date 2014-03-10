using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.DTO
{
    public class HoaDonBan_DTO
    {
        private int id_HoaDon;

        public int Id_HD
        {
            get { return id_HoaDon; }
            set { id_HoaDon = value; }
        }

        private DateTime _ngaygiao;

        public DateTime NgayGiao
        {
            get { return _ngaygiao; }
            set { _ngaygiao = value; }
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

        private int tongTienPhaiThu;

        public int TongTien
        {
            get { return tongTienPhaiThu; }
            set { tongTienPhaiThu = value; }
        }

        private string _ghichu = "";

        public string Ghichu
        {
            get { return _ghichu; }
            set { _ghichu = value; }
        }
    }
}
