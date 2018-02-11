using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SistemaBiblioteca.Model
{
    class cls_dav_prestamo
    {
        private cls_conexion _con = cls_conexion.Instance;
        public cls_vo_prestamo _vo_pres;
        private SqlDataReader _sqldatareader;
        private bool _b_action;
        public cls_dav_prestamo(cls_vo_prestamo _pres) {
            _vo_pres = _pres;
        }
        public bool _action {
            get { return _b_action; }
        }
        public SqlDataReader _SqlDataReader {
            get { return _sqldatareader; }
        }
        public void _met_bus_clv_increment() {
            _sqldatareader = _con.met_consultDrig("select max(int_IdPrest) + 1 from tbl_prestamos");
        }
        public void _met_bus_libr() {
            _sqldatareader = _con.met_consultDrig("exec _SP_busqueda_libros '1','" + _vo_pres.Clv_li + "'");
        }
        public void _met_bus_matr_alum() {
            _sqldatareader = _con.met_consultDrig("exec _SP_busc_alumno '" + _vo_pres.Matri_alum + "'");
        }
        public void _met_insert_prestamo() {
            if (_con.met_acciones("insert into tbl_prestamos values('"+_vo_pres.Str_clv_pre+"','"+_vo_pres.Str_tipo_pres+"','"+_vo_pres.Str_fecha_pres+"','"+_vo_pres.Int_cant_libro+"','"+_vo_pres.Matri_alum+"')")) {
                _b_action = true;
            }
        }
        public void _met_insert_prestamo_deta() {
            if (_con.met_acciones("insert into tbl_prestamo_detalle values('" + _vo_pres.Str_clv_pre + "','" + _vo_pres.Clv_li + "','"+_vo_pres.Int_cant+"')")) {
                _b_action = true;
            }
        }
    }
}
