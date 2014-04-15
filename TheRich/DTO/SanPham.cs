using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        private int id_SP;
        public int Id_SP { 
            get { return id_SP; }
            set { id_SP = value; }
        }
        
        private string maSP;
        public string MaSP{
            get { return maSP; }
            set { maSP = value; }
        }

        private string tenSP;
        public string TenSP {
            get { return tenSP; }
            set { tenSP = value; }
        }

        private int slTon;
        public int SLTon {
            get { return slTon; }
            set { slTon = value; }
        }

        private int donViTinh;
        public int DonViTinh {
            get { return donViTinh; }
            set { donViTinh = value; }
        }

        private int giaNhap;
        public int GiaNhap {
            get { return giaNhap; }
            set { giaNhap = value; }
        }

        private int giaSi;
        public int GiaSi {
            get { return giaSi; }
            set { giaSi = value; }
        }

        private int giaLe;
        private int tiLeGiam;
        public int TiLeGiam {
            get { return tiLeGiam; }
            set { tiLeGiam = value; }
        }

        private int id_LSP;
        public int Id_LSP {
            get { return id_LSP; }
            set { id_LSP = value; }
        }

        private int id_NCC;
        public int Id_NCC {
            get { return id_NCC; }
            set { id_NCC = value; }
        }

        private int id_ND;
        public int Id_ND {
            get { return id_ND; }
            set { id_ND = value; }
        }
    }
}
