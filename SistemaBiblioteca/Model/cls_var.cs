using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Model
{
    class cls_var
    {
        private static string _str_clave_libro, _str_tipo_user;

        public string Str_tipo_user
        {
            get { return cls_var._str_tipo_user; }
            set { cls_var._str_tipo_user = value; }
        }
        public string _str_clv_li {
            get { return _str_clave_libro; }
            set { _str_clave_libro = value; }
        }
    }
}
