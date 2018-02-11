using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaBiblioteca.Model
{
    class cls_dav_grados
    {
        public cls_conexion _cls_con = cls_conexion.Instance;
        private SqlDataReader _sqldataread;
        private bool _action;
        public cls_dav_grados() {
            
        }
        public SqlDataReader _SqlDataRead {
            get { return _sqldataread; }
        }
        public void _met_load_datagrid() {
            _sqldataread = _cls_con.met_consultDrig("exec _procedure_grados");
        }
        public bool _met_insert_data(string _str_clv, string _str_grad) {
            if (_cls_con.met_acciones("insert into tbl_grados values('" + _str_clv + "','" + _str_grad + "')")) {
                _action = true;
            }
            return _action;
        }
        public bool _met_update_data(string _str_clv, string _str_grad) {
            if (_cls_con.met_acciones("update tbl_grados set vch_grado = '" + _str_grad + "' where int_Id_grados = '" + _str_clv + "'")) {
                _action = true;
            }
            return _action;
        }
        public bool _met_delete_data(string _str_clv) {
            if (_cls_con.met_acciones("delete from tbl_grados where int_Id_grados = '" + _str_clv + "'")) {
                _action = true;
            }
            return _action;
        }
    }
}
