using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.DTO
{
    public class PhieuNhapHang_DTO
    {
        private string _maPNH = "";

        public string MaPNH
        {
            get { return _maPNH; }
            set { _maPNH = value; }
        }

        private int _id_NCC;

        public int Id_NCC
        {
            get { return _id_NCC; }
            set { _id_NCC = value; }
        }

        private int _id_NV;

        public int Id_NV
        {
            get { return _id_NV; }
            set { _id_NV = value; }
        }

        private string _diachi = "";

        public string Diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }

        private string _sdt = "";

        public string SDT
        {
            get { return _sdt; }
            set { _sdt = value; }
        }

        private DateTime _ngaynhap;

        public DateTime Ngaynhap
        {
            get { return _ngaynhap; }
            set { _ngaynhap = value; }
        }

        private int _tongtien;

        public int TongTien
        {
            get { return _tongtien; }
            set { _tongtien = value; }
        }

        private int _tinhtrang;

        public int TinhTrang
        {
            get { return _tinhtrang; }
            set { _tinhtrang = value; }
        }
    }
}
