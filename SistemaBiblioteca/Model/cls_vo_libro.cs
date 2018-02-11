using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Model
{
    class cls_vo_libro
    {
        private cls_vo_libro _instance;
        public cls_vo_libro _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_vo_libro();
                }
                return _instance;
            }
        }
        private string _clv_li, _nom_li, _clasi_li, _est_li, _str_editorial, _str_autors;
        private int _id, _exis;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Str_editorial
        {
            get { return _str_editorial; }
            set { _str_editorial = value; }
        }

        public string Str_autors
        {
            get { return _str_autors; }
            set { _str_autors = value; }
        }
        public int Exis
        {
            get { return _exis; }
            set { _exis = value; }
        }

        public string Clv_li
        {
            get { return _clv_li; }
            set { _clv_li = value; }
        }

        public string Nom_li
        {
            get { return _nom_li; }
            set { _nom_li = value; }
        }

        public string Clasi_li
        {
            get { return _clasi_li; }
            set { _clasi_li = value; }
        }

        public string Est_li
        {
            get { return _est_li; }
            set { _est_li = value; }
        }
    }
}
