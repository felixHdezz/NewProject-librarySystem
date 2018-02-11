using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SistemaBiblioteca.Model
{
    class cls_dav_grupo
    {
        cls_conexion _con = cls_conexion.Instance;
        private SqlDataReader _slqdataread;
        private bool _action;
        public cls_dav_grupo() { 
            
        }
        public SqlDataReader _SqlDataRead{
            get { return _slqdataread; }
        }
        public bool _Action {
            get { return _action; }
        }
        public void _met_update_DataGridView(){
            _slqdataread = _con.met_consultDrig("select * from tbl_grupos");
        }
        public void _met_autoincrement() {
            _slqdataread = _con.met_consultDrig("select max(int_Id_grupo)+ 1 from tbl_grupos");
        }
        public void _met_insert_data(string _str_clv, string _str_grupo) {
            if (_con.met_acciones("insert into tbl_grupos values('" + _str_clv + "','" + _str_grupo + "')")) {
                _action = true;
            }
        }
        public void _met_update_data(string _str_clv, string _str_grupo)
        {
            if (_con.met_acciones("update tbl_grupos set vch_grupo = '" + _str_clv + "' where int_Id_grupo = '" + _str_grupo + "'"))
            {
                _action = true;
            }
        }
        public void _met_delete_data(string _str_clv)
        {
            if (_con.met_acciones("delete from tbl_grupos where int_Id_grupo = '" + _str_clv + "'"))
            {
                _action = true;
            }
        }
    }
}
