using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.DTO
{
    public class ChiTietPhieuBan_DTO
    {
        private int _id_CTP;

        public int ID_CTP
        {
            get { return _id_CTP; }
            set { _id_CTP = value; }
        }

        private string _maphieu;

        public string Maphieu
        {
            get { return _maphieu; }
            set { _maphieu = value; }
        }

        private int _id_SP;

        public int ID_SP
        {
            get { return _id_SP; }
            set { _id_SP = value; }
        }

        private int _soluong;

        public int Soluong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }

        private int _dongia;

        public int DonGia
        {
            get { return _dongia; }
            set { _dongia = value; }
        }

        private int _thanhtien;

        public int ThanhTien
        {
            get { return _thanhtien; }
            set { _thanhtien = value; }
        }

    }
}
