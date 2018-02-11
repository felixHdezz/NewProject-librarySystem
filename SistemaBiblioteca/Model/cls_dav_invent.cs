using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaBiblioteca.Model
{
    class cls_dav_invent
    {
        private cls_conexion _cls_con = cls_conexion.Instance;
        private SqlDataReader _sqldataread;
        public cls_dav_invent() { 
            
        }
        public SqlDataReader _SqlDataRead {
            get { return _sqldataread; }
        }
        public void _met_load_datagrid() {
            _sqldataread = _cls_con.met_consultDrig("exec _SP_libros");
        }
    }
}
