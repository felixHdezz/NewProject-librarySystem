using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Model
{
    class cls_vo_prestamo
    {
        private cls_vo_prestamo _intances;
        public cls_vo_prestamo _Instance {
            get {
                if (_intances == null) {
                    _intances = new cls_vo_prestamo();
                }
                return _intances;
            }
        }
        private string _clv_li, _matri_alum, _str_fecha_pres, _str_clv_pre, str_fecha_dev, _str_tipo_pres;

        public string Str_tipo_pres
        {
            get { return _str_tipo_pres; }
            set { _str_tipo_pres = value; }
        }

        public string Str_fecha_dev
        {
            get { return str_fecha_dev; }
            set { str_fecha_dev = value; }
        }

        public string Str_fecha_pres
        {
            get { return _str_fecha_pres; }
            set { _str_fecha_pres = value; }
        }

        public string Str_clv_pre
        {
            get { return _str_clv_pre; }
            set { _str_clv_pre = value; }
        }
        private int _int_cant_libro, _int_cant;

        public int Int_cant
        {
            get { return _int_cant; }
            set { _int_cant = value; }
        }

        public int Int_cant_libro
        {
            get { return _int_cant_libro; }
            set { _int_cant_libro = value; }
        }

        public string Matri_alum
        {
            get { return _matri_alum; }
            set { _matri_alum = value; }
        }

        public string Clv_li
        {
            get { return _clv_li; }
            set { _clv_li = value; }
        }
    }
}
