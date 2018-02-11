using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaBiblioteca.Model
{
    class cls_dav_libro
    {
        cls_conexion _con = cls_conexion.Instance;
        cls_vo_libro _vo_libro;
        private DataTable _datatable;
        private SqlDataReader _sqldatareader;
        public cls_dav_libro(cls_vo_libro _li){
            _vo_libro = _li;
        }
        public DataTable _DataTable {
            get { return _datatable; }
        }
        public SqlDataReader _SqlDataReader {
            get { return _sqldatareader; }
        }
        public void _met_carga_combo_box() {
            _datatable = _con.met_consultar("select * from tbl_clasificacion");
        }
        public void _met_load_gridview() {
            _sqldatareader = _con.met_consultDrig("exec _procedure_select_lib");
        }
        public void _met_carg_clv_automatic() {
            _sqldatareader = _con.met_consultDrig("select max(int_IdLibro)+1 from tbl_libros");
        }
        public bool _met_insert_li() {
            bool ac = false;
            if (_con.met_acciones("insert into tbl_libros values('" + _vo_libro.Id +"','" + _vo_libro.Nom_li + "','" + _vo_libro.Clasi_li + "','" + _vo_libro.Exis + "','"+_vo_libro.Str_editorial+"','"+_vo_libro.Str_autors+"')")) {
                ac = true;
            }
            return ac;
        }
        public void _met_insert_li_det() {
            _con.met_acciones("insert into tbl_libros_detalle values('" + _vo_libro.Clv_li + "','" + _vo_libro.Id + "','" + _vo_libro.Est_li + "')");
        }
    }
}
