using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaBiblioteca.Controller
{
    class cls_libros_prestados
    {
        private Model.cls_var _cls_var = new Model.cls_var();
        private Model.cls_conexion _cls_con = Model.cls_conexion.Instance;
        private View.Frm_libros_prestados _frm_li_pre;
        private SqlDataReader _sqldataread;
        private int _int_cont = 0;
        public cls_libros_prestados(View.Frm_libros_prestados _f_li_pre) {
            _frm_li_pre = _f_li_pre;
            _met_event();
        }
        private void _met_event() {
            //_frm_li_pre.pictureBox1.Click += new EventHandler(_met_event_click_cerrar);
            _met_load_data();
        }
        private void _met_event_click_cerrar(object sender, EventArgs e) {
            _frm_li_pre.Close();
        }
        private void _met_load_data() {
            _sqldataread = _cls_con.met_consultDrig("exec _SP_busca_libro_prestado '" + _cls_var._str_clv_li + "'");
            while(_sqldataread.Read()){
                _int_cont = _frm_li_pre.dgv_l_pre.Rows.Add();
                _frm_li_pre.txt_matri.Text = _sqldataread[7].ToString();
                _frm_li_pre.txt_nom.Text = _sqldataread[8].ToString().ToUpper();
                _frm_li_pre.txt_grad.Text = _sqldataread[9].ToString();
                _frm_li_pre.txt_grup.Text = _sqldataread[10].ToString();
                _frm_li_pre.txt_fec_pres.Text = _sqldataread[1].ToString().ToUpper();
                _frm_li_pre.txt_tip_pre.Text = _sqldataread[2].ToString().ToUpper();
                _frm_li_pre.txt_cant.Text = _sqldataread[3].ToString();
                for (int x = 0; x < 3; x++ ) {
                    _frm_li_pre.dgv_l_pre.Rows[_int_cont].Cells[0].Value = _sqldataread[4].ToString().ToUpper();
                    _frm_li_pre.dgv_l_pre.Rows[_int_cont].Cells[1].Value = _sqldataread[5].ToString().ToUpper();
                    _frm_li_pre.dgv_l_pre.Rows[_int_cont].Cells[2].Value = _sqldataread[6].ToString().ToUpper();
                }
                _int_cont++;
            }
        }
    }
}
