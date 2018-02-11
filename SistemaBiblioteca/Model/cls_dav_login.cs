using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaBiblioteca.Model
{
    class cls_dav_login
    {
        private bool _acceso =  false;
        private cls_conexion _conexion = cls_conexion.Instance;
        private cls_var _cls_var = new cls_var();
        private IDataReader _dataread;
        private SqlDataReader _sqldataread;
        private cls_vo_login _vo_login;
        public cls_dav_login(cls_vo_login _login) {
            _vo_login = _login;
        }
        public bool acc {
            get { return _acceso; }
        }
        public void _met_acceso() {
            _dataread = _conexion.met_busca("select vch_user,vch_pass from tbl_usuarios where vch_user='" + _vo_login.User + "' and vch_pass='" + _vo_login.Password + "'");
            if (_dataread.Read()) {
                _acceso = true;
            }
            _sqldataread = _conexion.met_consultDrig("select vch_tipoUser from tbl_usuarios where vch_user='" + _vo_login.User + "' and vch_pass='" + _vo_login.Password + "'");
            while (_sqldataread.Read()) {
                _cls_var.Str_tipo_user = _sqldataread[0].ToString();
            }
        }
    }
}
