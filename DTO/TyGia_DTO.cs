using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.DTO
{
    public class TyGia_DTO
    {
        private int id_tyGia;

        public int Id_TG
        {
            get { return id_tyGia; }
            set { id_tyGia = value; }
        }

        private string _maTG = "";

        public string MaTG
        {
            get { return _maTG; }
            set { _maTG = value; }
        }

        private string _tenTG = "";

        public string TenTG
        {
            get { return _tenTG; }
            set { _tenTG = value; }
        }

        private int _quyDoi;

        public int QuyDoi
        {
            get { return _quyDoi; }
            set { _quyDoi = value; }
        }

    }
}
