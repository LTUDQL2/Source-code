using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.DTO
{
    public class Help_DTO
    {
        private int id_help;

        public int Id
        {
            get { return id_help; }
            set { id_help = value; }
        }

        private string _title = "";

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _body = "";

        public string Body
        {
            get { return _body; }
            set { _body = value; }
        }

        private int _depend;

        public int Depend
        {
            get { return _depend; }
            set { _depend = value; }
        }
    }
}
