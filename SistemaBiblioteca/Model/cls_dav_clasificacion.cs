using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SistemaBiblioteca.Model
{
    class cls_dav_clasificacion
    {
        cls_conexion _con = cls_conexion.Instance;
        private SqlDataReader _slqdataread;
        private bool _action;
        public cls_dav_clasificacion() { 
            
        }
        public SqlDataReader _SqlDataRead {
            get { return _slqdataread; }
        }
        public bool _Action {
            get { return _action; }
        }
        public void _met_cargar_drig_view() {
            _slqdataread = _con.met_consultDrig("select * from tbl_clasificacion");
        }
        public void _met_insert_clasi(string _str_clv, string _str_clasi){
            if (_con.met_acciones("insert into tbl_clasificacion values('"+_str_clv+"','" + _str_clasi + "')"))
            {
                _action = true;
            }
        }
        public void _met_update_clasifi(string _str_clv, string _str_clasi) {
            if (_con.met_acciones("update tbl_clasificacion set vch_clasificacion  = '" + _str_clasi + "' where nch_idclasf = '" + _str_clv + "'"))
            {
                _action = true;
            }
        }
        public void _met_delete_clasificacion(string _str_clav) {
            if (_con.met_acciones("delete from tbl_clasificacion where nch_idclasf = '" + _str_clav + "'"))
            {
                _action = true;
            }
        }
    }
}
