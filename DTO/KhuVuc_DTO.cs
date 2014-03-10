using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.DTO
{
    public class KhuVuc_DTO
    {
        private int idkv;

        public int Id_KV
        {
            get { return idkv; }
            set { idkv = value; }
        }

        private string ma = "";

        public string MaKV
        {
            get { return ma; }
            set { ma = value; }
        }

        private string ten = "";

        public string TenKV
        {
            get { return ten; }
            set { ten = value; }
        }

        private int tt;

        public int TrucThuoc
        {
            get { return tt; }
            set { tt = value; }
        }
    }
}
