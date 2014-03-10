using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.DTO
{
    public class NhaSanXuat_DTO
    {
        private int id_NhaSanXuat;

        public int Id_NSX
        {
            get { return id_NhaSanXuat; }
            set { id_NhaSanXuat = value; }
        }

        private string maNhaSanXuat = "";

        public string MaNSX
        {
            get { return maNhaSanXuat; }
            set { maNhaSanXuat = value; }
        }

        private string tenNhaSanXuat = "";

        public string TenNSX
        {
            get { return tenNhaSanXuat; }
            set { tenNhaSanXuat = value; }
        }

    }
}
