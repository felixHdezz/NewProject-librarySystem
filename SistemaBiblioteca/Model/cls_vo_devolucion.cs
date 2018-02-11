using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Model
{
    class cls_vo_devolucion
    {
        private cls_vo_devolucion _instace;
        public cls_vo_devolucion _Instance {
            get {
                if (_instace == null) {
                    _instace = new cls_vo_devolucion();
                }
                return _instace;
            }
        }
        private string _str_mat;

        public string Str_mat
        {
            get { return _str_mat; }
            set { _str_mat = value; }
        }
    }
}
