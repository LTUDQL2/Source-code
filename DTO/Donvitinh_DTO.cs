using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.DTO
{
    public class Donvitinh_DTO
    {
        private int _id_DVT;

        public int Id_DVT
        {
            get { return _id_DVT; }
            set { _id_DVT = value; }
        }

        private string _maDVT = "";

        public string MaDVT
        {
            get { return _maDVT; }
            set { _maDVT = value; }
        }


        private string _tenDVT = "";

        public string TenDVT
        {
            get { return _tenDVT; }
            set { _tenDVT = value; }
        }

    }
}
