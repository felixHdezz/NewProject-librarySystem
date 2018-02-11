using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Model
{
    class cls_vo_alumnos
    {
        private string _str_matricula, _str_nombre, _str_ap, _str_am, _str_sexo, _str_id_grad, _str_id_grup, _str_tutor, _str_estado, _str_fecha_naci, _str_ciclo_escolar;

        public string Str_fecha_naci
        {
            get { return _str_fecha_naci; }
            set { _str_fecha_naci = value; }
        }

        public string Str_ciclo_escolar
        {
            get { return _str_ciclo_escolar; }
            set { _str_ciclo_escolar = value; }
        }

        public string Str_matricula
        {
            get { return _str_matricula; }
            set { _str_matricula = value; }
        }

        public string Str_nombre
        {
            get { return _str_nombre; }
            set { _str_nombre = value; }
        }

        public string Str_ap
        {
            get { return _str_ap; }
            set { _str_ap = value; }
        }

        public string Str_am
        {
            get { return _str_am; }
            set { _str_am = value; }
        }

        public string Str_sexo
        {
            get { return _str_sexo; }
            set { _str_sexo = value; }
        }

        public string Str_id_grad
        {
            get { return _str_id_grad; }
            set { _str_id_grad = value; }
        }

        public string Str_id_grup
        {
            get { return _str_id_grup; }
            set { _str_id_grup = value; }
        }

        public string Str_tutor
        {
            get { return _str_tutor; }
            set { _str_tutor = value; }
        }

        public string Str_estado
        {
            get { return _str_estado; }
            set { _str_estado = value; }
        }
    }
}
