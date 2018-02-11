using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaBiblioteca.Model
{
    class cls_dav_devolucion
    {
        public cls_conexion _csl_con = cls_conexion.Instance;
        public cls_vo_devolucion _cls_vo_del;
        private SqlDataReader _sql_data_read;
        private bool _bol_action;
        public cls_dav_devolucion(cls_vo_devolucion _cls_v_dev) {
            _cls_vo_del = _cls_v_dev;
        }
        public SqlDataReader _SqlDataRead {
            get { return _sql_data_read; }
        }
        public bool _action{
            get { return _bol_action; }
        }
        public void _met_bus_clv_increment(){
            _sql_data_read = _csl_con.met_consultDrig("select max(int_IdDevol) + 1 from tbl_devoluciones");
        }
        public void _met_bus_matri_alum() {
            _sql_data_read = _csl_con.met_consultDrig("exec _SP_busca_libro_prestado_devol '" + _cls_vo_del.Str_mat + "'");
        }
        public void _met_insert_devol(string _clv_de,string _str_Idpres,string _fec_devol,int _int_cant_li,string _matri) {
            if (_csl_con.met_acciones("insert into tbl_devoluciones values('" + _clv_de + "','"+_str_Idpres+"','" + _fec_devol + "','" + _int_cant_li + "','" + _matri + "')"))
            {
                _bol_action = true;
            }
        }
        public void _met_insert_devol_detalle(string _clv_de, string _clv_lib, int _cant) {
            _csl_con.met_acciones("insert into tbl_devoluciones_detalle values('" + _clv_de + "','" + _clv_lib + "','" + _cant + "')");
        }
    }
}
