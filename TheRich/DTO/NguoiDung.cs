using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class NguoiDung
    {
        private int id_ND;
        public int Id_ND {
            get { return id_ND; }
            set { id_ND = value; }
        }

        private string ht;
        public string HoTen {
            get { return ht; }
            set { ht = value; }
        }

        private string email;
        public string Email {
            get { return email; }
            set { email = value; }
        }

        private string sdt;
        public string SDT {
            get { return sdt; }
            set { sdt = value; }
        }
        private string cmnd;
        public string CMND {
            get { return cmnd; }
            set { cmnd = value; }
        }

        private string stk;        
        public string SoTaiKhoan {
            get { return stk; }
            set { stk = value; }
        }

        private string uname;
        public string Username {
            get { return uname; }
            set { uname = value; }
        }

        private string pword1;
        public string Password1 {
            get { return pword1; }
            set { pword1 = value; }
        }

        private string pword2;
        public string Password2 {
            get { return pword2; }
            set { pword2 = value; }
        }

        private string vaiTro;
        public string VaiTro {
            get { return vaiTro; }
            set { vaiTro = value; }
        }

        private int id_QL;
        public int Id_QL {
            get { return id_QL; }
            set { id_QL = value; }
        }

        private string tenCH;
        public string TenCH {
            get { return tenCH; }
            set { tenCH = value; }
        }

        private string diaChi;
        public string DiaChi {
            get { return diaChi; }
            set { diaChi = value; }
        }
    }
}
