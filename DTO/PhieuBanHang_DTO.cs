using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.DTO
{
    public class PhieuBanHang_DTO
    {
        private string _maPBH = "";

        public string MaPBH
        {
            get { return _maPBH; }
            set { _maPBH = value; }
        }

        private int _id_KH;

        public int Id_KH
        {
            get { return _id_KH; }
            set { _id_KH = value; }
        }

        private int _id_NV;

        public int Id_NV
        {
            get { return _id_NV; }
            set { _id_NV = value; }
        }

        private DateTime _ngaygiao;

        public DateTime Ngaygiao
        {
            get { return _ngaygiao; }
            set { _ngaygiao = value; }
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

    }
}
