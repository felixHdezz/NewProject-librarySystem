using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SistemaBiblioteca.Model
{
    class cls_dav_alumno
    {
        cls_conexion _con = cls_conexion.Instance;
        private cls_vo_alumnos _cls_vo_alum;
        private SqlDataReader _slqdataread;
        private DataTable _datatable;
        private bool _action;
        public cls_dav_alumno(cls_vo_alumnos _cls_vo_al) {
            _cls_vo_alum = _cls_vo_al;
        }
        public SqlDataReader _SqlDataRead{
            get { return _slqdataread; }
        }
        public DataTable _DataTable {
            get { return _datatable; }
        }
        public bool _Action {
            get { return _action; }
        }
        public void _met_update_drig_view(){
            _slqdataread = _con.met_consultDrig("exec _procedure_alumnos");
        }
        public void _met_load_combo_box1(){
            _datatable = _con.met_consultar("exec _procedure_grados");
        }
        public void _met_load_combo_box2(){
            _datatable = _con.met_consultar("select * from tbl_grupos");
        }
        public void _met_busca_alumno(string _str_matri) {
            _slqdataread = _con.met_consultDrig("exec _SP_busca_alumno '" + _str_matri + "'");
        }
        public void _met_insert_alumno() {
            if (_con.met_acciones("exec _SP_alumnos '1','" + _cls_vo_alum.Str_matricula + "','" + _cls_vo_alum.Str_nombre + "','" + _cls_vo_alum.Str_ap + "','" + _cls_vo_alum.Str_am + "','" + _cls_vo_alum.Str_sexo + "','"+ _cls_vo_alum.Str_fecha_naci +"','" + _cls_vo_alum.Str_id_grad + "','" + _cls_vo_alum.Str_id_grup + "','" + _cls_vo_alum.Str_tutor + "','"+ _cls_vo_alum.Str_ciclo_escolar +"','" + _cls_vo_alum.Str_estado + "'"))
            {
                _action = true;
            }
        }
        public void _met_update_alumno(){
            if (_con.met_acciones("exec _SP_alumnos '2','" + _cls_vo_alum.Str_matricula + "','" + _cls_vo_alum.Str_nombre + "','" + _cls_vo_alum.Str_ap + "','" + _cls_vo_alum.Str_am + "','" + _cls_vo_alum.Str_sexo + "','" + _cls_vo_alum.Str_fecha_naci + "','" + _cls_vo_alum.Str_id_grad + "','" + _cls_vo_alum.Str_id_grup + "','" + _cls_vo_alum.Str_tutor + "','" + _cls_vo_alum.Str_ciclo_escolar + "','" + _cls_vo_alum.Str_estado + "'"))
            {
                _action = true;
            }
        }
        public void _met_delete_alumno() {
            if (_con.met_acciones("exec _SP_alumnos '3','" + _cls_vo_alum.Str_matricula + "','','','','','','','','','',''")) {
                _action = true;
            }
        }
    }
}
